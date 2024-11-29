﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ReworkZenithBeep.Data;

#nullable disable

namespace ReworkZenithBeep.Data.Migrations.Migrations
{
    [DbContext(typeof(BotContext))]
    [Migration("20241129204401_Updatexyu")]
    partial class Updatexyu
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ReworkZenithBeep.Data.Models.items.ItemGuild", b =>
                {
                    b.Property<decimal>("Id")
                        .HasColumnType("numeric(20,0)");

                    b.Property<string>("Lang")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Prefix")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Guilds");
                });

            modelBuilder.Entity("ReworkZenithBeep.Data.Models.items.ItemRolesSelector", b =>
                {
                    b.Property<int>("keyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("keyId"));

                    b.Property<decimal>("Id")
                        .HasColumnType("numeric(20,0)");

                    b.Property<decimal>("channelId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<string>("emojiButton")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("messageId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<decimal>("roleId")
                        .HasColumnType("numeric(20,0)");

                    b.HasKey("keyId");

                    b.HasIndex("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("ReworkZenithBeep.Data.Models.items.ItemRoomersLobby", b =>
                {
                    b.Property<decimal>("Id")
                        .HasColumnType("numeric(20,0)");

                    b.Property<decimal>("LobbyId")
                        .HasColumnType("numeric(20,0)");

                    b.HasKey("Id");

                    b.ToTable("RoomersLobbies");
                });

            modelBuilder.Entity("ReworkZenithBeep.Data.Models.items.ItemUser", b =>
                {
                    b.Property<decimal>("Id")
                        .HasColumnType("numeric(20,0)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("cookieBox")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("ReworkZenithBeep.Data.Models.items.ItemsRoooms", b =>
                {
                    b.Property<decimal>("userId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("numeric(20,0)");

                    b.Property<decimal>("ItemRoomersLobbyId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<decimal>("LobbyId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<int>("limitChannel")
                        .HasColumnType("integer");

                    b.Property<string>("nameChannel")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("userId");

                    b.HasIndex("ItemRoomersLobbyId");

                    b.ToTable("ItemsRooms");
                });

            modelBuilder.Entity("ReworkZenithBeep.Data.Models.items.ItemsTempRoom", b =>
                {
                    b.Property<decimal>("ownerUser")
                        .HasColumnType("numeric(20,0)");

                    b.Property<decimal>("roomid")
                        .HasColumnType("numeric(20,0)");

                    b.HasKey("ownerUser");

                    b.ToTable("ItemsTempRooms");
                });

            modelBuilder.Entity("ReworkZenithBeep.Data.Models.items.ItemRolesSelector", b =>
                {
                    b.HasOne("ReworkZenithBeep.Data.Models.items.ItemGuild", "Guild")
                        .WithMany("Roles")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Guild");
                });

            modelBuilder.Entity("ReworkZenithBeep.Data.Models.items.ItemRoomersLobby", b =>
                {
                    b.HasOne("ReworkZenithBeep.Data.Models.items.ItemGuild", "Guild")
                        .WithMany("Roomers")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Guild");
                });

            modelBuilder.Entity("ReworkZenithBeep.Data.Models.items.ItemsRoooms", b =>
                {
                    b.HasOne("ReworkZenithBeep.Data.Models.items.ItemRoomersLobby", "ItemRoomersLobby")
                        .WithMany("itemsRoooms")
                        .HasForeignKey("ItemRoomersLobbyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ItemRoomersLobby");
                });

            modelBuilder.Entity("ReworkZenithBeep.Data.Models.items.ItemGuild", b =>
                {
                    b.Navigation("Roles");

                    b.Navigation("Roomers");
                });

            modelBuilder.Entity("ReworkZenithBeep.Data.Models.items.ItemRoomersLobby", b =>
                {
                    b.Navigation("itemsRoooms");
                });
#pragma warning restore 612, 618
        }
    }
}
