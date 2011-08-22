namespace GuiPractice1
{
    partial class Form1
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
            this.Go = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.lblPickAnOption = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Go
            // 
            this.Go.Location = new System.Drawing.Point(12, 49);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(75, 23);
            this.Go.TabIndex = 0;
            this.Go.Text = "Go";
            this.Go.UseVisualStyleBackColor = true;
            this.Go.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(205, 49);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(75, 23);
            this.Stop.TabIndex = 1;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblPickAnOption
            // 
            this.lblPickAnOption.AutoSize = true;
            this.lblPickAnOption.Location = new System.Drawing.Point(106, 9);
            this.lblPickAnOption.Name = "lblPickAnOption";
            this.lblPickAnOption.Size = new System.Drawing.Size(77, 13);
            this.lblPickAnOption.TabIndex = 2;
            this.lblPickAnOption.Text = "Pick an Option";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.lblPickAnOption);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Go);
            this.Name = "Form1";
            this.Text = "Stop Go";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Go;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Label lblPickAnOption;

    }
}

