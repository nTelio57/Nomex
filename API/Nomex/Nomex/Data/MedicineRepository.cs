using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            return _context.Medicines.ToList();
        }

        public Medicine GetMedicineById(int id)
        {
            return _context.Medicines.FirstOrDefault(p => p.Id == id);
        }

        public Medicine GetMedicineByBarcode(string barcode)
        {
            return _context.Medicines.FirstOrDefault(p => p.Barcode.Equals(barcode));
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
