namespace Tic_Tac_Toe_Game
{
    partial class GameScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTurn = new System.Windows.Forms.Label();
            this.LblWinner = new System.Windows.Forms.Label();
            this.BtRestart = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.BtExit = new System.Windows.Forms.Button();
            this.Bt1 = new System.Windows.Forms.Button();
            this.Bt2 = new System.Windows.Forms.Button();
            this.Bt3 = new System.Windows.Forms.Button();
            this.Bt4 = new System.Windows.Forms.Button();
            this.Bt5 = new System.Windows.Forms.Button();
            this.Bt6 = new System.Windows.Forms.Button();
            this.Bt7 = new System.Windows.Forms.Button();
            this.Bt8 = new System.Windows.Forms.Button();
            this.Bt9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(96, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "Turn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(82, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 30);
            this.label2.TabIndex = 8;
            this.label2.Text = "Winner";
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.ForeColor = System.Drawing.Color.NavajoWhite;
            this.lblTurn.Location = new System.Drawing.Point(66, 106);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(146, 30);
            this.lblTurn.TabIndex = 9;
            this.lblTurn.Text = "Player 1";
            this.lblTurn.Click += new System.EventHandler(this.lblTurn_Click);
            // 
            // LblWinner
            // 
            this.LblWinner.AutoSize = true;
            this.LblWinner.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWinner.ForeColor = System.Drawing.Color.OrangeRed;
            this.LblWinner.Location = new System.Drawing.Point(51, 238);
            this.LblWinner.Name = "LblWinner";
            this.LblWinner.Size = new System.Drawing.Size(166, 26);
            this.LblWinner.TabIndex = 10;
            this.LblWinner.Text = "In Progress";
            // 
            // BtRestart
            // 
            this.BtRestart.BackColor = System.Drawing.Color.Black;
            this.BtRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtRestart.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.BtRestart.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtRestart.ForeColor = System.Drawing.Color.Cornsilk;
            this.BtRestart.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtRestart.Location = new System.Drawing.Point(158, 381);
            this.BtRestart.Name = "BtRestart";
            this.BtRestart.Size = new System.Drawing.Size(133, 38);
            this.BtRestart.TabIndex = 11;
            this.BtRestart.Text = "Restart ";
            this.BtRestart.UseVisualStyleBackColor = false;
            this.BtRestart.Click += new System.EventHandler(this.BtRestart_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Algerian", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label4.Location = new System.Drawing.Point(278, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(460, 54);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tic Tac Toe Game";
            // 
            // BtExit
            // 
            this.BtExit.BackColor = System.Drawing.Color.Black;
            this.BtExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtExit.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.BtExit.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtExit.ForeColor = System.Drawing.Color.Cornsilk;
            this.BtExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtExit.Location = new System.Drawing.Point(19, 381);
            this.BtExit.Name = "BtExit";
            this.BtExit.Size = new System.Drawing.Size(133, 38);
            this.BtExit.TabIndex = 13;
            this.BtExit.Text = "Exit";
            this.BtExit.UseVisualStyleBackColor = false;
            this.BtExit.Click += new System.EventHandler(this.BtExit_Click);
            // 
            // Bt1
            // 
            this.Bt1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt1.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.Bt1.Location = new System.Drawing.Point(300, 104);
            this.Bt1.Name = "Bt1";
            this.Bt1.Size = new System.Drawing.Size(89, 79);
            this.Bt1.TabIndex = 22;
            this.Bt1.Tag = "?";
            this.Bt1.UseVisualStyleBackColor = true;
            this.Bt1.Click += new System.EventHandler(this.Bt_Click);
            // 
            // Bt2
            // 
            this.Bt2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt2.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.Bt2.Location = new System.Drawing.Point(466, 104);
            this.Bt2.Name = "Bt2";
            this.Bt2.Size = new System.Drawing.Size(89, 79);
            this.Bt2.TabIndex = 23;
            this.Bt2.Tag = "?";
            this.Bt2.UseVisualStyleBackColor = true;
            this.Bt2.Click += new System.EventHandler(this.Bt_Click);
            // 
            // Bt3
            // 
            this.Bt3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt3.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.Bt3.Location = new System.Drawing.Point(619, 104);
            this.Bt3.Name = "Bt3";
            this.Bt3.Size = new System.Drawing.Size(89, 79);
            this.Bt3.TabIndex = 24;
            this.Bt3.Tag = "?";
            this.Bt3.UseVisualStyleBackColor = true;
            this.Bt3.Click += new System.EventHandler(this.Bt_Click);
            // 
            // Bt4
            // 
            this.Bt4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt4.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.Bt4.Location = new System.Drawing.Point(300, 218);
            this.Bt4.Name = "Bt4";
            this.Bt4.Size = new System.Drawing.Size(89, 79);
            this.Bt4.TabIndex = 25;
            this.Bt4.Tag = "?";
            this.Bt4.UseVisualStyleBackColor = true;
            this.Bt4.Click += new System.EventHandler(this.Bt_Click);
            // 
            // Bt5
            // 
            this.Bt5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt5.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.Bt5.Location = new System.Drawing.Point(466, 218);
            this.Bt5.Name = "Bt5";
            this.Bt5.Size = new System.Drawing.Size(89, 79);
            this.Bt5.TabIndex = 26;
            this.Bt5.Tag = "?";
            this.Bt5.UseVisualStyleBackColor = true;
            this.Bt5.Click += new System.EventHandler(this.Bt_Click);
            // 
            // Bt6
            // 
            this.Bt6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt6.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.Bt6.Location = new System.Drawing.Point(619, 218);
            this.Bt6.Name = "Bt6";
            this.Bt6.Size = new System.Drawing.Size(89, 79);
            this.Bt6.TabIndex = 27;
            this.Bt6.Tag = "?";
            this.Bt6.UseVisualStyleBackColor = true;
            this.Bt6.Click += new System.EventHandler(this.Bt_Click);
            // 
            // Bt7
            // 
            this.Bt7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt7.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.Bt7.Location = new System.Drawing.Point(300, 345);
            this.Bt7.Name = "Bt7";
            this.Bt7.Size = new System.Drawing.Size(89, 79);
            this.Bt7.TabIndex = 28;
            this.Bt7.Tag = "?";
            this.Bt7.UseVisualStyleBackColor = true;
            this.Bt7.Click += new System.EventHandler(this.Bt_Click);
            // 
            // Bt8
            // 
            this.Bt8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt8.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.Bt8.Location = new System.Drawing.Point(466, 345);
            this.Bt8.Name = "Bt8";
            this.Bt8.Size = new System.Drawing.Size(89, 79);
            this.Bt8.TabIndex = 29;
            this.Bt8.Tag = "?";
            this.Bt8.UseVisualStyleBackColor = true;
            this.Bt8.Click += new System.EventHandler(this.Bt_Click);
            // 
            // Bt9
            // 
            this.Bt9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt9.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.Bt9.Location = new System.Drawing.Point(619, 345);
            this.Bt9.Name = "Bt9";
            this.Bt9.Size = new System.Drawing.Size(89, 79);
            this.Bt9.TabIndex = 30;
            this.Bt9.Tag = "?";
            this.Bt9.UseVisualStyleBackColor = true;
            this.Bt9.Click += new System.EventHandler(this.Bt_Click);
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Bt9);
            this.Controls.Add(this.Bt8);
            this.Controls.Add(this.Bt7);
            this.Controls.Add(this.Bt6);
            this.Controls.Add(this.Bt5);
            this.Controls.Add(this.Bt4);
            this.Controls.Add(this.Bt3);
            this.Controls.Add(this.Bt2);
            this.Controls.Add(this.Bt1);
            this.Controls.Add(this.BtExit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtRestart);
            this.Controls.Add(this.LblWinner);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "GameScreen";
            this.Text = "x`";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.XO_Draw);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label LblWinner;
        private System.Windows.Forms.Button BtRestart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtExit;
        private System.Windows.Forms.Button Bt1;
        private System.Windows.Forms.Button Bt2;
        private System.Windows.Forms.Button Bt3;
        private System.Windows.Forms.Button Bt4;
        private System.Windows.Forms.Button Bt5;
        private System.Windows.Forms.Button Bt6;
        private System.Windows.Forms.Button Bt7;
        private System.Windows.Forms.Button Bt8;
        private System.Windows.Forms.Button Bt9;
    }
}