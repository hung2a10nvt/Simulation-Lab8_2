using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8_2
{
    public partial class Form1 : Form
    {
        private Random random;
        private string[] responses;
        private double[] probabilities;
        public Form1()
        {
            InitializeComponent();
            random = new Random();
            responses = new string[]
            {
                "Определённо да!",
                "Скорее всего да",
                "Вероятно",
                "Не могу сказать",
                "Спроси позже",
                "Не сейчас",
                "Скорее всего нет",
                "Определённо нет!",
                "Перспективы не очень",
                "Маловероятно"
            };
            probabilities = new double[]
            {
                0.15, 
                0.15, 
                0.10, 
                0.10, 
                0.10, 
                0.10, 
                0.10, 
                0.05, 
                0.05, 
                0.10  
            };
        }

        private void btAns_Click(object sender, EventArgs e)
        {
            double alpha = random.NextDouble();
            double A = alpha;
            int k = 1;

            while (k <= probabilities.Length)
            {
                A -= probabilities[k - 1]; 
                if (A <= 0)
                {
                    lbAns.Text = responses[k - 1]; //  k-th response
                    return;
                }
                k++; 
            }

            lbAns.Text = responses[responses.Length - 1];
        }
    }
}
