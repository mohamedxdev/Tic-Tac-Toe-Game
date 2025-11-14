namespace Tic_Tac_Toe_Game
{
    partial class The_Rules_Screen
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtGoBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtRules = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = global::Tic_Tac_Toe_Game.Properties.Resources.wallhaven_951q21_3840x2160;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1013, 453);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BtGoBack
            // 
            this.BtGoBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtGoBack.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.BtGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtGoBack.Font = new System.Drawing.Font("Algerian", 21.75F, System.Drawing.FontStyle.Bold);
            this.BtGoBack.ForeColor = System.Drawing.Color.Cornsilk;
            this.BtGoBack.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtGoBack.Location = new System.Drawing.Point(695, 395);
            this.BtGoBack.Name = "BtGoBack";
            this.BtGoBack.Size = new System.Drawing.Size(110, 57);
            this.BtGoBack.TabIndex = 2;
            this.BtGoBack.Text = "->";
            this.BtGoBack.UseVisualStyleBackColor = false;
            this.BtGoBack.Click += new System.EventHandler(this.BtRules_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(28, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter the 3x3 Cursed Grid... if you dare.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtRules
            // 
            this.BtRules.BackColor = System.Drawing.Color.Black;
            this.BtRules.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.BtRules.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtRules.Font = new System.Drawing.Font("Andalus", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtRules.ForeColor = System.Drawing.Color.Cornsilk;
            this.BtRules.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtRules.Location = new System.Drawing.Point(12, 33);
            this.BtRules.Name = "BtRules";
            this.BtRules.Size = new System.Drawing.Size(190, 57);
            this.BtRules.TabIndex = 4;
            this.BtRules.Text = "The Rules";
            this.BtRules.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Desktop;
            this.label2.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(28, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(349, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "One is X, the other O. The Loser... forfeits their soul.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Desktop;
            this.label3.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Cornsilk;
            this.label3.Location = new System.Drawing.Point(28, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "The FIRST to get 3 in a row WINS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Desktop;
            this.label4.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Cornsilk;
            this.label4.Location = new System.Drawing.Point(28, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(318, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "If the grid fills with no winner, you\'re trapped ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Desktop;
            this.label5.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Cornsilk;
            this.label5.Location = new System.Drawing.Point(104, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "FOREVER. Mwahahaha!";
            // 
            // The_Rules_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtRules);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtGoBack);
            this.Controls.Add(this.pictureBox1);
            this.Name = "The_Rules_Screen";
            this.Text = "The_Rules_Screen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtGoBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtRules;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}