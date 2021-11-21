
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
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowAnsweredQuestion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(146, 115);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(895, 72);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "label1";
            // 
            // dataGridViewShowAnsweredQuestion
            // 
            this.dataGridViewShowAnsweredQuestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowAnsweredQuestion.Location = new System.Drawing.Point(149, 225);
            this.dataGridViewShowAnsweredQuestion.Name = "dataGridViewShowAnsweredQuestion";
            this.dataGridViewShowAnsweredQuestion.RowTemplate.Height = 24;
            this.dataGridViewShowAnsweredQuestion.Size = new System.Drawing.Size(892, 353);
            this.dataGridViewShowAnsweredQuestion.TabIndex = 1;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Location = new System.Drawing.Point(146, 199);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(308, 23);
            this.lblSubtitle.TabIndex = 2;
            this.lblSubtitle.Text = "Your Previous Answered Question is As Below:";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(870, 628);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(171, 79);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 745);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dataGridViewShowAnsweredQuestion);
            this.Controls.Add(this.lblSubtitle);
            this.Name = "Score";
            this.Text = "Score";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Score_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowAnsweredQuestion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dataGridViewShowAnsweredQuestion;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Button btnExit;
    }
}