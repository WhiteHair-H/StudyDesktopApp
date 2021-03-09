using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaskedTextApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //입사일 , 주민번호 유효한 값인지 체크필요
            string str = "입사일: " + TxtHiredDate.Text + "\n";
            str += "우편번호: " + TxtZipCode.Text + "\n";
            str += "주소: " + TxtAddress.Text.Trim() + "\n";
            str += "휴대폰번호: " + Mobile.Text + "\n";
            str += "주민등록번호: " + TxtRegisterNumber.Text + "\n";
            str += "이메일: " + TxtEmail.Text.Trim() + "\n";


            MessageBox.Show(str, "개인정보" , MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
