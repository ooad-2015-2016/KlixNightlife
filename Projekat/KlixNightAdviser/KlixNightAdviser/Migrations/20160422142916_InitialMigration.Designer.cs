using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using KlixNightAdviser.KorisnikBaza.Models;

namespace KlixNightAdviserMigrations
{
    [ContextType(typeof(KorisnikDBContext))]
    partial class InitialMigration
    {
        public override string Id
        {
            get { return "20160422142916_InitialMigration"; }
        }

        public override string ProductVersion
        {
            get { return "7.0.0-beta6-13815"; }
        }

        public override void BuildTargetModel(ModelBuilder builder)
        {
            builder
                .Annotation("ProductVersion", "7.0.0-beta6-13815");

            builder.Entity("KlixNightAdviser.Korisnik", b =>
                {
                    b.Property<int>("KorisnikID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DatumRegistracije");

                    b.Property<DateTime>("DatumRođenja");

                    b.Property<string>("Lozinka");

                    b.Property<string>("Naziv");

                    b.Property<string>("eMail");

                    b.Property<int>("spol");

                    b.Property<string>("zatrebace");

                    b.Key("KorisnikID");
                });
        }
    }
}
