namespace Memory_game_Groep_12_HBO
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.player1Txt = new System.Windows.Forms.TextBox();
            this.player2Txt = new System.Windows.Forms.TextBox();
            this.playersubmitBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naam speler 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naam speler 2";
            // 
            // player1Txt
            // 
            this.player1Txt.Location = new System.Drawing.Point(16, 91);
            this.player1Txt.Name = "player1Txt";
            this.player1Txt.Size = new System.Drawing.Size(138, 26);
            this.player1Txt.TabIndex = 2;
            // 
            // player2Txt
            // 
            this.player2Txt.Location = new System.Drawing.Point(16, 156);
            this.player2Txt.Name = "player2Txt";
            this.player2Txt.Size = new System.Drawing.Size(138, 26);
            this.player2Txt.TabIndex = 3;
            // 
            // playersubmitBtn
            // 
            this.playersubmitBtn.Location = new System.Drawing.Point(29, 221);
            this.playersubmitBtn.Name = "playersubmitBtn";
            this.playersubmitBtn.Size = new System.Drawing.Size(146, 35);
            this.playersubmitBtn.TabIndex = 4;
            this.playersubmitBtn.Text = "Volgende";
            this.playersubmitBtn.UseVisualStyleBackColor = true;
            this.playersubmitBtn.Click += new System.EventHandler(this.playersubmitBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.playersubmitBtn);
            this.Controls.Add(this.player2Txt);
            this.Controls.Add(this.player1Txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox player1Txt;
        private System.Windows.Forms.TextBox player2Txt;
        private System.Windows.Forms.Button playersubmitBtn;
        private System.Windows.Forms.Timer timer1;
    }
}