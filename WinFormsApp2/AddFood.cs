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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FoodTracker
{
    public partial class AddFood : Form
    {
        Form opener;
        string currDir = Directory.GetCurrentDirectory();
        string parentOfStartupPath = Path.GetFullPath(Path.Combine(Application.StartupPath, @"../../../"));
        string foodName = "";
        string calories = "";
        string sodium = "";
        string sugar = "";
        public AddFood()
        {
            InitializeComponent();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            /*foodName = textBox1.Text;
            calories = textBox2.Text;
            sodium = textBox3.Text;
            sugar = textBox4.Text;
            if (label5.Text != " ") label5.Text = label5.Text + "\n" + foodName;
            else label5.Text = foodName;
            if (label6.Text != " ") label6.Text = label6.Text + "\n" + calories;
            else label6.Text = calories;
            if (label7.Text != " ") label7.Text = label7.Text + "\n" + sugar;
            else label7.Text = sugar;
            if (label8.Text != " ") label8.Text = label8.Text + "\n" + sodium;
            else label8.Text = sodium;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            */

            using (StreamWriter writetext = new StreamWriter(Path.Combine(parentOfStartupPath, "foodName.txt"), true))
            {
                writetext.WriteLine(textBox1.Text);
            }
            using (StreamWriter writetext = new StreamWriter(Path.Combine(parentOfStartupPath, "calorieCount.txt"), true))
            {
                writetext.WriteLine(textBox4.Text);
            }
            using (StreamWriter writetext = new StreamWriter(Path.Combine(parentOfStartupPath, "sodiumCount.txt"), true))
            {
                writetext.WriteLine(textBox3.Text);
            }
            using (StreamWriter writetext = new StreamWriter(Path.Combine(parentOfStartupPath, "sugarCount.txt"), true))
            {
                writetext.WriteLine(textBox2.Text);
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

            StreamReader sr = new StreamReader(Path.Combine(parentOfStartupPath, "foodName.txt"));

            string line = sr.ReadLine();
            while (line != null)
            {
                if (label5.Text != "") label5.Text = label5.Text + "\n" + line;
                else label5.Text = line;
                line = sr.ReadLine();
            }
            sr.Close();


            sr = new StreamReader(Path.Combine(parentOfStartupPath, "calorieCount.txt"));

            line = sr.ReadLine();
            while (line != null)
            {
                if (label6.Text != "") label6.Text = label6.Text + "\n" + line;
                else label6.Text = line;
                line = sr.ReadLine();
            }
            sr.Close();


            sr = new StreamReader(Path.Combine(parentOfStartupPath, "sodiumCount.txt"));

            line = sr.ReadLine();
            while (line != null)
            {
                if (label8.Text != "") label8.Text = label8.Text + "\n" + line;
                else label8.Text = line;
                line = sr.ReadLine();
            }
            sr.Close();


            sr = new StreamReader(Path.Combine(parentOfStartupPath, "sugarCount.txt"));

            line = sr.ReadLine();
            while (line != null)
            {
                if (label7.Text != "") label7.Text = label7.Text + "\n" + line;
                else label7.Text = line;
                line = sr.ReadLine();
            }
            sr.Close();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddFood_Load(object sender, EventArgs e)
        {
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            StreamReader sr = new StreamReader(Path.Combine(parentOfStartupPath, "foodName.txt"));

            string line = sr.ReadLine();
            while (line != null)
            {
                if (label5.Text != "") label5.Text = label5.Text + "\n" + line;
                else label5.Text = line;
                line = sr.ReadLine();
            }
            sr.Close();


            sr = new StreamReader(Path.Combine(parentOfStartupPath, "calorieCount.txt"));

            line = sr.ReadLine();
            while (line != null)
            {
                if (label6.Text != "") label6.Text = label6.Text + "\n" + line;
                else label6.Text = line;
                line = sr.ReadLine();
            }
            sr.Close();


            sr = new StreamReader(Path.Combine(parentOfStartupPath, "sodiumCount.txt"));

            line = sr.ReadLine();
            while (line != null)
            {
                if (label8.Text != "") label8.Text = label8.Text + "\n" + line;
                else label8.Text = line;
                line = sr.ReadLine();
            }
            sr.Close();


            sr = new StreamReader(Path.Combine(parentOfStartupPath, "sugarCount.txt"));

            line = sr.ReadLine();
            while (line != null)
            {
                if (label7.Text != "") label7.Text = label7.Text + "\n" + line;
                else label7.Text = line;
                line = sr.ReadLine();
            }
            sr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            NutritionView nutritionView = new NutritionView();
            nutritionView.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            File.WriteAllText(Path.Combine(parentOfStartupPath, "sodiumCount.txt"), string.Empty);
            File.WriteAllText(Path.Combine(parentOfStartupPath, "calorieCount.txt"), string.Empty);
            File.WriteAllText(Path.Combine(parentOfStartupPath, "foodName.txt"), string.Empty);
            File.WriteAllText(Path.Combine(parentOfStartupPath, "sugarCount.txt"), string.Empty);
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";

        }
    }
}
