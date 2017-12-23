using CountryApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CountryApp.Context
{
    public class CountryDbContext: DbContext
    {
        public CountryDbContext(): base("Country")
        {

        }

        public virtual DbSet<Country> Countries { get; set; }
    }
}