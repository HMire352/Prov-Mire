namespace Prov_Mire
{
    public partial class Form1 : Form
    {
        int datorntal;
        int antalgissningar;

        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add(10);
            comboBox1.Items.Add(20);

            comboBox1.SelectedItem =comboBox1.Items[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String St�rstatalet = comboBox1.SelectedItem.ToString();
            int St�rst = int.Parse(St�rstatalet);
            Random slump = new Random();
            datorntal = slump.Next(1, St�rst + 1);

            button3.Enabled = false;
            label1.Enabled = false;
            label3.Enabled = true;

          textBox4.Text = "??";
            antalgissningar = 0;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            antalgissningar++;
            string gissa = textBox5.Text;
            int gissatTal = int.Parse(gissa);

            if (gissatTal == datorntal)
            {
                button9.Text = "Du vann" +
                antalgissningar + "f�rs�k.";
                button4.Enabled = true;


               textBox4.Text = datorntal.ToString();
                textBox7.AppendText(antalgissningar + "F�rs�k\n");

            }
           
            else if (gissatTal < datorntal)
            {
                textBox6.Text = "f�r l�gt. f�rs�k igen.";
            }
            else
            {
                textBox6.Text = "f�r h�gt. f�rs�k igen.";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}