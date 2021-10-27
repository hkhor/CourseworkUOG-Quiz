
namespace CourseworkUOG_Quiz
{
    partial class AdminPage
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
            this.listQuiz = new System.Windows.Forms.ListBox();
            this.lblQuizId = new System.Windows.Forms.Label();
            this.lblAnimalCategory = new System.Windows.Forms.Label();
            this.lblAnswerType = new System.Windows.Forms.Label();
            this.lblAnswer1 = new System.Windows.Forms.Label();
            this.lblAnswer2 = new System.Windows.Forms.Label();
            this.lblAnswer3 = new System.Windows.Forms.Label();
            this.lblAnswer4 = new System.Windows.Forms.Label();
            this.txtQuizID = new System.Windows.Forms.TextBox();
            this.cmbAnimalCategory = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtAns1 = new System.Windows.Forms.TextBox();
            this.txtAns2 = new System.Windows.Forms.TextBox();
            this.txtAns3 = new System.Windows.Forms.TextBox();
            this.txtAns4 = new System.Windows.Forms.TextBox();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listQuiz
            // 
            this.listQuiz.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listQuiz.FormattingEnabled = true;
            this.listQuiz.ItemHeight = 16;
            this.listQuiz.Location = new System.Drawing.Point(390, 48);
            this.listQuiz.Name = "listQuiz";
            this.listQuiz.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listQuiz.Size = new System.Drawing.Size(355, 372);
            this.listQuiz.TabIndex = 0;
            // 
            // lblQuizId
            // 
            this.lblQuizId.AutoSize = true;
            this.lblQuizId.Location = new System.Drawing.Point(49, 48);
            this.lblQuizId.Name = "lblQuizId";
            this.lblQuizId.Size = new System.Drawing.Size(50, 16);
            this.lblQuizId.TabIndex = 1;
            this.lblQuizId.Text = "Quiz ID";
            // 
            // lblAnimalCategory
            // 
            this.lblAnimalCategory.AutoSize = true;
            this.lblAnimalCategory.Location = new System.Drawing.Point(49, 87);
            this.lblAnimalCategory.Name = "lblAnimalCategory";
            this.lblAnimalCategory.Size = new System.Drawing.Size(107, 16);
            this.lblAnimalCategory.TabIndex = 2;
            this.lblAnimalCategory.Text = "Animal Category";
            // 
            // lblAnswerType
            // 
            this.lblAnswerType.AutoSize = true;
            this.lblAnswerType.Location = new System.Drawing.Point(49, 130);
            this.lblAnswerType.Name = "lblAnswerType";
            this.lblAnswerType.Size = new System.Drawing.Size(87, 16);
            this.lblAnswerType.TabIndex = 3;
            this.lblAnswerType.Text = "Answer Type";
            // 
            // lblAnswer1
            // 
            this.lblAnswer1.AutoSize = true;
            this.lblAnswer1.Location = new System.Drawing.Point(49, 172);
            this.lblAnswer1.Name = "lblAnswer1";
            this.lblAnswer1.Size = new System.Drawing.Size(62, 16);
            this.lblAnswer1.TabIndex = 4;
            this.lblAnswer1.Text = "Answer 1";
            // 
            // lblAnswer2
            // 
            this.lblAnswer2.AutoSize = true;
            this.lblAnswer2.Location = new System.Drawing.Point(49, 215);
            this.lblAnswer2.Name = "lblAnswer2";
            this.lblAnswer2.Size = new System.Drawing.Size(62, 16);
            this.lblAnswer2.TabIndex = 5;
            this.lblAnswer2.Text = "Answer 2";
            // 
            // lblAnswer3
            // 
            this.lblAnswer3.AutoSize = true;
            this.lblAnswer3.Location = new System.Drawing.Point(49, 256);
            this.lblAnswer3.Name = "lblAnswer3";
            this.lblAnswer3.Size = new System.Drawing.Size(62, 16);
            this.lblAnswer3.TabIndex = 6;
            this.lblAnswer3.Text = "Answer 3";
            // 
            // lblAnswer4
            // 
            this.lblAnswer4.AutoSize = true;
            this.lblAnswer4.Location = new System.Drawing.Point(49, 301);
            this.lblAnswer4.Name = "lblAnswer4";
            this.lblAnswer4.Size = new System.Drawing.Size(62, 16);
            this.lblAnswer4.TabIndex = 7;
            this.lblAnswer4.Text = "Answer 4";
            // 
            // txtQuizID
            // 
            this.txtQuizID.Location = new System.Drawing.Point(164, 42);
            this.txtQuizID.Name = "txtQuizID";
            this.txtQuizID.Size = new System.Drawing.Size(121, 22);
            this.txtQuizID.TabIndex = 8;
            // 
            // cmbAnimalCategory
            // 
            this.cmbAnimalCategory.FormattingEnabled = true;
            this.cmbAnimalCategory.Items.AddRange(new object[] {
            "Bird",
            "Mammal",
            "Fish"});
            this.cmbAnimalCategory.Location = new System.Drawing.Point(164, 79);
            this.cmbAnimalCategory.Name = "cmbAnimalCategory";
            this.cmbAnimalCategory.Size = new System.Drawing.Size(121, 24);
            this.cmbAnimalCategory.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "Mutliple";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mutliple",
            "Order",
            "Fill"});
            this.comboBox1.Location = new System.Drawing.Point(164, 122);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 10;
            // 
            // txtAns1
            // 
            this.txtAns1.Location = new System.Drawing.Point(164, 165);
            this.txtAns1.Name = "txtAns1";
            this.txtAns1.Size = new System.Drawing.Size(121, 22);
            this.txtAns1.TabIndex = 11;
            // 
            // txtAns2
            // 
            this.txtAns2.Location = new System.Drawing.Point(164, 209);
            this.txtAns2.Name = "txtAns2";
            this.txtAns2.Size = new System.Drawing.Size(121, 22);
            this.txtAns2.TabIndex = 12;
            // 
            // txtAns3
            // 
            this.txtAns3.Location = new System.Drawing.Point(164, 249);
            this.txtAns3.Name = "txtAns3";
            this.txtAns3.Size = new System.Drawing.Size(121, 22);
            this.txtAns3.TabIndex = 13;
            // 
            // txtAns4
            // 
            this.txtAns4.Location = new System.Drawing.Point(164, 295);
            this.txtAns4.Name = "txtAns4";
            this.txtAns4.Size = new System.Drawing.Size(121, 22);
            this.txtAns4.TabIndex = 14;
            // 
            // btnAddImage
            // 
            this.btnAddImage.Location = new System.Drawing.Point(164, 334);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(121, 24);
            this.btnAddImage.TabIndex = 15;
            this.btnAddImage.Text = "Add Image";
            this.btnAddImage.UseVisualStyleBackColor = true;
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnAddImage);
            this.Controls.Add(this.txtAns4);
            this.Controls.Add(this.txtAns3);
            this.Controls.Add(this.txtAns2);
            this.Controls.Add(this.txtAns1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cmbAnimalCategory);
            this.Controls.Add(this.txtQuizID);
            this.Controls.Add(this.lblAnswer4);
            this.Controls.Add(this.lblAnswer3);
            this.Controls.Add(this.lblAnswer2);
            this.Controls.Add(this.lblAnswer1);
            this.Controls.Add(this.lblAnswerType);
            this.Controls.Add(this.lblAnimalCategory);
            this.Controls.Add(this.lblQuizId);
            this.Controls.Add(this.listQuiz);
            this.Name = "AdminPage";
            this.Text = "AdminPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listQuiz;
        private System.Windows.Forms.Label lblQuizId;
        private System.Windows.Forms.Label lblAnimalCategory;
        private System.Windows.Forms.Label lblAnswerType;
        private System.Windows.Forms.Label lblAnswer1;
        private System.Windows.Forms.Label lblAnswer2;
        private System.Windows.Forms.Label lblAnswer3;
        private System.Windows.Forms.Label lblAnswer4;
        private System.Windows.Forms.TextBox txtQuizID;
        private System.Windows.Forms.ComboBox cmbAnimalCategory;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtAns1;
        private System.Windows.Forms.TextBox txtAns2;
        private System.Windows.Forms.TextBox txtAns3;
        private System.Windows.Forms.TextBox txtAns4;
        private System.Windows.Forms.Button btnAddImage;
    }
}