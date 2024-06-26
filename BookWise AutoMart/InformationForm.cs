﻿using System;
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
        private readonly string[] stepsInfo = { "Categories", "Search && Filter Items", "Add Items to Cart", "Proceed to Checkout" };
        private readonly PictureBox[] pages;
        private readonly UserControl[] userControls;

        public InformationForm()
        {
            InitializeComponent();
            lblStep.Text = stepsInfo[currentStep];
            userControls = new UserControl[]
            {
                new UserControlGuide1(),new UserControlGuide2(),new UserControlGuide3(),new UserControlGuide4()
            };
            pages  = new PictureBox[]
            {
                pictureBoxPage1 , pictureBoxPage2 , pictureBoxPage3 , pictureBoxPage4 
            };
        }
        private void Steps(int step)
        {
            for (int i = 0;i<pages.Length;i++)
            {
                lblStep.Text = stepsInfo[currentStep];
                if(i== step)
                {
                    pages[i].Image = Properties.Resources.colored_circle__blue_;
                }
                else
                {
                    pages[i].Image = Properties.Resources.uncolored_circle;
                }
            }
        }

        private void SwitchStep(UserControl userControl)
        {
            pnlStepContainer.Controls.Clear();
            pnlStepContainer.Controls.Add(userControl);
        }

        private void imageBackward_Click(object sender, EventArgs e)
        {
           if (currentStep > 0)
            {
                currentStep--;
                SwitchStep(userControls[currentStep]);
                Steps(currentStep);
                imageForward.Visible = true;
            }
           if (currentStep > 0)
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
                SwitchStep(userControls[currentStep]);
                Steps(currentStep);
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

        private void InformationForm_Load(object sender, EventArgs e)
        {
            SwitchStep(userControls[currentStep]);
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InformationForm_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
