
namespace CourseworkUOG_Quiz
{
    partial class Home
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
            this.rdbJungle = new System.Windows.Forms.RadioButton();
            this.rdbBird = new System.Windows.Forms.RadioButton();
            this.rdbAquatic = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdbJungle
            // 
            this.rdbJungle.AutoSize = true;
            this.rdbJungle.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbJungle.Location = new System.Drawing.Point(193, 165);
            this.rdbJungle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbJungle.Name = "rdbJungle";
            this.rdbJungle.Size = new System.Drawing.Size(172, 35);
            this.rdbJungle.TabIndex = 2;
            this.rdbJungle.TabStop = true;
            this.rdbJungle.Text = "JungleAnimal";
            this.rdbJungle.UseVisualStyleBackColor = true;
            // 
            // rdbBird
            // 
            this.rdbBird.AutoSize = true;
            this.rdbBird.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbBird.Location = new System.Drawing.Point(415, 165);
            this.rdbBird.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbBird.Name = "rdbBird";
            this.rdbBird.Size = new System.Drawing.Size(75, 35);
            this.rdbBird.TabIndex = 3;
            this.rdbBird.TabStop = true;
            this.rdbBird.Text = "Bird";
            this.rdbBird.UseVisualStyleBackColor = true;
            // 
            // rdbAquatic
            // 
            this.rdbAquatic.AutoSize = true;
            this.rdbAquatic.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAquatic.Location = new System.Drawing.Point(553, 165);
            this.rdbAquatic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbAquatic.Name = "rdbAquatic";
            this.rdbAquatic.Size = new System.Drawing.Size(181, 35);
            this.rdbAquatic.TabIndex = 4;
            this.rdbAquatic.TabStop = true;
            this.rdbAquatic.Text = "AquaticAnimal";
            this.rdbAquatic.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Source Sans Pro Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(318, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "Zoology Quiz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Category :";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(135, 242);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(239, 127);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Source Sans Pro SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(491, 241);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(223, 127);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(852, 512);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdbAquatic);
            this.Controls.Add(this.rdbBird);
            this.Controls.Add(this.rdbJungle);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbJungle;
        private System.Windows.Forms.RadioButton rdbBird;
        private System.Windows.Forms.RadioButton rdbAquatic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
    }
}