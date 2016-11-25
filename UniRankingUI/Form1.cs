using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniRanking.Data;

namespace UniRankingUI
{
    public partial class Form1 : Form
    {
        Repository repository = new Repository();
        

        public Form1()
        {
            InitializeComponent();
            using (Context cont = new Context())
            {
                foreach(var item in cont.Univesities)
                {
                    comboBoxUniversities.Items.Add(item.NameOfUniversity);
                }
            }
        }

        private void buttonRatingForYear_Click(object sender, EventArgs e)
        {
            if (comboBoxYears.SelectedIndex!=-1)
            {
                if (comboBoxGrouping.SelectedIndex==0)
                {
                    listBox1.Items.Clear();
                    var Rating = repository.RatingByYearSortedByCountry(int.Parse(comboBoxYears.Text));
                    foreach(var r in Rating)
                    {
                        listBox1.Items.Add(r);
                    }
                    
                }
                else
                {
                    listBox1.Items.Clear();
                    var Rating = repository.GetRatingByYear(int.Parse(comboBoxYears.Text));
                    foreach (var r in Rating)
                    {
                        listBox1.Items.Add(r);
                    }
                }
            }
            else
            {
                MessageBox.Show("Year is not choosen.");
            }
        }

        private void buttonRatingForTheUni_Click(object sender, EventArgs e)
        {
            if (comboBoxUniversities.SelectedIndex!=-1)
            {
                var Rating = repository.DinamicOfUni(comboBoxUniversities.Text);
                listBox1.Items.Clear();
                foreach (var r in Rating)
                {
                    listBox1.Items.Add(r);
                }
            }
            else
            {
                MessageBox.Show("University is not choosen.");
            }
        }

        private void buttonAverageScores_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var Rating = repository.ScorsAboutUnis();
            foreach (var r in Rating)
            {
                listBox1.Items.Add(r);
            }
        }

        private void comboBoxUniversities_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
