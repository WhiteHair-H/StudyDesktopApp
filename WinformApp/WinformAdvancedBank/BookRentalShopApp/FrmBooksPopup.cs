using MetroFramework.Forms;
using MetroFramework;
using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace BookRentalShopApp
{
    public partial class FrmBooksPopup : MetroForm
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

        private void RefreshData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();

                    var query = @"SELECT b.Idx
                                  ,b.Author
                                  ,b.Division
                                  ,b.Names
                                  ,b.Descriptions
                              FROM dbo.bookstbl as b";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "bookstbl");

                    DgvData.DataSource = ds;
                    DgvData.DataMember = "bookstbl";

                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"예외발생 {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        #endregion

        #region 커스텀 메서드 영역


        /// <summary>
        /// 삭제처리 프로세스
        /// </summary>




        public FrmBooksPopup()
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
            selName = DgvData.SelectedRows[0].Cells[3].Value.ToString();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}