namespace Tic_Tac_Toe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lbWinner = new Label();
            lbPlayer = new Label();
            btnRestart = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(656, 57);
            label1.Name = "label1";
            label1.Size = new Size(491, 68);
            label1.TabIndex = 0;
            label1.Text = "Tic-Tac-Toe Game";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Yellow;
            label2.Location = new Point(173, 111);
            label2.Name = "label2";
            label2.Size = new Size(154, 68);
            label2.TabIndex = 1;
            label2.Text = "Turn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Constantia", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Yellow;
            label3.Location = new Point(136, 309);
            label3.Name = "label3";
            label3.Size = new Size(229, 68);
            label3.TabIndex = 2;
            label3.Text = "Winner";
            // 
            // lbWinner
            // 
            lbWinner.AutoSize = true;
            lbWinner.Font = new Font("Constantia", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbWinner.ForeColor = Color.Lime;
            lbWinner.Location = new Point(110, 408);
            lbWinner.Name = "lbWinner";
            lbWinner.Size = new Size(328, 68);
            lbWinner.TabIndex = 3;
            lbWinner.Text = "In Progress";
            // 
            // lbPlayer
            // 
            lbPlayer.AutoSize = true;
            lbPlayer.Font = new Font("Constantia", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPlayer.ForeColor = Color.White;
            lbPlayer.Location = new Point(113, 210);
            lbPlayer.Name = "lbPlayer";
            lbPlayer.Size = new Size(225, 68);
            lbPlayer.TabIndex = 4;
            lbPlayer.Text = "Player 1";
            // 
            // btnRestart
            // 
            btnRestart.FlatAppearance.BorderColor = Color.White;
            btnRestart.FlatStyle = FlatStyle.Flat;
            btnRestart.Font = new Font("Constantia", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRestart.ForeColor = Color.White;
            btnRestart.Location = new Point(80, 507);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(341, 89);
            btnRestart.TabIndex = 5;
            btnRestart.Text = "Restart Game";
            btnRestart.UseVisualStyleBackColor = true;
            btnRestart.Click += btnRestart_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.question_mark_96;
            button1.Location = new Point(615, 161);
            button1.Name = "button1";
            button1.Size = new Size(173, 105);
            button1.TabIndex = 15;
            button1.Tag = "?";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = Properties.Resources.question_mark_96;
            button2.Location = new Point(821, 161);
            button2.Name = "button2";
            button2.Size = new Size(173, 105);
            button2.TabIndex = 16;
            button2.Tag = "?";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = Properties.Resources.question_mark_96;
            button3.Location = new Point(1027, 161);
            button3.Name = "button3";
            button3.Size = new Size(173, 105);
            button3.TabIndex = 17;
            button3.Tag = "?";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Image = Properties.Resources.question_mark_96;
            button4.Location = new Point(615, 315);
            button4.Name = "button4";
            button4.Size = new Size(173, 105);
            button4.TabIndex = 18;
            button4.Tag = "?";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Flat;
            button5.Image = Properties.Resources.question_mark_96;
            button5.Location = new Point(821, 315);
            button5.Name = "button5";
            button5.Size = new Size(173, 105);
            button5.TabIndex = 19;
            button5.Tag = "?";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.FlatStyle = FlatStyle.Flat;
            button6.Image = Properties.Resources.question_mark_96;
            button6.Location = new Point(1027, 315);
            button6.Name = "button6";
            button6.Size = new Size(173, 105);
            button6.TabIndex = 20;
            button6.Tag = "?";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.FlatStyle = FlatStyle.Flat;
            button7.Image = Properties.Resources.question_mark_96;
            button7.Location = new Point(615, 469);
            button7.Name = "button7";
            button7.Size = new Size(173, 105);
            button7.TabIndex = 21;
            button7.Tag = "?";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.FlatStyle = FlatStyle.Flat;
            button8.Image = Properties.Resources.question_mark_96;
            button8.Location = new Point(821, 469);
            button8.Name = "button8";
            button8.Size = new Size(173, 105);
            button8.TabIndex = 22;
            button8.Tag = "?";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.FlatStyle = FlatStyle.Flat;
            button9.Image = Properties.Resources.question_mark_96;
            button9.Location = new Point(1027, 469);
            button9.Name = "button9";
            button9.Size = new Size(173, 105);
            button9.TabIndex = 23;
            button9.Tag = "?";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1287, 710);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnRestart);
            Controls.Add(lbPlayer);
            Controls.Add(lbWinner);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Tic-Tac-Toe Game";
            Load += Form1_Load;
            Paint += Form1_Paint;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label lbWinner;
        private Label lbPlayer;
        private Button btnRestart;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
    }
}
