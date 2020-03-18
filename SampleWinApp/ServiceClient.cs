using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SampleWinApp.myServices;
namespace SampleWinApp
{
    public partial class ServiceClient : Form
    {
        public ServiceClient()
        {
            InitializeComponent();
        }

        private void ServiceClient_Load(object sender, EventArgs e)
        {
            EmpServiceClient proxy = new EmpServiceClient();
            dataGridView1.DataSource = proxy.GetAllEmployees();
        }
    }
}
