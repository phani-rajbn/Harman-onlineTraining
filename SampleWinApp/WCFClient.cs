using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SampleWinApp.mySelfHostingService;

namespace SampleWinApp
{
    public partial class WCFClient : Form
    {
        public WCFClient()
        {
            InitializeComponent();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            var proxy = new PatientServiceClient();
            var patient = new Patient
            {
                BillAmount = double.Parse(cmbAmount.Text),
                PatientName = textBox1.Text,
                ContactNo = long.Parse(textBox2.Text),
                DateOfVisit = DateTime.Now
            };
            try
            {
                proxy.AddNewPatient(patient);
            }
            catch(Exception ex)
            {
                string error = ex.Message;
                if(ex.InnerException != null)
                {
                    error += $"\n{ex.InnerException.Message}";
                }
                MessageBox.Show(error);
            }
        }

        private void WCFClient_Load(object sender, EventArgs e)
        {
            var proxy = new PatientServiceClient();
            var data = proxy.GetAllPatients().ToList();
            lstNames.DataSource = data;
            lstNames.DisplayMember = "PatientName";
            lstNames.ValueMember = "PatientID";
        }

        private void LstNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            var patient = lstNames.SelectedItem as Patient;
            textBox1.Text = patient.PatientName;
            textBox2.Text = patient.ContactNo.ToString();
            cmbAmount.Text = patient.BillAmount.ToString();
        }
    }
}
