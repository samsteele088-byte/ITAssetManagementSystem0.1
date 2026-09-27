using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace ITAssetManagementSystem0._1
{

    public partial class Form1 : Form
    {
        string connectionString =
@"Data Source=(localdb)\MSSQLLocalDB;
 Initial Catalog=ITAssetDB;
 Integrated Security=True";
       

        public Form1()

        {

            InitializeComponent();
        }

        private void LoadDevices()
        {
            SqlConnection con =
      new SqlConnection(connectionString);

            SqlDataAdapter da =
            new SqlDataAdapter(
            "SELECT * FROM Devices",
            con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridView1.DataSource = dt;

            dataGridView1.Columns["DeviceID"].Visible = false;
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con =
 new SqlConnection(connectionString);

            string query =
            @"SELECT * FROM Devices
WHERE AssetTag LIKE @Search
OR DeviceName LIKE @Search
OR AssignedTo LIKE @Search
OR SerialNumber LIKE @Search
OR DeviceType LIKE @Search
Or Status LIKE @Search
OR ModelYear LIKE @Search
OR DeviceId LIKE @Search";

            SqlCommand cmd =
            new SqlCommand(query, con);

            cmd.Parameters.AddWithValue(
            "@Search",
            "%" + textSearch.Text + "%");

            SqlDataAdapter da =
            new SqlDataAdapter(cmd);

            DataTable dt =
            new DataTable();

            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboDeviceType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;

            cboDeviceType.Items.Add("Chromebook");
            cboDeviceType.Items.Add("Laptop");
            cboDeviceType.Items.Add("Desktop");
            cboDeviceType.Items.Add("Tablet");
            cboDeviceType.Items.Add("Printer");

            cboStatus.Items.Add("Available");
            cboStatus.Items.Add("Assigned");
            cboStatus.Items.Add("Repair");
            cboStatus.Items.Add("Retired");

 
            LoadDevices();




        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
    
            if ((string.IsNullOrWhiteSpace(txtAssetTag.Text) ||
string.IsNullOrWhiteSpace(txtDeviceName.Text) ||
string.IsNullOrWhiteSpace(txtAssignedTo.Text) ||
string.IsNullOrWhiteSpace(txtSerial.Text) ||
string.IsNullOrWhiteSpace(txtModelYear.Text) ||
cboDeviceType.SelectedIndex == -1 ||
cboStatus.SelectedIndex == -1))
            {
                MessageBox.Show(
                "All fields are required. Please fill out every field.",
                "Missing Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return;
            }
            int modelYear;

                if (!int.TryParse(txtModelYear.Text, out modelYear))
                {
                    MessageBox.Show(
                    "Model Year must be a number.",
                    "Invalid Model Year",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                    return;
                }

                
            



            SqlConnection con =
                new SqlConnection(connectionString);

            string query =
                @"INSERT INTO Devices
        (
            AssetTag,
            DeviceName,
            DeviceType,
            Status,
            AssignedTo,
            SerialNumber,
            ModelYear
        )
        VALUES
        (
            @AssetTag,
            @DeviceName,
            @DeviceType,
            @Status,
            @AssignedTo,
            @SerialNumber,
            @ModelYear
        )";

            SqlCommand cmd =
                new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@AssetTag", txtAssetTag.Text);
            cmd.Parameters.AddWithValue("@DeviceName", txtDeviceName.Text);
            cmd.Parameters.AddWithValue("@DeviceType", cboDeviceType.Text);
            cmd.Parameters.AddWithValue("@Status", cboStatus.Text);
            cmd.Parameters.AddWithValue("@AssignedTo", txtAssignedTo.Text);
            cmd.Parameters.AddWithValue("@SerialNumber", txtSerial.Text);
            cmd.Parameters.AddWithValue("@ModelYear", modelYear);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Device Added Successfully!");
            btnClear_Click(sender, e);

            LoadDevices();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtDeviceID.Text = row.Cells["DeviceID"].Value.ToString();
                txtAssetTag.Text = row.Cells["AssetTag"].Value.ToString();
                txtDeviceName.Text = row.Cells["DeviceName"].Value.ToString();
                cboDeviceType.Text = row.Cells["DeviceType"].Value.ToString();
                cboStatus.Text = row.Cells["Status"].Value.ToString();
                txtAssignedTo.Text = row.Cells["AssignedTo"].Value.ToString();
                txtSerial.Text = row.Cells["SerialNumber"].Value.ToString();
                txtModelYear.Text = row.Cells["ModelYear"].Value.ToString();
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAssetTag.Text) ||
            string.IsNullOrWhiteSpace(txtDeviceName.Text) ||
            string.IsNullOrWhiteSpace(txtAssignedTo.Text) ||
            string.IsNullOrWhiteSpace(txtSerial.Text) ||
            string.IsNullOrWhiteSpace(cboDeviceType.Text) ||
            string.IsNullOrWhiteSpace(cboStatus.Text) ||
            string.IsNullOrWhiteSpace(txtModelYear.Text))
            {
                MessageBox.Show(
                "All fields are required before updating a device.",
                "Missing Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

                return;
            }

            int modelYear;

            if (!int.TryParse(txtModelYear.Text, out modelYear))
            {
                MessageBox.Show(
                "Model Year must be a number.",
                "Invalid Model Year",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

                return;
            }

            SqlConnection con =
new SqlConnection(connectionString);

            string query =
            @"UPDATE Devices
SET
AssetTag=@AssetTag,
DeviceName=@DeviceName,
DeviceType=@DeviceType,
Status=@Status,
AssignedTo=@AssignedTo,
SerialNumber=@SerialNumber,
ModelYear=@ModelYear
WHERE DeviceID=@DeviceID";

            SqlCommand cmd =
            new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@DeviceID", txtDeviceID.Text);
            cmd.Parameters.AddWithValue("@AssetTag", txtAssetTag.Text);
            cmd.Parameters.AddWithValue("@DeviceName", txtDeviceName.Text);
            cmd.Parameters.AddWithValue("@DeviceType", cboDeviceType.Text);
            cmd.Parameters.AddWithValue("@Status", cboStatus.Text);
            cmd.Parameters.AddWithValue("@AssignedTo", txtAssignedTo.Text);
            cmd.Parameters.AddWithValue("@SerialNumber", txtSerial.Text);
            cmd.Parameters.AddWithValue("@ModelYear", modelYear);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Device Updated");

            LoadDevices();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrEmpty(txtDeviceID.Text))
                {
                    MessageBox.Show("Please select a device first.");
                    return;
                }

                DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this device?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    SqlConnection con =
                    new SqlConnection(connectionString);

                    string query =
                    "DELETE FROM Devices WHERE DeviceID = @DeviceID";

                    SqlCommand cmd =
                    new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue(
                    "@DeviceID",
                    Convert.ToInt32(txtDeviceID.Text));

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show(
                    "Device was successfully deleted!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                    LoadDevices();

                    txtDeviceID.Clear();
                    txtAssetTag.Clear();
                    txtDeviceName.Clear();
                    txtAssignedTo.Clear();
                    txtSerial.Clear();
                    txtModelYear.Clear();

                    cboDeviceType.SelectedIndex = -1;
                    cboStatus.SelectedIndex = -1;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDeviceID.Clear();
            txtAssetTag.Clear();
            txtDeviceName.Clear();
            txtAssignedTo.Clear();
            txtSerial.Clear();
            txtModelYear.Clear();
            cboDeviceType.SelectedIndex = -1;
            cboStatus.SelectedIndex = -1;
        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard =
new Dashboard();

            dashboard.Show();
        }

        private void cboDeviceType_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void cboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];

                txtDeviceID.Text = row.Cells["DeviceID"].Value.ToString();
                txtAssetTag.Text = row.Cells["AssetTag"].Value.ToString();
                txtDeviceName.Text = row.Cells["DeviceName"].Value.ToString();
                cboDeviceType.Text = row.Cells["DeviceType"].Value.ToString();
                cboStatus.Text = row.Cells["Status"].Value.ToString();
                txtAssignedTo.Text = row.Cells["AssignedTo"].Value.ToString();
                txtSerial.Text = row.Cells["SerialNumber"].Value.ToString();
                txtModelYear.Text = row.Cells["ModelYear"].Value.ToString();
            }
        }

        private void txtModelYear_TextChanged(object sender, EventArgs e)
        {

  

            }
        }
    }


