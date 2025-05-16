namespace Learner
{
    public partial class FormParent : Form
    {
        public FormParent()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtFirst.Text);
            int b = Convert.ToInt32(txtSecond.Text);
            int c = Convert.ToInt32(txtThird.Text);

            string largestNumber = "";

            if (a > b && a > c)
            {
                largestNumber = a.ToString();
                txtFourth.Text = largestNumber;
            }
            else if (b > a && b > c)
            {
                largestNumber = b.ToString();
                txtFourth.Text = largestNumber;
            }
            else if (c > a && c > b)
            {
                largestNumber = c.ToString();
                txtFourth.Text = largestNumber;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
