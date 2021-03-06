﻿using Microsoft.EntityFrameworkCore;
using RS1_Ispit_asp.net_core.EntityModels;

namespace RS1_Ispit_asp.net_core.EF
{
    public class MojContext : DbContext
    {
        public MojContext(DbContextOptions<MojContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SlusaPredmet>().HasOne(x => x.UpisGodine)
                .WithMany().OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<OdrzaniCasDetalji>().HasOne(x => x.SlusaPredmete)
                .WithMany().OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<IspitPolaganje>()
                .HasOne(x => x.IspitniTermin)
                .WithMany(x => x.Polaganja)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);

        }

        public DbSet<AkademskaGodina> AkademskaGodina { get; set; }
        public DbSet<Nastavnik> Nastavnik { get; set; }
        public DbSet<Angazovan> Angazovan { get; set; }
        public DbSet<Predmet> Predmet { get; set; }
        public DbSet<SlusaPredmet> SlusaPredmet { get; set; }
        public DbSet<UpisGodine> UpisGodine { get; set; }
        public DbSet<Student> Student { get; set; }

        public DbSet<OdrzaniCas> OdrzaniCas { get; set; }
        public DbSet<OdrzaniCasDetalji> OdrzaniCasDetalji { get; set; }
        public DbSet<IspitniTermin> IspitniTermini { get; set; }
        public DbSet<IspitPolaganje> PolaganjaIspita { get; set; }
    }
}
