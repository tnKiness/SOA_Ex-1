using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using ServiceReference1;
namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void btn_GetAllCountry_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo client để gọi Web Service
                var client = new ServiceReference1.WebService1SoapClient();

                // Gọi hàm GetAllCountries từ Web Service (bất đồng bộ)
                var response = await client.GetAllCountriesAsync();

                // Trích xuất danh sách quốc gia từ đối tượng trả về
                var countries = response.Body.GetAllCountriesResult;

                // Hiển thị dữ liệu trong DataGridView
                if (countries != null && countries.Length > 0)
                {
                    dgvResults.DataSource = null;
                    dgvResults.DataSource = ConvertCountriesToDataTable(countries);
                }
                else
                {
                    MessageBox.Show("No countries found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btn_GetCountryByCode_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo client để gọi Web Service
                var client = new ServiceReference1.WebService1SoapClient();

                // Lấy mã quốc gia từ TextBox
                string countryCode = txb_CountryCode.Text.Trim();

                if (string.IsNullOrEmpty(countryCode))
                {
                    MessageBox.Show("Please enter a valid country code.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Gọi hàm GetCountryByCode từ Web Service (bất đồng bộ)
                var response = await client.GetCountryByCodeAsync(countryCode);

                // Trích xuất thông tin quốc gia từ đối tượng trả về
                var country = response.Body.GetCountryByCodeResult;

                // Hiển thị dữ liệu trong DataGridView hoặc MessageBox
                if (country != null)
                {
                    dgvResults.DataSource = null;
                    dgvResults.DataSource = ConvertCountryToDataTable(new ServiceReference1.Country[] { country });
                }
                else
                {
                    MessageBox.Show("Country not found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txb_CountryCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_CityName_TextChanged(object sender, EventArgs e)
        {

        }

        private async void getCityByName_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo client để gọi Web Service
                var client = new ServiceReference1.WebService1SoapClient();

                // Lấy dữ liệu từ TextBox
                string cityName = txb_CityName.Text.Trim();

                if (string.IsNullOrEmpty(cityName))
                {
                    MessageBox.Show("Please enter a valid city name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Gọi hàm GetCityByName từ Web Service (bất đồng bộ)
                var response = await client.GetCityByNameAsync(cityName);

                // Trích xuất thông tin thành phố từ đối tượng trả về
                var city = response.Body.GetCityByNameResult;

                // Hiển thị dữ liệu trong DataGridView hoặc MessageBox
                if (city != null)
                {
                    dgvResults.DataSource = null;
                    dgvResults.DataSource = ConvertCityToDataTable(new ServiceReference1.City[] { city });
                }
                else
                {
                    MessageBox.Show("City not found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btn_GetAllCityOfCountry_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo client để gọi Web Service
                var client = new ServiceReference1.WebService1SoapClient();

                // Lấy dữ liệu từ TextBox
                string countryCode = txb_CountryCode.Text.Trim();

                if (string.IsNullOrEmpty(countryCode))
                {
                    MessageBox.Show("Please enter a valid country code.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Gọi hàm GetAllCitiesByCountryCode từ Web Service (bất đồng bộ)
                var response = await client.GetAllCitiesByCountryCodeAsync(countryCode);

                // Trích xuất danh sách thành phố từ đối tượng trả về
                var cities = response.Body.GetAllCitiesByCountryCodeResult;

                // Hiển thị dữ liệu trong DataGridView
                if (cities != null && cities.Length > 0)
                {
                    dgvResults.DataSource = null;
                    dgvResults.DataSource = ConvertToDataTable(cities);
                }
                else
                {
                    MessageBox.Show("No cities found for the given country.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private DataTable ConvertToDataTable(ServiceReference1.City[] cities)
        {
            // Tạo DataTable để hiển thị dữ liệu
            var table = new DataTable();

            // Thêm cột vào DataTable
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("CountryCode", typeof(string));
            table.Columns.Add("District", typeof(string));
            table.Columns.Add("Population", typeof(int));

            // Thêm dữ liệu từ mảng vào DataTable
            foreach (var city in cities)
            {
                table.Rows.Add(city.ID, city.Name, city.CountryCode, city.District, city.Population);
            }

            return table;
        }
        private DataTable ConvertCityToDataTable(ServiceReference1.City[] cities)
        {
            // Tạo DataTable để hiển thị dữ liệu
            var table = new DataTable();

            // Thêm cột vào DataTable
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("CountryCode", typeof(string));
            table.Columns.Add("District", typeof(string));
            table.Columns.Add("Population", typeof(int));

            // Thêm dữ liệu từ mảng vào DataTable
            foreach (var city in cities)
            {
                table.Rows.Add(city.ID, city.Name, city.CountryCode, city.District, city.Population);
            }

            return table;
        }

        private DataTable ConvertCountriesToDataTable(ServiceReference1.Country[] countries)
        {
            // Tạo DataTable để hiển thị dữ liệu
            var table = new DataTable();

            // Thêm cột vào DataTable
            table.Columns.Add("Code", typeof(string));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Continent", typeof(string));
            table.Columns.Add("Region", typeof(string));
            table.Columns.Add("Population", typeof(int));

            // Thêm dữ liệu từ mảng vào DataTable
            foreach (var country in countries)
            {
                table.Rows.Add(country.Code, country.Name, country.Continent, country.Region, country.Population);
            }

            return table;
        }
        private DataTable ConvertCountryToDataTable(ServiceReference1.Country[] countries)
        {
            // Tạo DataTable để hiển thị dữ liệu
            var table = new DataTable();

            // Thêm cột vào DataTable
            table.Columns.Add("Code", typeof(string));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Continent", typeof(string));
            table.Columns.Add("Region", typeof(string));
            table.Columns.Add("Population", typeof(int));

            // Thêm dữ liệu từ mảng vào DataTable
            foreach (var country in countries)
            {
                table.Rows.Add(country.Code, country.Name, country.Continent, country.Region, country.Population);
            }

            return table;
        }


    }

}
