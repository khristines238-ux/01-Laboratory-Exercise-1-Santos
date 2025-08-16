using System;
using System.Windows.Forms;

namespace _01_Laboratory_Exercise_1_Santos
{
    public partial class FrmConfirm : Form
    {
       
        private StudentInfoClass.DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;
        private StudentInfoClass.DelegateNumber DelNumAge, DelNumContactNo, DelStudNo;

        public FrmConfirm()
        {
            InitializeComponent();

            DelProgram = new StudentInfoClass.DelegateText(StudentInfoClass.GetProgram);
            DelFirstName = new StudentInfoClass.DelegateText(StudentInfoClass.GetFirstName);
            DelLastName = new StudentInfoClass.DelegateText(StudentInfoClass.GetLastName);
            DelMiddleName = new StudentInfoClass.DelegateText(StudentInfoClass.GetMiddleName);
            DelAddress = new StudentInfoClass.DelegateText(StudentInfoClass.GetAddress);

            DelNumAge = new StudentInfoClass.DelegateNumber(StudentInfoClass.GetAge);
            DelNumContactNo = new StudentInfoClass.DelegateNumber(StudentInfoClass.GetContactNo);
            DelStudNo = new StudentInfoClass.DelegateNumber(StudentInfoClass.GetStudentNo);
        }

        private void FrmConfirm_Load(object sender, EventArgs e)
        {
           
            labelProgramValue.Text = DelProgram(StudentInfoClass.Program);
            labelFirstNameValue.Text = DelFirstName(StudentInfoClass.FirstName);
            labelLastNameValue.Text = DelLastName(StudentInfoClass.LastName);
            labelMiddleNameValue.Text = DelMiddleName(StudentInfoClass.MiddleName);
            labelAddressValue.Text = DelAddress(StudentInfoClass.Address);
            labelAgeValue.Text = DelNumAge(StudentInfoClass.Age).ToString();
            labelContactNoValue.Text = DelNumContactNo(StudentInfoClass.ContactNo).ToString();
            labelStudentNoValue.Text = DelStudNo(StudentInfoClass.StudentNo).ToString();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registration Submitted Successfully!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FrmConfirm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}

