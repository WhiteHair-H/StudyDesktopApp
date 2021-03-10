using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurentSelApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            Cborest.Items.AddRange(new string[]
            {
                "히노아지" , "수타우동 겐", " 베아투스", " 스시 유이" , "동경 오이시", "1314"
            });
        }

        private void Cborest_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selItem = sender as ComboBox;
            LblResult.Text = $"이번주 모임장소 : {selItem.SelectedItem}" ;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (Cborest.Text != "")
            {
                Cborest.Items.Add(Cborest.Text);
                LblResult.Text = $"{Cborest.Text} 아이템 추가";
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (Cborest.SelectedIndex > -1)
            {
                LblResult.Text = $"{Cborest.SelectedItem} 아이템 삭제";
                Cborest.Items.Remove(Cborest.SelectedItem);
            }
        }
    }
}
