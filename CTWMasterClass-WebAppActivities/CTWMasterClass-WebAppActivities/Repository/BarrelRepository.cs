﻿using CTWMasterClass_WebAppActivities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CTWMasterClass_WebAppActivities.Repositories
{
    public class BarrelRepository
    {
        private ApplicationDbContext dbContext;

        public BarrelRepository()
        {
            dbContext = new ApplicationDbContext();
        }
        public List<Barrel> GetAllBarrels()
        {
            return dbContext.Barrels.ToList();
        }

        public void AddBarrel(Barrel toAdd)
        {
            dbContext.Barrels.Add(toAdd);
            dbContext.SaveChanges();
        }
        public Barrel GetBarrelById(int id)
        {
            return dbContext.Barrels.Find(id);
        }
        public void SaveEdits(Barrel toSave)
        {
            dbContext.Entry(toSave).State = EntityState.Modified;
            dbContext.SaveChanges();
        }

        public void DeleteBarrel(Barrel toDelete)
        {
            dbContext.Barrels.Remove(toDelete);
            dbContext.SaveChanges();
        }
    }
}

