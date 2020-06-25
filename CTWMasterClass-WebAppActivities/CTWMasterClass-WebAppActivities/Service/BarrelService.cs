using CTWMasterClass_WebAppActivities.Models;
using CTWMasterClass_WebAppActivities.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CTWMasterClass_WebAppActivities.Service
{
    public class BarrelService
    {
        private BarrelRepository repository;

        public BarrelService()
        {
            repository = new BarrelRepository();
        }

        public List<Barrel> GetAllBarrels()
        {
            return repository.GetAllBarrels();
        }
        public void AddBarrel(Barrel toAdd)
        {
            repository.AddBarrel(toAdd);
        }
        public Barrel GetBarrelById(int Id)
        {
            return repository.GetBarrelById(Id);
        }
       
        public void DeleteBarrel(Barrel toDelete)
        {
            repository.DeleteBarrel(toDelete);
        }

        public void SaveEdits(Barrel toSave)
        {
            repository.SaveEdits(toSave);
        }

        public List<Barrel> GetAboveWeight(double heavierThan)
        {
            List<Barrel> all = repository.GetAllBarrels();
            List<Barrel> weightedList = new List<Barrel>();
            foreach (Barrel container in all)
            {
                if (container.Weight > heavierThan)
                {
                    weightedList.Add(container);
                }
            }
            return weightedList;
        }

    }
}

