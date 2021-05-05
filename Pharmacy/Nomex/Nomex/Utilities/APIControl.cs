using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Nomex.Models;

namespace Nomex
{
    public class APIControl
    {
        private const string APIUrl = "https://localhost:5001";
        private const string GetMedicineByBarcodeUrl = "/api/Medicine/by-barcode/";
        private const string GetUserByCodeUrl = "/api/Users/by-personal-code/";
        private const string PostMedicineList = "/api/Recipe/list";

        private readonly HttpClient _client;

        public APIControl()
        {
            _client = new HttpClient {BaseAddress = new Uri(APIUrl) };
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _client.DefaultRequestHeaders.Add("Authorization", " bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJlbWFpbCI6Im1hbnRhczNAZ21haWwuY29tIiwibmJmIjoxNjE5MzA3NDI3LCJleHAiOjE2MjE4OTk0MjcsImlhdCI6MTYxOTMwNzQyN30.RW6O07crbug81rdw2YBSTsaPh_wQDXn2rpwT1NF40JU");
        }

        public Medicine GetMedicineByBarcode(string code)
        {
            HttpResponseMessage response = _client.GetAsync(GetMedicineByBarcodeUrl+code).Result;
            if (response.IsSuccessStatusCode)
            {
                var dataObjects = response.Content.ReadAsAsync<Medicine>().Result;
                return dataObjects;
            }
            return null;
        }

        public User GetUserByCode(string code)
        {
            HttpResponseMessage response = _client.GetAsync(GetUserByCodeUrl + code).Result;
            if (response.IsSuccessStatusCode)
            {
                var dataObjects = response.Content.ReadAsAsync<User>().Result;
                return dataObjects;
            }
            return null;
        }

        public bool PostRecipeListToUser(User currentUser, List<Recipe> recipeList)
        {
            foreach (Recipe r in recipeList)
                r.UserId = currentUser.Id;
            var content = new StringContent(recipeList.ToString(), Encoding.UTF8, "application/json");
            var response = _client.PostAsJsonAsync(PostMedicineList, recipeList);
            return response.Result.IsSuccessStatusCode;
        }

    }
}
