namespace _5thUnit03Question1
{
    partial class frmLotto649
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLotto649));
            this.lblLotto649 = new System.Windows.Forms.Label();
            this.picCoinCash1 = new System.Windows.Forms.PictureBox();
            this.lblGenerate = new System.Windows.Forms.Label();
            this.cboNumberOfDraws = new System.Windows.Forms.ComboBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.picCoinCash2 = new System.Windows.Forms.PictureBox();
            this.libLottoNumbers = new System.Windows.Forms.ListBox();
            this.picStars = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCoinCash1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoinCash2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStars)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLotto649
            // 
            this.lblLotto649.AutoSize = true;
            this.lblLotto649.BackColor = System.Drawing.Color.Transparent;
            this.lblLotto649.Font = new System.Drawing.Font("Verdana", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLotto649.ForeColor = System.Drawing.Color.White;
            this.lblLotto649.Location = new System.Drawing.Point(29, 9);
            this.lblLotto649.Name = "lblLotto649";
            this.lblLotto649.Size = new System.Drawing.Size(415, 42);
            this.lblLotto649.TabIndex = 0;
            this.lblLotto649.Text = "Lotto 649 Generator";
            // 
            // picCoinCash1
            // 
            this.picCoinCash1.BackColor = System.Drawing.Color.Transparent;
            this.picCoinCash1.Image = ((System.Drawing.Image)(resources.GetObject("picCoinCash1.Image")));
            this.picCoinCash1.Location = new System.Drawing.Point(61, 109);
            this.picCoinCash1.Name = "picCoinCash1";
            this.picCoinCash1.Size = new System.Drawing.Size(76, 50);
            this.picCoinCash1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCoinCash1.TabIndex = 1;
            this.picCoinCash1.TabStop = false;
            // 
            // lblGenerate
            // 
            this.lblGenerate.BackColor = System.Drawing.Color.Transparent;
            this.lblGenerate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenerate.ForeColor = System.Drawing.Color.White;
            this.lblGenerate.Location = new System.Drawing.Point(48, 51);
            this.lblGenerate.Name = "lblGenerate";
            this.lblGenerate.Size = new System.Drawing.Size(211, 48);
            this.lblGenerate.TabIndex = 2;
            this.lblGenerate.Text = "Enter the number of draws to generate:";
            // 
            // cboNumberOfDraws
            // 
            this.cboNumberOfDraws.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cboNumberOfDraws.Font = new System.Drawing.Font("Segoe Marker", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNumberOfDraws.ForeColor = System.Drawing.Color.White;
            this.cboNumberOfDraws.FormattingEnabled = true;
            this.cboNumberOfDraws.Location = new System.Drawing.Point(265, 54);
            this.cboNumberOfDraws.Name = "cboNumberOfDraws";
            this.cboNumberOfDraws.Size = new System.Drawing.Size(141, 49);
            this.cboNumberOfDraws.TabIndex = 3;
            this.cboNumberOfDraws.Text = "1";
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.MediumBlue;
            this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerate.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(143, 109);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(170, 45);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // picCoinCash2
            // 
            this.picCoinCash2.BackColor = System.Drawing.Color.Transparent;
            this.picCoinCash2.Image = ((System.Drawing.Image)(resources.GetObject("picCoinCash2.Image")));
            this.picCoinCash2.Location = new System.Drawing.Point(319, 109);
            this.picCoinCash2.Name = "picCoinCash2";
            this.picCoinCash2.Size = new System.Drawing.Size(76, 50);
            this.picCoinCash2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCoinCash2.TabIndex = 5;
            this.picCoinCash2.TabStop = false;
            // 
            // libLottoNumbers
            // 
            this.libLottoNumbers.BackColor = System.Drawing.SystemColors.HotTrack;
            this.libLottoNumbers.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libLottoNumbers.ForeColor = System.Drawing.Color.White;
            this.libLottoNumbers.FormattingEnabled = true;
            this.libLottoNumbers.ItemHeight = 36;
            this.libLottoNumbers.Location = new System.Drawing.Point(88, 165);
            this.libLottoNumbers.Name = "libLottoNumbers";
            this.libLottoNumbers.Size = new System.Drawing.Size(562, 76);
            this.libLottoNumbers.TabIndex = 6;
            // 
            // picStars
            // 
            this.picStars.BackColor = System.Drawing.Color.Transparent;
            this.picStars.Image = ((System.Drawing.Image)(resources.GetObject("picStars.Image")));
            this.picStars.Location = new System.Drawing.Point(365, 12);
            this.picStars.Name = "picStars";
            this.picStars.Size = new System.Drawing.Size(407, 147);
            this.picStars.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picStars.TabIndex = 7;
            this.picStars.TabStop = false;
            // 
            // frmLotto649
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(717, 252);
            this.Controls.Add(this.libLottoNumbers);
            this.Controls.Add(this.picCoinCash2);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.cboNumberOfDraws);
            this.Controls.Add(this.lblGenerate);
            this.Controls.Add(this.picCoinCash1);
            this.Controls.Add(this.lblLotto649);
            this.Controls.Add(this.picStars);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLotto649";
            this.Text = "Lotto 649 Generator";
            this.Load += new System.EventHandler(this.frmLotto649_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCoinCash1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoinCash2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLotto649;
        private System.Windows.Forms.PictureBox picCoinCash1;
        private System.Windows.Forms.Label lblGenerate;
        private System.Windows.Forms.ComboBox cboNumberOfDraws;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.PictureBox picCoinCash2;
        private System.Windows.Forms.ListBox libLottoNumbers;
        private System.Windows.Forms.PictureBox picStars;
    }
}

