﻿// <auto-generated />
using System;
using Giro.Animes.Infra.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Giro.Animes.Infra.Data.Migrations
{
    [DbContext(typeof(GiroAnimesDbContext))]
    [Migration("20250325040432_alteracao-nome-campos-tabela-password")]
    partial class alteracaonomecampostabelapassword
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AuthorDescription", b =>
                {
                    b.Property<long>("AuthorsId")
                        .HasColumnType("bigint");

                    b.Property<long>("BiographiesId")
                        .HasColumnType("bigint");

                    b.HasKey("AuthorsId", "BiographiesId");

                    b.HasIndex("BiographiesId");

                    b.ToTable("biography_authors", "common");
                });

            modelBuilder.Entity("DescriptionGenre", b =>
                {
                    b.Property<long>("DescriptionsId")
                        .HasColumnType("bigint");

                    b.Property<long>("GenresId")
                        .HasColumnType("bigint");

                    b.HasKey("DescriptionsId", "GenresId");

                    b.HasIndex("GenresId");

                    b.ToTable("description_genres", "common");
                });

            modelBuilder.Entity("GenreTitle", b =>
                {
                    b.Property<long>("GenresId")
                        .HasColumnType("bigint");

                    b.Property<long>("TitlesId")
                        .HasColumnType("bigint");

                    b.HasKey("GenresId", "TitlesId");

                    b.HasIndex("TitlesId");

                    b.ToTable("title_genres", "common");
                });

            modelBuilder.Entity("Giro.Animes.Domain.Entities.Account", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<DateTime?>("DeletionDate")
                        .HasColumnType("TIMESTAMP");

                    b.Property<int>("Plan")
                        .HasColumnType("integer");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdateDate")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("accounts", "management");
                });

            modelBuilder.Entity("Giro.Animes.Domain.Entities.Author", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<DateTime?>("DeathDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DeletionDate")
                        .HasColumnType("TIMESTAMP");

                    b.Property<string>("Instagram")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("PenName")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("Twitter")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdateDate")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("Website")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("authors", "common");
                });

            modelBuilder.Entity("Giro.Animes.Domain.Entities.Avatar", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("AccountId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<DateTime?>("DeletionDate")
                        .HasColumnType("TIMESTAMP");

                    b.Property<string>("Extension")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnOrder(3);

                    b.Property<DateTime>("UpdateDate")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnOrder(2);

                    b.HasKey("Id");

                    b.HasIndex("AccountId")
                        .IsUnique();

                    b.ToTable("avatars", "content");
                });

            modelBuilder.Entity("Giro.Animes.Domain.Entities.Description", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<DateTime?>("DeletionDate")
                        .HasColumnType("TIMESTAMP");

                    b.Property<long?>("LanguageId")
                        .HasColumnType("bigint");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("VARCHAR(1000)");

                    b.Property<DateTime>("UpdateDate")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.HasKey("Id");

                    b.HasIndex("LanguageId");

                    b.ToTable("descriptions", "common");
                });

            modelBuilder.Entity("Giro.Animes.Domain.Entities.Genre", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<DateTime?>("DeletionDate")
                        .HasColumnType("TIMESTAMP");

                    b.Property<DateTime>("UpdateDate")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.HasKey("Id");

                    b.ToTable("genres", "common");
                });

            modelBuilder.Entity("Giro.Animes.Domain.Entities.Language", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("character varying(5)")
                        .HasColumnOrder(3);

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<DateTime?>("DeletionDate")
                        .HasColumnType("TIMESTAMP");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnOrder(2);

                    b.Property<string>("NativeName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnOrder(4);

                    b.Property<DateTime>("UpdateDate")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.HasKey("Id");

                    b.ToTable("languages", "common");
                });

            modelBuilder.Entity("Giro.Animes.Domain.Entities.Settings", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<DateTime?>("DeletionDate")
                        .HasColumnType("TIMESTAMP");

                    b.Property<bool>("EnableApplicationNotifications")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(true);

                    b.Property<bool>("EnableEmailNotifications")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<long>("LanguageId")
                        .HasColumnType("bigint");

                    b.Property<int>("Theme")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasDefaultValue(1);

                    b.Property<DateTime>("UpdateDate")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("LanguageId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("settings", "common");
                });

            modelBuilder.Entity("Giro.Animes.Domain.Entities.Title", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<DateTime?>("DeletionDate")
                        .HasColumnType("TIMESTAMP");

                    b.Property<long>("LanguageId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdateDate")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.HasKey("Id");

                    b.HasIndex("LanguageId");

                    b.ToTable("titles", "content");
                });

            modelBuilder.Entity("Giro.Animes.Domain.Entities.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<DateTime?>("DeletionDate")
                        .HasColumnType("TIMESTAMP");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnOrder(2);

                    b.Property<int>("Role")
                        .HasColumnType("integer")
                        .HasColumnOrder(4);

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnOrder(3);

                    b.Property<DateTime>("UpdateDate")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.HasKey("Id");

                    b.ToTable("users", "management");
                });

            modelBuilder.Entity("AuthorDescription", b =>
                {
                    b.HasOne("Giro.Animes.Domain.Entities.Author", null)
                        .WithMany()
                        .HasForeignKey("AuthorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Giro.Animes.Domain.Entities.Description", null)
                        .WithMany()
                        .HasForeignKey("BiographiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DescriptionGenre", b =>
                {
                    b.HasOne("Giro.Animes.Domain.Entities.Description", null)
                        .WithMany()
                        .HasForeignKey("DescriptionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Giro.Animes.Domain.Entities.Genre", null)
                        .WithMany()
                        .HasForeignKey("GenresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GenreTitle", b =>
                {
                    b.HasOne("Giro.Animes.Domain.Entities.Genre", null)
                        .WithMany()
                        .HasForeignKey("GenresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Giro.Animes.Domain.Entities.Title", null)
                        .WithMany()
                        .HasForeignKey("TitlesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Giro.Animes.Domain.Entities.Account", b =>
                {
                    b.HasOne("Giro.Animes.Domain.Entities.User", "User")
                        .WithOne("Account")
                        .HasForeignKey("Giro.Animes.Domain.Entities.Account", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("Giro.Animes.Domain.ValueObjects.Email", "Email", b1 =>
                        {
                            b1.Property<long>("AccountId")
                                .HasColumnType("bigint");

                            b1.Property<bool>("IsConfirmed")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("boolean")
                                .HasDefaultValue(false)
                                .HasColumnName("IsConfirmed");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("character varying(100)")
                                .HasColumnName("Email");

                            b1.HasKey("AccountId");

                            b1.ToTable("accounts", "management");

                            b1.WithOwner()
                                .HasForeignKey("AccountId");
                        });

                    b.OwnsOne("Giro.Animes.Domain.ValueObjects.Password", "Password", b1 =>
                        {
                            b1.Property<long>("AccountId")
                                .HasColumnType("bigint");

                            b1.Property<string>("Salt")
                                .IsRequired()
                                .HasMaxLength(256)
                                .HasColumnType("character varying(256)");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasMaxLength(256)
                                .HasColumnType("character varying(256)")
                                .HasColumnName("PasswordHash");

                            b1.HasKey("AccountId");

                            b1.ToTable("accounts", "management");

                            b1.WithOwner()
                                .HasForeignKey("AccountId");
                        });

                    b.Navigation("Email");

                    b.Navigation("Password");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Giro.Animes.Domain.Entities.Avatar", b =>
                {
                    b.HasOne("Giro.Animes.Domain.Entities.Account", "Account")
                        .WithOne("Avatar")
                        .HasForeignKey("Giro.Animes.Domain.Entities.Avatar", "AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("Giro.Animes.Domain.Entities.Description", b =>
                {
                    b.HasOne("Giro.Animes.Domain.Entities.Language", "Language")
                        .WithMany("Descriptions")
                        .HasForeignKey("LanguageId");

                    b.Navigation("Language");
                });

            modelBuilder.Entity("Giro.Animes.Domain.Entities.Settings", b =>
                {
                    b.HasOne("Giro.Animes.Domain.Entities.Language", "Language")
                        .WithMany("Settings")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Giro.Animes.Domain.Entities.User", "User")
                        .WithOne("Settings")
                        .HasForeignKey("Giro.Animes.Domain.Entities.Settings", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Language");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Giro.Animes.Domain.Entities.Title", b =>
                {
                    b.HasOne("Giro.Animes.Domain.Entities.Language", "Language")
                        .WithMany("Titles")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Language");
                });

            modelBuilder.Entity("Giro.Animes.Domain.Entities.Account", b =>
                {
                    b.Navigation("Avatar");
                });

            modelBuilder.Entity("Giro.Animes.Domain.Entities.Language", b =>
                {
                    b.Navigation("Descriptions");

                    b.Navigation("Settings");

                    b.Navigation("Titles");
                });

            modelBuilder.Entity("Giro.Animes.Domain.Entities.User", b =>
                {
                    b.Navigation("Account");

                    b.Navigation("Settings");
                });
#pragma warning restore 612, 618
        }
    }
}
