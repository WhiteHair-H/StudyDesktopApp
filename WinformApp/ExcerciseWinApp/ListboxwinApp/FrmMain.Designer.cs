
namespace ListboxwinApp
{
    partial class FrmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.LsbGdpCountry = new System.Windows.Forms.ListBox();
            this.LsbGoodCity = new System.Windows.Forms.ListBox();
            this.LsbHappyCountry = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtIndexGdp = new System.Windows.Forms.TextBox();
            this.TxtItemGdp = new System.Windows.Forms.TextBox();
            this.TxtIndexGood = new System.Windows.Forms.TextBox();
            this.TxtItemGood = new System.Windows.Forms.TextBox();
            this.TxtIndexHappy = new System.Windows.Forms.TextBox();
            this.TxtItemHappy = new System.Windows.Forms.TextBox();
            this.BtnInit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LsbGdpCountry
            // 
            this.LsbGdpCountry.FormattingEnabled = true;
            this.LsbGdpCountry.ItemHeight = 12;
            this.LsbGdpCountry.Items.AddRange(new object[] {
            "미국",
            "러시아",
            "중국",
            "영국",
            "독일",
            "프랑스",
            "일본",
            "이스라엘",
            "사우디아라비아",
            "UAE"});
            this.LsbGdpCountry.Location = new System.Drawing.Point(171, 88);
            this.LsbGdpCountry.Name = "LsbGdpCountry";
            this.LsbGdpCountry.Size = new System.Drawing.Size(144, 220);
            this.LsbGdpCountry.TabIndex = 12;
            this.LsbGdpCountry.SelectedIndexChanged += new System.EventHandler(this.LsbGdpCountry_SelectedIndexChanged);
            // 
            // LsbGoodCity
            // 
            this.LsbGoodCity.FormattingEnabled = true;
            this.LsbGoodCity.ItemHeight = 12;
            this.LsbGoodCity.Location = new System.Drawing.Point(363, 88);
            this.LsbGoodCity.Name = "LsbGoodCity";
            this.LsbGoodCity.Size = new System.Drawing.Size(144, 220);
            this.LsbGoodCity.TabIndex = 0;
            this.LsbGoodCity.SelectedIndexChanged += new System.EventHandler(this.LsbGoodCity_SelectedIndexChanged);
            // 
            // LsbHappyCountry
            // 
            this.LsbHappyCountry.FormattingEnabled = true;
            this.LsbHappyCountry.ItemHeight = 12;
            this.LsbHappyCountry.Location = new System.Drawing.Point(554, 88);
            this.LsbHappyCountry.Name = "LsbHappyCountry";
            this.LsbHappyCountry.Size = new System.Drawing.Size(144, 220);
            this.LsbHappyCountry.TabIndex = 0;
            this.LsbHappyCountry.SelectedIndexChanged += new System.EventHandler(this.LsbHappyCountry_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "SelectedIndex : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "SelectedItem : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "GDP 국가 순위";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(361, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "살기좋은 도시";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(552, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "행복한 나라";
            // 
            // TxtIndexGdp
            // 
            this.TxtIndexGdp.Location = new System.Drawing.Point(171, 334);
            this.TxtIndexGdp.Name = "TxtIndexGdp";
            this.TxtIndexGdp.Size = new System.Drawing.Size(144, 21);
            this.TxtIndexGdp.TabIndex = 1;
            // 
            // TxtItemGdp
            // 
            this.TxtItemGdp.Location = new System.Drawing.Point(171, 368);
            this.TxtItemGdp.Name = "TxtItemGdp";
            this.TxtItemGdp.Size = new System.Drawing.Size(144, 21);
            this.TxtItemGdp.TabIndex = 2;
            // 
            // TxtIndexGood
            // 
            this.TxtIndexGood.Location = new System.Drawing.Point(363, 334);
            this.TxtIndexGood.Name = "TxtIndexGood";
            this.TxtIndexGood.Size = new System.Drawing.Size(144, 21);
            this.TxtIndexGood.TabIndex = 3;
            // 
            // TxtItemGood
            // 
            this.TxtItemGood.Location = new System.Drawing.Point(363, 368);
            this.TxtItemGood.Name = "TxtItemGood";
            this.TxtItemGood.Size = new System.Drawing.Size(144, 21);
            this.TxtItemGood.TabIndex = 4;
            // 
            // TxtIndexHappy
            // 
            this.TxtIndexHappy.Location = new System.Drawing.Point(554, 334);
            this.TxtIndexHappy.Name = "TxtIndexHappy";
            this.TxtIndexHappy.Size = new System.Drawing.Size(144, 21);
            this.TxtIndexHappy.TabIndex = 5;
            // 
            // TxtItemHappy
            // 
            this.TxtItemHappy.Location = new System.Drawing.Point(554, 368);
            this.TxtItemHappy.Name = "TxtItemHappy";
            this.TxtItemHappy.Size = new System.Drawing.Size(144, 21);
            this.TxtItemHappy.TabIndex = 6;
            // 
            // BtnInit
            // 
            this.BtnInit.Location = new System.Drawing.Point(68, 267);
            this.BtnInit.Name = "BtnInit";
            this.BtnInit.Size = new System.Drawing.Size(82, 41);
            this.BtnInit.TabIndex = 15;
            this.BtnInit.Text = "초기화";
            this.BtnInit.UseVisualStyleBackColor = true;
            this.BtnInit.Click += new System.EventHandler(this.BtnInit_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 435);
            this.Controls.Add(this.BtnInit);
            this.Controls.Add(this.TxtItemHappy);
            this.Controls.Add(this.TxtItemGood);
            this.Controls.Add(this.TxtItemGdp);
            this.Controls.Add(this.TxtIndexHappy);
            this.Controls.Add(this.TxtIndexGood);
            this.Controls.Add(this.TxtIndexGdp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LsbHappyCountry);
            this.Controls.Add(this.LsbGoodCity);
            this.Controls.Add(this.LsbGdpCountry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "ListBox Test";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LsbGdpCountry;
        private System.Windows.Forms.ListBox LsbGoodCity;
        private System.Windows.Forms.ListBox LsbHappyCountry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtIndexGdp;
        private System.Windows.Forms.TextBox TxtItemGdp;
        private System.Windows.Forms.TextBox TxtIndexGood;
        private System.Windows.Forms.TextBox TxtItemGood;
        private System.Windows.Forms.TextBox TxtIndexHappy;
        private System.Windows.Forms.TextBox TxtItemHappy;
        private System.Windows.Forms.Button BtnInit;
    }
}

