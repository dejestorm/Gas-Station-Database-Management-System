using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gas_Station_Database_Management_System
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gas_Station_Management_SystemDataSet1.PurchaseRecordDetails' table. You can move, or remove it, as needed.
            this.purchaseRecordDetailsTableAdapter.Fill(this.gas_Station_Management_SystemDataSet1.PurchaseRecordDetails);
            // TODO: This line of code loads data into the 'gas_Station_Management_SystemDataSet1.SalesRecordDetails' table. You can move, or remove it, as needed.
            this.salesRecordDetailsTableAdapter.Fill(this.gas_Station_Management_SystemDataSet1.SalesRecordDetails);
            // TODO: This line of code loads data into the 'gas_Station_Management_SystemDataSet1.SupplyRecordDetails' table. You can move, or remove it, as needed.
            this.supplyRecordDetailsTableAdapter.Fill(this.gas_Station_Management_SystemDataSet1.SupplyRecordDetails);
            // TODO: This line of code loads data into the 'gas_Station_Management_SystemDataSet1.AddressDetails' table. You can move, or remove it, as needed.
            this.addressDetailsTableAdapter.Fill(this.gas_Station_Management_SystemDataSet1.AddressDetails);
            // TODO: This line of code loads data into the 'gas_Station_Management_SystemDataSet1.ItemDetails' table. You can move, or remove it, as needed.
            this.itemDetailsTableAdapter.Fill(this.gas_Station_Management_SystemDataSet1.ItemDetails);
            // TODO: This line of code loads data into the 'gas_Station_Management_SystemDataSet1.JobDetails' table. You can move, or remove it, as needed.
            this.jobDetailsTableAdapter.Fill(this.gas_Station_Management_SystemDataSet1.JobDetails);
            // TODO: This line of code loads data into the 'gas_Station_Management_SystemDataSet1.FuelDetails' table. You can move, or remove it, as needed.
            this.fuelDetailsTableAdapter.Fill(this.gas_Station_Management_SystemDataSet1.FuelDetails);
            // TODO: This line of code loads data into the 'gas_Station_Management_SystemDataSet1.VendorDetails' table. You can move, or remove it, as needed.
            this.vendorDetailsTableAdapter.Fill(this.gas_Station_Management_SystemDataSet1.VendorDetails);
            // TODO: This line of code loads data into the 'gas_Station_Management_SystemDataSet1.SupplierDetails' table. You can move, or remove it, as needed.
            this.supplierDetailsTableAdapter.Fill(this.gas_Station_Management_SystemDataSet1.SupplierDetails);
            // TODO: This line of code loads data into the 'gas_Station_Management_SystemDataSet.EmployeeDetails' table. You can move, or remove it, as needed.
            this.employeeDetailsTableAdapter.Fill(this.gas_Station_Management_SystemDataSet.EmployeeDetails);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.employeeDetailsTableAdapter.FillBy(this.gas_Station_Management_SystemDataSet.EmployeeDetails);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void employee_DetailsToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.employeeDetailsTableAdapter.Employee_Details(this.gas_Station_Management_SystemDataSet.EmployeeDetails);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private bool mouseDown;
        private Point lastLocation;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
