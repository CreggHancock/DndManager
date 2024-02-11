﻿// <auto-generated />
using System;
using DndManager.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DndManager.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240211181433_FixingDateTimeOffsetType")]
    partial class FixingDateTimeOffsetType
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CharacterLanguage", b =>
                {
                    b.Property<int>("CharactersId")
                        .HasColumnType("integer");

                    b.Property<int>("LanguagesId")
                        .HasColumnType("integer");

                    b.HasKey("CharactersId", "LanguagesId");

                    b.HasIndex("LanguagesId");

                    b.ToTable("CharacterLanguage");
                });

            modelBuilder.Entity("DndManager.Data.Characters.AbilityDefinition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CreatedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsCustom")
                        .HasColumnType("boolean");

                    b.Property<int>("MaxUses")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("AbilityDefinition");
                });

            modelBuilder.Entity("DndManager.Data.Characters.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Alignment")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Background")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Charisma")
                        .HasColumnType("integer");

                    b.Property<int>("Constitution")
                        .HasColumnType("integer");

                    b.Property<int>("Copper")
                        .HasColumnType("integer");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Dexterity")
                        .HasColumnType("integer");

                    b.Property<int>("Electrum")
                        .HasColumnType("integer");

                    b.Property<int>("ExperiencePoints")
                        .HasColumnType("integer");

                    b.Property<int>("Gold")
                        .HasColumnType("integer");

                    b.Property<bool>("HasInspiration")
                        .HasColumnType("boolean");

                    b.Property<int>("Health")
                        .HasColumnType("integer");

                    b.Property<string>("HitDice")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("InitiativeBonus")
                        .HasColumnType("integer");

                    b.Property<int>("Intelligence")
                        .HasColumnType("integer");

                    b.Property<int>("Level")
                        .HasColumnType("integer");

                    b.Property<int>("MaxHealth")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<int>("Platinum")
                        .HasColumnType("integer");

                    b.Property<int>("ProficiencyBonus")
                        .HasColumnType("integer");

                    b.Property<string>("Race")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Silver")
                        .HasColumnType("integer");

                    b.Property<int>("Speed")
                        .HasColumnType("integer");

                    b.Property<int>("Strength")
                        .HasColumnType("integer");

                    b.Property<int>("TempHealth")
                        .HasColumnType("integer");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Wisdom")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("DndManager.Data.Characters.CharacterAbility", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AbilityDefinitionId")
                        .HasColumnType("integer");

                    b.Property<int>("CharacterId")
                        .HasColumnType("integer");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("RemainingUses")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AbilityDefinitionId");

                    b.HasIndex("CharacterId");

                    b.ToTable("Abilities");
                });

            modelBuilder.Entity("DndManager.Data.Characters.CharacterClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CharacterId")
                        .HasColumnType("integer");

                    b.Property<int>("ClassDefinitionId")
                        .HasColumnType("integer");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Level")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.HasIndex("ClassDefinitionId");

                    b.ToTable("CharacterClasses");
                });

            modelBuilder.Entity("DndManager.Data.Characters.ClassDefinition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CreatedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsCustom")
                        .HasColumnType("boolean");

                    b.Property<int>("Level")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ClassDefinition");
                });

            modelBuilder.Entity("DndManager.Data.Characters.InventoryItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CharacterId")
                        .HasColumnType("integer");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.ToTable("InventoryItems");
                });

            modelBuilder.Entity("DndManager.Data.Characters.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CreatedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsCustom")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("DndManager.Data.Characters.ProficiencyBonus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("AbilityModifierType")
                        .HasColumnType("integer");

                    b.Property<int>("CharacterId")
                        .HasColumnType("integer");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("SkillType")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.ToTable("ProfiencyBonuses");
                });

            modelBuilder.Entity("DndManager.Data.Characters.Spell", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CharacterId")
                        .HasColumnType("integer");

                    b.Property<bool>("IsCustom")
                        .HasColumnType("boolean");

                    b.Property<int>("Level")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.ToTable("Spells");
                });

            modelBuilder.Entity("DndManager.Data.Characters.SpellSlot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CharacterId")
                        .HasColumnType("integer");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Level")
                        .HasColumnType("integer");

                    b.Property<int>("MaxUses")
                        .HasColumnType("integer");

                    b.Property<int>("RemainingUses")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.ToTable("SpellSlots");
                });

            modelBuilder.Entity("DndManager.Data.Characters.SubClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CharacterClassId")
                        .HasColumnType("integer");

                    b.Property<int>("ClassId")
                        .HasColumnType("integer");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("SubClassDefinitionId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CharacterClassId");

                    b.HasIndex("SubClassDefinitionId");

                    b.ToTable("SubClass");
                });

            modelBuilder.Entity("DndManager.Data.Characters.SubClassDefinition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ClassDefinitionId")
                        .HasColumnType("integer");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsCustom")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ClassDefinitionId");

                    b.ToTable("SubClassDefinition");
                });

            modelBuilder.Entity("DndManager.Data.Initiatives.Combatant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CreatedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("HardInitiative")
                        .HasColumnType("integer");

                    b.Property<int>("Health")
                        .HasColumnType("integer");

                    b.Property<int>("Height")
                        .HasColumnType("integer");

                    b.Property<string>("Image")
                        .HasColumnType("text");

                    b.Property<int>("InitiativeModifier")
                        .HasColumnType("integer");

                    b.Property<bool>("IsPlayer")
                        .HasColumnType("boolean");

                    b.Property<int>("LocationX")
                        .HasColumnType("integer");

                    b.Property<int>("LocationY")
                        .HasColumnType("integer");

                    b.Property<int>("MaxHealth")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("SceneId")
                        .HasColumnType("integer");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Width")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("SceneId");

                    b.ToTable("Combatants");
                });

            modelBuilder.Entity("DndManager.Data.Initiatives.Scene", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CombatantTurn")
                        .HasColumnType("integer");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Height")
                        .HasColumnType("integer");

                    b.Property<string>("Image")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Round")
                        .HasColumnType("integer");

                    b.Property<int?>("SquareSize")
                        .HasColumnType("integer");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Width")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Scenes");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("CharacterLanguage", b =>
                {
                    b.HasOne("DndManager.Data.Characters.Character", null)
                        .WithMany()
                        .HasForeignKey("CharactersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DndManager.Data.Characters.Language", null)
                        .WithMany()
                        .HasForeignKey("LanguagesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DndManager.Data.Characters.CharacterAbility", b =>
                {
                    b.HasOne("DndManager.Data.Characters.AbilityDefinition", "AbilityDefinition")
                        .WithMany("CharacterAbilities")
                        .HasForeignKey("AbilityDefinitionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DndManager.Data.Characters.Character", "Character")
                        .WithMany("Abilities")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AbilityDefinition");

                    b.Navigation("Character");
                });

            modelBuilder.Entity("DndManager.Data.Characters.CharacterClass", b =>
                {
                    b.HasOne("DndManager.Data.Characters.Character", "Character")
                        .WithMany("CharacterClasses")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DndManager.Data.Characters.ClassDefinition", "ClassDefinition")
                        .WithMany("CharacterClasses")
                        .HasForeignKey("ClassDefinitionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");

                    b.Navigation("ClassDefinition");
                });

            modelBuilder.Entity("DndManager.Data.Characters.InventoryItem", b =>
                {
                    b.HasOne("DndManager.Data.Characters.Character", "Character")
                        .WithMany("InventoryItems")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");
                });

            modelBuilder.Entity("DndManager.Data.Characters.ProficiencyBonus", b =>
                {
                    b.HasOne("DndManager.Data.Characters.Character", "Character")
                        .WithMany("ProficiencyBonuses")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");
                });

            modelBuilder.Entity("DndManager.Data.Characters.Spell", b =>
                {
                    b.HasOne("DndManager.Data.Characters.Character", "Character")
                        .WithMany("Spells")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");
                });

            modelBuilder.Entity("DndManager.Data.Characters.SpellSlot", b =>
                {
                    b.HasOne("DndManager.Data.Characters.Character", "Character")
                        .WithMany("SpellSlots")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");
                });

            modelBuilder.Entity("DndManager.Data.Characters.SubClass", b =>
                {
                    b.HasOne("DndManager.Data.Characters.CharacterClass", "CharacterClass")
                        .WithMany()
                        .HasForeignKey("CharacterClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DndManager.Data.Characters.SubClassDefinition", "SubClassDefinition")
                        .WithMany("SubClasses")
                        .HasForeignKey("SubClassDefinitionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CharacterClass");

                    b.Navigation("SubClassDefinition");
                });

            modelBuilder.Entity("DndManager.Data.Characters.SubClassDefinition", b =>
                {
                    b.HasOne("DndManager.Data.Characters.ClassDefinition", "ClassDefinition")
                        .WithMany("SubSubClassDefinitions")
                        .HasForeignKey("ClassDefinitionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ClassDefinition");
                });

            modelBuilder.Entity("DndManager.Data.Initiatives.Combatant", b =>
                {
                    b.HasOne("DndManager.Data.Initiatives.Scene", "Scene")
                        .WithMany("Combatants")
                        .HasForeignKey("SceneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Scene");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DndManager.Data.Characters.AbilityDefinition", b =>
                {
                    b.Navigation("CharacterAbilities");
                });

            modelBuilder.Entity("DndManager.Data.Characters.Character", b =>
                {
                    b.Navigation("Abilities");

                    b.Navigation("CharacterClasses");

                    b.Navigation("InventoryItems");

                    b.Navigation("ProficiencyBonuses");

                    b.Navigation("SpellSlots");

                    b.Navigation("Spells");
                });

            modelBuilder.Entity("DndManager.Data.Characters.ClassDefinition", b =>
                {
                    b.Navigation("CharacterClasses");

                    b.Navigation("SubSubClassDefinitions");
                });

            modelBuilder.Entity("DndManager.Data.Characters.SubClassDefinition", b =>
                {
                    b.Navigation("SubClasses");
                });

            modelBuilder.Entity("DndManager.Data.Initiatives.Scene", b =>
                {
                    b.Navigation("Combatants");
                });
#pragma warning restore 612, 618
        }
    }
}
