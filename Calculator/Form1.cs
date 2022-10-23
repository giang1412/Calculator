namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lb_SoA_Click(object sender, EventArgs e)
        {

        }

        private void lb_SoB_Click(object sender, EventArgs e)
        {

        }

        private void btnCong_Click(object sender, EventArgs e)
        {
             double a = double.Parse(txtSoA.Text); 
             double b = double.Parse(txtSoB.Text);
             double c = a + b;
             txtKetQua.Text = c.ToString();
        }
    }
}