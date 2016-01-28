namespace Finals
{
    partial class Frm_Final
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
            this.components = new System.ComponentModel.Container();
            this.Lbl_1 = new System.Windows.Forms.Label();
            this.Lbl_2 = new System.Windows.Forms.Label();
            this.Lbl_3 = new System.Windows.Forms.Label();
            this.Lbl_4 = new System.Windows.Forms.Label();
            this.Lbl_5 = new System.Windows.Forms.Label();
            this.Lbl_Count = new System.Windows.Forms.Label();
            this.Pic_Runner = new System.Windows.Forms.PictureBox();
            this.Tmr_DoCounter = new System.Windows.Forms.Timer(this.components);
            this.Tmr_Delay10 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.changeRangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Runner)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_1
            // 
            this.Lbl_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_1.Location = new System.Drawing.Point(12, 41);
            this.Lbl_1.Name = "Lbl_1";
            this.Lbl_1.Size = new System.Drawing.Size(24, 29);
            this.Lbl_1.TabIndex = 0;
            this.Lbl_1.Text = "0";
            // 
            // Lbl_2
            // 
            this.Lbl_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_2.Location = new System.Drawing.Point(12, 70);
            this.Lbl_2.Name = "Lbl_2";
            this.Lbl_2.Size = new System.Drawing.Size(24, 29);
            this.Lbl_2.TabIndex = 1;
            this.Lbl_2.Text = "0";
            // 
            // Lbl_3
            // 
            this.Lbl_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_3.Location = new System.Drawing.Point(12, 99);
            this.Lbl_3.Name = "Lbl_3";
            this.Lbl_3.Size = new System.Drawing.Size(24, 29);
            this.Lbl_3.TabIndex = 2;
            this.Lbl_3.Text = "0";
            // 
            // Lbl_4
            // 
            this.Lbl_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_4.Location = new System.Drawing.Point(12, 128);
            this.Lbl_4.Name = "Lbl_4";
            this.Lbl_4.Size = new System.Drawing.Size(24, 29);
            this.Lbl_4.TabIndex = 3;
            this.Lbl_4.Text = "0";
            // 
            // Lbl_5
            // 
            this.Lbl_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_5.Location = new System.Drawing.Point(12, 157);
            this.Lbl_5.Name = "Lbl_5";
            this.Lbl_5.Size = new System.Drawing.Size(24, 29);
            this.Lbl_5.TabIndex = 4;
            this.Lbl_5.Text = "0";
            // 
            // Lbl_Count
            // 
            this.Lbl_Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Count.Location = new System.Drawing.Point(12, 186);
            this.Lbl_Count.Name = "Lbl_Count";
            this.Lbl_Count.Size = new System.Drawing.Size(177, 29);
            this.Lbl_Count.TabIndex = 5;
            this.Lbl_Count.Text = "Count: ";
            // 
            // Pic_Runner
            // 
            this.Pic_Runner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pic_Runner.Location = new System.Drawing.Point(0, 24);
            this.Pic_Runner.Name = "Pic_Runner";
            this.Pic_Runner.Size = new System.Drawing.Size(229, 200);
            this.Pic_Runner.TabIndex = 6;
            this.Pic_Runner.TabStop = false;
            this.Pic_Runner.Click += new System.EventHandler(this.Pic_Runner_Click);
            // 
            // Tmr_DoCounter
            // 
            this.Tmr_DoCounter.Interval = 1000;
            this.Tmr_DoCounter.Tick += new System.EventHandler(this.Tmr_DoCounter_Tick);
            // 
            // Tmr_Delay10
            // 
            this.Tmr_Delay10.Interval = 1000;
            this.Tmr_Delay10.Tick += new System.EventHandler(this.Tmr_Delay10_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeRangeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(229, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // changeRangeToolStripMenuItem
            // 
            this.changeRangeToolStripMenuItem.Name = "changeRangeToolStripMenuItem";
            this.changeRangeToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.changeRangeToolStripMenuItem.Text = "Change Range";
            this.changeRangeToolStripMenuItem.Click += new System.EventHandler(this.changeRangeToolStripMenuItem_Click);
            // 
            // Frm_Final
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 224);
            this.Controls.Add(this.Lbl_Count);
            this.Controls.Add(this.Lbl_5);
            this.Controls.Add(this.Lbl_4);
            this.Controls.Add(this.Lbl_3);
            this.Controls.Add(this.Lbl_2);
            this.Controls.Add(this.Lbl_1);
            this.Controls.Add(this.Pic_Runner);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Frm_Final";
            this.Text = "Final";
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Runner)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_1;
        private System.Windows.Forms.Label Lbl_2;
        private System.Windows.Forms.Label Lbl_3;
        private System.Windows.Forms.Label Lbl_4;
        private System.Windows.Forms.Label Lbl_5;
        private System.Windows.Forms.Label Lbl_Count;
        private System.Windows.Forms.PictureBox Pic_Runner;
        private System.Windows.Forms.Timer Tmr_DoCounter;
        private System.Windows.Forms.Timer Tmr_Delay10;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem changeRangeToolStripMenuItem;
    }
}

