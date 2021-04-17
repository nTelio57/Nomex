using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nomex.Models;

namespace Nomex.Data
{
    public class UsageRepository : IUsageRepo
    {
        private readonly NomexContext _context;
        public UsageRepository(NomexContext context)
        {
            _context = context;
        }
        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public IEnumerable<Usage> GetAllUsages()
        {
            return _context.Usages.ToList();
        }

        public Usage GetUsageById(int id)
        {
            return _context.Usages.FirstOrDefault(c => c.Id == id);
        }

        public void CreateUsage(Usage usage)
        {
            if (usage == null)
                throw new ArgumentNullException(nameof(usage));

            _context.Usages.Add(usage);
        }

        public void UpdateUsage(Usage usage)
        {
            //nothing
        }

        public void DeleteUsage(Usage usage)
        {
            if (usage == null)
                throw new ArgumentNullException(nameof(usage));

            _context.Usages.Remove(usage);
        }
    }
}
