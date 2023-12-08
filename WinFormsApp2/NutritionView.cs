using FoodTrackerApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodTracker
{
    public partial class NutritionView : Form
    {
        string currDir = Directory.GetCurrentDirectory();
        string parentOfStartupPath = Path.GetFullPath(Path.Combine(Application.StartupPath, @"../../../"));
        public NutritionView()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NutritionView_Load(object sender, EventArgs e)
        {
    
            StreamReader sr = new StreamReader(Path.Combine(parentOfStartupPath, "calorieCount.txt"));

            string line = sr.ReadLine();
            double x = 0;
            while (line != null)
            {
                x += Int32.Parse(line);
                line = sr.ReadLine();
            }
            sr.Close();

            label6.Text = Convert.ToInt32(x/2000*100) + "%";
            label9.Text = x + "/2000 calories";

            sr = new StreamReader(Path.Combine(parentOfStartupPath, "sodiumCount.txt"));
            x = 0;
            line = sr.ReadLine();
            while (line != null)
            {
                x += Int32.Parse(line);
                line = sr.ReadLine();
            }
            sr.Close();
            label7.Text = Convert.ToInt32(x / 2300*100) + "%";
            label10.Text = x + "/2300mg sodium";

            sr = new StreamReader(Path.Combine(parentOfStartupPath, "sugarCount.txt"));
            line = sr.ReadLine();
            x = 0;
            while (line != null)
            {
                x += Int32.Parse(line);
                line = sr.ReadLine();
            }
            sr.Close();
            label8.Text = Convert.ToInt32(x / 50 * 100) + "%";
            label11.Text = x + "/50g sugar";

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddFood addFood = new AddFood();
            addFood.Show();
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            WeekView weekView = new WeekView();
            weekView.Show();
            this.Close();
        }
    }
}
