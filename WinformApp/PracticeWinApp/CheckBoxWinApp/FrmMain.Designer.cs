
namespace CheckBoxWinApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.ChkApple = new System.Windows.Forms.CheckBox();
            this.ChkPear = new System.Windows.Forms.CheckBox();
            this.ChkStb = new System.Windows.Forms.CheckBox();
            this.ChkBana = new System.Windows.Forms.CheckBox();
            this.ChkOran = new System.Windows.Forms.CheckBox();
            this.ChkDori = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "질문 : 좋아하는 과일을 모두 선택하세요.";
            // 
            // ChkApple
            // 
            this.ChkApple.AutoSize = true;
            this.ChkApple.Location = new System.Drawing.Point(38, 75);
            this.ChkApple.Name = "ChkApple";
            this.ChkApple.Size = new System.Drawing.Size(48, 16);
            this.ChkApple.TabIndex = 1;
            this.ChkApple.Text = "사과";
            this.ChkApple.UseVisualStyleBackColor = true;
            // 
            // ChkPear
            // 
            this.ChkPear.AutoSize = true;
            this.ChkPear.Location = new System.Drawing.Point(38, 96);
            this.ChkPear.Name = "ChkPear";
            this.ChkPear.Size = new System.Drawing.Size(36, 16);
            this.ChkPear.TabIndex = 2;
            this.ChkPear.Text = "배";
            this.ChkPear.UseVisualStyleBackColor = true;
            // 
            // ChkStb
            // 
            this.ChkStb.AutoSize = true;
            this.ChkStb.Location = new System.Drawing.Point(38, 117);
            this.ChkStb.Name = "ChkStb";
            this.ChkStb.Size = new System.Drawing.Size(48, 16);
            this.ChkStb.TabIndex = 3;
            this.ChkStb.Text = "딸기";
            this.ChkStb.UseVisualStyleBackColor = true;
            // 
            // ChkBana
            // 
            this.ChkBana.AutoSize = true;
            this.ChkBana.Location = new System.Drawing.Point(38, 138);
            this.ChkBana.Name = "ChkBana";
            this.ChkBana.Size = new System.Drawing.Size(60, 16);
            this.ChkBana.TabIndex = 4;
            this.ChkBana.Text = "바나나";
            this.ChkBana.UseVisualStyleBackColor = true;
            // 
            // ChkOran
            // 
            this.ChkOran.AutoSize = true;
            this.ChkOran.Location = new System.Drawing.Point(38, 159);
            this.ChkOran.Name = "ChkOran";
            this.ChkOran.Size = new System.Drawing.Size(60, 16);
            this.ChkOran.TabIndex = 5;
            this.ChkOran.Text = "오렌지";
            this.ChkOran.UseVisualStyleBackColor = true;
            // 
            // ChkDori
            // 
            this.ChkDori.AutoSize = true;
            this.ChkDori.Location = new System.Drawing.Point(38, 180);
            this.ChkDori.Name = "ChkDori";
            this.ChkDori.Size = new System.Drawing.Size(60, 16);
            this.ChkDori.TabIndex = 6;
            this.ChkDori.Text = "두리안";
            this.ChkDori.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(288, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "결과";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 242);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ChkDori);
            this.Controls.Add(this.ChkOran);
            this.Controls.Add(this.ChkBana);
            this.Controls.Add(this.ChkStb);
            this.Controls.Add(this.ChkPear);
            this.Controls.Add(this.ChkApple);
            this.Controls.Add(this.label1);
            this.Name = "FrmMain";
            this.Text = "Favorite Fruits App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ChkApple;
        private System.Windows.Forms.CheckBox ChkPear;
        private System.Windows.Forms.CheckBox ChkStb;
        private System.Windows.Forms.CheckBox ChkBana;
        private System.Windows.Forms.CheckBox ChkOran;
        private System.Windows.Forms.CheckBox ChkDori;
        private System.Windows.Forms.Button button1;
    }
}

