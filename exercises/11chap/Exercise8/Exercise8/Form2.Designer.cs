namespace Exercise8
{
    partial class CarDetails
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
            this.btnOk = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblForYear = new System.Windows.Forms.Label();
            this.lblForMake = new System.Windows.Forms.Label();
            this.lblForModel = new System.Windows.Forms.Label();
            this.lblForColor = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.llblLink = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(361, 461);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(424, 264);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.llblLink);
            this.panel1.Controls.Add(this.lblColor);
            this.panel1.Controls.Add(this.lblModel);
            this.panel1.Controls.Add(this.lblMake);
            this.panel1.Controls.Add(this.lblYear);
            this.panel1.Controls.Add(this.lblForColor);
            this.panel1.Controls.Add(this.lblForModel);
            this.panel1.Controls.Add(this.lblForMake);
            this.panel1.Controls.Add(this.lblForYear);
            this.panel1.Location = new System.Drawing.Point(12, 319);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 124);
            this.panel1.TabIndex = 4;
            // 
            // lblForYear
            // 
            this.lblForYear.AutoSize = true;
            this.lblForYear.Location = new System.Drawing.Point(3, 0);
            this.lblForYear.Name = "lblForYear";
            this.lblForYear.Size = new System.Drawing.Size(32, 13);
            this.lblForYear.TabIndex = 0;
            this.lblForYear.Text = "Year:";
            // 
            // lblForMake
            // 
            this.lblForMake.AutoSize = true;
            this.lblForMake.Location = new System.Drawing.Point(3, 25);
            this.lblForMake.Name = "lblForMake";
            this.lblForMake.Size = new System.Drawing.Size(37, 13);
            this.lblForMake.TabIndex = 1;
            this.lblForMake.Text = "Make:";
            // 
            // lblForModel
            // 
            this.lblForModel.AutoSize = true;
            this.lblForModel.Location = new System.Drawing.Point(3, 55);
            this.lblForModel.Name = "lblForModel";
            this.lblForModel.Size = new System.Drawing.Size(39, 13);
            this.lblForModel.TabIndex = 2;
            this.lblForModel.Text = "Model:";
            // 
            // lblForColor
            // 
            this.lblForColor.AutoSize = true;
            this.lblForColor.Location = new System.Drawing.Point(3, 86);
            this.lblForColor.Name = "lblForColor";
            this.lblForColor.Size = new System.Drawing.Size(34, 13);
            this.lblForColor.TabIndex = 3;
            this.lblForColor.Text = "Color:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(64, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(31, 13);
            this.lblYear.TabIndex = 4;
            this.lblYear.Text = "none";
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(64, 25);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(31, 13);
            this.lblMake.TabIndex = 5;
            this.lblMake.Text = "none";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(64, 55);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(31, 13);
            this.lblModel.TabIndex = 6;
            this.lblModel.Text = "none";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(64, 86);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(31, 13);
            this.lblColor.TabIndex = 7;
            this.lblColor.Text = "none";
            // 
            // llblLink
            // 
            this.llblLink.AutoSize = true;
            this.llblLink.Location = new System.Drawing.Point(3, 111);
            this.llblLink.Name = "llblLink";
            this.llblLink.Size = new System.Drawing.Size(74, 13);
            this.llblLink.TabIndex = 8;
            this.llblLink.TabStop = true;
            this.llblLink.Text = "Find Out More";
            this.llblLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblLink_LinkClicked);
            // 
            // CarDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 496);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOk);
            this.Name = "CarDetails";
            this.Text = "Car Details";
            this.Load += new System.EventHandler(this.CarDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblForColor;
        private System.Windows.Forms.Label lblForModel;
        private System.Windows.Forms.Label lblForMake;
        private System.Windows.Forms.Label lblForYear;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.LinkLabel llblLink;
    }
}