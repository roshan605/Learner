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
            try
            {
                if (string.IsNullOrWhiteSpace(txtFirst.Text) ||
                    string.IsNullOrWhiteSpace(txtSecond.Text) ||
                    string.IsNullOrWhiteSpace(txtThird.Text))
                {
                    MessageBox.Show("Please enter values in all input fields.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtFirst.Text, out int a) ||
                    !int.TryParse(txtSecond.Text, out int b) ||
                    !int.TryParse(txtThird.Text, out int c))
                {
                    MessageBox.Show("Please enter valid integer values.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

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
                else
                {
                    // Handle case when numbers are equal
                    txtFourth.Text = a.ToString() + " (multiple equal values)";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
