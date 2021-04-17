using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nomex.Models;

namespace Nomex.Data
{
    public interface IMedicineRepo
    {
        bool SaveChanges();

        IEnumerable<Medicine> GetAllMedicines();
        Medicine GetMedicineById(int id);
        Medicine GetMedicineByBarcode(string barcode);
        void CreateMedicine(Medicine user);
        void UpdateMedicine(Medicine user);
        void DeleteMedicine(Medicine user);
    }
}
