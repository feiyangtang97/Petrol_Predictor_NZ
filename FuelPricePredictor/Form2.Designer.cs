namespace PetrolPricePredictor
{
	partial class Form2
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
			this.lblTitle = new System.Windows.Forms.Label();
			this.btnBack = new System.Windows.Forms.Button();
			this.picbxGraph = new System.Windows.Forms.PictureBox();
			this.lbl2 = new System.Windows.Forms.Label();
			this.lbl1 = new System.Windows.Forms.Label();
			this.lblPricePredicted = new System.Windows.Forms.Label();
			this.lblPriceCurrent = new System.Windows.Forms.Label();
			this.lblSignificance = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lblPricePredictedWeek = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.picbxGraph)).BeginInit();
			this.SuspendLayout();
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold);
			this.lblTitle.Location = new System.Drawing.Point(75, 9);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(189, 73);
			this.lblTitle.TabIndex = 5;
			this.lblTitle.Text = "INFO";
			// 
			// btnBack
			// 
			this.btnBack.Location = new System.Drawing.Point(257, 566);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(75, 23);
			this.btnBack.TabIndex = 6;
			this.btnBack.Text = "BACK";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// picbxGraph
			// 
			this.picbxGraph.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.picbxGraph.Location = new System.Drawing.Point(12, 264);
			this.picbxGraph.Name = "picbxGraph";
			this.picbxGraph.Size = new System.Drawing.Size(320, 238);
			this.picbxGraph.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picbxGraph.TabIndex = 7;
			this.picbxGraph.TabStop = false;
			// 
			// lbl2
			// 
			this.lbl2.AutoSize = true;
			this.lbl2.Location = new System.Drawing.Point(12, 173);
			this.lbl2.Name = "lbl2";
			this.lbl2.Size = new System.Drawing.Size(84, 13);
			this.lbl2.TabIndex = 8;
			this.lbl2.Text = "Predicted price: ";
			// 
			// lbl1
			// 
			this.lbl1.AutoSize = true;
			this.lbl1.Location = new System.Drawing.Point(12, 150);
			this.lbl1.Name = "lbl1";
			this.lbl1.Size = new System.Drawing.Size(73, 13);
			this.lbl1.TabIndex = 9;
			this.lbl1.Text = "Current price: ";
			// 
			// lblPricePredicted
			// 
			this.lblPricePredicted.AutoSize = true;
			this.lblPricePredicted.Location = new System.Drawing.Point(164, 173);
			this.lblPricePredicted.Name = "lblPricePredicted";
			this.lblPricePredicted.Size = new System.Drawing.Size(0, 13);
			this.lblPricePredicted.TabIndex = 10;
			// 
			// lblPriceCurrent
			// 
			this.lblPriceCurrent.AutoSize = true;
			this.lblPriceCurrent.Location = new System.Drawing.Point(164, 150);
			this.lblPriceCurrent.Name = "lblPriceCurrent";
			this.lblPriceCurrent.Size = new System.Drawing.Size(0, 13);
			this.lblPriceCurrent.TabIndex = 11;
			// 
			// lblSignificance
			// 
			this.lblSignificance.AutoSize = true;
			this.lblSignificance.Location = new System.Drawing.Point(12, 128);
			this.lblSignificance.Name = "lblSignificance";
			this.lblSignificance.Size = new System.Drawing.Size(0, 13);
			this.lblSignificance.TabIndex = 12;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 198);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(136, 13);
			this.label1.TabIndex = 13;
			this.label1.Text = "Predicted price next week: ";
			// 
			// lblPricePredictedWeek
			// 
			this.lblPricePredictedWeek.AutoSize = true;
			this.lblPricePredictedWeek.Location = new System.Drawing.Point(164, 198);
			this.lblPricePredictedWeek.Name = "lblPricePredictedWeek";
			this.lblPricePredictedWeek.Size = new System.Drawing.Size(0, 13);
			this.lblPricePredictedWeek.TabIndex = 14;
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(344, 601);
			this.Controls.Add(this.lblPricePredictedWeek);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblSignificance);
			this.Controls.Add(this.lblPriceCurrent);
			this.Controls.Add(this.lblPricePredicted);
			this.Controls.Add(this.lbl1);
			this.Controls.Add(this.lbl2);
			this.Controls.Add(this.picbxGraph);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.lblTitle);
			this.Name = "Form2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Fuel Price Predictor - Info";
			((System.ComponentModel.ISupportInitialize)(this.picbxGraph)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.PictureBox picbxGraph;
		private System.Windows.Forms.Label lbl2;
		private System.Windows.Forms.Label lbl1;
		private System.Windows.Forms.Label lblPricePredicted;
		private System.Windows.Forms.Label lblPriceCurrent;
		private System.Windows.Forms.Label lblSignificance;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblPricePredictedWeek;
	}
}