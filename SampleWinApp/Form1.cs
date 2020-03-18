using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleWinApp
{
    public partial class MainContainer : Form
    {
        public MainContainer()
        {
            InitializeComponent();
        }
        //Obtained when U double-click the form. Auto generated code which is generated as Event handler.
        private void Form1_Load(object sender, EventArgs e)
        {
            var com = new EmpDatabase();
            var list = com.GetAllEmployees();//List implements IList.
            lstNames.DisplayMember = "EmpName";//Display the property called name
            lstNames.ValueMember = "EmpID";//It represents ID...
            lstNames.DataSource = list;//U can bind only those objects that implement IList Interface
        }
        //When the form is resized, this event handler will be called by the CLR.
        private void MainContainer_SizeChanged(object sender, EventArgs e)
        {
            tabControl1.Size = Size;
        }
        //SelectedIndexChanged is an event of the listbox that is triggered when any selection is made in the listbox..
        private void LstNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            var data = lstNames.SelectedItem as Employee;
            txtID.Text = data.EmpID.ToString();
            txtName.Text = data.EmpName;
            txtSalary.Text = data.EmpSalary.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var emp = new Employee
            {
                EmpID = int.Parse(txtID.Text),
                EmpName = txtName.Text,
                EmpSalary = int.Parse(txtSalary.Text)
            };
            try
            {
                var com = new EmpDatabase();
                com.UpdateEmployee(emp);
                MessageBox.Show("Employee updated successfully to the database");
                Form1_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Event handler for adding button in the Tab2...
        private void myAddingEvent(object sender, EventArgs e)
        {
            var emp = new Employee
            {
                EmpID = int.Parse(txtNewID.Text),
                EmpName = txtNewName.Text,
                EmpSalary = int.Parse(txtNewSalary.Text)
            };
            var com = new EmpDatabase();
            com.AddNewEmployee(emp);
            MessageBox.Show("Employee added successfully to the database");
            Form1_Load(sender, e);
        }
    }
}
