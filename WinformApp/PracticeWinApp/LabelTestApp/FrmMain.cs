using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabelTestApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            LblAutoSize.Text = LblManualSize.Text = string.Empty;
        }

        private void BtnPushText_Click(object sender, EventArgs e)
        {
            String sample1 = "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Libero ut placeat mollitia commodi veritatis alias culpa officia soluta? Beatae distinctio vitae tenetur sit hic, odit debitis cum velit voluptas totam.";
            String sample2 = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Consequatur qui eum rem assumenda quia, ut repudiandae deleniti laborum nemo veniam optio quisquam earum aperiam esse soluta eligendi unde dolore impedit.";


            LblAutoSize.Text = sample1;
            LblManualSize.Text = sample2;
        }
    }
}
