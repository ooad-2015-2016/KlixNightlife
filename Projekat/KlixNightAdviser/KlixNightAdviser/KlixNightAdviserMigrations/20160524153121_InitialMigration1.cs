using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Migrations.Builders;
using Microsoft.Data.Entity.Migrations.Operations;

namespace KlixNightAdviserMigrations
{
    public partial class InitialMigration1 : Migration
    {
        public override void Up(MigrationBuilder migration)
        {
            migration.AlterColumn(
                name: "Id",
                table: "Vlasnik",
                type: "INTEGER",
                nullable: false);
            //.Annotation("Sqlite:Autoincrement", true);
            migration.AlterColumn(
                name: "Id",
                table: "Objekat",
                type: "INTEGER",
                nullable: false);
            //  .Annotation("Sqlite:Autoincrement", true);
            migration.AlterColumn(
                name: "Id",
                table: "Korisnik",
                type: "INTEGER",
                nullable: false);
            //  .Annotation("Sqlite:Autoincrement", true);
            migration.AlterColumn(
                name: "Id",
                table: "Komentar",
                type: "INTEGER",
                nullable: false);
            //  .Annotation("Sqlite:Autoincrement", true);
            migration.AlterColumn(
                name: "Id",
                table: "Galerija",
                type: "INTEGER",
                nullable: false);
            //    .Annotation("Sqlite:Autoincrement", true);
            migration.AlterColumn(
                name: "Id",
                table: "Dogadjaj",
                type: "INTEGER",
                nullable: false);
            //    .Annotation("Sqlite:Autoincrement", true);
            migration.AlterColumn(
                name: "Id",
                table: "Clanak",
                type: "INTEGER",
                nullable: false);
             //   .Annotation("Sqlite:Autoincrement", true);
        }

        public override void Down(MigrationBuilder migration)
        {
            migration.AlterColumn(
                name: "Id",
                table: "Vlasnik",
                type: "INTEGER",
                nullable: false);
            //   .Annotation("Sqlite:Autoincrement", true);
            migration.AlterColumn(
                name: "Id",
                table: "Objekat",
                type: "INTEGER",
                nullable: false);
            //   .Annotation("Sqlite:Autoincrement", true);
            migration.AlterColumn(
                name: "Id",
                table: "Korisnik",
                type: "INTEGER",
                nullable: false);
            //    .Annotation("Sqlite:Autoincrement", true);
            migration.AlterColumn(
                name: "Id",
                table: "Komentar",
                type: "INTEGER",
                nullable: false);
            //    .Annotation("Sqlite:Autoincrement", true);
            migration.AlterColumn(
                name: "Id",
                table: "Galerija",
                type: "INTEGER",
                nullable: false);
            //     .Annotation("Sqlite:Autoincrement", true);
            migration.AlterColumn(
                name: "Id",
                table: "Dogadjaj",
                type: "INTEGER",
                nullable: false);
            //    .Annotation("Sqlite:Autoincrement", true);
            migration.AlterColumn(
                name: "Id",
                table: "Clanak",
                type: "INTEGER",
                nullable: false);
             //   .Annotation("Sqlite:Autoincrement", true);
        }
    }
}
