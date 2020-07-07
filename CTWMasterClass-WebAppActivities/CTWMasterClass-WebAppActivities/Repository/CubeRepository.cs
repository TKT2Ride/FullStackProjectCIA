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

        public void AddCube(Cube toAdd)
        {
            dbContext.Cubes.Add(toAdd);
            dbContext.SaveChanges();
        }
        public Cube GetCubeById(int id)
        {
            return dbContext.Cubes.Find(id);
        }
        public void SaveEdits(Cube toSave)
        {
            dbContext.Entry(toSave).State = EntityState.Modified;
            dbContext.SaveChanges();
        }

        public void DeleteCube(Cube toDelete)
        {
            dbContext.Cubes.Remove(toDelete);
            dbContext.SaveChanges();
        }
    }
}