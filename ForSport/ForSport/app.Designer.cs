namespace ForSport
{
    partial class app
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
            this.mainpanel = new System.Windows.Forms.Panel();
            this.toppanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_vysledky = new System.Windows.Forms.Button();
            this.bt_forum = new System.Windows.Forms.Button();
            this.bt_live = new System.Windows.Forms.Button();
            this.bt_kurzy = new System.Windows.Forms.Button();
            this.bt_minimize = new System.Windows.Forms.Button();
            this.toppanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainpanel
            // 
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(0, 0);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(1157, 588);
            this.mainpanel.TabIndex = 3;
            // 
            // toppanel
            // 
            this.toppanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.toppanel.Controls.Add(this.bt_minimize);
            this.toppanel.Controls.Add(this.btn_exit);
            this.toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toppanel.Location = new System.Drawing.Point(0, 0);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(1157, 35);
            this.toppanel.TabIndex = 0;
            this.toppanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toppanel_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(239)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1157, 72);
            this.panel1.TabIndex = 1;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(1125, 6);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(29, 23);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ForSport.Properties.Resources.logo_SK;
            this.pictureBox1.Location = new System.Drawing.Point(14, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel2.Controls.Add(this.bt_vysledky);
            this.panel2.Controls.Add(this.bt_forum);
            this.panel2.Controls.Add(this.bt_live);
            this.panel2.Controls.Add(this.bt_kurzy);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1157, 40);
            this.panel2.TabIndex = 2;
            // 
            // bt_vysledky
            // 
            this.bt_vysledky.BackColor = System.Drawing.SystemColors.GrayText;
            this.bt_vysledky.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_vysledky.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_vysledky.ForeColor = System.Drawing.Color.White;
            this.bt_vysledky.Location = new System.Drawing.Point(380, 4);
            this.bt_vysledky.Name = "bt_vysledky";
            this.bt_vysledky.Size = new System.Drawing.Size(100, 33);
            this.bt_vysledky.TabIndex = 0;
            this.bt_vysledky.Text = "Výsledky";
            this.bt_vysledky.UseVisualStyleBackColor = false;
            this.bt_vysledky.Click += new System.EventHandler(this.bt_vysledky_Click);
            // 
            // bt_forum
            // 
            this.bt_forum.BackColor = System.Drawing.SystemColors.GrayText;
            this.bt_forum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_forum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_forum.ForeColor = System.Drawing.Color.White;
            this.bt_forum.Location = new System.Drawing.Point(260, 3);
            this.bt_forum.Name = "bt_forum";
            this.bt_forum.Size = new System.Drawing.Size(100, 34);
            this.bt_forum.TabIndex = 0;
            this.bt_forum.Text = "Fórum";
            this.bt_forum.UseVisualStyleBackColor = false;
            this.bt_forum.Click += new System.EventHandler(this.bt_forum_Click);
            // 
            // bt_live
            // 
            this.bt_live.BackColor = System.Drawing.SystemColors.GrayText;
            this.bt_live.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_live.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_live.ForeColor = System.Drawing.Color.White;
            this.bt_live.Location = new System.Drawing.Point(137, 3);
            this.bt_live.Name = "bt_live";
            this.bt_live.Size = new System.Drawing.Size(100, 34);
            this.bt_live.TabIndex = 0;
            this.bt_live.Text = "LIVE";
            this.bt_live.UseVisualStyleBackColor = false;
            this.bt_live.Click += new System.EventHandler(this.bt_live_Click);
            // 
            // bt_kurzy
            // 
            this.bt_kurzy.BackColor = System.Drawing.SystemColors.GrayText;
            this.bt_kurzy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_kurzy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_kurzy.ForeColor = System.Drawing.Color.White;
            this.bt_kurzy.Location = new System.Drawing.Point(14, 3);
            this.bt_kurzy.Name = "bt_kurzy";
            this.bt_kurzy.Size = new System.Drawing.Size(100, 34);
            this.bt_kurzy.TabIndex = 0;
            this.bt_kurzy.Text = "Kurzy";
            this.bt_kurzy.UseVisualStyleBackColor = false;
            this.bt_kurzy.Click += new System.EventHandler(this.bt_kurzy_Click);
            // 
            // bt_minimize
            // 
            this.bt_minimize.Location = new System.Drawing.Point(1094, 6);
            this.bt_minimize.Name = "bt_minimize";
            this.bt_minimize.Size = new System.Drawing.Size(25, 23);
            this.bt_minimize.TabIndex = 4;
            this.bt_minimize.Text = "-";
            this.bt_minimize.UseVisualStyleBackColor = true;
            this.bt_minimize.Click += new System.EventHandler(this.bt_minimize_Click);
            // 
            // app
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1157, 588);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toppanel);
            this.Controls.Add(this.mainpanel);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "app";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForSport";
            this.toppanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Panel toppanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bt_vysledky;
        private System.Windows.Forms.Button bt_forum;
        private System.Windows.Forms.Button bt_live;
        private System.Windows.Forms.Button bt_kurzy;
        private System.Windows.Forms.Button bt_minimize;
    }
}