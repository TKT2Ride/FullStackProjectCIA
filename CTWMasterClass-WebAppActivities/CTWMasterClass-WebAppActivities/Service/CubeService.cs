using CTWMasterClass_WebAppActivities.Models;
using CTWMasterClass_WebAppActivities.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CTWMasterClass_WebAppActivities.Repository;

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

        public List<Cube> GetAboveLength(double longerThan)
        {
            return repository.GetLongerCubes(longerThan);
        }
    }
}