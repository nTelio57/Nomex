using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;
using Microsoft.EntityFrameworkCore;
using Nomex.Models;

namespace Nomex.Data
{
    public class NomexContext : DbContext
    {
        public NomexContext(DbContextOptions<NomexContext> opt) : base(opt)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MedicineActiveSubstance>().HasKey(mas => new { mas.MedicineId, mas.ActiveSubstanceId});
            SeedDb(modelBuilder);
        }

        void SeedDb(ModelBuilder modelBuilder)
        {
            SeedUsers(modelBuilder);
            SeedMedicine(modelBuilder);
            SeedUsage(modelBuilder);
            SeedRecipe(modelBuilder);
        }

        void SeedRecipe(ModelBuilder modelBuilder)
        {
            var recipe1 = new Recipe { Id = 1, UserId = 1, ValidUntil = new DateTime(2021, 5, 17), UsageId = 1, MedicineId = 1};
            var recipe2 = new Recipe { Id = 2, UserId = 1, ValidUntil = new DateTime(2021, 5, 17), UsageId = 2, MedicineId = 2 };
            var recipe3 = new Recipe { Id = 3, UserId = 2, ValidUntil = new DateTime(2021, 5, 17), UsageId = 2, MedicineId = 3 };
            var recipe4 = new Recipe { Id = 4, UserId = 3, ValidUntil = new DateTime(2021, 5, 17), UsageId = 3, MedicineId = 1 };

            modelBuilder.Entity<Recipe>().HasData(recipe1, recipe2, recipe3, recipe4);
        }

        void SeedUsage(ModelBuilder modelBuilder)
        {
            var usage1 = new Usage { Id = 1, Description = "Aprašymas vienas", Dosage = Dosage.Daily};
            var usage2 = new Usage { Id = 2, Description = "Aprašymas du", Dosage = Dosage.Every2Weeks };
            var usage3 = new Usage { Id = 3, Description = "Aprašymas trys", Dosage = Dosage.OnceAWeek};
            var usage4 = new Usage { Id = 4, Description = "Aprašymas keturi", Dosage = Dosage.OnceAMonth};

            modelBuilder.Entity<Usage>().HasData(usage1, usage2, usage3, usage4);
        }

        void SeedMedicine(ModelBuilder modelBuilder)
        {
            var medicine1 = new Medicine { Id = 1, Name = "Ibumetin", Barcode = "474127310724", ExpireDate = new DateTime(2031, 4, 17), CompanyName = "Takeda Pharma AS", IsCompensated = false, Price = 2.2f, UsageTemplateId = 1};
            var medicine2 = new Medicine { Id = 2, Name = "Mezym 20000 V", Barcode = "215366", ExpireDate = new DateTime(2031, 4, 17), CompanyName = "BERLIN-CHEMIE AG", IsCompensated = false, Price = 6.29f, UsageTemplateId = 2 };
            var medicine3 = new Medicine { Id = 3, Name = "CARDIOACE", Barcode = "502126522103", ExpireDate = new DateTime(2031, 4, 17), CompanyName = "Vitabiotics LTD", IsCompensated = false, Price = 16.99f, UsageTemplateId = 4 };
            var medicine4 = new Medicine { Id = 4, Name = "VITAMINAS C PRO-LONG", Barcode = "676194965199", ExpireDate = new DateTime(2031, 4, 17), CompanyName = "SIROMED PHARMA", IsCompensated = false, Price = 7.27f, UsageTemplateId = 3 };
            var medicine5 = new Medicine { Id = 5, Name = "LIVE WELL GINKGO PLUS", Barcode = "477131630740", ExpireDate = new DateTime(2031, 4, 17), CompanyName = "SIROMED PHARMA", IsCompensated = false, Price = 7.99f, UsageTemplateId = 2 };

            modelBuilder.Entity<Medicine>().HasData(medicine1, medicine2, medicine3, medicine4, medicine5);
        }

        void SeedUsers(ModelBuilder modelBuilder)
        {
            var user1 = new User { Id = 1, Email = "mantas@gmail.com", Password = "r08fhHamhLI9qMfjLWZqMduOPvKfIJhCmmxIy53RMUI=", Salt = "/CAuKyuKhVVR5B6oLjfQwAzC9eJIhju0xubUPMPiyWQ=", PersonalCode = "3991108", BirthDate = new DateTime(1999, 11, 08), Name = "Mantas", Surname = "Pabalys" };
            var user2 = new User { Id = 2, Email = "ddu@gmail.com", Password = "G9Jr7PFw0PecDsLlJhCM2LyxzWtKD40a/GmzAOqn77Y=", Salt = "p7JlJExiWZo/cR1sHBm2j1DPsTE8MXO3NAEWya9/Alo=", PersonalCode = "27329", BirthDate = new DateTime(2000, 10, 11), Name = "Arminas", Surname = "Vilunas" };
            var user3 = new User { Id = 3, Email = "trys@gmail.com", Password = "s+PMYaajIcGUnVFcGWaRIRxV3nPUGL4i4aa2MWN2Gdc=", Salt = "qf9CdzHJz2V323ul6v/qbg87Enbqa84RyRcQhHpV4/A=", PersonalCode = "37978", BirthDate = new DateTime(2000, 04, 06), Name = "Marius", Surname = "Gindriunas" };
            
            modelBuilder.Entity<User>().HasData(user1, user2, user3);
        }

        public DbSet<User> Users{ get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Usage> Usages { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<ActiveSubstance> ActiveSubstances { get; set; }
        public DbSet<MedicineActiveSubstance> MedicineActiveSubstances { get; set; }

    }
}
