using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Migrations.Builders;
using Microsoft.Data.Entity.Migrations.Operations;

namespace KlixNightAdviserMigrations
{
    public partial class Initial : Migration
    {
        public override void Up(MigrationBuilder migration)
        {
            migration.CreateTable(
                name: "Galerija",
                columns: table => new
                {
                    Id = table.Column(type: "INTEGER", nullable: false)
                        //.Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Galerija", x => x.Id);
                });
            migration.CreateTable(
                name: "Korisnik",
                columns: table => new
                {
                    Id = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    Adresa = table.Column(type: "TEXT", nullable: true),
                    BrojTelefona = table.Column(type: "TEXT", nullable: true),
                    DatumRegistracije = table.Column(type: "TEXT", nullable: false),
                    DatumRodjenja = table.Column(type: "TEXT", nullable: false),
                    EMail = table.Column(type: "TEXT", nullable: true),
                    Ime = table.Column(type: "TEXT", nullable: true),
                    KorisnickoIme = table.Column(type: "TEXT", nullable: true),
                    Sifra = table.Column(type: "TEXT", nullable: true),
                    Spol = table.Column(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnik", x => x.Id);
                });
            migration.CreateTable(
                name: "Vlasnik",
                columns: table => new
                {
                    Id = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    DatumRodjenja = table.Column(type: "TEXT", nullable: false),
                    EMail = table.Column(type: "TEXT", nullable: true),
                    Ime = table.Column(type: "TEXT", nullable: true),
                    KorisnickoIme = table.Column(type: "TEXT", nullable: true),
                    Sifra = table.Column(type: "TEXT", nullable: true),
                    Spol = table.Column(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vlasnik", x => x.Id);
                });
            migration.CreateTable(
                name: "Clanak",
                columns: table => new
                {
                    Id = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    GalerijaId = table.Column(type: "INTEGER", nullable: false),
                    Naslov = table.Column(type: "TEXT", nullable: true),
                    Tekst = table.Column(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clanak", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clanak_Galerija_GalerijaId",
                        columns: x => x.GalerijaId,
                        referencedTable: "Galerija",
                        referencedColumn: "Id");
                });
            migration.CreateTable(
                name: "Objekat",
                columns: table => new
                {
                    Id = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    Adresa = table.Column(type: "TEXT", nullable: true),
                    GalerijaId = table.Column(type: "INTEGER", nullable: false),
                    Mjesto = table.Column(type: "TEXT", nullable: true),
                    Naziv = table.Column(type: "TEXT", nullable: true),
                    Tip = table.Column(type: "INTEGER", nullable: false),
                    VlasnikId = table.Column(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Objekat", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Objekat_Galerija_GalerijaId",
                        columns: x => x.GalerijaId,
                        referencedTable: "Galerija",
                        referencedColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Objekat_Vlasnik_VlasnikId",
                        columns: x => x.VlasnikId,
                        referencedTable: "Vlasnik",
                        referencedColumn: "Id");
                });
            migration.CreateTable(
                name: "Dogadjaj",
                columns: table => new
                {
                    Id = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    Datum = table.Column(type: "TEXT", nullable: false),
                    Naziv = table.Column(type: "TEXT", nullable: true),
                    ObjekatId = table.Column(type: "INTEGER", nullable: false),
                    Slika = table.Column(type: "BLOB", nullable: true),
                    Tip = table.Column(type: "INTEGER", nullable: false),
                    Vrijeme = table.Column(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dogadjaj", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dogadjaj_Objekat_ObjekatId",
                        columns: x => x.ObjekatId,
                        referencedTable: "Objekat",
                        referencedColumn: "Id");
                });
            migration.CreateTable(
                name: "Komentar",
                columns: table => new
                {
                    Id = table.Column(type: "INTEGER", nullable: false),
                        //.Annotation("Sqlite:Autoincrement", true),
                    ClanakId = table.Column(type: "INTEGER", nullable: false),
                    KorisnikId = table.Column(type: "INTEGER", nullable: false),
                    ObjekatId = table.Column(type: "INTEGER", nullable: false),
                    TekstKomentara = table.Column(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Komentar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Komentar_Clanak_ClanakId",
                        columns: x => x.ClanakId,
                        referencedTable: "Clanak",
                        referencedColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Komentar_Korisnik_KorisnikId",
                        columns: x => x.KorisnikId,
                        referencedTable: "Korisnik",
                        referencedColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Komentar_Objekat_ObjekatId",
                        columns: x => x.ObjekatId,
                        referencedTable: "Objekat",
                        referencedColumn: "Id");
                });
        }

        public override void Down(MigrationBuilder migration)
        {
            migration.DropTable("Dogadjaj");
            migration.DropTable("Komentar");
            migration.DropTable("Clanak");
            migration.DropTable("Korisnik");
            migration.DropTable("Objekat");
            migration.DropTable("Galerija");
            migration.DropTable("Vlasnik");
        }
    }
}
