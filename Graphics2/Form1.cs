namespace Graphics2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Pen mypen = new Pen(Color.Black, 2);
            graphics.DrawEllipse(mypen, 0, 0, pictureBox1.Width / 2, pictureBox1.Height / 2);
            graphics.DrawEllipse(mypen, pictureBox1.Width / 2, 0, pictureBox1.Width / 2, pictureBox1.Height / 2);
            graphics.DrawEllipse(mypen, 0, pictureBox1.Height/2, pictureBox1.Width / 2, pictureBox1.Height / 2);
            graphics.DrawEllipse(mypen, pictureBox1.Width / 2, pictureBox1.Height / 2, pictureBox1.Width / 2, pictureBox1.Height / 2);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            lblOutput.Text = pictureBox1.Width.ToString();
            lblOutput2.Text = pictureBox1.Height.ToString();
        }
    }
}