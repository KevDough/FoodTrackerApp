using FoodTrackerApp;
using System.Windows.Forms;

using static System.Windows.Forms.DataFormats;

namespace FoodTracker
{
    public partial class MainMenu : Form
    {
        string foodName = "";
        string calories = "";
        string sodium = "";
        string sugar = "";
        public MainMenu(string foods, string calories1, string sugar1, string sodium1)
        {
            InitializeComponent();
            string foodName = foods;
            string calories = calories1;
            string sodium = sodium1;
            string sugar = sugar1;
 
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
 
        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            AddFood addFood = new AddFood();
            addFood.Show();
 
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NutritionView nutritionView = new NutritionView();
            nutritionView.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            WeekView weekView = new WeekView();
            weekView.Show();
        }
    }
}