using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Registration
{
    public partial class FrmConfirm : Form
    {
        private DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;

        private DelegateNumber DelNumAge, DelNumContactNo, DelStudNo;
        public FrmConfirm()
        {
            InitializeComponent();
            DelStudNo = new DelegateNumber(StudentInfoClass.GetStudentNo);
            DelProgram = new DelegateText(StudentInfoClass.GetProgram);
            DelLastName = new DelegateText(StudentInfoClass.GetLastName);
            DelFirstName = new DelegateText(StudentInfoClass.GetFirstName);
            DelMiddleName = new DelegateText(StudentInfoClass.GetMiddleName);
            DelNumAge = new DelegateNumber(StudentInfoClass.GetAge);
            DelNumContactNo = new DelegateNumber(StudentInfoClass.GetContactNo);
            DelAddress = new DelegateText(StudentInfoClass.GetAddress);




            lbStudentNo.Text = DelStudNo(StudentInfoClass.StudentNo).ToString();
            lbProgram.Text = DelProgram(StudentInfoClass.Program);
            lbLastName.Text = DelLastName(StudentInfoClass.LastName);
            lbFirstName.Text = DelFirstName(StudentInfoClass.FirstName);
            lbMiddleName.Text = DelMiddleName(StudentInfoClass.MiddleName);
            lbAge.Text = DelNumAge(StudentInfoClass.Age).ToString();
            lbContactNo.Text = DelNumContactNo(StudentInfoClass.ContactNo).ToString();
            lbAdress.Text = DelAddress(StudentInfoClass.Address);
        }

        private void FrmConfirm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void FrmConfirm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
