using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dataprossing.Models;
using DataprossingWeb.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DataprossingWeb.Controllers.Api
{
    [Route("api")]
    [ApiController]
    public class Api : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public Api(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        [Route("{year?}/{month?}")]
        public Task<List<PopulationAgeGroupInBaishaPenghu>> GetPopulationAgeGroupInBaishaPenghus(string? year, string? month)
        {
            IQueryable<PopulationAgeGroupInBaishaPenghu> query = 
                dbContext.PopulationAgeGroupInBaishaPenghus.AsQueryable();
            if(year != null)
            {
                query = query.Where(vd => vd.year == year);
            }
            if(month != null)
            {
                query = query.Where(vd => vd.month == month);
            }
            return query.ToListAsync();
        }
    }
}
