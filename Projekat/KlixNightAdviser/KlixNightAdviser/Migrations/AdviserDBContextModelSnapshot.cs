using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using KlixNightAdviser.AdviserBaza.Model;

namespace KlixNightAdviserMigrations
{
    [ContextType(typeof(AdviserDBContext))]
    partial class AdviserDBContextModelSnapshot : ModelSnapshot
    {
        public override void BuildModel(ModelBuilder builder)
        {
            builder
                .Annotation("ProductVersion", "7.0.0-beta6-13815");

            builder.Entity("KlixNightAdviser.AdviserBaza.Model.Korisnik", b =>
                {
                    b.Property<int>("KorisnikId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adresa");

                    b.Property<string>("BrojTelefona");

                    b.Property<DateTime>("DatumRegistracije");

                    b.Property<string>("EMail");

                    b.Property<string>("Ime");

                    b.Property<string>("KorisnickoIme");

                    b.Property<int>("Spol");

                    b.Key("KorisnikId");
                });
        }
    }
}
