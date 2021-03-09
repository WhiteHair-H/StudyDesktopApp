using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeWinApp.Views
{
    public partial class FrmParent : Form
    {
        public FrmParent()
        {
            InitializeComponent();
        }

        private void FrmParent_Load(object sender, EventArgs e)
        {
            this.ClientSize = new Size(800, 600);

            FrmChild frm = new FrmChild();
            this.AddOwnedForm(frm); // AddOwnedForm 사용할 경우 자식창이 앞으로 나옴

            frm.Show();
        }
    }
}
