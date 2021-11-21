
namespace CourseworkUOG_Quiz
{
    partial class Score
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.dataGridViewShowAnsweredQuestion = new System.Windows.Forms.DataGridView();
            this.lblSubtitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowAnsweredQuestion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(45, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(711, 72);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "label1";
            // 
            // dataGridViewShowAnsweredQuestion
            // 
            this.dataGridViewShowAnsweredQuestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowAnsweredQuestion.Location = new System.Drawing.Point(48, 127);
            this.dataGridViewShowAnsweredQuestion.Name = "dataGridViewShowAnsweredQuestion";
            this.dataGridViewShowAnsweredQuestion.RowTemplate.Height = 24;
            this.dataGridViewShowAnsweredQuestion.Size = new System.Drawing.Size(708, 311);
            this.dataGridViewShowAnsweredQuestion.TabIndex = 1;
        
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Location = new System.Drawing.Point(45, 101);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(308, 23);
            this.lblSubtitle.TabIndex = 2;
            this.lblSubtitle.Text = "Your Previous Answered Question is As Below:";
            // 
            // Score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.dataGridViewShowAnsweredQuestion);
            this.Controls.Add(this.lblTitle);
            this.Name = "Score";
            this.Text = "Score";
            this.Load += new System.EventHandler(this.Score_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowAnsweredQuestion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dataGridViewShowAnsweredQuestion;
        private System.Windows.Forms.Label lblSubtitle;
    }
}