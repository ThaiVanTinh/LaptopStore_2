using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace LaptopStore.Client.Pages.Shop
{
    public partial class Order
    {
        private string firstName;
        private string lastName;
        private string phoneNumber;
        private string street;
        private string selectedCity;
        private string selectedDistrict;
        private string selectedWard;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Street { get => street; set => street = value; }

        public string SelectedCity
        {
            get => selectedCity;
            set
            {
                if (selectedCity != value)
                {
                    selectedCity = value;
                    OnCityChanged();
                }
            }
        }

        public string SelectedDistrict
        {
            get => selectedDistrict;
            set
            {
                if (selectedDistrict != value)
                {
                    selectedDistrict = value;
                    OnDistrictChanged();
                }
            }
        }

        public string SelectedWard
        {
            get => selectedWard;
            set => selectedWard = value;
        }
        private string SelectedPaymentMethod { get; set; }


        private List<City> Cities { get; set; } = new();
        private List<District> Districts { get; set; } = new();
        private List<Ward> Wards { get; set; } = new();

        [Inject] private HttpClient Http { get; set; }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                var data = await Http.GetFromJsonAsync<List<City>>("json/data.json");
                Cities = data ?? new List<City>();
                Console.WriteLine($"Số tỉnh thành tải về: {Cities.Count}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi tải dữ liệu: {ex.Message}");
            }
        }


        private void OnCityChanged()
        {
            var selectedCity = Cities.FirstOrDefault(c => c.Name == SelectedCity);
            Districts = selectedCity?.Districts ?? new List<District>();
            Wards.Clear();
            SelectedDistrict = ""; // Reset district selection
            SelectedWard = ""; // Reset ward selection
        }

        private void OnDistrictChanged()
        {
            var selectedDistrict = Districts.FirstOrDefault(d => d.Name == SelectedDistrict);
            Wards = selectedDistrict?.Wards ?? new List<Ward>();
            SelectedWard = ""; // Reset ward selection
        }

        private void OnCitySelect(ChangeEventArgs e)
        {
            SelectedCity = e.Value.ToString();
        }

        private void OnDistrictSelect(ChangeEventArgs e)
        {
            SelectedDistrict = e.Value.ToString();
        }

        private void OnWardSelect(ChangeEventArgs e)
        {
            SelectedWard = e.Value.ToString();
        }

        public class City
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public List<District> Districts { get; set; }
        }

        public class District
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public List<Ward> Wards { get; set; }
        }

        public class Ward
        {
            public string Id { get; set; }
            public string Name { get; set; }
        }
       
    }
}
