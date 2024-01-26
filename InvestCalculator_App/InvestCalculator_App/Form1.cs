using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace InvestCalculator_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }


        //Сброс всех установленных ранее настроек до изначальных значений
        private void resetButton_Click(object sender, EventArgs e)
        {
            firstSumTextBox.Text = "100000";
            percentTextBox.Text = "10";
            timeTextBox.Text = "12";
            timeReinvestTextBox.Text = "2";
            sumReinvestTextBox.Text = "2000";
            yesRadioButton.Checked = false;
            noRadioButton.Checked = true;
            label5.Visible = false;
            label6.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            timeReinvestTextBox.Visible = false;
            sumReinvestTextBox.Visible = false;
        }

        //открытие настроек реинвестиций
        private void yesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            label5.Visible = true;
            label6.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            timeReinvestTextBox.Visible = true;
            sumReinvestTextBox.Visible = true;
            timeReinvestTextBox.Text = "2";
            sumReinvestTextBox.Text = "2000";

        }

        //закрытие настроек реинвестиций, сброс значений
        private void noRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            label5.Visible = false;
            label6.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            timeReinvestTextBox.Visible = false;
            sumReinvestTextBox.Visible = false;

            timeReinvestTextBox.Text = "0";
            sumReinvestTextBox.Text = "0";

        }

        ClassInvest Investition = new ClassInvest();

        //Считать и вывести результаты инвестирования
        private void calculateButton_Click(object sender, EventArgs e)
        {
            int time = 0;
            if (yearRadioButton.Checked == true)
            {
                time = int.Parse(timeTextBox.Text) * 12;

            }
            else
            {
                time = int.Parse(timeTextBox.Text);
            }

            Investition.Calculate(double.Parse(firstSumTextBox.Text), time, double.Parse(percentTextBox.Text), int.Parse(timeReinvestTextBox.Text), double.Parse(sumReinvestTextBox.Text));

            Form2 form = new Form2();
            form.Show();

            form.FinalSumLabel.Text = "Итоговая сумма";
            form.ReinvestFinalSumLabel.Text = "Было реинвестировано";
            form.ProfitSumLabel.Text = "Прибыль";
            form.profitMonthLabel.Text = "Прибыль в месяц";

            form.FinalSumLabel.Text += (":  " + int.Parse(firstSumTextBox.Text));
            form.ReinvestFinalSumLabel.Text += (":  " + Math.Round(Investition.GetFinalReinvestSum(), 2));
            form.ProfitSumLabel.Text += (":  " + Math.Round(Investition.GetProfit(), 2));
            form.profitMonthLabel.Text += (":  " + (Math.Round(Investition.GetProfit() / int.Parse(timeTextBox.Text)), 2));


            InitializeComponent();

            string[] types = { "Начальная сумма", "Реинвестировано", "Прибыль" };
            double[] money = { Math.Round(Investition.GetFinalSum(), 2), Math.Round(Investition.GetFinalReinvestSum(), 2), Math.Round(Investition.GetProfit(), 2) };
            form.chart.Titles.Add("Графики по доходу");

            // Добавляем последовательность
            for (int i = 0; i < types.Length; i++)
            {
                Series series = form.chart.Series.Add(types[i]);

                // Добавляем точку
                series.Points.Add(money[i]);
            }
        }
        private void monthRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void yearRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
