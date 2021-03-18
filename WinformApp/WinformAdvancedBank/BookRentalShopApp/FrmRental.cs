using MetroFramework.Forms;
using MetroFramework;
using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Diagnostics;

namespace BookRentalShopApp
{
     public partial class FrmRental : MetroForm
    {
        #region 전역변수
        private bool IsNew = false;

        #endregion

        #region 이벤트 영역
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            //Validation
            if (CheckValidation() == false) return;

            if (MetroMessageBox.Show(this, "삭제하시겠습니까?", "삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return; ;

            DeleteData();
            RefreshData();
            ClearInputs();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void FrmDivCode_Resize(object sender, EventArgs e)
        {
            DgvData.Height = this.ClientRectangle.Height - 90;
            DgvData.Width = this.ClientRectangle.Width - 400;
        }

        private void DgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1) // 선택된 값이 존재하면
            {
                var selData = DgvData.Rows[e.RowIndex];
                AsignControls(selData);
                IsNew = false;
                BtnSearchBooks.Enabled = BtnSearchMember.Enabled = false;

            }
        }

        private void AsignControls(DataGridViewRow selData)
        {
            TxtIdx.Text = selData.Cells[0].Value.ToString();
            selMemberIdx = (int)selData.Cells[1].Value;
            Debug.WriteLine($">>>> selMemberIdx : {selMemberIdx}");
            TxtMemberName.Text = selData.Cells[2].Value.ToString();
            selBookIdx = (int)selData.Cells[3].Value;
            Debug.WriteLine($">>>> selBookIdx : {selBookIdx}");
            TxtBookName.Text = selData.Cells[4].Value.ToString();
            CboRentalDate.Value = (DateTime)selData.Cells[5].Value;
            CboReturnState.Value = (DateTime)selData.Cells[6].Value == null? new DateTime(9999, 12, 31) : (DateTime)selData.Cells[6].Value;
            CboRentalState.SelectedValue = selData.Cells[7].Value;
        }

        private void FrmDivCode_Load(object sender, EventArgs e)
        {
            IsNew = true; // 신규 초기화
            InitCboData(); // 콤보박스 들어가는 데이터 초기화
            RefreshData(); // 테이블 조회

            CboRentalDate.CustomFormat = "yyyy-MM-dd";
            CboReturnState.Format = DateTimePickerFormat.Custom;
        }

       

        private void BtnSave_Click(object sender, EventArgs e)
        {

            // Validation 체크
            if (CheckValidation() == false) return;

            SaveData();
            ClearInputs();
            RefreshData();
        }

        #endregion

        #region 커스텀 메서드 영역

        private void InitCboData()
        {
            try
            {
                var temp = new Dictionary<string, string>();
                temp.Add("R", "대여중");
                temp.Add("T", "반납");

                
                CboRentalState.DataSource = new BindingSource(temp, null); // dataMember는 null로
                CboRentalState.DisplayMember = "Value";
                CboRentalState.ValueMember = "Key";
                CboRentalState.SelectedIndex = -1;

                
            }
            catch { }
        }

        /// <summary>
        /// 삭제처리 프로세스
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

                    var query = "";

                    query = "DELETE FROM [dbo].[bookstbl] " +
                            " WHERE [Idx] = @Idx ";
                    cmd.CommandText = query;

                    SqlParameter pIdx = new SqlParameter("@Idx", SqlDbType.Int);
                    pIdx.Value = TxtIdx.Text;
                    cmd.Parameters.Add(pIdx);

                    var result = cmd.ExecuteNonQuery();
                    if (result == 1)
                    {
                        MetroMessageBox.Show(this, "삭제 성공", "삭제", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "삭제 실패", "삭제", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"예외발생 {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();

                    var query = @"SELECT r.Idx
                                      ,r.memberIdx
                                      ,m.Names as memberName
                                      ,r.bookIdx
                                      ,b.Names as bookName
                                      ,r.rentalDate
                                      ,r.returnDate
                                      ,r.rentalState
                                      ,case r.rentalState 
                                         when 'R' then '대여중'
                                         when 'T' then '반납'
                                         else '상태없음' 
                                        end as StateDesc
                                  FROM dbo.rentaltbl as r
                                  INNER JOIN dbo.membertbl as m 
                                    On r.memberIdx = m.Idx
                                  INNER JOIN dbo.bookstbl as b
                                    ON r.bookIdx = b.Idx";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "rentaltbl");

                    DgvData.DataSource = ds;
                    DgvData.DataMember = "rentaltbl";

                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"예외발생 {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           // 데이터그리드뷰 컬럼(Division) 화면에서 안보이게
            var column = DgvData.Columns[1]; // memberIdx
            column.Visible = false;
            column = DgvData.Columns[3]; // booksIdx
            column.Visible = false;
            column = DgvData.Columns[7]; // rentalState
            column.Visible = false;

            column = DgvData.Columns[4];
            column.Width = 250;
            column.HeaderText = "도서명";

            column = DgvData.Columns[0]; // Idx
            column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

     
        }


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


                    if (IsNew == true) //INSERT
                    {
                        query = @"INSERT INTO [dbo].[bookstbl]
                                                   ([Author]
                                                   ,[Division]
                                                   ,[Names]
                                                   ,[ReleaseDate]
                                                   ,[ISBN]
                                                   ,[Price]
                                                   ,[Descriptions])
                                             VALUES
                                                   (@Author
                                                   ,@Division
                                                   ,@Names
                                                   ,@ReleaseDate
                                                   ,@ISBN
                                                   ,@Price
                                                   ,@Descriptions)";
                    }
                    else //UPDATE
                    {
                        query = @"UPDATE [dbo].[bookstbl]
                                           SET [Author] = @Author
                                              ,[Division] = @Division
                                              ,[Names] = @Names
                                              ,[ReleaseDate] = @ReleaseDate
                                              ,[ISBN] = @ISBN
                                              ,[Price] = @Price
                                              ,[Descriptions] = @Descriptions
                                         WHERE Idx = @Idx; ";
                    }
                    cmd.CommandText = query;

                    SqlParameter pAuthor = new SqlParameter("@Author", SqlDbType.NVarChar, 50);
                    pAuthor.Value = TxtMemberName.Text;
                    cmd.Parameters.Add(pAuthor);

                   /* SqlParameter pDivision = new SqlParameter("@Division", SqlDbType.VarChar, 8);
                    pDivision.Value = CboDivision.SelectedValue;
                    cmd.Parameters.Add(pDivision);*/

                    SqlParameter pNames = new SqlParameter("@Names", SqlDbType.NVarChar, 100);
                    pNames.Value = TxtBookName.Text;
                    cmd.Parameters.Add(pNames);

                    SqlParameter pReleaseDate = new SqlParameter("@ReleaseDate", SqlDbType.Date);
                    pReleaseDate.Value = CboRentalDate.Value;
                    cmd.Parameters.Add(pReleaseDate);

                    

                    if(IsNew == false) // Update 일때만 처리
                    {
                        SqlParameter pIdx = new SqlParameter("@Idx", SqlDbType.Int);
                        pIdx.Value = TxtIdx.Text;
                        cmd.Parameters.Add(pIdx);
                    }

                    var result = cmd.ExecuteNonQuery();
                    if (result == 1)
                    {
                        MetroMessageBox.Show(this, "저장 성공", "저장", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "저장 실패", "저장", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"예외발생 {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public FrmRental()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 입력값 유효성 체크 메서드
        /// </summary>
        /// <returns></returns>
        private bool CheckValidation()
        {
            if (string.IsNullOrEmpty(TxtMemberName.Text) || 
                string.IsNullOrEmpty(TxtBookName.Text)||
                 
                CboRentalDate.Value == null)
            {
                MetroMessageBox.Show(this, "빈값은 처리할 수 없습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void ClearInputs()
        {
            TxtIdx.Text = TxtMemberName.Text = "";
            TxtMemberName.Text = "";
            CboRentalDate.Value = DateTime.Now; // 오늘 날짜로 초기화
            CboReturnState.Value = DateTime.Now; // 오늘 날짜로 초기화
            TxtIdx.ReadOnly = true;
            IsNew = true;
        }

        #endregion

        private int selMemberIdx = 0; // 선택된 회원번호
        private string selMemberName =  ""; // 선택된 회원이름

        private void BtnSearchMember_Click(object sender, EventArgs e)
        {
            FrmMemberPopup frm = new FrmMemberPopup();
            frm.StartPosition = FormStartPosition.CenterParent;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                selMemberIdx = frm.selIdx;
                TxtMemberName.Text = selMemberName = frm.selName;
            }
        }

        private int selBookIdx = 0;
        private string selBookName = "";
        private void BtnSearchBook_Click(object sender, EventArgs e)
        {
            FrmBooksPopup frm = new FrmBooksPopup();
            frm.StartPosition = FormStartPosition.CenterParent;
            if(frm.ShowDialog() == DialogResult.OK)
            {
                selBookIdx = frm.selIdx;
                TxtBookName.Text = selBookName = frm.selName;
            }
        }
    }
}
