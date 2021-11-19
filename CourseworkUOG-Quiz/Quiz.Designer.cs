
namespace CourseworkUOG_Quiz
{
    partial class Quiz
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnAns1 = new System.Windows.Forms.Button();
            this.btnAns2 = new System.Windows.Forms.Button();
            this.btnAns3 = new System.Windows.Forms.Button();
            this.btnAns4 = new System.Windows.Forms.Button();
            this.txtFillAnswer = new System.Windows.Forms.TextBox();
            this.btnAns5 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(81, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(61, 16);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Question";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(80, 36);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(299, 24);
            this.lblQuestion.TabIndex = 1;
            this.lblQuestion.Text = "What is the following question?";
            // 
            // btnAns1
            // 
            this.btnAns1.Location = new System.Drawing.Point(214, 306);
            this.btnAns1.Name = "btnAns1";
            this.btnAns1.Size = new System.Drawing.Size(170, 76);
            this.btnAns1.TabIndex = 3;
            this.btnAns1.Text = "btnAns1";
            this.btnAns1.UseVisualStyleBackColor = true;
            // 
            // btnAns2
            // 
            this.btnAns2.Location = new System.Drawing.Point(447, 306);
            this.btnAns2.Name = "btnAns2";
            this.btnAns2.Size = new System.Drawing.Size(170, 76);
            this.btnAns2.TabIndex = 4;
            this.btnAns2.Text = "button2";
            this.btnAns2.UseVisualStyleBackColor = true;
            // 
            // btnAns3
            // 
            this.btnAns3.Location = new System.Drawing.Point(214, 388);
            this.btnAns3.Name = "btnAns3";
            this.btnAns3.Size = new System.Drawing.Size(170, 71);
            this.btnAns3.TabIndex = 5;
            this.btnAns3.Text = "button3";
            this.btnAns3.UseVisualStyleBackColor = true;
            // 
            // btnAns4
            // 
            this.btnAns4.Location = new System.Drawing.Point(447, 388);
            this.btnAns4.Name = "btnAns4";
            this.btnAns4.Size = new System.Drawing.Size(170, 71);
            this.btnAns4.TabIndex = 6;
            this.btnAns4.Text = "button4";
            this.btnAns4.UseVisualStyleBackColor = true;
            // 
            // txtFillAnswer
            // 
            this.txtFillAnswer.Location = new System.Drawing.Point(84, 278);
            this.txtFillAnswer.Name = "txtFillAnswer";
            this.txtFillAnswer.Size = new System.Drawing.Size(322, 22);
            this.txtFillAnswer.TabIndex = 7;
            // 
            // btnAns5
            // 
            this.btnAns5.Location = new System.Drawing.Point(84, 324);
            this.btnAns5.Name = "btnAns5";
            this.btnAns5.Size = new System.Drawing.Size(124, 84);
            this.btnAns5.TabIndex = 8;
            this.btnAns5.Text = "button5";
            this.btnAns5.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(349, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 142);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 638);
            this.Controls.Add(this.btnAns4);
            this.Controls.Add(this.btnAns3);
            this.Controls.Add(this.btnAns2);
            this.Controls.Add(this.btnAns1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtFillAnswer);
            this.Controls.Add(this.btnAns5);
            this.Name = "Quiz";
            this.Text = "Quiz";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAns1;
        private System.Windows.Forms.Button btnAns2;
        private System.Windows.Forms.Button btnAns3;
        private System.Windows.Forms.Button btnAns4;
        private System.Windows.Forms.TextBox txtFillAnswer;
        private System.Windows.Forms.Button btnAns5;
    }
}