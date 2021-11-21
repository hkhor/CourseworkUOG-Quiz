
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
            this.lblQuizId = new System.Windows.Forms.Label();
            this.lblAnimalCategory = new System.Windows.Forms.Label();
            this.lblAnswerType = new System.Windows.Forms.Label();
            this.lblAnswer1 = new System.Windows.Forms.Label();
            this.lblAnswer2 = new System.Windows.Forms.Label();
            this.lblAnswer3 = new System.Windows.Forms.Label();
            this.lblAnswer4 = new System.Windows.Forms.Label();
            this.txtQuizID = new System.Windows.Forms.TextBox();
            this.cmbAnimalCategory = new System.Windows.Forms.ComboBox();
            this.cmbAnswerType = new System.Windows.Forms.ComboBox();
            this.txtAns1 = new System.Windows.Forms.TextBox();
            this.txtAns2 = new System.Windows.Forms.TextBox();
            this.txtAns3 = new System.Windows.Forms.TextBox();
            this.txtAns4 = new System.Windows.Forms.TextBox();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.Question = new System.Windows.Forms.Label();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.btnModifyImage = new System.Windows.Forms.Button();
            this.btnDeleteImage = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.dataGridViewQuestionList = new System.Windows.Forms.DataGridView();
            this.lblFileName = new System.Windows.Forms.Label();
            this.lblRealAnswer = new System.Windows.Forms.Label();
            this.txtRealAnswer = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuestionList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuizId
            // 
            this.lblQuizId.AutoSize = true;
            this.lblQuizId.Location = new System.Drawing.Point(49, 48);
            this.lblQuizId.Name = "lblQuizId";
            this.lblQuizId.Size = new System.Drawing.Size(53, 16);
            this.lblQuizId.TabIndex = 1;
            this.lblQuizId.Text = "Quiz ID ";
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
            this.lblAnswer1.Location = new System.Drawing.Point(49, 214);
            this.lblAnswer1.Name = "lblAnswer1";
            this.lblAnswer1.Size = new System.Drawing.Size(62, 16);
            this.lblAnswer1.TabIndex = 4;
            this.lblAnswer1.Text = "Answer 1";
            // 
            // lblAnswer2
            // 
            this.lblAnswer2.AutoSize = true;
            this.lblAnswer2.Location = new System.Drawing.Point(49, 257);
            this.lblAnswer2.Name = "lblAnswer2";
            this.lblAnswer2.Size = new System.Drawing.Size(62, 16);
            this.lblAnswer2.TabIndex = 5;
            this.lblAnswer2.Text = "Answer 2";
            // 
            // lblAnswer3
            // 
            this.lblAnswer3.AutoSize = true;
            this.lblAnswer3.Location = new System.Drawing.Point(49, 298);
            this.lblAnswer3.Name = "lblAnswer3";
            this.lblAnswer3.Size = new System.Drawing.Size(62, 16);
            this.lblAnswer3.TabIndex = 6;
            this.lblAnswer3.Text = "Answer 3";
            // 
            // lblAnswer4
            // 
            this.lblAnswer4.AutoSize = true;
            this.lblAnswer4.Location = new System.Drawing.Point(49, 343);
            this.lblAnswer4.Name = "lblAnswer4";
            this.lblAnswer4.Size = new System.Drawing.Size(62, 16);
            this.lblAnswer4.TabIndex = 7;
            this.lblAnswer4.Text = "Answer 4";
            // 
            // txtQuizID
            // 
            this.txtQuizID.Location = new System.Drawing.Point(164, 42);
            this.txtQuizID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuizID.Name = "txtQuizID";
            this.txtQuizID.ReadOnly = true;
            this.txtQuizID.Size = new System.Drawing.Size(121, 22);
            this.txtQuizID.TabIndex = 8;
            // 
            // cmbAnimalCategory
            // 
            this.cmbAnimalCategory.FormattingEnabled = true;
            this.cmbAnimalCategory.Items.AddRange(new object[] {
            "jungle",
            "bird",
            "aquatic"});
            this.cmbAnimalCategory.Location = new System.Drawing.Point(164, 79);
            this.cmbAnimalCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbAnimalCategory.Name = "cmbAnimalCategory";
            this.cmbAnimalCategory.Size = new System.Drawing.Size(122, 24);
            this.cmbAnimalCategory.TabIndex = 9;
            // 
            // cmbAnswerType
            // 
            this.cmbAnswerType.DisplayMember = "Mutliple";
            this.cmbAnswerType.FormattingEnabled = true;
            this.cmbAnswerType.Items.AddRange(new object[] {
            "Mutliple",
            "Fill"});
            this.cmbAnswerType.Location = new System.Drawing.Point(164, 122);
            this.cmbAnswerType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbAnswerType.Name = "cmbAnswerType";
            this.cmbAnswerType.Size = new System.Drawing.Size(122, 24);
            this.cmbAnswerType.TabIndex = 10;
            // 
            // txtAns1
            // 
            this.txtAns1.Location = new System.Drawing.Point(164, 207);
            this.txtAns1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAns1.Name = "txtAns1";
            this.txtAns1.Size = new System.Drawing.Size(121, 22);
            this.txtAns1.TabIndex = 11;
            // 
            // txtAns2
            // 
            this.txtAns2.Location = new System.Drawing.Point(164, 251);
            this.txtAns2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAns2.Name = "txtAns2";
            this.txtAns2.Size = new System.Drawing.Size(121, 22);
            this.txtAns2.TabIndex = 12;
            // 
            // txtAns3
            // 
            this.txtAns3.Location = new System.Drawing.Point(164, 290);
            this.txtAns3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAns3.Name = "txtAns3";
            this.txtAns3.Size = new System.Drawing.Size(121, 22);
            this.txtAns3.TabIndex = 13;
            // 
            // txtAns4
            // 
            this.txtAns4.Location = new System.Drawing.Point(164, 337);
            this.txtAns4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAns4.Name = "txtAns4";
            this.txtAns4.Size = new System.Drawing.Size(121, 22);
            this.txtAns4.TabIndex = 14;
            // 
            // btnAddImage
            // 
            this.btnAddImage.Location = new System.Drawing.Point(232, 459);
            this.btnAddImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(97, 32);
            this.btnAddImage.TabIndex = 15;
            this.btnAddImage.Text = "Add Image";
            this.btnAddImage.UseVisualStyleBackColor = true;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // Question
            // 
            this.Question.AutoSize = true;
            this.Question.Location = new System.Drawing.Point(49, 175);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(61, 16);
            this.Question.TabIndex = 16;
            this.Question.Text = "Question";
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(164, 170);
            this.txtQuestion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(288, 22);
            this.txtQuestion.TabIndex = 17;
            // 
            // btnModifyImage
            // 
            this.btnModifyImage.Location = new System.Drawing.Point(129, 519);
            this.btnModifyImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModifyImage.Name = "btnModifyImage";
            this.btnModifyImage.Size = new System.Drawing.Size(97, 31);
            this.btnModifyImage.TabIndex = 18;
            this.btnModifyImage.Text = "Modify";
            this.btnModifyImage.UseVisualStyleBackColor = true;
            this.btnModifyImage.Click += new System.EventHandler(this.btnModifyImage_Click);
            // 
            // btnDeleteImage
            // 
            this.btnDeleteImage.Location = new System.Drawing.Point(232, 519);
            this.btnDeleteImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteImage.Name = "btnDeleteImage";
            this.btnDeleteImage.Size = new System.Drawing.Size(97, 31);
            this.btnDeleteImage.TabIndex = 19;
            this.btnDeleteImage.Text = "Delete";
            this.btnDeleteImage.UseVisualStyleBackColor = true;
            this.btnDeleteImage.Click += new System.EventHandler(this.btnDeleteImage_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(26, 519);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(97, 31);
            this.btnInsert.TabIndex = 20;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // dataGridViewQuestionList
            // 
            this.dataGridViewQuestionList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewQuestionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuestionList.Location = new System.Drawing.Point(481, 42);
            this.dataGridViewQuestionList.Name = "dataGridViewQuestionList";
            this.dataGridViewQuestionList.RowTemplate.Height = 24;
            this.dataGridViewQuestionList.Size = new System.Drawing.Size(800, 606);
            this.dataGridViewQuestionList.TabIndex = 21;
            this.dataGridViewQuestionList.Click += new System.EventHandler(this.dataGridViewQuestionList_Click);
            // 
            // lblFileName
            // 
            this.lblFileName.Location = new System.Drawing.Point(49, 467);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(184, 18);
            this.lblFileName.TabIndex = 22;
            this.lblFileName.Text = "FileName";
            // 
            // lblRealAnswer
            // 
            this.lblRealAnswer.Location = new System.Drawing.Point(49, 391);
            this.lblRealAnswer.Name = "lblRealAnswer";
            this.lblRealAnswer.Size = new System.Drawing.Size(87, 23);
            this.lblRealAnswer.TabIndex = 23;
            this.lblRealAnswer.Text = "Real Answer";
            // 
            // txtRealAnswer
            // 
            this.txtRealAnswer.Location = new System.Drawing.Point(164, 388);
            this.txtRealAnswer.Name = "txtRealAnswer";
            this.txtRealAnswer.Size = new System.Drawing.Size(121, 22);
            this.txtRealAnswer.TabIndex = 24;
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.txtRealAnswer);
            this.Controls.Add(this.lblRealAnswer);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.dataGridViewQuestionList);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnDeleteImage);
            this.Controls.Add(this.btnModifyImage);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.btnAddImage);
            this.Controls.Add(this.txtAns4);
            this.Controls.Add(this.txtAns3);
            this.Controls.Add(this.txtAns2);
            this.Controls.Add(this.txtAns1);
            this.Controls.Add(this.cmbAnswerType);
            this.Controls.Add(this.cmbAnimalCategory);
            this.Controls.Add(this.txtQuizID);
            this.Controls.Add(this.lblAnswer4);
            this.Controls.Add(this.lblAnswer3);
            this.Controls.Add(this.lblAnswer2);
            this.Controls.Add(this.lblAnswer1);
            this.Controls.Add(this.lblAnswerType);
            this.Controls.Add(this.lblAnimalCategory);
            this.Controls.Add(this.lblQuizId);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminPage";
            this.Text = "AdminPage";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuestionList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblQuizId;
        private System.Windows.Forms.Label lblAnimalCategory;
        private System.Windows.Forms.Label lblAnswerType;
        private System.Windows.Forms.Label lblAnswer1;
        private System.Windows.Forms.Label lblAnswer2;
        private System.Windows.Forms.Label lblAnswer3;
        private System.Windows.Forms.Label lblAnswer4;
        private System.Windows.Forms.TextBox txtQuizID;
        private System.Windows.Forms.ComboBox cmbAnimalCategory;
        private System.Windows.Forms.ComboBox cmbAnswerType;
        private System.Windows.Forms.TextBox txtAns1;
        private System.Windows.Forms.TextBox txtAns2;
        private System.Windows.Forms.TextBox txtAns3;
        private System.Windows.Forms.TextBox txtAns4;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Button btnModifyImage;
        private System.Windows.Forms.Button btnDeleteImage;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DataGridView dataGridViewQuestionList;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label lblRealAnswer;
        private System.Windows.Forms.TextBox txtRealAnswer;
    }
}