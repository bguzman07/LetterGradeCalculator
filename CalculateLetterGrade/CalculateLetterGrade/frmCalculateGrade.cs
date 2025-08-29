using System.Drawing.Text;

namespace CalculateLetterGrade
{
    public partial class frmCalculateGrade : Form
    {
        public frmCalculateGrade()
        {
            InitializeComponent();
        }

        private void txtNumberGrade_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            if (txtNumberGrade.Text != "")
            {
                decimal percentage = Convert.ToDecimal(txtNumberGrade.Text);
                if (percentage < 60)
                {
                    txtLetterGrade.Text = "F";
                }
                else if (percentage < 70)
                {
                    txtLetterGrade.Text = "D";
                }
                else if (percentage < 80)
                {
                    txtLetterGrade.Text = "C";
                }
                else if (percentage < 90)
                {
                    txtLetterGrade.Text = "B";
                }
                else if (percentage >= 90)
                {
                    txtLetterGrade.Text = "A";
                }
                else
                {
                    txtLetterGrade.Text = "";
                }
            }
        }
    }
}