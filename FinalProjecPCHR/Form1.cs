using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjecPCHR
{
    public partial class Login_Frm : Form
    {
        public Login_Frm()
        {
            InitializeComponent();
        }

        private void aLLERGY_TBLBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aLLERGY_TBLBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pchr42563DataSet);

        }

        private void pER_DETAILS_TBLBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pER_DETAILS_TBLBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pchr42563DataSet);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
