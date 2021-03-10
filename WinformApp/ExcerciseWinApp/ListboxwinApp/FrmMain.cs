using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListboxwinApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

            //살기좋은 도시 초기화
            LsbGoodCity.Items.Add("오스트리아, 빈");
            LsbGoodCity.Items.Add("일본, 오사카");
            LsbGoodCity.Items.Add("캐나다, 캘거리");
            LsbGoodCity.Items.Add("덴마크, 코펜하겐");
            LsbGoodCity.Items.Add("호주 , 시드니");
            LsbGoodCity.Items.Add("호주, 애들레이드");

            //데이터 바인딩 방식중 하나 (디비랑 연결했을 경우 흔한 방법)
            List<String> lstGDP = new List<string> { "미국","러시아","중국", "영국", "독일", "프랑스"
                , "일본", "이스라엘", "사우디아라비아", "UAE" };
            LsbHappyCountry.DataSource = lstGDP;
            LsbHappyCountry.SelectedIndex = -1;
        }

        private void LsbGdpCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lst = sender as ListBox; // sender가 object로 박싱되기 때문에 listBox로 형변화시켜줘야함
            TxtIndexGdp.Text = lst.SelectedIndex.ToString();
            TxtItemGdp.Text = lst.SelectedItem == null ? string.Empty : lst.SelectedItem.ToString();


        }

        private void LsbGoodCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lst = sender as ListBox;
            TxtIndexGood.Text = lst.SelectedIndex.ToString();
            TxtItemGood.Text = lst.SelectedItem == null ? string.Empty : lst.SelectedItem.ToString();
        }

        private void LsbHappyCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lst = sender as ListBox;
            TxtIndexHappy.Text = lst.SelectedIndex.ToString();
            TxtItemHappy.Text = lst.SelectedItem == null ? string.Empty : lst.SelectedItem.ToString();
        }

        private void BtnInit_Click(object sender, EventArgs e)
        {
            LsbGdpCountry.SelectedIndex = LsbGoodCity.SelectedIndex = LsbHappyCountry.SelectedIndex = -1;
        }
    }
}
