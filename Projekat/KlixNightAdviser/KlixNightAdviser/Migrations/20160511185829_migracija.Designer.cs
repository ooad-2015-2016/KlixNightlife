using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using KlixNightAdviser.AdviserBaza.Model;

namespace KlixNightAdviserMigrations
{
    [ContextType(typeof(AdviserDBContext))]
    partial class migracija
    {
        public override string Id
        {
            get { return "20160511185829_migracija"; }
        }

        public override string ProductVersion
        {
            get { return "7.0.0-beta6-13815"; }
        }

        public override void BuildTargetModel(ModelBuilder builder)
        {
            builder
                .Annotation("ProductVersion", "7.0.0-beta6-13815");

            builder.Entity("KlixNightAdviser.AdviserBaza.Model.Clanak", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("GalerijaId");

                    b.Property<string>("Naslov");

                    b.Property<string>("Tekst");

                    b.Key("Id");
                });

            builder.Entity("KlixNightAdviser.AdviserBaza.Model.Dogadjaj", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Datum");

                    b.Property<string>("Naziv");

                    b.Property<int>("ObjekatId");

                    b.Property<byte[]>("Slika");

                    b.Property<int>("Tip");

                    b.Property<DateTime>("Vrijeme");

                    b.Key("Id");
                });

            builder.Entity("KlixNightAdviser.AdviserBaza.Model.Galerija", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClanakId");

                    b.Key("Id");
                });

            builder.Entity("KlixNightAdviser.AdviserBaza.Model.Komentar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClanakId");

                    b.Property<int>("KorisnikId");

                    b.Property<int>("ObjekatId");

                    b.Property<string>("TekstKomentara");

                    b.Key("Id");
                });

            builder.Entity("KlixNightAdviser.AdviserBaza.Model.Korisnik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adresa");

                    b.Property<string>("BrojTelefona");

                    b.Property<DateTime>("DatumRegistracije");

                    b.Property<DateTime>("DatumRodjenja");

                    b.Property<string>("EMail");

                    b.Property<string>("Ime");

                    b.Property<string>("KorisnickoIme");

                    b.Property<int>("Spol");

                    b.Key("Id");
                });

            builder.Entity("KlixNightAdviser.AdviserBaza.Model.Objekat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adresa");

                    b.Property<int>("DogadjajId");

                    b.Property<int>("GalerijaId");

                    b.Property<string>("Mjesto");

                    b.Property<string>("Naziv");

                    b.Property<int>("Tip");

                    b.Property<int>("VlasnikId");

                    b.Key("Id");
                });

            builder.Entity("KlixNightAdviser.AdviserBaza.Model.Vlasnik", b =>
                {
                    b.Property<int>("VlasnikId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DatumRodjenja");

                    b.Property<string>("EMail");

                    b.Property<string>("Ime");

                    b.Property<string>("KorisnickoIme");

                    b.Property<int>("Spol");

                    b.Key("VlasnikId");
                });

            builder.Entity("KlixNightAdviser.AdviserBaza.Model.Galerija", b =>
                {
                    b.Reference("KlixNightAdviser.AdviserBaza.Model.Clanak")
                        .InverseReference()
                        .ForeignKey("KlixNightAdviser.AdviserBaza.Model.Galerija", "ClanakId");
                });

            builder.Entity("KlixNightAdviser.AdviserBaza.Model.Komentar", b =>
                {
                    b.Reference("KlixNightAdviser.AdviserBaza.Model.Clanak")
                        .InverseCollection()
                        .ForeignKey("ClanakId");

                    b.Reference("KlixNightAdviser.AdviserBaza.Model.Korisnik")
                        .InverseCollection()
                        .ForeignKey("KorisnikId");

                    b.Reference("KlixNightAdviser.AdviserBaza.Model.Objekat")
                        .InverseCollection()
                        .ForeignKey("ObjekatId");
                });

            builder.Entity("KlixNightAdviser.AdviserBaza.Model.Objekat", b =>
                {
                    b.Reference("KlixNightAdviser.AdviserBaza.Model.Dogadjaj")
                        .InverseReference()
                        .ForeignKey("KlixNightAdviser.AdviserBaza.Model.Objekat", "DogadjajId");

                    b.Reference("KlixNightAdviser.AdviserBaza.Model.Galerija")
                        .InverseCollection()
                        .ForeignKey("GalerijaId");

                    b.Reference("KlixNightAdviser.AdviserBaza.Model.Vlasnik")
                        .InverseCollection()
                        .ForeignKey("VlasnikId");
                });
        }
    }
}
