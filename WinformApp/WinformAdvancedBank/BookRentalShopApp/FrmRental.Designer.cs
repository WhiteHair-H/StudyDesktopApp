
namespace BookRentalShopApp
{
    partial class FrmRental
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRental));
            this.GrbDetail = new System.Windows.Forms.GroupBox();
            this.CboRentalState = new MetroFramework.Controls.MetroComboBox();
            this.CboReturnState = new MetroFramework.Controls.MetroDateTime();
            this.CboRentalDate = new MetroFramework.Controls.MetroDateTime();
            this.BtnSearchBooks = new System.Windows.Forms.Button();
            this.BtnSearchMember = new System.Windows.Forms.Button();
            this.BtnSave = new MetroFramework.Controls.MetroButton();
            this.BtnNew = new MetroFramework.Controls.MetroButton();
            this.TxtBookName = new MetroFramework.Controls.MetroTextBox();
            this.TxtMemberName = new MetroFramework.Controls.MetroTextBox();
            this.dsada = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.TxtIdx = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.DgvData = new System.Windows.Forms.DataGridView();
            this.GrbDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // GrbDetail
            // 
            this.GrbDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrbDetail.Controls.Add(this.CboRentalState);
            this.GrbDetail.Controls.Add(this.CboReturnState);
            this.GrbDetail.Controls.Add(this.CboRentalDate);
            this.GrbDetail.Controls.Add(this.BtnSearchBooks);
            this.GrbDetail.Controls.Add(this.BtnSearchMember);
            this.GrbDetail.Controls.Add(this.BtnSave);
            this.GrbDetail.Controls.Add(this.BtnNew);
            this.GrbDetail.Controls.Add(this.TxtBookName);
            this.GrbDetail.Controls.Add(this.TxtMemberName);
            this.GrbDetail.Controls.Add(this.dsada);
            this.GrbDetail.Controls.Add(this.metroLabel5);
            this.GrbDetail.Controls.Add(this.TxtIdx);
            this.GrbDetail.Controls.Add(this.metroLabel4);
            this.GrbDetail.Controls.Add(this.metroLabel3);
            this.GrbDetail.Controls.Add(this.metroLabel2);
            this.GrbDetail.Controls.Add(this.metroLabel1);
            this.GrbDetail.Location = new System.Drawing.Point(507, 63);
            this.GrbDetail.Name = "GrbDetail";
            this.GrbDetail.Size = new System.Drawing.Size(303, 452);
            this.GrbDetail.TabIndex = 0;
            this.GrbDetail.TabStop = false;
            this.GrbDetail.Text = "상세";
            // 
            // CboRentalState
            // 
            this.CboRentalState.FormattingEnabled = true;
            this.CboRentalState.ItemHeight = 23;
            this.CboRentalState.Location = new System.Drawing.Point(100, 208);
            this.CboRentalState.Name = "CboRentalState";
            this.CboRentalState.Size = new System.Drawing.Size(121, 29);
            this.CboRentalState.TabIndex = 9;
            this.CboRentalState.UseSelectable = true;
            // 
            // CboReturnState
            // 
            this.CboReturnState.CustomFormat = "yyyy-MM-dd";
            this.CboReturnState.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CboReturnState.Location = new System.Drawing.Point(100, 169);
            this.CboReturnState.MinimumSize = new System.Drawing.Size(0, 29);
            this.CboReturnState.Name = "CboReturnState";
            this.CboReturnState.Size = new System.Drawing.Size(187, 29);
            this.CboReturnState.TabIndex = 8;
            // 
            // CboRentalDate
            // 
            this.CboRentalDate.CustomFormat = "yyyy-MM-dd";
            this.CboRentalDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CboRentalDate.Location = new System.Drawing.Point(100, 128);
            this.CboRentalDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.CboRentalDate.Name = "CboRentalDate";
            this.CboRentalDate.Size = new System.Drawing.Size(187, 29);
            this.CboRentalDate.TabIndex = 7;
            // 
            // BtnSearchBooks
            // 
            this.BtnSearchBooks.Image = ((System.Drawing.Image)(resources.GetObject("BtnSearchBooks.Image")));
            this.BtnSearchBooks.Location = new System.Drawing.Point(257, 91);
            this.BtnSearchBooks.Name = "BtnSearchBooks";
            this.BtnSearchBooks.Size = new System.Drawing.Size(30, 24);
            this.BtnSearchBooks.TabIndex = 6;
            this.BtnSearchBooks.UseVisualStyleBackColor = true;
            this.BtnSearchBooks.Click += new System.EventHandler(this.BtnSearchBook_Click);
            // 
            // BtnSearchMember
            // 
            this.BtnSearchMember.Image = ((System.Drawing.Image)(resources.GetObject("BtnSearchMember.Image")));
            this.BtnSearchMember.Location = new System.Drawing.Point(257, 60);
            this.BtnSearchMember.Name = "BtnSearchMember";
            this.BtnSearchMember.Size = new System.Drawing.Size(30, 25);
            this.BtnSearchMember.TabIndex = 4;
            this.BtnSearchMember.UseVisualStyleBackColor = true;
            this.BtnSearchMember.Click += new System.EventHandler(this.BtnSearchMember_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSave.Location = new System.Drawing.Point(218, 393);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(69, 43);
            this.BtnSave.TabIndex = 12;
            this.BtnSave.Text = "저장";
            this.BtnSave.UseSelectable = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNew.Location = new System.Drawing.Point(122, 393);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(69, 43);
            this.BtnNew.TabIndex = 11;
            this.BtnNew.Text = "신규";
            this.BtnNew.UseSelectable = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // TxtBookName
            // 
            // 
            // 
            // 
            this.TxtBookName.CustomButton.Image = null;
            this.TxtBookName.CustomButton.Location = new System.Drawing.Point(124, 1);
            this.TxtBookName.CustomButton.Name = "";
            this.TxtBookName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtBookName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtBookName.CustomButton.TabIndex = 1;
            this.TxtBookName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtBookName.CustomButton.UseSelectable = true;
            this.TxtBookName.CustomButton.Visible = false;
            this.TxtBookName.Lines = new string[0];
            this.TxtBookName.Location = new System.Drawing.Point(100, 92);
            this.TxtBookName.MaxLength = 32767;
            this.TxtBookName.Name = "TxtBookName";
            this.TxtBookName.PasswordChar = '\0';
            this.TxtBookName.PromptText = "도서명";
            this.TxtBookName.ReadOnly = true;
            this.TxtBookName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtBookName.SelectedText = "";
            this.TxtBookName.SelectionLength = 0;
            this.TxtBookName.SelectionStart = 0;
            this.TxtBookName.ShortcutsEnabled = true;
            this.TxtBookName.Size = new System.Drawing.Size(146, 23);
            this.TxtBookName.TabIndex = 5;
            this.TxtBookName.UseSelectable = true;
            this.TxtBookName.WaterMark = "도서명";
            this.TxtBookName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtBookName.WaterMarkFont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // TxtMemberName
            // 
            // 
            // 
            // 
            this.TxtMemberName.CustomButton.Image = null;
            this.TxtMemberName.CustomButton.Location = new System.Drawing.Point(123, 1);
            this.TxtMemberName.CustomButton.Name = "";
            this.TxtMemberName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtMemberName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtMemberName.CustomButton.TabIndex = 1;
            this.TxtMemberName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtMemberName.CustomButton.UseSelectable = true;
            this.TxtMemberName.CustomButton.Visible = false;
            this.TxtMemberName.Lines = new string[0];
            this.TxtMemberName.Location = new System.Drawing.Point(100, 60);
            this.TxtMemberName.MaxLength = 32767;
            this.TxtMemberName.Name = "TxtMemberName";
            this.TxtMemberName.PasswordChar = '\0';
            this.TxtMemberName.PromptText = "대여회원";
            this.TxtMemberName.ReadOnly = true;
            this.TxtMemberName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtMemberName.SelectedText = "";
            this.TxtMemberName.SelectionLength = 0;
            this.TxtMemberName.SelectionStart = 0;
            this.TxtMemberName.ShortcutsEnabled = true;
            this.TxtMemberName.Size = new System.Drawing.Size(145, 23);
            this.TxtMemberName.TabIndex = 3;
            this.TxtMemberName.UseSelectable = true;
            this.TxtMemberName.WaterMark = "대여회원";
            this.TxtMemberName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtMemberName.WaterMarkFont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // dsada
            // 
            this.dsada.AutoSize = true;
            this.dsada.Location = new System.Drawing.Point(26, 211);
            this.dsada.Name = "dsada";
            this.dsada.Size = new System.Drawing.Size(76, 19);
            this.dsada.TabIndex = 1;
            this.dsada.Text = "대여상태 : ";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(38, 172);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(62, 19);
            this.metroLabel5.TabIndex = 1;
            this.metroLabel5.Text = "반납일 : ";
            // 
            // TxtIdx
            // 
            // 
            // 
            // 
            this.TxtIdx.CustomButton.Image = null;
            this.TxtIdx.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.TxtIdx.CustomButton.Name = "";
            this.TxtIdx.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtIdx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtIdx.CustomButton.TabIndex = 1;
            this.TxtIdx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtIdx.CustomButton.UseSelectable = true;
            this.TxtIdx.CustomButton.Visible = false;
            this.TxtIdx.Lines = new string[0];
            this.TxtIdx.Location = new System.Drawing.Point(100, 31);
            this.TxtIdx.MaxLength = 32767;
            this.TxtIdx.Name = "TxtIdx";
            this.TxtIdx.PasswordChar = '\0';
            this.TxtIdx.PromptText = "순번";
            this.TxtIdx.ReadOnly = true;
            this.TxtIdx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtIdx.SelectedText = "";
            this.TxtIdx.SelectionLength = 0;
            this.TxtIdx.SelectionStart = 0;
            this.TxtIdx.ShortcutsEnabled = true;
            this.TxtIdx.Size = new System.Drawing.Size(187, 23);
            this.TxtIdx.TabIndex = 2;
            this.TxtIdx.UseSelectable = true;
            this.TxtIdx.WaterMark = "순번";
            this.TxtIdx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtIdx.WaterMarkFont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(38, 133);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(62, 19);
            this.metroLabel4.TabIndex = 1;
            this.metroLabel4.Text = "대여일 : ";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(38, 94);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(62, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "도서명 : ";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(24, 60);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(76, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "대여회원 : ";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(52, 31);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(48, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "순번 : ";
            // 
            // DgvData
            // 
            this.DgvData.AllowUserToAddRows = false;
            this.DgvData.AllowUserToDeleteRows = false;
            this.DgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvData.Location = new System.Drawing.Point(23, 63);
            this.DgvData.Name = "DgvData";
            this.DgvData.ReadOnly = true;
            this.DgvData.RowTemplate.Height = 23;
            this.DgvData.Size = new System.Drawing.Size(469, 452);
            this.DgvData.TabIndex = 1;
            this.DgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvData_CellClick);
            // 
            // FrmRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 538);
            this.Controls.Add(this.DgvData);
            this.Controls.Add(this.GrbDetail);
            this.Name = "FrmRental";
            this.Text = "대여관리";
            this.Load += new System.EventHandler(this.FrmDivCode_Load);
            this.Resize += new System.EventHandler(this.FrmDivCode_Resize);
            this.GrbDetail.ResumeLayout(false);
            this.GrbDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrbDetail;
        private MetroFramework.Controls.MetroButton BtnSave;
        private MetroFramework.Controls.MetroButton BtnNew;
        private MetroFramework.Controls.MetroTextBox TxtIdx;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridView DgvData;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.Button BtnSearchMember;
        private MetroFramework.Controls.MetroTextBox TxtMemberName;
        private MetroFramework.Controls.MetroDateTime CboReturnState;
        private MetroFramework.Controls.MetroDateTime CboRentalDate;
        private System.Windows.Forms.Button BtnSearchBooks;
        private MetroFramework.Controls.MetroTextBox TxtBookName;
        private MetroFramework.Controls.MetroLabel dsada;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox CboRentalState;
    }
}