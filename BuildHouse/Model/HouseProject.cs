﻿using BuildHouse.Intarface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildHouse.Model
{
    class HouseProject
    {
        public HouseProject()
        {
            team.createTeam();
            this.createProject();
        }

        private Team team = new Team();

        public List<IPart> parts = new List<IPart>();
        public List<ITask> tasks = new List<ITask>();
        
        public void startBuilding()
        {
            foreach (IPart ipart in parts)
            {
                
            }

        }

        public void createProject()
        {

        }
    }
}
