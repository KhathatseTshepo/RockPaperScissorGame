namespace RockPaperScissorGame
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rockPicturebox = new System.Windows.Forms.PictureBox();
            this.paperPicturebox = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.PlayerPictureBox = new System.Windows.Forms.PictureBox();
            this.computerpicturebox = new System.Windows.Forms.PictureBox();
            this.winnerLabel = new System.Windows.Forms.Label();
            this.scissorsPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelPlayer = new System.Windows.Forms.Panel();
            this.panelComputer = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.rockPicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paperPicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerpicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scissorsPictureBox)).BeginInit();
            this.panelPlayer.SuspendLayout();
            this.panelComputer.SuspendLayout();
            this.SuspendLayout();
            // 
            // rockPicturebox
            // 
            this.rockPicturebox.Image = ((System.Drawing.Image)(resources.GetObject("rockPicturebox.Image")));
            this.rockPicturebox.Location = new System.Drawing.Point(43, 44);
            this.rockPicturebox.Name = "rockPicturebox";
            this.rockPicturebox.Size = new System.Drawing.Size(119, 120);
            this.rockPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rockPicturebox.TabIndex = 0;
            this.rockPicturebox.TabStop = false;
            this.rockPicturebox.Click += new System.EventHandler(this.rockPicturebox_Click);
            // 
            // paperPicturebox
            // 
            this.paperPicturebox.Image = ((System.Drawing.Image)(resources.GetObject("paperPicturebox.Image")));
            this.paperPicturebox.Location = new System.Drawing.Point(223, 44);
            this.paperPicturebox.Name = "paperPicturebox";
            this.paperPicturebox.Size = new System.Drawing.Size(118, 120);
            this.paperPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.paperPicturebox.TabIndex = 1;
            this.paperPicturebox.TabStop = false;
            this.paperPicturebox.Click += new System.EventHandler(this.paperPicturebox_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(209, 483);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(123, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // PlayerPictureBox
            // 
            this.PlayerPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlayerPictureBox.Location = new System.Drawing.Point(15, 13);
            this.PlayerPictureBox.Name = "PlayerPictureBox";
            this.PlayerPictureBox.Size = new System.Drawing.Size(119, 120);
            this.PlayerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerPictureBox.TabIndex = 5;
            this.PlayerPictureBox.TabStop = false;
            // 
            // computerpicturebox
            // 
            this.computerpicturebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.computerpicturebox.Location = new System.Drawing.Point(17, 13);
            this.computerpicturebox.Name = "computerpicturebox";
            this.computerpicturebox.Size = new System.Drawing.Size(119, 120);
            this.computerpicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.computerpicturebox.TabIndex = 6;
            this.computerpicturebox.TabStop = false;
            // 
            // winnerLabel
            // 
            this.winnerLabel.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winnerLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.winnerLabel.Location = new System.Drawing.Point(44, 430);
            this.winnerLabel.Name = "winnerLabel";
            this.winnerLabel.Size = new System.Drawing.Size(464, 20);
            this.winnerLabel.TabIndex = 7;
            this.winnerLabel.Text = "................................";
            this.winnerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scissorsPictureBox
            // 
            this.scissorsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("scissorsPictureBox.Image")));
            this.scissorsPictureBox.Location = new System.Drawing.Point(389, 44);
            this.scissorsPictureBox.Name = "scissorsPictureBox";
            this.scissorsPictureBox.Size = new System.Drawing.Size(118, 120);
            this.scissorsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.scissorsPictureBox.TabIndex = 9;
            this.scissorsPictureBox.TabStop = false;
            this.scissorsPictureBox.Click += new System.EventHandler(this.scissorsPictureBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Your Choice";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(376, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Computer Choice";
            // 
            // panelPlayer
            // 
            this.panelPlayer.Controls.Add(this.PlayerPictureBox);
            this.panelPlayer.Location = new System.Drawing.Point(46, 236);
            this.panelPlayer.Name = "panelPlayer";
            this.panelPlayer.Size = new System.Drawing.Size(150, 150);
            this.panelPlayer.TabIndex = 12;
            // 
            // panelComputer
            // 
            this.panelComputer.Controls.Add(this.computerpicturebox);
            this.panelComputer.Location = new System.Drawing.Point(352, 236);
            this.panelComputer.Name = "panelComputer";
            this.panelComputer.Size = new System.Drawing.Size(155, 150);
            this.panelComputer.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Old English Text MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Rock";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Old English Text MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(219, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "Paper";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Old English Text MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(385, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Scissors";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Old English Text MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(557, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "Score Board";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(561, 44);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(154, 459);
            this.listBox1.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 530);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelComputer);
            this.Controls.Add(this.panelPlayer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scissorsPictureBox);
            this.Controls.Add(this.winnerLabel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.paperPicturebox);
            this.Controls.Add(this.rockPicturebox);
            this.Name = "Form1";
            this.Text = "Rock-Paper-Scissors Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rockPicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paperPicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerpicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scissorsPictureBox)).EndInit();
            this.panelPlayer.ResumeLayout(false);
            this.panelComputer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox rockPicturebox;
        private System.Windows.Forms.PictureBox paperPicturebox;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox PlayerPictureBox;
        private System.Windows.Forms.PictureBox computerpicturebox;
        private System.Windows.Forms.Label winnerLabel;
        private System.Windows.Forms.PictureBox scissorsPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelPlayer;
        private System.Windows.Forms.Panel panelComputer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox1;
    }
}

