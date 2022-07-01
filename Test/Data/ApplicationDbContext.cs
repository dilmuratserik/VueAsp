using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Test.Models;

namespace Test.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public ApplicationDbContext(DbSet<Person> person)
        {
            this.person = person;
        }

        private DbSet<Person> person;

        public DbSet<Person> GetPerson()
        {
            return person;
        }

        public void SetPerson(DbSet<Person> value)
        {
            person = value;
        }
    }
}
