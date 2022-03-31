namespace MineSweeper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.easy = new System.Windows.Forms.RadioButton();
            this.medium = new System.Windows.Forms.RadioButton();
            this.expert = new System.Windows.Forms.RadioButton();
            this.custom = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.item1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.easyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.item2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseAll = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerDisplay = new System.Windows.Forms.TextBox();
            this.nOG = new System.Windows.Forms.Label();
            this.openGames = new System.Windows.Forms.TextBox();
            this.userN = new System.Windows.Forms.TextBox();
            this.nameEnter = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(237, 175);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "Play";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Play);
            // 
            // easy
            // 
            this.easy.AutoSize = true;
            this.easy.BackColor = System.Drawing.Color.Black;
            this.easy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.easy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.easy.Location = new System.Drawing.Point(40, 66);
            this.easy.Margin = new System.Windows.Forms.Padding(4);
            this.easy.Name = "easy";
            this.easy.Size = new System.Drawing.Size(77, 29);
            this.easy.TabIndex = 1;
            this.easy.TabStop = true;
            this.easy.Text = "Easy";
            this.easy.UseVisualStyleBackColor = false;
            this.easy.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // medium
            // 
            this.medium.AutoSize = true;
            this.medium.BackColor = System.Drawing.Color.Black;
            this.medium.Checked = true;
            this.medium.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.medium.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.medium.Location = new System.Drawing.Point(182, 66);
            this.medium.Margin = new System.Windows.Forms.Padding(4);
            this.medium.Name = "medium";
            this.medium.Size = new System.Drawing.Size(103, 29);
            this.medium.TabIndex = 2;
            this.medium.TabStop = true;
            this.medium.Text = "Medium";
            this.medium.UseVisualStyleBackColor = false;
            this.medium.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // expert
            // 
            this.expert.AutoSize = true;
            this.expert.BackColor = System.Drawing.Color.Black;
            this.expert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expert.ForeColor = System.Drawing.Color.Red;
            this.expert.Location = new System.Drawing.Point(342, 66);
            this.expert.Margin = new System.Windows.Forms.Padding(4);
            this.expert.Name = "expert";
            this.expert.Size = new System.Drawing.Size(89, 29);
            this.expert.TabIndex = 3;
            this.expert.TabStop = true;
            this.expert.Text = "Expert";
            this.expert.UseVisualStyleBackColor = false;
            this.expert.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // custom
            // 
            this.custom.AutoSize = true;
            this.custom.BackColor = System.Drawing.Color.Black;
            this.custom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.custom.ForeColor = System.Drawing.Color.Red;
            this.custom.Location = new System.Drawing.Point(496, 66);
            this.custom.Margin = new System.Windows.Forms.Padding(4);
            this.custom.Name = "custom";
            this.custom.Size = new System.Drawing.Size(101, 29);
            this.custom.TabIndex = 4;
            this.custom.TabStop = true;
            this.custom.Text = "Custom";
            this.custom.UseVisualStyleBackColor = false;
            this.custom.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(686, 33);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked_1);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item1ToolStripMenuItem,
            this.item2ToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // item1ToolStripMenuItem
            // 
            this.item1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.easyToolStripMenuItem,
            this.mediumToolStripMenuItem,
            this.expertToolStripMenuItem});
            this.item1ToolStripMenuItem.Name = "item1ToolStripMenuItem";
            this.item1ToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.item1ToolStripMenuItem.Text = "Play a game";
            this.item1ToolStripMenuItem.Click += new System.EventHandler(this.item1ToolStripMenuItem_Click);
            // 
            // easyToolStripMenuItem
            // 
            this.easyToolStripMenuItem.Name = "easyToolStripMenuItem";
            this.easyToolStripMenuItem.Size = new System.Drawing.Size(172, 30);
            this.easyToolStripMenuItem.Text = "Easy";
            this.easyToolStripMenuItem.Click += new System.EventHandler(this.easyToolStripMenuItem_Click);
            // 
            // mediumToolStripMenuItem
            // 
            this.mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
            this.mediumToolStripMenuItem.Size = new System.Drawing.Size(172, 30);
            this.mediumToolStripMenuItem.Text = "Medium";
            this.mediumToolStripMenuItem.Click += new System.EventHandler(this.mediumToolStripMenuItem_Click);
            // 
            // expertToolStripMenuItem
            // 
            this.expertToolStripMenuItem.Name = "expertToolStripMenuItem";
            this.expertToolStripMenuItem.Size = new System.Drawing.Size(172, 30);
            this.expertToolStripMenuItem.Text = "Expert";
            this.expertToolStripMenuItem.Click += new System.EventHandler(this.expertToolStripMenuItem_Click);
            // 
            // item2ToolStripMenuItem
            // 
            this.item2ToolStripMenuItem.Name = "item2ToolStripMenuItem";
            this.item2ToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.item2ToolStripMenuItem.Text = "Close All";
            this.item2ToolStripMenuItem.Click += new System.EventHandler(this.item2ToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // CloseAll
            // 
            this.CloseAll.BackColor = System.Drawing.Color.Black;
            this.CloseAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseAll.ForeColor = System.Drawing.Color.Red;
            this.CloseAll.Location = new System.Drawing.Point(237, 115);
            this.CloseAll.Margin = new System.Windows.Forms.Padding(4);
            this.CloseAll.Name = "CloseAll";
            this.CloseAll.Size = new System.Drawing.Size(153, 52);
            this.CloseAll.TabIndex = 6;
            this.CloseAll.Text = "Close All";
            this.CloseAll.UseVisualStyleBackColor = false;
            this.CloseAll.Click += new System.EventHandler(this.CloseAll_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // timerDisplay
            // 
            this.timerDisplay.BackColor = System.Drawing.Color.Black;
            this.timerDisplay.Enabled = false;
            this.timerDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timerDisplay.ForeColor = System.Drawing.Color.Red;
            this.timerDisplay.Location = new System.Drawing.Point(563, 23);
            this.timerDisplay.Name = "timerDisplay";
            this.timerDisplay.Size = new System.Drawing.Size(100, 27);
            this.timerDisplay.TabIndex = 7;
            this.timerDisplay.Text = "0.0";
            this.timerDisplay.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // nOG
            // 
            this.nOG.AutoSize = true;
            this.nOG.BackColor = System.Drawing.Color.Black;
            this.nOG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nOG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.nOG.Location = new System.Drawing.Point(416, 225);
            this.nOG.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nOG.Name = "nOG";
            this.nOG.Size = new System.Drawing.Size(236, 25);
            this.nOG.TabIndex = 8;
            this.nOG.Text = "Number of games running";
            this.nOG.Click += new System.EventHandler(this.label1_Click);
            // 
            // openGames
            // 
            this.openGames.BackColor = System.Drawing.Color.Black;
            this.openGames.Enabled = false;
            this.openGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openGames.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.openGames.Location = new System.Drawing.Point(421, 278);
            this.openGames.Name = "openGames";
            this.openGames.Size = new System.Drawing.Size(100, 41);
            this.openGames.TabIndex = 9;
            this.openGames.Text = "0";
            this.openGames.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // userN
            // 
            this.userN.BackColor = System.Drawing.Color.Black;
            this.userN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.userN.Location = new System.Drawing.Point(58, 278);
            this.userN.Name = "userN";
            this.userN.Size = new System.Drawing.Size(100, 41);
            this.userN.TabIndex = 10;
            this.userN.TextChanged += new System.EventHandler(this.userName_TextChanged);
            // 
            // nameEnter
            // 
            this.nameEnter.AutoSize = true;
            this.nameEnter.BackColor = System.Drawing.Color.Black;
            this.nameEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameEnter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.nameEnter.Location = new System.Drawing.Point(11, 236);
            this.nameEnter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameEnter.Name = "nameEnter";
            this.nameEnter.Size = new System.Drawing.Size(147, 25);
            this.nameEnter.TabIndex = 11;
            this.nameEnter.Text = "Enter the Name";
            this.nameEnter.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(686, 365);
            this.Controls.Add(this.nameEnter);
            this.Controls.Add(this.userN);
            this.Controls.Add(this.openGames);
            this.Controls.Add(this.nOG);
            this.Controls.Add(this.timerDisplay);
            this.Controls.Add(this.CloseAll);
            this.Controls.Add(this.custom);
            this.Controls.Add(this.expert);
            this.Controls.Add(this.medium);
            this.Controls.Add(this.easy);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "MineSweeper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton easy;
        private System.Windows.Forms.RadioButton medium;
        private System.Windows.Forms.RadioButton expert;
        private System.Windows.Forms.RadioButton custom;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem item1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem item2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem easyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button CloseAll;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox timerDisplay;
        private System.Windows.Forms.Label nOG;
        private System.Windows.Forms.TextBox openGames;
        private System.Windows.Forms.TextBox userN;
        private System.Windows.Forms.Label nameEnter;
    }
}

