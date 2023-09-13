using System.Xml.Linq;

namespace Account_Registration
{
    public partial class AccountRegistration : Form
    {
        public AccountRegistration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentInfoClass.LastName = tbLastName.Text.ToString();
            StudentInfoClass.FirstName = tbFirstName.Text.ToString();
            StudentInfoClass.MiddleName = tbMiddleName.Text.ToString();
            StudentInfoClass.Address = tbAdress.Text.ToString();
            StudentInfoClass.Program = cbProgram.Text.ToString();
            StudentInfoClass.StudentNo = long.Parse(tbStudentNo.Text);
            StudentInfoClass.Age = long.Parse(tbAge.Text);
            StudentInfoClass.ContactNo = long.Parse(tbContactNo.Text);

            FrmConfirm frc = new FrmConfirm();

            DialogResult res = new DialogResult();
            res = frc.ShowDialog();
            if (res == DialogResult.OK)
            {
                tbLastName.Text = "";
                tbFirstName.Text = "";
                tbMiddleName.Text = "";
                tbAdress.Text = "";
                cbProgram.Text = "";
                tbStudentNo.Text = "";
                tbAge.Text = "";
                tbContactNo.Text = "";
            }
        }
    }
}