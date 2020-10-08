using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoronaVirus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            CoronaVirusTotalCases.ReadOnly = true;
            ActiveCases.ReadOnly = true;
            MeetingIll.ReadOnly = true;
            Contagion.ReadOnly = true;

            string data1 = Program.ToHTML("https://www.medonet.pl/zdrowie/zdrowie-dla-kazdego,zasieg-koronawirusa-covid-19--mapa-,artykul,43602150.html");
            string data2 = Program.ToHTML("http://populacja.population.city/polska/");
            if (data1 != null && data2 !=null)
            {
                string cases = (data1.Substring(data1.IndexOf("POTWIERDZONE PRZYPADKI") + 70, 7).Replace(" ", string.Empty));
                CoronaVirusTotalCases.Text = cases;

                int cured = int.Parse(data1.Substring(data1.IndexOf("WYZDROWIAŁO") + 66, 6).Replace(" ", string.Empty));
                int ActivelyIll = int.Parse(cases) - cured;
                ActiveCases.Text = ActivelyIll.ToString();

                int population = int.Parse((data2.Substring(data2.IndexOf("id=\"populationcounter\"") + 47, 10).Replace(" ", string.Empty)));

                //w procentach
                int n = (Convert.ToDouble(ActivelyIll) / Convert.ToDouble(population) * 100).ToString().Length - (Convert.ToDouble(ActivelyIll) / Convert.ToDouble(population) * 100).ToString().Replace("0", string.Empty).Length;
                string meetingProbS = Math.Round((Convert.ToDouble(ActivelyIll) / Convert.ToDouble(population) * 100), (3 + n)).ToString("G3"); 
                meetingProbS += "%";
                MeetingIll.Text = meetingProbS;

                int doneTests = int.Parse(data1.Substring(data1.IndexOf("WYKONANE TESTY - POLSKA") + 71, 9).Replace(" ", string.Empty));
                double chance = Convert.ToDouble(int.Parse(cases)) / Convert.ToDouble(doneTests);

                double final = (chance * (Convert.ToDouble(ActivelyIll) / Convert.ToDouble(population) * 100));
                n = final.ToString().Length - final.ToString().Replace("0", string.Empty).Length;
                string finalS = Math.Round(final, 3 + n).ToString("G3") + "%";
                Contagion.Text = finalS;

            }
            else {CoronaVirusTotalCases.Text ="Network error";
                ActiveCases.Text = "Network error";
                MeetingIll.Text = "Network error";
                Contagion.Text = "Network error";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        public void CornaVirusTotalCasesSetter(String a)
        {
            CoronaVirusTotalCases.Text = a;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void Source_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://populacja.population.city/polska/");
        }

        private void Contagion_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dane_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.medonet.pl/zdrowie/zdrowie-dla-kazdego,zasieg-koronawirusa-covid-19--mapa-,artykul,43602150.html");
        }

        private void MeetingIll_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
