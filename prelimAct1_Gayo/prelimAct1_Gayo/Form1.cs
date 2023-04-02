namespace prelimAct1_Gayo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             dayofWeekTextBox.Text = "";
            monthtextBox.Text = "";
            dayofMonthtextBox.Text = "";
            yeartextBox.Text = "";
            textBox1.Text = "";
        }

        private void showDatebutton_Click(object sender, EventArgs e)
        {
            string dateString = $"{dayofWeekTextBox.Text}, {monthtextBox.Text} {dayofMonthtextBox.Text}, {yeartextBox.Text}";
            textBox1.Text = dateString;
        }

        private void exitbutton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}