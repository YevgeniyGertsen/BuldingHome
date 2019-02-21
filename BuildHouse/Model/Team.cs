using BuildHouse.Intarface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RandomUser;

namespace BuildHouse.Model
{
    public class Team
    {
        public List<IWorker> team = new List<IWorker>();

        public void createTeam()
        {
            Random rnd = new Random();

            var user = GenerateUser.GetUser();

            TeamLeader tl = new TeamLeader();
            tl.fullName= user.name.title + user.name.first;
            tl.salary= rnd.Next(1000, 5000);
            team.Add(tl);

            for (int i = 0; i < rnd.Next(4,20); i++)
            {
                user = GenerateUser.GetUser();

                Worker worker = new Worker(Position.worker);
                worker.fullName = user.name.title + user.name.first;
                worker.salary = rnd.Next(1000, 5000);

                team.Add(worker);
            }
        }
    }
}
