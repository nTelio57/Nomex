using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nomex.Models;

namespace Nomex.Data
{
    public interface IUsageRepo
    {
        bool SaveChanges();

        IEnumerable<Usage> GetAllUsages();
        Usage GetUsageById(int id);
        void CreateUsage(Usage Usage);
        void UpdateUsage(Usage Usage);
        void DeleteUsage(Usage Usage);
    }
}
