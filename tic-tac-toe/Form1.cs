namespace tic_tac_toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button step = (Button)sender;
            if (step.Text == "")
            {
                if (comboBox1.SelectedIndex == 1)
                {
                    step.Text = "X";
                    checkWin();
                    comboBox1.SelectedIndex = 0;
                }
                else
                {
                    step.Text = "O";
                    checkWin();
                    comboBox1.SelectedIndex = 1;
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            button9.BackColor = Color.White;
        }

        private void checkWin()
        {
            if (button1.Text == button2.Text && button2.Text == button3.Text)
            {
                if (button1.Text != "")
                {
                    button1.BackColor = Color.Green;
                    button2.BackColor = Color.Green;
                    button3.BackColor = Color.Green;
                    MessageBox.Show("A winner appeared: " + comboBox1.Text + "!");
                }
            }
            if (button4.Text == button5.Text && button5.Text == button6.Text)
            {
                if (button4.Text != "")
                {
                    button4.BackColor = Color.Green;
                    button5.BackColor = Color.Green;
                    button6.BackColor = Color.Green;
                    MessageBox.Show("A winner appeared: " + comboBox1.Text + "!");
                }
            }
            if (button7.Text == button8.Text && button8.Text == button9.Text)
            {
                if (button7.Text != "")
                {
                    button7.BackColor = Color.Green;
                    button8.BackColor = Color.Green;
                    button9.BackColor = Color.Green;
                    MessageBox.Show("A winner appeared: " + comboBox1.Text + "!");
                }
            }
            if (button1.Text == button4.Text && button4.Text == button7.Text)
            {
                if (button1.Text != "")
                {
                    button1.BackColor = Color.Green;
                    button4.BackColor = Color.Green;
                    button7.BackColor = Color.Green;
                    MessageBox.Show("A winner appeared: " + comboBox1.Text + "!");
                }
            }
            if (button2.Text == button5.Text && button5.Text == button8.Text)
            {
                if (button2.Text != "")
                {
                    button2.BackColor = Color.Green;
                    button5.BackColor = Color.Green;
                    button8.BackColor = Color.Green;
                    MessageBox.Show("A winner appeared: " + comboBox1.Text + "!");
                }
            }
            if (button3.Text == button6.Text && button6.Text == button9.Text)
            {
                if (button3.Text != "")
                {
                    button3.BackColor = Color.Green;
                    button6.BackColor = Color.Green;
                    button9.BackColor = Color.Green;
                    MessageBox.Show("A winner appeared: " + comboBox1.Text + "!");
                }
            }
            if (button1.Text == button5.Text && button5.Text == button9.Text)
            {
                if (button1.Text != "")
                {
                    button1.BackColor = Color.Green;
                    button5.BackColor = Color.Green;
                    button9.BackColor = Color.Green;
                    MessageBox.Show("A winner appeared: " + comboBox1.Text + "!");
                }
            }
            if (button3.Text == button5.Text && button5.Text == button7.Text)
            {
                if (button3.Text != "")
                {
                    button3.BackColor = Color.Green;
                    button5.BackColor = Color.Green;
                    button7.BackColor = Color.Green;
                    MessageBox.Show("A winner appeared: " + comboBox1.Text + "!");
                }
            }
        }
    }
}