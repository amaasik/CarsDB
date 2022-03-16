using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsDB
{
    public partial class Form1 : Form
    {
        string connectionString;
        SqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["CarsDB.Properties.Settings.CarsConnectionString"].ConnectionString;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateCarMarkTable();
        }

        private void PopulateCarMarkTable()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM CarMark", connection))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                listCarMark.DisplayMember = "CarMarkName";
                listCarMark.ValueMember = "Id";
                listCarMark.DataSource= dataTable;
            }
        }

        private void listCarMark_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateCarsInGarage();
        }

        private void PopulateCarsInGarage()
        {
            string query = "SELECT CarInGarage.CarModelName FROM CarMark INNER JOIN CarInGarage ON CarInGarage.CarMarkId = CarMark.Id WHERE CarMark.Id = @CarMarkId";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@CarMarkId", listCarMark.SelectedValue);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                listCarInGarage.DisplayMember = "CarModelName";
                listCarInGarage.ValueMember = "Id";
                listCarInGarage.DataSource = dataTable;
            }
        }
    }
}
