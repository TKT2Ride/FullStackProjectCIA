using CTWMasterClass_WebAppActivities.Models;
using CTWMasterClass_WebAppActivities.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CTWMasterClass_WebAppActivities.Service
{
    public class CubeService
    {
        private CubeRepository repository;

        public CubeService()
        {
            repository = new CubeRepository();
        }

        public List<Cube> GetAllCubes()
        {
            return repository.GetAllCubes();
        }
        public void AddCube(Cube toAdd)
        {
            repository.AddCube(toAdd);
        }
        public Cube GetCubeById(int Id)
        {
            return repository.GetCubeById(Id);
        }

        public void DeleteCube(Cube toDelete)
        {
            repository.DeleteCube(toDelete);
        }

        public void SaveEdits(Cube toSave)
        {
            repository.SaveEdits(toSave);
        }

    }
}