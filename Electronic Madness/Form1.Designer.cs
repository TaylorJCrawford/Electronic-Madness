namespace Electronic_Madness
{
    partial class frmLoading_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoading_Form));
            this.lblgamename_loadingform = new System.Windows.Forms.Label();
            this.pgbloadingform = new System.Windows.Forms.ProgressBar();
            this.Loadingfrom_timer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblgamename_loadingform
            // 
            this.lblgamename_loadingform.AutoSize = true;
            this.lblgamename_loadingform.Font = new System.Drawing.Font("Times New Roman", 22.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgamename_loadingform.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblgamename_loadingform.Image = ((System.Drawing.Image)(resources.GetObject("lblgamename_loadingform.Image")));
            this.lblgamename_loadingform.Location = new System.Drawing.Point(81, 8);
            this.lblgamename_loadingform.Name = "lblgamename_loadingform";
            this.lblgamename_loadingform.Size = new System.Drawing.Size(320, 43);
            this.lblgamename_loadingform.TabIndex = 0;
            this.lblgamename_loadingform.Text = "Electronic Madness";
            // 
            // pgbloadingform
            // 
            this.pgbloadingform.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pgbloadingform.Location = new System.Drawing.Point(32, 366);
            this.pgbloadingform.Name = "pgbloadingform";
            this.pgbloadingform.Size = new System.Drawing.Size(419, 55);
            this.pgbloadingform.TabIndex = 4;
            this.pgbloadingform.Click += new System.EventHandler(this.pgbloadingform_Click);
            // 
            // Loadingfrom_timer
            // 
            this.Loadingfrom_timer.Interval = 30;
            this.Loadingfrom_timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(485, 469);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Location = new System.Drawing.Point(1, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(488, 10);
            this.panel2.TabIndex = 12;
            // 
            // frmLoading_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pgbloadingform);
            this.Controls.Add(this.lblgamename_loadingform);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmLoading_Form";
            this.Text = "Loading Form";
            this.Load += new System.EventHandler(this.Loading_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblgamename_loadingform;
        private System.Windows.Forms.ProgressBar pgbloadingform;
        private System.Windows.Forms.Timer Loadingfrom_timer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
    }
}

