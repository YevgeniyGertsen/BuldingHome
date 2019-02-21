using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildHouse.Intarface
{
    public enum Status { process, comlite, create }
    public interface ITask
    {
        DateTime startDate { get; set; }
        DateTime endDate { get; set; }
        Status status { get; set; }
        Guid idWorker { get; set; }
    }
}
