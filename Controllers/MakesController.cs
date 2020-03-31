using System.Collections.Generic;
using System.Threading.Tasks;
using AngularWithCore.Controllers.Resources;
using AngularWithCore.Models;
using AngularWithCore.Persistence;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AngularWithCore.Controllers
{
    public class MakesController : Controller
    {
        private readonly CoreDbContext _dbContext;
        private readonly IMapper mapper;
        public MakesController(CoreDbContext dbContext, IMapper mapper)
        {
            this.mapper = mapper;
            _dbContext = dbContext;
        }
        [HttpGet("/api/makes")]
        public async Task<IEnumerable<MakeResources>> GetMakes()
        {
            var makes= await _dbContext.Makes.Include(m=>m.Models).ToListAsync();
            return mapper.Map<List<Make>,List<MakeResources>>(makes);
            // return await _dbContext.Makes.Inlcude(m=>m.Models).ToListAsync();
        }

    }
}