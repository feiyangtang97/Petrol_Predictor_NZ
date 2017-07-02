namespace PetrolPricePredictor
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
			this.lblInputPrice = new System.Windows.Forms.Label();
			this.btnPetrol = new System.Windows.Forms.Button();
			this.btnDiesel = new System.Windows.Forms.Button();
			this.lblTitle = new System.Windows.Forms.Label();
			this.lblBuy = new System.Windows.Forms.Label();
			this.lblWait = new System.Windows.Forms.Label();
			this.nudInput = new System.Windows.Forms.NumericUpDown();
			this.btnInfo = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.nudInput)).BeginInit();
			this.SuspendLayout();
			// 
			// lblInputPrice
			// 
			this.lblInputPrice.AutoSize = true;
			this.lblInputPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
			this.lblInputPrice.Location = new System.Drawing.Point(33, 115);
			this.lblInputPrice.Name = "lblInputPrice";
			this.lblInputPrice.Size = new System.Drawing.Size(276, 37);
			this.lblInputPrice.TabIndex = 1;
			this.lblInputPrice.Text = "CURRENT PRICE";
			// 
			// btnPetrol
			// 
			this.btnPetrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
			this.btnPetrol.Location = new System.Drawing.Point(12, 206);
			this.btnPetrol.Name = "btnPetrol";
			this.btnPetrol.Size = new System.Drawing.Size(155, 44);
			this.btnPetrol.TabIndex = 2;
			this.btnPetrol.Text = "PETROL";
			this.btnPetrol.UseVisualStyleBackColor = true;
			this.btnPetrol.Click += new System.EventHandler(this.btnPetrol_Click);
			// 
			// btnDiesel
			// 
			this.btnDiesel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
			this.btnDiesel.Location = new System.Drawing.Point(177, 205);
			this.btnDiesel.Name = "btnDiesel";
			this.btnDiesel.Size = new System.Drawing.Size(155, 45);
			this.btnDiesel.TabIndex = 3;
			this.btnDiesel.Text = "DIESEL";
			this.btnDiesel.UseVisualStyleBackColor = true;
			this.btnDiesel.Click += new System.EventHandler(this.btnDiesel_Click);
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold);
			this.lblTitle.Location = new System.Drawing.Point(91, 9);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(160, 73);
			this.lblTitle.TabIndex = 4;
			this.lblTitle.Text = "FPP";
			// 
			// lblBuy
			// 
			this.lblBuy.AutoSize = true;
			this.lblBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 96F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBuy.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblBuy.Location = new System.Drawing.Point(12, 355);
			this.lblBuy.Name = "lblBuy";
			this.lblBuy.Size = new System.Drawing.Size(327, 147);
			this.lblBuy.TabIndex = 5;
			this.lblBuy.Text = "BUY";
			this.lblBuy.Visible = false;
			// 
			// lblWait
			// 
			this.lblWait.AutoSize = true;
			this.lblWait.Font = new System.Drawing.Font("Microsoft Sans Serif", 96F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblWait.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblWait.Location = new System.Drawing.Point(-13, 355);
			this.lblWait.Name = "lblWait";
			this.lblWait.Size = new System.Drawing.Size(386, 147);
			this.lblWait.TabIndex = 6;
			this.lblWait.Text = "WAIT";
			this.lblWait.Visible = false;
			// 
			// nudInput
			// 
			this.nudInput.DecimalPlaces = 1;
			this.nudInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nudInput.Location = new System.Drawing.Point(12, 155);
			this.nudInput.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
			this.nudInput.Name = "nudInput";
			this.nudInput.Size = new System.Drawing.Size(320, 44);
			this.nudInput.TabIndex = 7;
			this.nudInput.Tag = "";
			this.nudInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nudInput.Value = new decimal(new int[] {
            1119,
            0,
            0,
            65536});
			// 
			// btnInfo
			// 
			this.btnInfo.Location = new System.Drawing.Point(257, 566);
			this.btnInfo.Name = "btnInfo";
			this.btnInfo.Size = new System.Drawing.Size(75, 23);
			this.btnInfo.TabIndex = 8;
			this.btnInfo.Text = "INFO";
			this.btnInfo.UseVisualStyleBackColor = true;
			this.btnInfo.Visible = false;
			this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(344, 601);
			this.Controls.Add(this.btnInfo);
			this.Controls.Add(this.nudInput);
			this.Controls.Add(this.lblWait);
			this.Controls.Add(this.lblBuy);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.btnDiesel);
			this.Controls.Add(this.btnPetrol);
			this.Controls.Add(this.lblInputPrice);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Fuel Price Predictor";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.nudInput)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label lblInputPrice;
		private System.Windows.Forms.Button btnPetrol;
		private System.Windows.Forms.Button btnDiesel;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label lblBuy;
		private System.Windows.Forms.Label lblWait;
		private System.Windows.Forms.NumericUpDown nudInput;
		private System.Windows.Forms.Button btnInfo;
	}
}

