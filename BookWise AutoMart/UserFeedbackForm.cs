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
        public UserFeedbackForm()
        {
            InitializeComponent();
        }

        private string connectionString = DatabaseString.GetUserDatabase();

        private void StarCount(int starCount, bool showLabel = false)
        {
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

        int userStarRating;
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
            if (rtbComment.Text.Trim() == "Tell us more about your experience... (optional)")
            {
                rtbComment.SelectionStart = 1;
            }

        }

        private void rtbComment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rtbComment.Text.Trim() == "Tell us more about your experience... (optional)")
            {
                rtbComment.Text = " ";
                rtbComment.SelectionStart = 1;

            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Verify rating selection --> Unfinished.
            
            if (rtbComment.Text.Trim() == "Tell us more about your experience... (optional)")
            {
                userFeedback = null;
            }
            else
            {
                userFeedback = rtbComment.Text;
            }
            
            
            SqlConnection conn = new SqlConnection(connectionString);

            //string query = "INSERT INTO Feedback (feedback_user_id, star_rating, feedback) VALUES ()"; ------------------- feedback_user_id --> Unfinished.
            string query = $"INSERT INTO Feedback (star_rating, feedback) VALUES ({userStarRating} , '{userFeedback}')";

            SqlCommand cmd = new SqlCommand(query, conn);
            
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) 
            {
                //error, error message.
            }
            finally 
            { 
                conn.Close();
                
            }

            //returning to a new login page (Latter part)
            

        }
    }
}
