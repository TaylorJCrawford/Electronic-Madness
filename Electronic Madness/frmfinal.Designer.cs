namespace Electronic_Madness
{
    partial class frmfinal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmfinal));
            this.Panel_frmfinal = new System.Windows.Forms.Panel();
            this.btnexit_final = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblpoints_final = new System.Windows.Forms.Label();
            this.btnmainmenu_final = new System.Windows.Forms.Button();
            this.lblgamename_frmfinal = new System.Windows.Forms.Label();
            this.imgbollons01 = new System.Windows.Forms.PictureBox();
            this.Panel_frmfinal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbollons01)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_frmfinal
            // 
            this.Panel_frmfinal.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Panel_frmfinal.Controls.Add(this.btnexit_final);
            this.Panel_frmfinal.Controls.Add(this.panel2);
            this.Panel_frmfinal.Controls.Add(this.lblpoints_final);
            this.Panel_frmfinal.Controls.Add(this.btnmainmenu_final);
            this.Panel_frmfinal.Controls.Add(this.lblgamename_frmfinal);
            this.Panel_frmfinal.Controls.Add(this.imgbollons01);
            this.Panel_frmfinal.Location = new System.Drawing.Point(14, 12);
            this.Panel_frmfinal.Name = "Panel_frmfinal";
            this.Panel_frmfinal.Size = new System.Drawing.Size(557, 479);
            this.Panel_frmfinal.TabIndex = 1;
            // 
            // btnexit_final
            // 
            this.btnexit_final.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnexit_final.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.btnexit_final.Location = new System.Drawing.Point(309, 400);
            this.btnexit_final.Name = "btnexit_final";
            this.btnexit_final.Size = new System.Drawing.Size(118, 47);
            this.btnexit_final.TabIndex = 27;
            this.btnexit_final.Text = "Exit";
            this.btnexit_final.UseVisualStyleBackColor = false;
            this.btnexit_final.Click += new System.EventHandler(this.btnexit_final_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Location = new System.Drawing.Point(42, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(466, 10);
            this.panel2.TabIndex = 26;
            // 
            // lblpoints_final
            // 
            this.lblpoints_final.AutoSize = true;
            this.lblpoints_final.Font = new System.Drawing.Font("Times New Roman", 13.2F);
            this.lblpoints_final.Location = new System.Drawing.Point(61, 356);
            this.lblpoints_final.Name = "lblpoints_final";
            this.lblpoints_final.Size = new System.Drawing.Size(252, 25);
            this.lblpoints_final.TabIndex = 25;
            this.lblpoints_final.Text = "You have Scored: <Points>";
            // 
            // btnmainmenu_final
            // 
            this.btnmainmenu_final.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnmainmenu_final.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.btnmainmenu_final.Location = new System.Drawing.Point(122, 402);
            this.btnmainmenu_final.Name = "btnmainmenu_final";
            this.btnmainmenu_final.Size = new System.Drawing.Size(118, 47);
            this.btnmainmenu_final.TabIndex = 16;
            this.btnmainmenu_final.Text = "Main Menu";
            this.btnmainmenu_final.UseVisualStyleBackColor = false;
            this.btnmainmenu_final.Click += new System.EventHandler(this.btnmainmenu_final_Click);
            // 
            // lblgamename_frmfinal
            // 
            this.lblgamename_frmfinal.AutoSize = true;
            this.lblgamename_frmfinal.Font = new System.Drawing.Font("Times New Roman", 22.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgamename_frmfinal.Image = ((System.Drawing.Image)(resources.GetObject("lblgamename_frmfinal.Image")));
            this.lblgamename_frmfinal.Location = new System.Drawing.Point(124, 14);
            this.lblgamename_frmfinal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblgamename_frmfinal.Name = "lblgamename_frmfinal";
            this.lblgamename_frmfinal.Size = new System.Drawing.Size(320, 43);
            this.lblgamename_frmfinal.TabIndex = 3;
            this.lblgamename_frmfinal.Text = "Electronic Madness";
            // 
            // imgbollons01
            // 
            this.imgbollons01.Image = ((System.Drawing.Image)(resources.GetObject("imgbollons01.Image")));
            this.imgbollons01.Location = new System.Drawing.Point(113, 43);
            this.imgbollons01.Name = "imgbollons01";
            this.imgbollons01.Size = new System.Drawing.Size(331, 338);
            this.imgbollons01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgbollons01.TabIndex = 6;
            this.imgbollons01.TabStop = false;
            // 
            // frmfinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(585, 503);
            this.Controls.Add(this.Panel_frmfinal);
            this.Name = "frmfinal";
            this.Text = "frmfinal";
            this.Load += new System.EventHandler(this.frmfinal_Load);
            this.Panel_frmfinal.ResumeLayout(false);
            this.Panel_frmfinal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbollons01)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_frmfinal;
        private System.Windows.Forms.Label lblgamename_frmfinal;
        private System.Windows.Forms.PictureBox imgbollons01;
        private System.Windows.Forms.Button btnmainmenu_final;
        private System.Windows.Forms.Label lblpoints_final;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnexit_final;
    }
}