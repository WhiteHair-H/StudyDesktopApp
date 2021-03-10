using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyHistoryApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            TreeNode root = new TreeNode("영국 왕실");

            TreeNode stuat = new TreeNode("스튜어트 가");
            stuat.Nodes.Add("ANN1", "앤 (1707~1714)");

            TreeNode hanover = new TreeNode("하노버 가");
            hanover.Nodes.Add("GRG1" , "조지 1세(1714~1727)");
            hanover.Nodes.Add("GRG2", "조지 2세(1727~1760)");
            hanover.Nodes.Add("GRG3", "조지 3세(1760~1820)");
            hanover.Nodes.Add("GRG4", "조지 4세(1820~1830)");
            hanover.Nodes.Add("WRM4", "윌리엄 4세(1830~1837)");
            hanover.Nodes.Add("BTR1", "빅토리아(1837~1901)");

            root.Nodes.Add(stuat);
            root.Nodes.Add(hanover);


            TrvList.Nodes.Add(root);
            TrvList.ExpandAll();
        }

        private void TrvList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //MessageBox.Show(e.Node.ToString());
            PcbPhoto.Image = null;
            TxtDescription.Text = string.Empty;


            if (e.Node.Name == "ANN1")
            {
                PcbPhoto.Image = Bitmap.FromFile("./Images/Anne.jpg");
                TxtDescription.Text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. " +
                    "It was popularised in the 1960s with the release of " +
                    "Letraset sheets containing Lorem Ipsum passages, " +
                    "and more recently with desktop publishing software" +
                    " like Aldus PageMaker including versions of Lorem Ipsum.";
            }
            else if (e.Node.Name == "GRG1")
            {
                PcbPhoto.Image = Bitmap.FromFile("./Images/King_George_I.jpg");
                TxtDescription.Text = "조지 1세는 " + "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. " +
                    "It was popularised in the 1960s with the release of " +
                    "Letraset sheets containing Lorem Ipsum passages, " +
                    "and more recently with desktop publishing software" +
                    " like Aldus PageMaker including versions of Lorem Ipsum.";
            }
        }
    }
}
