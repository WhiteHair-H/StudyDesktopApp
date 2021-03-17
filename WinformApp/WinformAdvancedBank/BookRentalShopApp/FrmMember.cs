using MetroFramework.Forms;
using MetroFramework;
using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace BookRentalShopApp
{
    public partial class FrmMember : MetroForm
    {

        #region 전역변수 영역

        public FrmMember()
        {
            InitializeComponent();
        }
        
        private bool IsNew = false; // false (수정) true (신규)

        

        #endregion

        #region 이벤트 영역


        

        private void FrmDivCode_Load(object sender, EventArgs e)
        {
            IsNew = true; //신규 초기화
            RefreshData();
        }

        private void FrmDivCode_Resize(object sender, EventArgs e)
        {
            DgvData.Height = this.ClientRectangle.Height - 90;
            GrbDetail.Height = this.ClientRectangle.Height - 90;
        }

        private void DgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1) // 선택된 값이 존재하면
            {
                var selData = DgvData.Rows[e.RowIndex];
                TxtIdx.Text = selData.Cells[0].Value.ToString();
                TxtNames.Text = selData.Cells[1].Value.ToString();
                CboLevels.SelectedItem = selData.Cells[2].Value;

                Txtaddr.Text = selData.Cells[3].Value.ToString();
                TxtMobile.Text = selData.Cells[4].Value.ToString();
                TxtEmail.Text = selData.Cells[5].Value.ToString();
                TxtId.Text = selData.Cells[6].Value.ToString();


                TxtIdx.ReadOnly = true;

                IsNew = false;
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            // Validation 체크
            if (CheckValidation() == false) return;
            // 삭제질문
            if (MetroMessageBox.Show(this, "삭제하시겠습니까?", "삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            DeleteData();
            RefreshData();
            ClearInputs();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // Validation 체크
            if (CheckValidation() == false) return;

            SaveData();
            RefreshData();
            ClearInputs();
        }

        #endregion

        #region 커스텀 메서드 영역

        /// <summary>
        /// 삭제 처리 프로세스
        /// </summary>
        private void DeleteData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;

                    var query = "DELETE FROM [dbo].[membertbl] " +
                                " WHERE [Idx] = @Idx";
                    cmd.CommandText = query;

                    var pIdx = new SqlParameter("@Idx", SqlDbType.VarChar, 8);
                    pIdx.Value = TxtIdx.Text;
                    cmd.Parameters.Add(pIdx);

                    //SqlParameter param;

                    //cmd.Parameters.Add(param);

                    var result = cmd.ExecuteNonQuery();
                    if (result == 1)
                    {
                        //저장성공
                        MetroMessageBox.Show(this, "삭제 성공", "삭제", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        //저장실패
                        MetroMessageBox.Show(this, "삭제 실패", "삭제", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"예외발생 : {ex.Message}", "오류", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void RefreshData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();
                    {
                        var query = @"SELECT [Idx]
                                      ,[Names]
                                      ,[Levels]
                                      ,[Addr]
                                      ,[Mobile]
                                      ,[Email]
                                      ,[userID]
                                      ,[lastLoginDt]
                                      ,[loginIpAddr]
                                  FROM [bookrentalshop].[dbo].[membertbl]";
                        SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                        DataSet ds = new DataSet();
                        adapter.Fill(ds, "membertbl");

                        DgvData.DataSource = ds;
                        DgvData.DataMember = "membertbl";
                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"예외발생 : {ex.Message}", "오류", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 입력, 수정 데이터
        /// </summary>
        private void SaveData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;

                    var query = "";
                    if (IsNew == true) // insert
                    {
                        query = @"INSERT INTO [dbo].[membertbl]
                                                ([Names]
                                               ,[Levels]
                                               ,[Addr]
                                               ,[Mobile]
                                               ,[Email]
                                               ,[userID]
                                               ,[passwords])
                                         VALUES
                                                (@Names
                                               ,@Levels
                                               ,@Addr
                                               ,@Mobile
                                               ,@Email
                                               ,@userID
                                               ,@passwords)";
                    }
                    else // UPDATE
                    {
                        query = @"UPDATE [dbo].[membertbl]
                                   SET [Names] = @Names
                                      ,[Levels] = @Levels
                                      ,[Addr] = @Addr
                                      ,[Mobile] = @Mobile
                                      ,[Email] = @Email
                                      ,[userID] = @userID
                                      ,[passwords] = @passwords
                                 WHERE Idx = @Idx;";
                    }
                    cmd.CommandText = query;

                    var pNames = new SqlParameter("@Names", SqlDbType.NVarChar, 50);
                    pNames.Value = TxtNames.Text;
                    cmd.Parameters.Add(pNames);

                    var pLevels = new SqlParameter("@Levels", SqlDbType.Char, 1);
                    pLevels.Value = CboLevels.SelectedItem.ToString();
                    cmd.Parameters.Add(pLevels);

                    var pAddr = new SqlParameter("@Addr", SqlDbType.NVarChar, 100);
                    pAddr.Value = Txtaddr.Text;
                    cmd.Parameters.Add(pAddr);

                    var pMobile = new SqlParameter("@Mobile", SqlDbType.VarChar, 13);
                    pMobile.Value = TxtMobile.Text;
                    cmd.Parameters.Add(pMobile);

                    var pEmail = new SqlParameter("@Email", SqlDbType.VarChar, 50);
                    pEmail.Value = TxtEmail.Text;
                    cmd.Parameters.Add(pEmail);

                    var pUserID = new SqlParameter("@userID", SqlDbType.VarChar, 20);
                    pUserID.Value = TxtId.Text;
                    cmd.Parameters.Add(pUserID);

                    var pPasswords = new SqlParameter("@passwords", SqlDbType.VarChar, 100);
                    pPasswords.Value = TxtPasswords.Text;
                    cmd.Parameters.Add(pPasswords);

                    if (IsNew == false) // UPDATE일때만 처리
                    {
                    var pIdx = new SqlParameter("@Idx", SqlDbType.Int);
                    pIdx.Value = TxtIdx.Text;
                    cmd.Parameters.Add(pIdx);

                    }






                    //SqlParameter param;

                    //cmd.Parameters.Add(param);

                    var result = cmd.ExecuteNonQuery();
                    if (result == 1)
                    {
                        //저장성공
                        MetroMessageBox.Show(this, "저장 성공", "저장", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        //저장실패
                        MetroMessageBox.Show(this, "저장 실패", "저장", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"예외발생 : {ex.Message}", "오류", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ClearInputs()
        {
            TxtIdx.Text = TxtNames.Text = "";
            TxtMobile.Text = Txtaddr.Text = TxtEmail.Text = "";
            TxtId.Text = "";
            TxtPasswords.Text = "";
            CboLevels.SelectedIndex = -1;
            TxtIdx.ReadOnly = true;
            IsNew = true;
        }

        /// <summary>
        /// 입력값 유효성 체크 메서드
        /// </summary>
        /// <returns></returns>
        private bool CheckValidation()
        {
            if (string.IsNullOrEmpty(TxtNames.Text) ||
                string.IsNullOrEmpty(Txtaddr.Text) || string.IsNullOrEmpty(TxtMobile.Text) ||
                string.IsNullOrEmpty(TxtEmail.Text) || CboLevels.SelectedIndex == -1 ||
                string.IsNullOrEmpty(TxtId.Text))
            {
                MetroMessageBox.Show(this, "빈값은 처리할 수 없습니다.", "경고",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }


        #endregion
    }
}
