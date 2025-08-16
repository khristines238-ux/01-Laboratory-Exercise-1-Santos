using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _01_Laboratory_Exercise_1_Santos
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {
           
            comboBoxProgram.Items.Clear();
            comboBoxProgram.Items.AddRange(new string[]
            {
                "BS in Information Technology",
                "BS in Business Administration",
                "BS in Accountancy",
                "BS in Hospitality Management",
                "BS in Tourism Management",
                "BS in Computer Science"
            });
            comboBoxProgram.Text = "Select a program";
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            
            StudentInfoClass.FirstName = textBoxFirstName.Text;
            StudentInfoClass.LastName = textBoxLastName.Text;
            StudentInfoClass.MiddleName = textBoxMiddleName.Text;
            StudentInfoClass.Address = textBoxAddress.Text;
            StudentInfoClass.Program = comboBoxProgram.Text;

            long.TryParse(textBoxAge.Text, out StudentInfoClass.Age);
            long.TryParse(textBoxContactNo.Text, out StudentInfoClass.ContactNo);
            long.TryParse(textBoxStudentNumber.Text, out StudentInfoClass.StudentNo);

           
            using (FrmConfirm confirmForm = new FrmConfirm())
            {
                if (confirmForm.ShowDialog() == DialogResult.OK)
                {
                   
                    textBoxLastName.Clear();
                    textBoxFirstName.Clear();
                    textBoxMiddleName.Clear();
                    textBoxAge.Clear();
                    textBoxContactNo.Clear();
                    textBoxStudentNumber.Clear();
                    textBoxAddress.Clear();
                    comboBoxProgram.SelectedIndex = -1;
                }
            }
        }
    }
}

