using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookWise_AutoMart
{
    public partial class MainForm : Form
    {
        private string sequence = "admin123";
        private int currentIndex = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (currentIndex < sequence.Length && e.KeyChar == sequence[currentIndex])
            {
                // Move to the next character
                currentIndex++;

                // If the sequence is complete
                if (currentIndex == sequence.Length)
                {
                    currentIndex = 0;   // Reset the sequence

                    bool adminLoginFormFound = false;

                    foreach (Form form in Application.OpenForms)
                    {
                        if (form is AdminLoginForm)
                        {
                            form.Show();
                            adminLoginFormFound = true;
                            break;
                        }
                    }
                    // The above code is used to check whether there already is an instance of the form to be displayed (in this case, AdminLoginForm) currently opened, and if so, it is displayed (rather than creating a new instance of the form every time)

                    if (!adminLoginFormFound)
                    {
                        AdminLoginForm adminLoginForm = new AdminLoginForm();
                        adminLoginForm.Show();
                    }

                    this.Hide();
                }
            }
            else
            {
                // Reset the sequence if the user types an incorrect character
                currentIndex = 0;
            }
        }
    }
}
