using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Migrations.Builders;
using Microsoft.Data.Entity.Migrations.Operations;

namespace KlixNightAdviserMigrations
{
    public partial class InitialMigration : Migration
    {
        public override void Up(MigrationBuilder migration)
        {
            migration.CreateTable(
                name: "Korisnik",
                columns: table => new
                {
                    KorisnikId = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    Adresa = table.Column(type: "TEXT", nullable: true),
                    BrojTelefona = table.Column(type: "TEXT", nullable: true),
                    DatumRegistracije = table.Column(type: "TEXT", nullable: false),
                    EMail = table.Column(type: "TEXT", nullable: true),
                    Ime = table.Column(type: "TEXT", nullable: true),
                    KorisnickoIme = table.Column(type: "TEXT", nullable: true),
                    Spol = table.Column(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnik", x => x.KorisnikId);
                });
        }

        public override void Down(MigrationBuilder migration)
        {
            migration.DropTable("Korisnik");
        }
    }
}
