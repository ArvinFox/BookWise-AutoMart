using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace BookWise_AutoMart
{
    public partial class UserFeedbackForm : Form
    {
        private Timer loginFormTimer;
        private int ratingTimer = 10;
        
        public UserFeedbackForm()
        {
            InitializeComponent();
            lblRatingTimer.Text = "";
            loginFormTimer = new Timer();
            loginFormTimer.Interval = 1000; // 1 second
            loginFormTimer.Tick += LoginFormTimer_Tick;
        }

        private string connectionString = DatabaseString.GetUserDatabase();

        private void StarCount(int starCount, bool showLabel = false)
        {
            ratingTimer = 15;
            lblStarValidation.Visible = false;
            
            PictureBox[] stars = new PictureBox[] { pictureBoxStar1, pictureBoxStar2, pictureBoxStar3, pictureBoxStar4, pictureBoxStar5 };
            Label[] starLabels = new Label[] { lblstar1, lblstar2, lblstar3, lblstar4, lblstar5 };

            //--------------------------------------
            /*int count = 1;
            foreach (Label lbl in starLabels)
            {
                if (showLabel && count == starCount)
                {
                    lbl.Visible = true;
                }
                else
                {
                    lbl.Visible = false;
                }
                count++;
            }*/
            //---------------------------------------

            for (int j = 0; j < starLabels.Length; j++)
            {
                if (showLabel && j == starCount-1)
                {
                    starLabels[j].Visible = true;
                }
                else
                {
                    starLabels[j].Visible = false;
                }
            }

            for (int i = 0; i < starCount; i++)
            {
                stars[i].Image = Properties.Resources.Gold_Star_Colored_1;
                //starLabels[i].Visible = true;

                for (int x=4; x >= starCount; x--)
                {
                    stars[x].Image = Properties.Resources.Gold_Star_Uncolored_1;
                    //starLabels[x].Visible = false;
                }
            }
        }

        int userStarRating =0;
        string userFeedback;
        
        private void pictureBoxStar1_Click(object sender, EventArgs e)
        {
            StarCount(1, true);
            userStarRating = 1;
        }

        private void pictureBoxStar2_Click(object sender, EventArgs e)
        {
            StarCount(2, true);
            userStarRating = 2;
        }

        private void pictureBoxStar3_Click(object sender, EventArgs e)
        {
            StarCount(3, true);
            userStarRating = 3;
        }

        private void pictureBoxStar4_Click(object sender, EventArgs e)
        {
            StarCount(4, true);
            userStarRating = 4;
        }

        private void pictureBoxStar5_Click(object sender, EventArgs e)
        {
            StarCount(5, true);
            userStarRating = 5;
        }

        private void rtbComment_Click(object sender, EventArgs e)
        {
            ratingTimer = 15;

            if (rtbComment.Text.Trim() == "Tell us more about your experience... (optional)")
            {
                rtbComment.SelectionStart = 1;
            }
        }

        private void rtbComment_KeyPress(object sender, KeyPressEventArgs e)
        {
            ratingTimer = 15;
            
            if (rtbComment.Text.Trim() == "Tell us more about your experience... (optional)")
            {
                rtbComment.Text = " ";
                rtbComment.SelectionStart = 1;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            //string query = "INSERT INTO Feedback (feedback_user_id, star_rating, feedback) VALUES ()"; ------------------- feedback_user_id --> Unfinished.
            //string query = $"INSERT INTO Feedback (star_rating, feedback) VALUES ({userStarRating} , '{userFeedback}')";

            //---------------------------

            if (rtbComment.Text.Trim() == "Tell us more about your experience... (optional)")
            {
                userFeedback = null;
            }
            else
            {
                userFeedback = rtbComment.Text;
            }

            // Verify rating selection.
            if (userStarRating == 0)
            {
                ratingTimer = 15;
                lblStarValidation.Visible = true;
            }
            else
            {
                try
                {
                    loginFormTimer.Stop();

                    string query = $"INSERT INTO Feedback (feedback_user_id, rating, comment) VALUES ({UserPanel.id}, {userStarRating}, '{userFeedback}')";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    //returning to a new login page.
                    bool userLoginFound = false;
                    foreach (Form form in Application.OpenForms)
                    {
                        if (form is UserLogin)
                        {
                            form.Show();
                            userLoginFound = true;
                            break;
                        }
                    }

                    if (!userLoginFound)
                    {
                        UserLogin userLogin = new UserLogin();
                        userLogin.Show();
                    }

                    this.Close();
                    UserPanel.checkoutForm.Close();   // Reset the user bill data

                    // Reset the previous user's data (close previous UserPanel instance)
                    UserLogin.userPanel.Close();
                }
                catch (Exception)
                {
                    //error, error message.
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void UserFeedbackForm_Load(object sender, EventArgs e)
        {
            loginFormTimer.Start();
        }

        private void LoginFormTimer_Tick(object sender, EventArgs e)
        {
            ratingTimer--;

            if (ratingTimer == 1)
            {
                lblRatingTimer.Text = $"Closing in {ratingTimer} second";
            }
            else
            {
                lblRatingTimer.Text = $"Closing in {ratingTimer} seconds";
            }

            //returning to a new login page.
            if (ratingTimer <= 0)
            {
                loginFormTimer.Stop();

                bool userLoginFound = false;
                foreach (Form form in Application.OpenForms)
                {
                    if (form is UserLogin)
                    {
                        form.Show();
                        userLoginFound = true;
                        break;
                    }
                }

                if (!userLoginFound)
                {
                    UserLogin userLogin = new UserLogin();
                    userLogin.Show();
                }

                this.Close();
                UserPanel.checkoutForm.Close();   // Reset the user bill data

                // Reset the previous user's data (close previous UserPanel instance)
                UserLogin.userPanel.Close();
            }
        }
    }
}
