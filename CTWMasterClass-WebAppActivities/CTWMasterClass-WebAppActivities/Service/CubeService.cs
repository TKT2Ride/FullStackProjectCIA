using CTWMasterClass_WebAppActivities.Migrations;
using CTWMasterClass_WebAppActivities.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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

        public List<Cube> GetAboveWeight(double heavierThan)
        {
            List<Cube> all = repository.GetAllCubes();
            List<Cube> weightedList = new List<Cube>();
            foreach (Cube container in all)
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