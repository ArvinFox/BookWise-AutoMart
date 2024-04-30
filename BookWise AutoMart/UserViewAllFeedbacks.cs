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

namespace BookWise_AutoMart
{
    public partial class UserViewAllFeedbacks : Form
    {
        int id;

        SqlConnection conn = new SqlConnection(DatabaseString.GetUserDatabase());
        public UserViewAllFeedbacks(int userID)
        {
            InitializeComponent();
            this.ParentChanged += UserViewAllFeedbacks_ParentChanged;
            id = userID;
            ViewUserFeedbacks();
        }
        private void ViewUserFeedbacks()
        {
            pnlTable.Controls.Clear();

            TableLayoutPanel tblHeading = new TableLayoutPanel();

            tblHeading.ColumnCount = 5;
            tblHeading.RowCount = 1;
            tblHeading.Width = this.Width;
            tblHeading.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10));
            tblHeading.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
            tblHeading.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10));
            tblHeading.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
            tblHeading.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10));

            tblHeading.Dock = DockStyle.Top;
            tblHeading.BackColor = Color.IndianRed;
            tblHeading.ForeColor = Color.White;
            tblHeading.Height = 55;

            Label lblFeedbackID = new Label();
            lblFeedbackID.Text = "Feedback ID";
            lblFeedbackID.Dock = DockStyle.Fill;
            lblFeedbackID.TextAlign = ContentAlignment.MiddleCenter;
            lblFeedbackID.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            tblHeading.Controls.Add(lblFeedbackID, 0, 0);

            Label lblFeedbackQuestion = new Label();
            lblFeedbackQuestion.Text = "Question";
            lblFeedbackQuestion.Dock = DockStyle.Fill;
            lblFeedbackQuestion.TextAlign = ContentAlignment.MiddleCenter;
            lblFeedbackQuestion.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            tblHeading.Controls.Add(lblFeedbackQuestion, 1, 0);

            Label lblFeedbackRate = new Label();
            lblFeedbackRate.Text = "Rating";
            lblFeedbackRate.Dock = DockStyle.Fill;
            lblFeedbackRate.TextAlign = ContentAlignment.MiddleCenter;
            lblFeedbackRate.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            tblHeading.Controls.Add(lblFeedbackRate, 2, 0);

            Label lblComment = new Label();
            lblComment.Text = "Comment";
            lblComment.Dock = DockStyle.Fill;
            lblComment.TextAlign = ContentAlignment.MiddleCenter;
            lblComment.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            tblHeading.Controls.Add(lblComment, 3, 0);

            string query = $@"SELECT F.feedback_id, Q.question, F.rating, F.comment 
                            FROM Feedback F
                            JOIN Feedback_Questions Q ON F.feedback_question_id = Q.question_id
                            WHERE F.feedback_user_id = {id}
                            ORDER BY F.feedback_id DESC";

            using (SqlCommand command = new SqlCommand(query, conn))
            {
                try
                {
                    conn.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            int count = 0;
                            while (reader.Read()) 
                            {

                                TableLayoutPanel tblData = new TableLayoutPanel();

                                tblData.ColumnCount = 5;
                                tblData.Width = this.Width;
                                tblData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10));
                                tblData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
                                tblData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10));
                                tblData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
                                tblData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10));

                                tblData.Dock = DockStyle.Top;

                                Label lblFeedbackIDData = new Label();
                                lblFeedbackIDData.Dock = DockStyle.Fill;
                                lblFeedbackIDData.TextAlign = ContentAlignment.MiddleCenter;
                                lblFeedbackIDData.Font = new Font("Segoe UI", 13);
                                tblData.Controls.Add(lblFeedbackIDData, 0, count);

                                Label lblFeedbackQuestionData = new Label();
                                lblFeedbackQuestionData.Dock = DockStyle.Fill;
                                lblFeedbackQuestionData.TextAlign = ContentAlignment.MiddleCenter;
                                lblFeedbackQuestionData.Font = new Font("Segoe UI", 11);
                                tblData.Controls.Add(lblFeedbackQuestionData, 1, count);

                                Label lblFeedbackRateData = new Label();
                                lblFeedbackRateData.Dock = DockStyle.Fill;
                                lblFeedbackRateData.TextAlign = ContentAlignment.MiddleCenter;
                                lblFeedbackRateData.Font = new Font("Segoe UI", 13);
                                tblData.Controls.Add(lblFeedbackRateData, 2, count);

                                Label lblCommentData = new Label();
                                lblCommentData.Dock = DockStyle.Fill;
                                lblCommentData.TextAlign = ContentAlignment.MiddleCenter;
                                lblCommentData.Font = new Font("Segoe UI", 11);
                                tblData.Controls.Add(lblCommentData, 3, count);

                                Button btnDeleteFeedback = new Button();
                                btnDeleteFeedback.FlatStyle = FlatStyle.Flat;
                                btnDeleteFeedback.FlatAppearance.BorderSize = 0;
                                btnDeleteFeedback.Anchor = AnchorStyles.None;
                                btnDeleteFeedback.Font = new Font("Segoe UI", 13, FontStyle.Bold);
                                btnDeleteFeedback.Text = "Delete";
                                btnDeleteFeedback.Cursor = Cursors.Hand;
                                btnDeleteFeedback.BackColor = Color.Red;
                                btnDeleteFeedback.ForeColor = Color.White;
                                btnDeleteFeedback.Size = new Size(120, 45);
                                btnDeleteFeedback.Click += (sender, e) =>
                                {
                                    DeleteUserFeedback(Convert.ToInt32(lblFeedbackIDData.Text));  
                                };
                                tblData.Controls.Add(btnDeleteFeedback, 4, count);

                                //Get data into the labels
                                lblFeedbackIDData.Text = reader["feedback_id"].ToString();
                                lblFeedbackRateData.Text = reader["rating"].ToString() + "/5";
                                lblCommentData.Text = reader["comment"].ToString();
                                lblFeedbackQuestionData.Text = reader["question"].ToString().Trim();
                                

                                if (count % 2 == 0)
                                {
                                    tblData.BackColor = Color.PaleTurquoise;
                                }
                                else
                                {
                                    tblData.BackColor = Color.White;
                                }

                                pnlTable.Controls.Add(tblData);
                                count++;

                            }
                            pnlTable.Controls.Add(tblHeading);
                        }
                        else
                        {
                            TableLayoutPanel tblNoDataAvailable = new TableLayoutPanel();
                            tblNoDataAvailable.Dock = DockStyle.Fill;
                            tblNoDataAvailable.ColumnCount = 1;
                            tblNoDataAvailable.RowCount = 1;
                            
                            Label lblNoDataAvailable = new Label();
                            lblNoDataAvailable.Text = "There is no data available for this user";
                            lblNoDataAvailable.ForeColor = SystemColors.ControlDark;
                            lblNoDataAvailable.Font = new Font("Segoe UI", 14, FontStyle.Bold);
                            lblNoDataAvailable.Dock = DockStyle.Fill;
                            lblNoDataAvailable.TextAlign = ContentAlignment.MiddleCenter;

                            //Display no data message
                            pnlTable.Controls.Add(tblNoDataAvailable);
                            tblNoDataAvailable.Controls.Add(lblNoDataAvailable);
                        }
                    }
                }
                catch (SqlException sqlex)
                {
                    MessageBox.Show(sqlex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void DeleteUserFeedback(int feedbackID)
        {
            DialogResult result = MessageBox.Show("Do you want to delete this feedback?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information); ;

            try
            {
                conn.Open();
                string query = $"DELETE FROM Feedback WHERE feedback_id = {feedbackID}";
                
                if (result == DialogResult.Yes)
                {
                    SqlCommand command = new SqlCommand(query, conn);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Deleted Feedback Successfully!");
                }
            }
            catch (SqlException sqlex)
            {
                MessageBox.Show(sqlex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                conn.Close();

                //To refresh the whole Table after deleting a feedback
                ViewUserFeedbacks();
            }
        }

        private void UserViewAllFeedbacks_ParentChanged(object sender, EventArgs e)
        {
            if (this.Parent != null)
            {
                this.Width = this.Parent.ClientSize.Width;
                this.Height = this.Parent.ClientSize.Height;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


