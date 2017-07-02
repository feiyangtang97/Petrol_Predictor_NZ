using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PetrolPricePredictor
{
	public partial class Form1 : Form
	{
		private double _predictedPriceCurrent = 0.0;
		private double _predictedPriceNextWeek = 0.0;
		private List<double> _predictions = new List<double>();
		private double _currentPrice = 0.0;
		private string _significance = "";
		private bool _isPetrol = false;

		// split string from python script into numbers
		private void SplitString(string stringToSplit)
		{
            char[] delimiters = { ' ', '\r', '\n' };
			List<string> numbers = new List<string>(stringToSplit.Split(delimiters, StringSplitOptions.RemoveEmptyEntries));
			foreach (string number in numbers)
			{
				_predictions.Add(double.Parse(number));
			}
		}

        // run python script, get standard output from python script (print statements)
        private void PythonRun(string cmd, string args)
		{
			Process p = new Process();
			p.StartInfo.FileName = cmd;
			p.StartInfo.Arguments = args;
			p.Start();
			p.WaitForExit();
		}

		private void GetPredictions()
		{
			string arg = Path.Combine(Directory.GetCurrentDirectory(), "predictions.txt");
			string predictions = File.ReadAllText(arg);
			SplitString(predictions);
		}

		// initialise form 1 and run python script to get predictions
		public Form1()
		{
			InitializeComponent();
			string arg = Path.Combine(Directory.GetCurrentDirectory(), "PredictionModelARMA.py");
			PythonRun("C:\\Python27\\python.exe", arg);
			GetPredictions();
		}

		// finds confidence interval to use for test of significance
		private void GetConfidenceInterval(double predictedPrice, ref double upperNormalVariance, ref double lowerNormalVariance)
		{
			// use predicted price to form confidence interval
			upperNormalVariance = predictedPrice + 4;
			lowerNormalVariance = predictedPrice - 4;
		}

		// tests whether you should buy or wait
		private void TestSignficance()
		{
			double currerntUpperNormalVariance = 0.0, nextUpperNormalVariance = 0.0, currentLowerNormalVariance = 0.0, nextLowerNormalVariance = 0.0;

			// find variance interval
			GetConfidenceInterval(_predictedPriceCurrent, ref currerntUpperNormalVariance, ref currentLowerNormalVariance);
			GetConfidenceInterval(_predictedPriceNextWeek, ref nextUpperNormalVariance, ref nextLowerNormalVariance);

			// price too high, should not buy
			if (_currentPrice > currerntUpperNormalVariance)
			{
				_significance = "red wait";
			}
			else if (_currentPrice <= currerntUpperNormalVariance && _currentPrice >= currentLowerNormalVariance)
			{
				// price normal but will probably go down, should wait till next week to buy
				if (_currentPrice > nextUpperNormalVariance)
				{
					_significance = "yellow wait";
				}
				// price normal and will stay normal next week, no need to wait
				else if (_currentPrice <= nextUpperNormalVariance && _currentPrice >= nextLowerNormalVariance)
				{
					_significance = "black buy";
				}
				// price normal but will probably go up, should buy before price increase
				if (_currentPrice < nextLowerNormalVariance)
				{
					_significance = "yellow buy";
				}
			}
			// price significantly low, buy buy buy
			else if (_currentPrice < currentLowerNormalVariance)
			{
				_significance = "green buy";
			}
		}

		// updates buy or wait label
		private void BuyOrWait()
		{
			if (_significance == "red wait")
			{
				lblWait.ForeColor = Color.Red;
				lblWait.Visible = true;
			}
			else if (_significance == "yellow wait")
			{
				lblWait.ForeColor = Color.Yellow;
				lblWait.Visible = true;
			}
			else if (_significance == "black buy")
			{
				lblBuy.ForeColor = Color.Black;
				lblBuy.Visible = true;
			}
			else if (_significance == "yellow buy")
			{
				lblBuy.ForeColor = Color.Yellow;
				lblBuy.Visible = true;
			}
			else if (_significance == "green buy")
			{
				lblBuy.ForeColor = Color.Green;
				lblBuy.Visible = true;
			}
		}

		private void Petrol()
		{
			_isPetrol = true;

			// reset labels
			lblBuy.Visible = false;
			lblWait.Visible = false;

			// set predicted values to test significance
			_predictedPriceCurrent = _predictions[0];
			_predictedPriceNextWeek = _predictions[1];
			_currentPrice = Convert.ToDouble(nudInput.Value);

			// find significance of difference between current price and predicted current price
			TestSignficance();

			// update buy or wait
			BuyOrWait();

			// show info button
			btnInfo.Visible = true;
		}

		// user has selected PETROL
		private void btnPetrol_Click(object sender, EventArgs e)
		{
			Petrol();
		}

		public void Diesel()
		{
			_isPetrol = false;

			// reset labels
			lblBuy.Visible = false;
			lblWait.Visible = false;

			// set predicted values to test significance
			_predictedPriceCurrent = _predictions[2];
			_predictedPriceNextWeek = _predictions[3];
			_currentPrice = Convert.ToDouble(nudInput.Value);

			// find significance of difference between current price and predicted current price
			TestSignficance();

			// update buy or wait
			BuyOrWait();

			// show info button
			btnInfo.Visible = true;
		}

		private void btnDiesel_Click(object sender, EventArgs e)
		{
			Diesel();
		}

		private void btnInfo_Click(object sender, EventArgs e)
		{
			Form2 aForm = new Form2(_isPetrol, _currentPrice, _predictedPriceCurrent, _predictedPriceNextWeek, _significance);
			this.Visible = false;
			aForm.ShowDialog();
			this.Visible = true;
			this.TopMost = true;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
		}
	}
}
