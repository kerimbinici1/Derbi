namespace WinFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {






        }

        private void Form1_Load(object sender, EventArgs e)
        {



            textBox2.UseSystemPasswordChar = true;
            button3.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
            button3.Visible = true;
            button2.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
            button2.Visible = true;
            button3.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "1234")
            {

                Form2 oyun = new Form2();
                oyun.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("hatalý bilgi");
                textBox1.Clear();
                textBox2.Clear();
            }

        }
           
        }
    }

