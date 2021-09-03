﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyExchangeGame
{
    public partial class Form1 : Form
    {
		private int currentDay, count;
		private double currentPrice, money;
		private GBM gbm;
		public Form1()
		{
			InitializeComponent();
		}

		private void Timer1_Tick(object sender, EventArgs e)
		{
			currentDay += 1;

			currentPrice = gbm.GetNextRV();

			if (currentDay > 10) chart1.ChartAreas[0].AxisX.Minimum += 1;

			chart1.Series[0].Points.AddXY(currentDay, currentPrice);
		}

		private void StartButton_Click(object sender, EventArgs e)
		{
			if (!timer1.Enabled)
			{
				chart1.Series[0].Points.Clear();

				startButton.Text = "Finish";

				count = 0;

				money = 500;

				currentDay = 1;

				currentPrice = (double)initPriceValue.Value;

				gbm = new GBM(currentPrice, 0.01, (double)muValue.Value, (double)sigmaValue.Value);

				ShowMoney();

				chart1.ChartAreas[0].AxisX.Minimum = 0;

				chart1.Series[0].Points.AddXY(currentDay, currentPrice);

				buyButton.Enabled = true;
				sellButton.Enabled = true;

				timer1.Start();
			}
			else
			{
				timer1.Stop();

				buyButton.Enabled = false;
				sellButton.Enabled = false;

				startButton.Text = "Start";
			}
		}

		private void BuyButton_Click(object sender, EventArgs e)
		{
			if (money > currentPrice)
			{
				money -= currentPrice;
				count += 1;

				ShowMoney();
			}
		}

		private void SellButton_Click(object sender, EventArgs e)
		{
			if (count > 0)
			{
				money += currentPrice;
				count -= 1;

				ShowMoney();
			}
		}

		private void ShowMoney()
		{
			countLabel.Text = "Count: " + count;
			moneyLabel.Text = "Money: " + money.ToString("0.0000");
		}
	}
}
