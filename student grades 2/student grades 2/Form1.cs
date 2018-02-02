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
    }
}
