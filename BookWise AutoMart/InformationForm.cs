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
    public partial class InformationForm : Form
    {
        private int currentStep = 0;
        PictureBox[] pages;
        UserControl[] userControls;
        public InformationForm()
        {
            InitializeComponent();
            userControls=new UserControl[]
            {
                new UserControl1(),new UserControl2(),new UserControl3(),new UserControl4()
            };
            pages  = new PictureBox[]
            {
                pictureBoxPage1 , pictureBoxPage2 , pictureBoxPage3 , pictureBoxPage4 ,pictureBoxPage5
            };
        }
        private void steps(int steps)
        {
            
            for (int i = 0;i<pages.Length;i++)
            {
                if(i==steps)
                {
                    pages[i].Image = Properties.Resources.colored_circle;
                }
                else
                {
                    pages[i].Image = Properties.Resources.uncolored_circle;
                }
            }
        }

        private void imageBackward_Click(object sender, EventArgs e)
        {
           if (currentStep > 0)
            {
                currentStep--;
                switchPages(userControls[currentStep]);
                steps(currentStep);
                imageForward.Visible = true;
            }
           if (currentStep>0)
            {
                imageBackward.Visible = true;
            }
           else
            {
                imageBackward.Visible = false;

            }

        }

        private void imageForward_Click(object sender, EventArgs e)
        {
           if (currentStep < pages.Length-1) 
            { 
                currentStep++;
                switchPages(userControls[currentStep]);
                steps(currentStep);
                imageBackward.Visible = true;
            }
           if (currentStep < pages.Length - 1)
            {
                imageForward.Visible = true;
            }
            else
            {
                imageForward.Visible = false;
            }
        }
        private void switchPages(UserControl userControl)
        {
            pnlStepContainer.Controls.Clear();
            pnlStepContainer.Controls.Add(userControl);
        }

        private void InformationForm_Load(object sender, EventArgs e)
        {
            switchPages(userControls[currentStep]);
        }
    }
}
