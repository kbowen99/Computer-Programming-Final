namespace Finals
{
    partial class Frm_ChooseField
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
            this.Lbl_Max = new System.Windows.Forms.Label();
            this.Txt_Min = new System.Windows.Forms.TextBox();
            this.Lbl_Min = new System.Windows.Forms.Label();
            this.Txt_Max = new System.Windows.Forms.TextBox();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Max
            // 
            this.Lbl_Max.AutoSize = true;
            this.Lbl_Max.Location = new System.Drawing.Point(9, 41);
            this.Lbl_Max.Name = "Lbl_Max";
            this.Lbl_Max.Size = new System.Drawing.Size(114, 13);
            this.Lbl_Max.TabIndex = 0;
            this.Lbl_Max.Text = "Enter Maximum Range";
            this.Lbl_Max.Click += new System.EventHandler(this.label1_Click);
            // 
            // Txt_Min
            // 
            this.Txt_Min.Location = new System.Drawing.Point(172, 9);
            this.Txt_Min.Name = "Txt_Min";
            this.Txt_Min.Size = new System.Drawing.Size(100, 20);
            this.Txt_Min.TabIndex = 1;
            this.Txt_Min.Text = "0";
            // 
            // Lbl_Min
            // 
            this.Lbl_Min.AutoSize = true;
            this.Lbl_Min.Location = new System.Drawing.Point(9, 16);
            this.Lbl_Min.Name = "Lbl_Min";
            this.Lbl_Min.Size = new System.Drawing.Size(111, 13);
            this.Lbl_Min.TabIndex = 2;
            this.Lbl_Min.Text = "Enter Minimum Range";
            // 
            // Txt_Max
            // 
            this.Txt_Max.Location = new System.Drawing.Point(172, 34);
            this.Txt_Max.Name = "Txt_Max";
            this.Txt_Max.Size = new System.Drawing.Size(100, 20);
            this.Txt_Max.TabIndex = 3;
            this.Txt_Max.Text = "5";
            // 
            // Btn_Update
            // 
            this.Btn_Update.Location = new System.Drawing.Point(12, 60);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(260, 23);
            this.Btn_Update.TabIndex = 4;
            this.Btn_Update.Text = "Update!";
            this.Btn_Update.UseVisualStyleBackColor = true;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // Frm_ChooseField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 91);
            this.Controls.Add(this.Btn_Update);
            this.Controls.Add(this.Txt_Max);
            this.Controls.Add(this.Lbl_Min);
            this.Controls.Add(this.Txt_Min);
            this.Controls.Add(this.Lbl_Max);
            this.MaximizeBox = false;
            this.Name = "Frm_ChooseField";
            this.Text = "Choose Random Ranges";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_ChooseField_FormClosing);
            this.Load += new System.EventHandler(this.Frm_ChooseField_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Max;
        private System.Windows.Forms.TextBox Txt_Min;
        private System.Windows.Forms.Label Lbl_Min;
        private System.Windows.Forms.TextBox Txt_Max;
        private System.Windows.Forms.Button Btn_Update;
    }
}