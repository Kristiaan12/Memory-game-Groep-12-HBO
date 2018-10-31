namespace Memory_game_Groep_12_HBO
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblspeler1 = new System.Windows.Forms.Label();
            this.lblspeler2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lblHighscore5 = new System.Windows.Forms.Label();
            this.lblHighscore4 = new System.Windows.Forms.Label();
            this.lblHighscore3 = new System.Windows.Forms.Label();
            this.lblHighscore2 = new System.Windows.Forms.Label();
            this.lblHighscore = new System.Windows.Forms.Label();
            this.TbHighscore1 = new System.Windows.Forms.TextBox();
            this.TbHighscore5 = new System.Windows.Forms.TextBox();
            this.TbHighscore4 = new System.Windows.Forms.TextBox();
            this.TbHighscore3 = new System.Windows.Forms.TextBox();
            this.TbHighscore2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(764, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.startGame);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(781, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "00:60";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(724, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tijd over:";
            // 
            // lblspeler1
            // 
            this.lblspeler1.AutoSize = true;
            this.lblspeler1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblspeler1.Location = new System.Drawing.Point(711, 92);
            this.lblspeler1.Name = "lblspeler1";
            this.lblspeler1.Size = new System.Drawing.Size(19, 18);
            this.lblspeler1.TabIndex = 22;
            this.lblspeler1.Text = "0";
            // 
            // lblspeler2
            // 
            this.lblspeler2.AutoSize = true;
            this.lblspeler2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblspeler2.Location = new System.Drawing.Point(711, 125);
            this.lblspeler2.Name = "lblspeler2";
            this.lblspeler2.Size = new System.Drawing.Size(19, 18);
            this.lblspeler2.TabIndex = 23;
            this.lblspeler2.Text = "0";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(764, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblHighscore5
            // 
            this.lblHighscore5.AutoSize = true;
            this.lblHighscore5.Location = new System.Drawing.Point(705, 359);
            this.lblHighscore5.Name = "lblHighscore5";
            this.lblHighscore5.Size = new System.Drawing.Size(67, 13);
            this.lblHighscore5.TabIndex = 29;
            this.lblHighscore5.Text = "Highscore 5:";
            // 
            // lblHighscore4
            // 
            this.lblHighscore4.AutoSize = true;
            this.lblHighscore4.Location = new System.Drawing.Point(705, 333);
            this.lblHighscore4.Name = "lblHighscore4";
            this.lblHighscore4.Size = new System.Drawing.Size(67, 13);
            this.lblHighscore4.TabIndex = 28;
            this.lblHighscore4.Text = "Highscore 4:";
            // 
            // lblHighscore3
            // 
            this.lblHighscore3.AutoSize = true;
            this.lblHighscore3.Location = new System.Drawing.Point(705, 304);
            this.lblHighscore3.Name = "lblHighscore3";
            this.lblHighscore3.Size = new System.Drawing.Size(67, 13);
            this.lblHighscore3.TabIndex = 27;
            this.lblHighscore3.Text = "Highscore 3:";
            // 
            // lblHighscore2
            // 
            this.lblHighscore2.AutoSize = true;
            this.lblHighscore2.Location = new System.Drawing.Point(705, 281);
            this.lblHighscore2.Name = "lblHighscore2";
            this.lblHighscore2.Size = new System.Drawing.Size(67, 13);
            this.lblHighscore2.TabIndex = 26;
            this.lblHighscore2.Text = "Highscore 2:";
            // 
            // lblHighscore
            // 
            this.lblHighscore.AutoSize = true;
            this.lblHighscore.Location = new System.Drawing.Point(705, 255);
            this.lblHighscore.Name = "lblHighscore";
            this.lblHighscore.Size = new System.Drawing.Size(67, 13);
            this.lblHighscore.TabIndex = 25;
            this.lblHighscore.Text = "Highscore 1:";
            // 
            // TbHighscore1
            // 
            this.TbHighscore1.Location = new System.Drawing.Point(778, 252);
            this.TbHighscore1.Name = "TbHighscore1";
            this.TbHighscore1.Size = new System.Drawing.Size(100, 20);
            this.TbHighscore1.TabIndex = 30;
            // 
            // TbHighscore5
            // 
            this.TbHighscore5.Location = new System.Drawing.Point(778, 356);
            this.TbHighscore5.Name = "TbHighscore5";
            this.TbHighscore5.Size = new System.Drawing.Size(100, 20);
            this.TbHighscore5.TabIndex = 31;
            // 
            // TbHighscore4
            // 
            this.TbHighscore4.Location = new System.Drawing.Point(778, 330);
            this.TbHighscore4.Name = "TbHighscore4";
            this.TbHighscore4.Size = new System.Drawing.Size(100, 20);
            this.TbHighscore4.TabIndex = 32;
            // 
            // TbHighscore3
            // 
            this.TbHighscore3.Location = new System.Drawing.Point(778, 304);
            this.TbHighscore3.Name = "TbHighscore3";
            this.TbHighscore3.Size = new System.Drawing.Size(100, 20);
            this.TbHighscore3.TabIndex = 33;
            // 
            // TbHighscore2
            // 
            this.TbHighscore2.Location = new System.Drawing.Point(778, 278);
            this.TbHighscore2.Name = "TbHighscore2";
            this.TbHighscore2.Size = new System.Drawing.Size(100, 20);
            this.TbHighscore2.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(781, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 35;
            this.label3.Text = "00:60";
            this.label3.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.label19, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label18, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label17, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label16, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label15, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label14, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label13, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label11, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label10, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label9, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(550, 550);
            this.tableLayoutPanel1.TabIndex = 36;
            // 
            // label19
            // 
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label19.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label19.Location = new System.Drawing.Point(414, 411);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(130, 136);
            this.label19.TabIndex = 15;
            this.label19.Text = "c";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label19.UseWaitCursor = true;
            this.label19.Click += new System.EventHandler(this.label_Click);
            // 
            // label18
            // 
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label18.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label18.Location = new System.Drawing.Point(278, 411);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(127, 136);
            this.label18.TabIndex = 14;
            this.label18.Text = "c";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label18.UseWaitCursor = true;
            this.label18.Click += new System.EventHandler(this.label_Click);
            // 
            // label17
            // 
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label17.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label17.Location = new System.Drawing.Point(142, 411);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(127, 136);
            this.label17.TabIndex = 13;
            this.label17.Text = "c";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label17.UseWaitCursor = true;
            this.label17.Click += new System.EventHandler(this.label_Click);
            // 
            // label16
            // 
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label16.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label16.Location = new System.Drawing.Point(6, 411);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(127, 136);
            this.label16.TabIndex = 12;
            this.label16.Text = "c";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label16.UseWaitCursor = true;
            this.label16.Click += new System.EventHandler(this.label_Click);
            // 
            // label15
            // 
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label15.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label15.Location = new System.Drawing.Point(414, 275);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(130, 133);
            this.label15.TabIndex = 11;
            this.label15.Text = "c";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label15.UseWaitCursor = true;
            this.label15.Click += new System.EventHandler(this.label_Click);
            // 
            // label14
            // 
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label14.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label14.Location = new System.Drawing.Point(278, 275);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 133);
            this.label14.TabIndex = 10;
            this.label14.Text = "c";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label14.UseWaitCursor = true;
            this.label14.Click += new System.EventHandler(this.label_Click);
            // 
            // label13
            // 
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label13.Location = new System.Drawing.Point(142, 275);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 133);
            this.label13.TabIndex = 9;
            this.label13.Text = "c";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label13.UseWaitCursor = true;
            this.label13.Click += new System.EventHandler(this.label_Click);
            // 
            // label12
            // 
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label12.Location = new System.Drawing.Point(6, 275);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 133);
            this.label12.TabIndex = 8;
            this.label12.Text = "c";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label12.UseWaitCursor = true;
            this.label12.Click += new System.EventHandler(this.label_Click);
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label11.Location = new System.Drawing.Point(414, 139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 133);
            this.label11.TabIndex = 7;
            this.label11.Text = "c";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.UseWaitCursor = true;
            this.label11.Click += new System.EventHandler(this.label_Click);
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label10.Location = new System.Drawing.Point(278, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 133);
            this.label10.TabIndex = 6;
            this.label10.Text = "c";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label10.UseWaitCursor = true;
            this.label10.Click += new System.EventHandler(this.label_Click);
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label9.Location = new System.Drawing.Point(142, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 133);
            this.label9.TabIndex = 5;
            this.label9.Text = "c";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.UseWaitCursor = true;
            this.label9.Click += new System.EventHandler(this.label_Click);
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label8.Location = new System.Drawing.Point(6, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 133);
            this.label8.TabIndex = 4;
            this.label8.Text = "c";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.UseWaitCursor = true;
            this.label8.Click += new System.EventHandler(this.label_Click);
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label7.Location = new System.Drawing.Point(414, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 133);
            this.label7.TabIndex = 3;
            this.label7.Text = "c";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.UseWaitCursor = true;
            this.label7.Click += new System.EventHandler(this.label_Click);
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label6.Location = new System.Drawing.Point(278, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 133);
            this.label6.TabIndex = 2;
            this.label6.Text = "c";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.UseWaitCursor = true;
            this.label6.Click += new System.EventHandler(this.label_Click);
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label5.Location = new System.Drawing.Point(142, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 133);
            this.label5.TabIndex = 1;
            this.label5.Text = "c";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.UseWaitCursor = true;
            this.label5.Click += new System.EventHandler(this.label_Click);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label4.Location = new System.Drawing.Point(6, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 133);
            this.label4.TabIndex = 0;
            this.label4.Text = "c";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.UseWaitCursor = true;
            this.label4.Click += new System.EventHandler(this.label_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 750;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 686);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbHighscore2);
            this.Controls.Add(this.TbHighscore3);
            this.Controls.Add(this.TbHighscore4);
            this.Controls.Add(this.TbHighscore5);
            this.Controls.Add(this.TbHighscore1);
            this.Controls.Add(this.lblHighscore5);
            this.Controls.Add(this.lblHighscore4);
            this.Controls.Add(this.lblHighscore3);
            this.Controls.Add(this.lblHighscore2);
            this.Controls.Add(this.lblHighscore);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblspeler2);
            this.Controls.Add(this.lblspeler1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblspeler1;
        private System.Windows.Forms.Label lblspeler2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label lblHighscore5;
        private System.Windows.Forms.Label lblHighscore4;
        private System.Windows.Forms.Label lblHighscore3;
        private System.Windows.Forms.Label lblHighscore2;
        private System.Windows.Forms.Label lblHighscore;
        private System.Windows.Forms.TextBox TbHighscore1;
        private System.Windows.Forms.TextBox TbHighscore5;
        private System.Windows.Forms.TextBox TbHighscore4;
        private System.Windows.Forms.TextBox TbHighscore3;
        private System.Windows.Forms.TextBox TbHighscore2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
    }
}

