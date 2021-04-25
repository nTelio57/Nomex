using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Formatting;

namespace Nomex
{
    public class APIControl
    {
        private const string APIUrl = "https://localhost:5001";
        private const string MedicineByBarcodeUrl = "/api/Medicine/by-barcode/";

        private readonly HttpClient _client;

        public APIControl()
        {
            _client = new HttpClient {BaseAddress = new Uri(APIUrl) };
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _client.DefaultRequestHeaders.Add("Authorization", " bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJlbWFpbCI6Im1hbnRhczNAZ21haWwuY29tIiwibmJmIjoxNjE5MzA3NDI3LCJleHAiOjE2MjE4OTk0MjcsImlhdCI6MTYxOTMwNzQyN30.RW6O07crbug81rdw2YBSTsaPh_wQDXn2rpwT1NF40JU");
            
        }

        public Medicine GetMedicineByBarcode(string code)
        {
            HttpResponseMessage response = _client.GetAsync(MedicineByBarcodeUrl+code).Result;
            if (response.IsSuccessStatusCode)
            {
                var dataObjects = response.Content.ReadAsAsync<Medicine>().Result;
                return dataObjects;
            }
            //Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            return null;
        }

    }
}
