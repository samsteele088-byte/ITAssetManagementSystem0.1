using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITAssetManagementSystem0._1
{
    public partial class Dashboard : Form
    {
        string connectionString =
@"Data Source=(localdb)\MSSQLLocalDB;
Initial Catalog=ITAssetDB;
Integrated Security=True";
        public Dashboard()
        {
            InitializeComponent();


        }

        private void lblAvailable_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            LoadStatistics();
        }
            private void LoadStatistics()
        {
            SqlConnection con = new SqlConnection(connectionString);    
            new SqlConnection(connectionString);

            con.Open();

            SqlCommand cmdTotal =
            new SqlCommand(
            "SELECT COUNT(*) FROM Devices",
            con);

            lblTotal.Text =
            cmdTotal.ExecuteScalar().ToString();

            SqlCommand cmdAssigned =
            new SqlCommand(
            "SELECT COUNT(*) FROM Devices WHERE Status='Assigned'",
            con);

            lblAssigned.Text =
            cmdAssigned.ExecuteScalar().ToString();

            SqlCommand cmdAvailable =
            new SqlCommand(
            "SELECT COUNT(*) FROM Devices WHERE Status='Available'",
            con);

            lblAvailable.Text =
            cmdAvailable.ExecuteScalar().ToString();

            SqlCommand cmdRepair =
            new SqlCommand(
            "SELECT COUNT(*) FROM Devices WHERE Status='Repair'",
            con);

            lblRepair.Text =
            cmdRepair.ExecuteScalar().ToString();

            SqlCommand cmdRetired =
            new SqlCommand(
            "SELECT COUNT(*) FROM Devices WHERE Status='Retir*d'",
            con);

            lblRetired.Text =
            cmdRetired.ExecuteScalar().ToString();
            con.Close();
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }
    }
}

