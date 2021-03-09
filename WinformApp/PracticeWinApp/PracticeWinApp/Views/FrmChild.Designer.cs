
namespace PracticeWinApp.Views
{
    partial class FrmChild
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
            this.BtnTestApp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnTestApp
            // 
            this.BtnTestApp.Location = new System.Drawing.Point(88, 21);
            this.BtnTestApp.Name = "BtnTestApp";
            this.BtnTestApp.Size = new System.Drawing.Size(90, 34);
            this.BtnTestApp.TabIndex = 0;
            this.BtnTestApp.Text = "질문";
            this.BtnTestApp.UseVisualStyleBackColor = true;
            this.BtnTestApp.Click += new System.EventHandler(this.BtnTestApp_Click);
            // 
            // FrmChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 91);
            this.Controls.Add(this.BtnTestApp);
            this.Name = "FrmChild";
            this.Text = "자식폼";
            this.Load += new System.EventHandler(this.FrmChild_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnTestApp;
    }
}