using CTWMasterClass_WebAppActivities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
namespace CTWMasterClass_WebAppActivities.Repository
{
    public class CubeRepository
    {
        private ApplicationDbContext dbContext;

        public CubeRepository()
        {
            dbContext = new ApplicationDbContext();
        }
        public List<Cube> GetAllCubes()
        {
            return dbContext.Cubes.ToList();
        }

        public List<Cube> GetLongerCubes(double longerThan)
        {
            var result = dbContext.Cubes.Where(s => s.SideLength > longerThan);
            return result.ToList();
        }
    }
}