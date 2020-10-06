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
            string data = Program.ToHTML("https://www.medonet.pl/zdrowie/zdrowie-dla-kazdego,zasieg-koronawirusa-covid-19--mapa-,artykul,43602150.html");
            if (data != null)
            {
                string cases = (data.Substring(data.IndexOf("POTWIERDZONE PRZYPADKI") + 42, 6).Replace(" ", string.Empty));
                CoronaVirusTotalCases.Text = cases;

                int cured = int.Parse(data.Substring(data.IndexOf("WYZDROWIAŁO") + 34, 6).Replace(" ", string.Empty)); ;
                int ActivelyIll = int.Parse(cases) - cured;
                ActiveCases.Text = ActivelyIll.ToString();

                string data2 = Program.ToHTML("http://populacja.population.city/polska/");
                int population = int.Parse((data2.Substring(data2.IndexOf("id=\"populationcounter\"") + 47, 10).Replace(" ", string.Empty)));

                //w procentach
                double ActivelyIllD = Convert.ToDouble(ActivelyIll);
                double populationD = Convert.ToDouble(population);
                double meetingProb = (ActivelyIllD / populationD * 100);
                int n = meetingProb.ToString().Length - meetingProb.ToString().Replace("0", string.Empty).Length;
                string meetingProbS = Math.Round(meetingProb, (3 + n)).ToString(); 
                meetingProbS += "%";
                MeetingIll.Text = meetingProbS;

                int doneTests = int.Parse(data.Substring(data.IndexOf("WYKONANE TESTY - POLSKA") + 42, 9).Replace(" ", string.Empty));
                int positive = int.Parse(cases);
                double doneTestsD = Convert.ToDouble(doneTests);
                double positiveD = Convert.ToDouble(positive);
                double chance = positiveD / doneTestsD;

                double final = (chance * meetingProb);
                n = final.ToString().Length - final.ToString().Replace("0", string.Empty).Length;
                final = Math.Round(final, 3 + n);
                string finalS = final.ToString();
                finalS += "%";
                Contagion.Text = finalS;

                Source.Text = "medonet.pl, populacja.population.city";
            }
            else {CoronaVirusTotalCases.Text ="Network error";
                ActiveCases.Text = "Network error";
                MeetingIll.Text = "Network error";
                Contagion.Text = "Network error";
                Source.Text = "Network error";
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
    }
}
