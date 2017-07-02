using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetrolPricePredictor
{
	public partial class Form2 : Form
	{
		public Form2(bool isPetrol, double currentPrice, double predictedPriceCurrent, double predictedPriceWeek, string significance)
		{
			InitializeComponent();
			ShowInfo(isPetrol, currentPrice, predictedPriceCurrent, predictedPriceWeek, significance);
		}

		// checks significance level
		private void Significance(string significance)
		{
			if (significance == "red wait")
			{
				lblSignificance.Text = "Current price is significantly high";
			}
			else if (significance == "yellow wait")
			{
				lblSignificance.Text = "Current price is close to normal but will probably go down";
			}
			else if (significance == "black buy")
			{
				lblSignificance.Text = "Current price is close to normal";
			}
			else if (significance == "yellow buy")
			{
				lblSignificance.Text = "Current price is close to normal but will probably go up";
			}
			else if (significance == "green buy")
			{
				lblSignificance.Text = "Current price is significantly low";
			}
		}

		// outputs info to form
		private void ShowInfo(bool isPetrol, double currentPrice, double predictedPriceCurrent, double predictedPriceWeek, string significance)
		{
			// set graph image DEBUG change to graph created from .py file
			if (isPetrol)
			{
				string picPath = Path.Combine(Directory.GetCurrentDirectory(), "petrol.png");
				picbxGraph.Image = Image.FromFile(picPath);
			}
			else
			{
				string picPath = Path.Combine(Directory.GetCurrentDirectory(), "diesel.png");
				picbxGraph.Image = Image.FromFile(picPath);
			}

			// find significance
			Significance(significance);

			// show values
			lblPriceCurrent.Text = currentPrice.ToString();
			lblPricePredicted.Text = predictedPriceCurrent.ToString();
			lblPricePredictedWeek.Text = predictedPriceWeek.ToString();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
