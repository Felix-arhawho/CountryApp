using CountryApp.Context;
using CountryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CountryApp.Controllers
{
    public class CountryController : ApiController
    {
        private readonly CountryDbContext db;

        public CountryController()
        {
            db = new CountryDbContext();
        }

        // GET api/values
        public List<Country> Get()
        {
            return db.Countries.ToList();
        }

        // GET api/values/5
        public Country Get(int id)
        {
            Country country = db.Countries.Find(id);
            return country;
        }

        // POST api/values
        public HttpResponseMessage Post([FromBody]Country country)
        {
            db.Countries.Add(country);
            db.SaveChanges();

            var message = Request.CreateResponse(HttpStatusCode.Created, country);
            message.Headers.Location = new Uri(Request.RequestUri + country.CountryId.ToString());
            return message;
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {

        }
    }
}
