using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BookRentalShopApp
{
    public partial class FrmMemberPopup : MetroForm
    {
        #region 전역변수
        public int selIdx { get; set; }
        public string selName { get; set; }

        #endregion

        #region 이벤트 영역

        private void DgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1) // 선택된 값이 존재하면
            {
                var selData = DgvData.Rows[e.RowIndex];
            }
        }

        private void FrmDivCode_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        #endregion

        #region 커스텀 메서드 영역

        private void RefreshData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();

                    var query = @"SELECT [Idx]
                                        ,[Names]
                                        ,[Levels]
                                        ,[Addr]
                                        ,[Mobile]
                                        ,[Email]
                                    FROM [dbo].[membertbl]";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "membertbl");

                    DgvData.DataSource = ds;
                    DgvData.DataMember = "membertbl";

                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"예외발생 {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }


        public FrmMemberPopup()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 입력값 유효성 체크 메서드
        /// </summary>
        /// <returns></returns>

        #endregion

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            if (DgvData.SelectedRows.Count == 0)
            {
                MetroMessageBox.Show(this, "데이터를 선택하세요", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            selIdx = (int)DgvData.SelectedRows[0].Cells[0].Value;
            selName = DgvData.SelectedRows[0].Cells[1].Value.ToString();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
