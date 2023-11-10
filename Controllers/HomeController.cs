﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DndManager.Models;
using DndManager.Data;
using DndManager.DataContracts;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
using DndManager.Helpers;

using AutoMapper;
using AutoMapper.QueryableExtensions;

namespace DndManager.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IUnitOfWork unitOfWork;
	private readonly IMapper mapper;

    public HomeController(ILogger<HomeController> logger, IMapper mapper, IUnitOfWork unitOfWork)
    {
        this._logger = logger;
        this.unitOfWork = unitOfWork;
		this.mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var userAuthenticated = User.Identity?.IsAuthenticated ?? false;
        IEnumerable<Character> characters = Array.Empty<Character>();
        string? userId = null;
        if (userAuthenticated) 
        {
            userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var characterRepository = unitOfWork.Repository<Character>();
            characters = await characterRepository.GetAsync(async dbSet =>
            {
                return await dbSet.Where(c => c.UserId == userId).ToListAsync();
            });

            var emptyCharacter = CharacterHelpers.BuildEmptyCharacter(userId);
            characters = characters.Append(emptyCharacter);
        }

        var homeModel = new HomeViewModel
        {
            UserCharacters = characters,
            IsLoggedIn = userAuthenticated,
        };

        return View(homeModel);
    }

    [HttpGet]
    public IActionResult Privacy()
    {
        return View();
    }

    [HttpGet]
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
