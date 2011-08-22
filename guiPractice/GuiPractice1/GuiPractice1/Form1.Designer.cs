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
            this.chkPepperoni = new System.Windows.Forms.CheckBox();
            this.chkSausage = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.radDelivery = new System.Windows.Forms.RadioButton();
            this.radTakeOut = new System.Windows.Forms.RadioButton();
            this.grpDeliverOptions = new System.Windows.Forms.GroupBox();
            this.grpToppings = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.grpDeliverOptions.SuspendLayout();
            this.grpToppings.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkPepperoni
            // 
            this.chkPepperoni.AutoSize = true;
            this.chkPepperoni.Location = new System.Drawing.Point(6, 19);
            this.chkPepperoni.Name = "chkPepperoni";
            this.chkPepperoni.Size = new System.Drawing.Size(74, 17);
            this.chkPepperoni.TabIndex = 0;
            this.chkPepperoni.Text = "Pepperoni";
            this.chkPepperoni.UseVisualStyleBackColor = true;
            this.chkPepperoni.CheckedChanged += new System.EventHandler(this.chkPepperoni_CheckedChanged);
            // 
            // chkSausage
            // 
            this.chkSausage.AutoSize = true;
            this.chkSausage.Location = new System.Drawing.Point(6, 45);
            this.chkSausage.Name = "chkSausage";
            this.chkSausage.Size = new System.Drawing.Size(68, 17);
            this.chkSausage.TabIndex = 1;
            this.chkSausage.Text = "Sausage";
            this.chkSausage.UseVisualStyleBackColor = true;
            this.chkSausage.CheckedChanged += new System.EventHandler(this.chkSausage_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(6, 68);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(54, 17);
            this.chkOnion.TabIndex = 2;
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // radDelivery
            // 
            this.radDelivery.AutoSize = true;
            this.radDelivery.Location = new System.Drawing.Point(6, 42);
            this.radDelivery.Name = "radDelivery";
            this.radDelivery.Size = new System.Drawing.Size(63, 17);
            this.radDelivery.TabIndex = 3;
            this.radDelivery.Text = "Delivery";
            this.radDelivery.UseVisualStyleBackColor = true;
            this.radDelivery.CheckedChanged += new System.EventHandler(this.radDelivery_CheckedChanged);
            // 
            // radTakeOut
            // 
            this.radTakeOut.AutoSize = true;
            this.radTakeOut.Location = new System.Drawing.Point(6, 19);
            this.radTakeOut.Name = "radTakeOut";
            this.radTakeOut.Size = new System.Drawing.Size(70, 17);
            this.radTakeOut.TabIndex = 4;
            this.radTakeOut.Text = "Take Out";
            this.radTakeOut.UseVisualStyleBackColor = true;
            this.radTakeOut.CheckedChanged += new System.EventHandler(this.radTakeOut_CheckedChanged);
            // 
            // grpDeliverOptions
            // 
            this.grpDeliverOptions.Controls.Add(this.radTakeOut);
            this.grpDeliverOptions.Controls.Add(this.radDelivery);
            this.grpDeliverOptions.Location = new System.Drawing.Point(169, 55);
            this.grpDeliverOptions.Name = "grpDeliverOptions";
            this.grpDeliverOptions.Size = new System.Drawing.Size(200, 100);
            this.grpDeliverOptions.TabIndex = 5;
            this.grpDeliverOptions.TabStop = false;
            this.grpDeliverOptions.Text = "Delivery Options";
            // 
            // grpToppings
            // 
            this.grpToppings.Controls.Add(this.chkOnion);
            this.grpToppings.Controls.Add(this.chkSausage);
            this.grpToppings.Controls.Add(this.chkPepperoni);
            this.grpToppings.Location = new System.Drawing.Point(12, 55);
            this.grpToppings.Name = "grpToppings";
            this.grpToppings.Size = new System.Drawing.Size(119, 100);
            this.grpToppings.TabIndex = 6;
            this.grpToppings.TabStop = false;
            this.grpToppings.Text = "Toppings";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(294, 179);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(64, 198);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(89, 13);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "The cost is $0.00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 266);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.grpToppings);
            this.Controls.Add(this.grpDeliverOptions);
            this.Name = "Form1";
            this.Text = "Stop Go";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpDeliverOptions.ResumeLayout(false);
            this.grpDeliverOptions.PerformLayout();
            this.grpToppings.ResumeLayout(false);
            this.grpToppings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkPepperoni;
        private System.Windows.Forms.CheckBox chkSausage;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.RadioButton radDelivery;
        private System.Windows.Forms.RadioButton radTakeOut;
        private System.Windows.Forms.GroupBox grpDeliverOptions;
        private System.Windows.Forms.GroupBox grpToppings;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblPrice;



    }
}

