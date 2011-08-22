namespace Exercise6
{
    partial class CarRentalForm
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
            this.grpTypeOfCar = new System.Windows.Forms.GroupBox();
            this.radLuxury = new System.Windows.Forms.RadioButton();
            this.radStandard = new System.Windows.Forms.RadioButton();
            this.radCompact = new System.Windows.Forms.RadioButton();
            this.numDaysSelector = new System.Windows.Forms.NumericUpDown();
            this.grpDaysToRent = new System.Windows.Forms.GroupBox();
            this.lblForTotalCharge = new System.Windows.Forms.Label();
            this.lblTotalCharge = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.grpTypeOfCar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDaysSelector)).BeginInit();
            this.grpDaysToRent.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTypeOfCar
            // 
            this.grpTypeOfCar.BackColor = System.Drawing.Color.Silver;
            this.grpTypeOfCar.Controls.Add(this.radLuxury);
            this.grpTypeOfCar.Controls.Add(this.radStandard);
            this.grpTypeOfCar.Controls.Add(this.radCompact);
            this.grpTypeOfCar.Controls.Add(this.shapeContainer1);
            this.grpTypeOfCar.ForeColor = System.Drawing.Color.Black;
            this.grpTypeOfCar.Location = new System.Drawing.Point(12, 37);
            this.grpTypeOfCar.Name = "grpTypeOfCar";
            this.grpTypeOfCar.Size = new System.Drawing.Size(83, 108);
            this.grpTypeOfCar.TabIndex = 0;
            this.grpTypeOfCar.TabStop = false;
            this.grpTypeOfCar.Text = "Type of Car";
            // 
            // radLuxury
            // 
            this.radLuxury.AutoSize = true;
            this.radLuxury.Location = new System.Drawing.Point(6, 70);
            this.radLuxury.Name = "radLuxury";
            this.radLuxury.Size = new System.Drawing.Size(58, 18);
            this.radLuxury.TabIndex = 1;
            this.radLuxury.TabStop = true;
            this.radLuxury.Text = "Luxury";
            this.radLuxury.UseVisualStyleBackColor = true;
            this.radLuxury.CheckedChanged += new System.EventHandler(this.radLuxury_CheckedChanged);
            // 
            // radStandard
            // 
            this.radStandard.AutoSize = true;
            this.radStandard.Location = new System.Drawing.Point(6, 45);
            this.radStandard.Name = "radStandard";
            this.radStandard.Size = new System.Drawing.Size(64, 18);
            this.radStandard.TabIndex = 1;
            this.radStandard.TabStop = true;
            this.radStandard.Text = "Standard";
            this.radStandard.UseVisualStyleBackColor = true;
            this.radStandard.CheckedChanged += new System.EventHandler(this.radStandard_CheckedChanged);
            // 
            // radCompact
            // 
            this.radCompact.AutoSize = true;
            this.radCompact.Location = new System.Drawing.Point(6, 20);
            this.radCompact.Name = "radCompact";
            this.radCompact.Size = new System.Drawing.Size(67, 18);
            this.radCompact.TabIndex = 0;
            this.radCompact.TabStop = true;
            this.radCompact.Text = "Compact";
            this.radCompact.UseVisualStyleBackColor = true;
            this.radCompact.CheckedChanged += new System.EventHandler(this.radCompact_CheckedChanged);
            // 
            // numDaysSelector
            // 
            this.numDaysSelector.Location = new System.Drawing.Point(10, 20);
            this.numDaysSelector.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numDaysSelector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDaysSelector.Name = "numDaysSelector";
            this.numDaysSelector.Size = new System.Drawing.Size(30, 18);
            this.numDaysSelector.TabIndex = 2;
            this.numDaysSelector.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDaysSelector.ValueChanged += new System.EventHandler(this.numDaysSelector_ValueChanged);
            // 
            // grpDaysToRent
            // 
            this.grpDaysToRent.BackColor = System.Drawing.Color.Silver;
            this.grpDaysToRent.Controls.Add(this.numDaysSelector);
            this.grpDaysToRent.Controls.Add(this.shapeContainer2);
            this.grpDaysToRent.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDaysToRent.ForeColor = System.Drawing.Color.Black;
            this.grpDaysToRent.Location = new System.Drawing.Point(121, 37);
            this.grpDaysToRent.Name = "grpDaysToRent";
            this.grpDaysToRent.Size = new System.Drawing.Size(103, 55);
            this.grpDaysToRent.TabIndex = 3;
            this.grpDaysToRent.TabStop = false;
            this.grpDaysToRent.Text = "Days To Rent";
            // 
            // lblForTotalCharge
            // 
            this.lblForTotalCharge.AutoSize = true;
            this.lblForTotalCharge.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForTotalCharge.Location = new System.Drawing.Point(15, 171);
            this.lblForTotalCharge.Name = "lblForTotalCharge";
            this.lblForTotalCharge.Size = new System.Drawing.Size(88, 15);
            this.lblForTotalCharge.TabIndex = 4;
            this.lblForTotalCharge.Text = "Total Charge:";
            // 
            // lblTotalCharge
            // 
            this.lblTotalCharge.AutoSize = true;
            this.lblTotalCharge.Location = new System.Drawing.Point(15, 199);
            this.lblTotalCharge.Name = "lblTotalCharge";
            this.lblTotalCharge.Size = new System.Drawing.Size(34, 14);
            this.lblTotalCharge.TabIndex = 5;
            this.lblTotalCharge.Text = "$0.00";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 16);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(77, 89);
            this.shapeContainer1.TabIndex = 2;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 2;
            this.lineShape1.X2 = 75;
            this.lineShape1.Y1 = 0;
            this.lineShape1.Y2 = 0;
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(3, 14);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2});
            this.shapeContainer2.Size = new System.Drawing.Size(97, 38);
            this.shapeContainer2.TabIndex = 3;
            this.shapeContainer2.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 0;
            this.lineShape2.X2 = 95;
            this.lineShape2.Y1 = 0;
            this.lineShape2.Y2 = 0;
            // 
            // CarRentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 286);
            this.Controls.Add(this.lblTotalCharge);
            this.Controls.Add(this.lblForTotalCharge);
            this.Controls.Add(this.grpDaysToRent);
            this.Controls.Add(this.grpTypeOfCar);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CarRentalForm";
            this.Text = "Rent a Car";
            this.grpTypeOfCar.ResumeLayout(false);
            this.grpTypeOfCar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDaysSelector)).EndInit();
            this.grpDaysToRent.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTypeOfCar;
        private System.Windows.Forms.RadioButton radStandard;
        private System.Windows.Forms.RadioButton radCompact;
        private System.Windows.Forms.RadioButton radLuxury;
        private System.Windows.Forms.NumericUpDown numDaysSelector;
        private System.Windows.Forms.GroupBox grpDaysToRent;
        private System.Windows.Forms.Label lblForTotalCharge;
        private System.Windows.Forms.Label lblTotalCharge;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
    }
}

