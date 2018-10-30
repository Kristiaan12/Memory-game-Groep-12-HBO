namespace Memory_game_Groep_12_HBO
{
    partial class Players
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
            this.playerOneTxt = new System.Windows.Forms.TextBox();
            this.playerTwoTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playerOneTxt
            // 
            this.playerOneTxt.Location = new System.Drawing.Point(6, 26);
            this.playerOneTxt.Name = "playerOneTxt";
            this.playerOneTxt.Size = new System.Drawing.Size(131, 26);
            this.playerOneTxt.TabIndex = 0;
            this.playerOneTxt.TextChanged += new System.EventHandler(this.playerOneTxt_TextChanged);
            // 
            // playerTwoTxt
            // 
            this.playerTwoTxt.Location = new System.Drawing.Point(6, 137);
            this.playerTwoTxt.Name = "playerTwoTxt";
            this.playerTwoTxt.Size = new System.Drawing.Size(131, 26);
            this.playerTwoTxt.TabIndex = 1;
            this.playerTwoTxt.TextChanged += new System.EventHandler(this.playerTwoTxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Naam speler 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Naam speler 2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(301, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Players
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 200);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playerTwoTxt);
            this.Controls.Add(this.playerOneTxt);
            this.Name = "Players";
            this.Text = "Players";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox playerOneTxt;
        private System.Windows.Forms.TextBox playerTwoTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}