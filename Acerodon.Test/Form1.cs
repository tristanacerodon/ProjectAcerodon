using Acerodon.Test.AcerodonService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acerodon.Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataServiceClient dsc = new DataServiceClient();

            dsc.AddCustomer(
                new Customer()
                {

                    Name = "SystemTest",
                    CreatedBy = 0,
                    ModifiedBy = 0,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IsActive = true

                });
        }
    }
}
