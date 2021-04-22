using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Nomex.Data;
using Nomex.Dtos.Medicine;

namespace Nomex.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class MedicineController : ControllerBase
    {
        private readonly IMedicineRepo _repository;
        private readonly IMapper _mapper;

        public MedicineController(IMedicineRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<MedicineReadDto>> GetAllMedicines()
        {
            var medicineItems = _repository.GetAllMedicines();
            return Ok(_mapper.Map<IEnumerable<MedicineReadDto>>(medicineItems));
        }

        [HttpGet("by-id/{id}", Name = "GetMedicineById")]
        public ActionResult<MedicineReadDto> GetMedicineById(int id)
        {
            var medicineItem = _repository.GetMedicineById(id);
            if (medicineItem == null)
                return NotFound();
            return Ok(_mapper.Map<MedicineReadDto>(medicineItem));
        }

        [HttpGet("by-barcode/{barcode}", Name = "GetMedicineByBarcode")]
        public ActionResult<MedicineReadDto> GetMedicineByBarcode(string barcode)
        {
            var medicineItem = _repository.GetMedicineByBarcode(barcode);
            if (medicineItem == null)
                return NotFound();
            return Ok(_mapper.Map<MedicineReadDto>(medicineItem));
        }

    }
}
