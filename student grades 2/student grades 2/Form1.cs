using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_grades_2
{


    public partial class frmStudentGrades : Form
    {
        //Declaration of variables
        String strStudentName, strStudentNumber, strGroup, strGrade = "";
        int intEnglish, intMaths, intScience = 0;
        float fAverage = 0;

        public frmStudentGrades()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Calling Halt procedure
            Halt();
        }

        //Procedure to Exit
        public static void Halt()
        {
            //Local variable to store result
            DialogResult dr;

            //Accept response
            dr = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            //if yes then close program
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Call the clear procedure
            ClearDetails();

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //enter student details
            EnterDetails();
            //calculate average mark
            fAverage = AverageMark(intEnglish, intMaths, intScience);
            //Calculate average mark
            strGrade = CalculateGrade(fAverage);
            //Display details and grade
            DisplayDetails();
        }

        //procedure to clear all details
        public void ClearDetails()
        {
            txtStudentName.Text = "";
            txtStudentNumber.Text = "";
            cbxGroup.Text = "";

            txtEnglish.Text = "";
            txtMaths.Text = "";
            txtScience.Text = "";

            txtStudentDetails.Text = "";
            txtAverageMark.Text = "";
            txtStudentGrade.Text = "";

            strStudentName = "";
            strStudentNumber = "";
            strGroup = "";
            strGrade = "";

            intEnglish = 0;
            intMaths = 0;
            intScience = 0;

            fAverage = 0;
                 
        }

        //procedure to enter student details
        public void EnterDetails()
        {
            strStudentName = txtStudentName.Text;
            strStudentNumber = txtStudentNumber.Text;
            strGroup = cbxGroup.Text;

            intEnglish = Convert.ToInt32(txtEnglish.Text);
            intMaths = Convert.ToInt32(txtMaths.Text);
            intScience = Convert.ToInt32(txtScience.Text);
        }

        //procedure to enter student details
        public void DisplayDetails()
        {
            txtStudentDetails.Text = strGroup + ":   " + strStudentNumber + ":   " + strStudentName;
            txtAverageMark.Text = fAverage.ToString("#0.00");
            txtStudentGrade.Text = strGrade;
        }

        //function to calculate average mark
        public float AverageMark( int intNumber1, int intNumber2, int intNumber3)
        {
            float Average = (float)(intEnglish + intMaths + intScience) / 3;
            return Average;
        }

        //function to enter student details
        public string CalculateGrade(float Mark)
        {
            string strFinalGrade = "";
            if (Mark >= 80)
            {
                strFinalGrade = "You achieved a Distinction";
            }
            else if (Mark >= 60)
            {
                strFinalGrade = "You achieved a Merit";
            }
            else if (Mark >= 40)
            {
                strFinalGrade = "You achieved a Pass";
            }
            else
            {
                strFinalGrade = "You must take a resit";
            }

            return strFinalGrade;
        }
    }
}
