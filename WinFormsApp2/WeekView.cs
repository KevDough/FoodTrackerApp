using FoodTracker;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodTrackerApp
{
    public partial class WeekView : Form
    {
        string parentOfStartupPath = Path.GetFullPath(Path.Combine(Application.StartupPath, @"../../../"));
        public WeekView()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.WriteAllText(Path.Combine(parentOfStartupPath, "weeklyCalorie.txt"), string.Empty);
            File.WriteAllText(Path.Combine(parentOfStartupPath, "weeklySugar.txt"), string.Empty);
            File.WriteAllText(Path.Combine(parentOfStartupPath, "weeklySodium.txt"), string.Empty);
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label7.Text = "0 calories on average";
            label8.Text = "0g sugar on average";
            label9.Text = "0mg sodium on average";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            NutritionView nutritionView = new NutritionView();
            nutritionView.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddFood addFood = new AddFood();
            addFood.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void WeekView_Load(object sender, EventArgs e)
        {
  
            List<string> calorieFile = File.ReadLines(Path.Combine(parentOfStartupPath, "weeklyCalorie.txt")).Reverse().Take(7).Reverse().ToList();
            List<int> calorieInts = calorieFile
            .Select(s => Int32.TryParse(s, out int n) ? n : (int?)null)
            .Where(n => n.HasValue)
            .Select(n => n.Value)
            .ToList();

             
            int x = 0;
            for (int i = 0; i < calorieInts.Count; i++)
            {
                if (label1.Text != "") label1.Text = label1.Text + "\n" + calorieInts[i] + " calories";
                else label1.Text = Convert.ToString(calorieInts[i]) + " calories";
                x += calorieInts[i];


            }
            label7.Text = x/calorieInts.Count + " calories on average";

            List<string> sugarFile = File.ReadLines(Path.Combine(parentOfStartupPath, "weeklySugar.txt")).Reverse().Take(7).Reverse().ToList();
            List<int> sugarInts = sugarFile
            .Select(s => Int32.TryParse(s, out int n) ? n : (int?)null)
            .Where(n => n.HasValue)
            .Select(n => n.Value)
            .ToList();


            x = 0;
            for (int i = 0; i < sugarInts.Count; i++)
            {
                if (label2.Text != "") label2.Text = label2.Text + "\n" + sugarInts[i] + "g sugar";
                else label2.Text = Convert.ToString(sugarInts[i]) + "g sugar";
                x += sugarInts[i];


            }
            label8.Text = x / sugarInts.Count + "g sugar on average";


            List<string> sodiumFile = File.ReadLines(Path.Combine(parentOfStartupPath, "weeklySodium.txt")).Reverse().Take(7).Reverse().ToList();
            List<int> sodiumInts = sodiumFile
            .Select(s => Int32.TryParse(s, out int n) ? n : (int?)null)
            .Where(n => n.HasValue)
            .Select(n => n.Value)
            .ToList();
            x = 0;
            for (int i = 0; i < sodiumInts.Count; i++)
            {
                if (label3.Text != "") label3.Text = label3.Text + "\n" + sodiumInts[i] + "mg sodium";
                else label3.Text = Convert.ToString(sodiumInts[i]) + "mg sodium";
                x += sodiumInts[i];


            }
            label9.Text = x / sodiumInts.Count + "mg sodium on average";

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
