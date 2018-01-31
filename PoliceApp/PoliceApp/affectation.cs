using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoliceApp
{
    public partial class affectation : Form
    {
        public affectation()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            panel6.Visible = true;
        }
    }
}
