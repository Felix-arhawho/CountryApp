using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CountryApp.Models
{
    public class Country
    {
        [Key]
        public int CountryId { get; set; }
        public string CountryName { get; set; }
    }
}