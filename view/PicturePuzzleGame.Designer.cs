namespace Lab7_PicturePuzzle
{
    partial class PicturePuzzleGame
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
            this.chooseImageGroup = new System.Windows.Forms.GroupBox();
            this.chooseImgButton = new System.Windows.Forms.Button();
            this.groupBoxPuzzle = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nrOfPieces = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.chooseImageGroup.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // chooseImageGroup
            // 
            this.chooseImageGroup.Controls.Add(this.chooseImgButton);
            this.chooseImageGroup.Location = new System.Drawing.Point(973, 43);
            this.chooseImageGroup.Name = "chooseImageGroup";
            this.chooseImageGroup.Size = new System.Drawing.Size(203, 87);
            this.chooseImageGroup.TabIndex = 0;
            this.chooseImageGroup.TabStop = false;
            this.chooseImageGroup.Text = "Please choose an image:";
            // 
            // chooseImgButton
            // 
            this.chooseImgButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.chooseImgButton.Location = new System.Drawing.Point(6, 34);
            this.chooseImgButton.Name = "chooseImgButton";
            this.chooseImgButton.Size = new System.Drawing.Size(75, 23);
            this.chooseImgButton.TabIndex = 1;
            this.chooseImgButton.Text = "Choose";
            this.chooseImgButton.UseVisualStyleBackColor = true;
            this.chooseImgButton.Click += new System.EventHandler(this.chooseImageButton);
            // 
            // groupBoxPuzzle
            // 
            this.groupBoxPuzzle.Location = new System.Drawing.Point(12, 33);
            this.groupBoxPuzzle.Name = "groupBoxPuzzle";
            this.groupBoxPuzzle.Size = new System.Drawing.Size(955, 785);
            this.groupBoxPuzzle.TabIndex = 1;
            this.groupBoxPuzzle.TabStop = false;
            this.groupBoxPuzzle.Text = "Picture Puzzle";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.nrOfPieces);
            this.groupBox2.Controls.Add(this.button9);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(973, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(203, 222);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choose difficulty level:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Or choose number of pieces:";
            // 
            // nrOfPieces
            // 
            this.nrOfPieces.Location = new System.Drawing.Point(9, 179);
            this.nrOfPieces.Name = "nrOfPieces";
            this.nrOfPieces.Size = new System.Drawing.Size(121, 22);
            this.nrOfPieces.TabIndex = 4;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(136, 176);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(45, 28);
            this.button9.TabIndex = 3;
            this.button9.Text = "Ok";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.userChoiceDifficulty);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(19, 109);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "High";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.highDifficultyButton);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(19, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Medium";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.mediumDifficultyButton);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(19, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Low";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.lowDifficultyButton);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Location = new System.Drawing.Point(973, 455);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(203, 172);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Move in Direction:";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(106, 63);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 3;
            this.button8.Text = "Right";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.moveRight);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(55, 92);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 2;
            this.button7.Text = "Down";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.MoveDown);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(55, 33);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 24);
            this.button6.TabIndex = 1;
            this.button6.Text = "Up";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.moveUp);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(9, 63);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 0;
            this.button5.Text = "Left";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.moveLeft);
            // 
            // PicturePuzzleGame
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 1055);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxPuzzle);
            this.Controls.Add(this.chooseImageGroup);
            this.MaximizeBox = false;
            this.Name = "PicturePuzzleGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Picture Puzzle";
            this.chooseImageGroup.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox chooseImageGroup;
        private System.Windows.Forms.Button chooseImgButton;
        private System.Windows.Forms.GroupBox groupBoxPuzzle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox nrOfPieces;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label1;
    }
}

