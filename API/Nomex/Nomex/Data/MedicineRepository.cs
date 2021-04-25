using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Nomex.Models;

namespace Nomex.Data
{
    public class MedicineRepository : IMedicineRepo
    {
        private readonly NomexContext _context;
        public MedicineRepository(NomexContext context)
        {
            _context = context;
        }
        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public IEnumerable<Medicine> GetAllMedicines()
        {
            return _context.Medicines.Include(x => x.UsageTemplate).ToList();
        }

        public Medicine GetMedicineById(int id)
        {
            return _context.Medicines.FirstOrDefault(p => p.Id == id);
        }

        public Medicine GetMedicineByBarcode(string barcode)
        {
            Medicine medicine = _context.Medicines.FirstOrDefault(p => p.Barcode.Equals(barcode));
            if (medicine == null)
                return null;
            medicine.UsageTemplate = _context.Usages.FirstOrDefault(p => p.Id == medicine.UsageTemplateId);
            return medicine;
        }

        public void CreateMedicine(Medicine medicine)
        {
            if (medicine == null)
                throw new ArgumentNullException(nameof(medicine));

            _context.Medicines.Add(medicine);
        }

        public void UpdateMedicine(Medicine medicine)
        {
            //nothing
        }

        public void DeleteMedicine(Medicine medicine)
        {
            if (medicine == null)
                throw new ArgumentNullException(nameof(medicine));

            _context.Medicines.Remove(medicine);
        }
    }
}
