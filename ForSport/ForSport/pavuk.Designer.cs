namespace ForSport
{
    partial class pavuk
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
            this.lb_team1 = new System.Windows.Forms.Label();
            this.lb_team2 = new System.Windows.Forms.Label();
            this.lb_team4 = new System.Windows.Forms.Label();
            this.lb_team3 = new System.Windows.Forms.Label();
            this.lb_postup1 = new System.Windows.Forms.Label();
            this.lb_postup2 = new System.Windows.Forms.Label();
            this.lb_team8 = new System.Windows.Forms.Label();
            this.lb_team7 = new System.Windows.Forms.Label();
            this.lb_team6 = new System.Windows.Forms.Label();
            this.lb_team5 = new System.Windows.Forms.Label();
            this.lb_postup4 = new System.Windows.Forms.Label();
            this.lb_postup3 = new System.Windows.Forms.Label();
            this.lb_finale1 = new System.Windows.Forms.Label();
            this.lb_finale2 = new System.Windows.Forms.Label();
            this.lb_finale4 = new System.Windows.Forms.Label();
            this.lb_finale3 = new System.Windows.Forms.Label();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.bt_vytvor = new System.Windows.Forms.Button();
            this.bt_vymaz = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_team1
            // 
            this.lb_team1.BackColor = System.Drawing.Color.Silver;
            this.lb_team1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_team1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_team1.ForeColor = System.Drawing.Color.Black;
            this.lb_team1.Location = new System.Drawing.Point(122, 47);
            this.lb_team1.Name = "lb_team1";
            this.lb_team1.Size = new System.Drawing.Size(205, 43);
            this.lb_team1.TabIndex = 0;
            this.lb_team1.Text = "team1";
            this.lb_team1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_team2
            // 
            this.lb_team2.BackColor = System.Drawing.Color.Silver;
            this.lb_team2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_team2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_team2.ForeColor = System.Drawing.Color.Black;
            this.lb_team2.Location = new System.Drawing.Point(122, 149);
            this.lb_team2.Name = "lb_team2";
            this.lb_team2.Size = new System.Drawing.Size(205, 43);
            this.lb_team2.TabIndex = 1;
            this.lb_team2.Text = "team2";
            this.lb_team2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_team4
            // 
            this.lb_team4.BackColor = System.Drawing.Color.Silver;
            this.lb_team4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_team4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_team4.ForeColor = System.Drawing.Color.Black;
            this.lb_team4.Location = new System.Drawing.Point(122, 329);
            this.lb_team4.Name = "lb_team4";
            this.lb_team4.Size = new System.Drawing.Size(205, 43);
            this.lb_team4.TabIndex = 3;
            this.lb_team4.Text = "team4";
            this.lb_team4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_team3
            // 
            this.lb_team3.BackColor = System.Drawing.Color.Silver;
            this.lb_team3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_team3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_team3.ForeColor = System.Drawing.Color.Black;
            this.lb_team3.Location = new System.Drawing.Point(122, 225);
            this.lb_team3.Name = "lb_team3";
            this.lb_team3.Size = new System.Drawing.Size(205, 43);
            this.lb_team3.TabIndex = 2;
            this.lb_team3.Text = "team3";
            this.lb_team3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_postup1
            // 
            this.lb_postup1.BackColor = System.Drawing.Color.Silver;
            this.lb_postup1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_postup1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_postup1.ForeColor = System.Drawing.Color.Black;
            this.lb_postup1.Location = new System.Drawing.Point(241, 97);
            this.lb_postup1.Name = "lb_postup1";
            this.lb_postup1.Size = new System.Drawing.Size(205, 43);
            this.lb_postup1.TabIndex = 8;
            this.lb_postup1.Text = "postup1";
            this.lb_postup1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_postup1.Visible = false;
            // 
            // lb_postup2
            // 
            this.lb_postup2.BackColor = System.Drawing.Color.Silver;
            this.lb_postup2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_postup2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_postup2.ForeColor = System.Drawing.Color.Black;
            this.lb_postup2.Location = new System.Drawing.Point(241, 277);
            this.lb_postup2.Name = "lb_postup2";
            this.lb_postup2.Size = new System.Drawing.Size(205, 43);
            this.lb_postup2.TabIndex = 9;
            this.lb_postup2.Text = "postup2";
            this.lb_postup2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_postup2.Visible = false;
            // 
            // lb_team8
            // 
            this.lb_team8.BackColor = System.Drawing.Color.Silver;
            this.lb_team8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_team8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_team8.ForeColor = System.Drawing.Color.Black;
            this.lb_team8.Location = new System.Drawing.Point(802, 329);
            this.lb_team8.Name = "lb_team8";
            this.lb_team8.Size = new System.Drawing.Size(205, 43);
            this.lb_team8.TabIndex = 13;
            this.lb_team8.Text = "team8";
            this.lb_team8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_team7
            // 
            this.lb_team7.BackColor = System.Drawing.Color.Silver;
            this.lb_team7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_team7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_team7.ForeColor = System.Drawing.Color.Black;
            this.lb_team7.Location = new System.Drawing.Point(802, 225);
            this.lb_team7.Name = "lb_team7";
            this.lb_team7.Size = new System.Drawing.Size(205, 43);
            this.lb_team7.TabIndex = 12;
            this.lb_team7.Text = "team7";
            this.lb_team7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_team6
            // 
            this.lb_team6.BackColor = System.Drawing.Color.Silver;
            this.lb_team6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_team6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_team6.ForeColor = System.Drawing.Color.Black;
            this.lb_team6.Location = new System.Drawing.Point(802, 149);
            this.lb_team6.Name = "lb_team6";
            this.lb_team6.Size = new System.Drawing.Size(205, 43);
            this.lb_team6.TabIndex = 11;
            this.lb_team6.Text = "team6";
            this.lb_team6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_team5
            // 
            this.lb_team5.BackColor = System.Drawing.Color.Silver;
            this.lb_team5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_team5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_team5.ForeColor = System.Drawing.Color.Black;
            this.lb_team5.Location = new System.Drawing.Point(802, 47);
            this.lb_team5.Name = "lb_team5";
            this.lb_team5.Size = new System.Drawing.Size(205, 43);
            this.lb_team5.TabIndex = 10;
            this.lb_team5.Text = "team5";
            this.lb_team5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_postup4
            // 
            this.lb_postup4.BackColor = System.Drawing.Color.Silver;
            this.lb_postup4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_postup4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_postup4.ForeColor = System.Drawing.Color.Black;
            this.lb_postup4.Location = new System.Drawing.Point(698, 277);
            this.lb_postup4.Name = "lb_postup4";
            this.lb_postup4.Size = new System.Drawing.Size(205, 43);
            this.lb_postup4.TabIndex = 15;
            this.lb_postup4.Text = "postup4";
            this.lb_postup4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_postup4.Visible = false;
            // 
            // lb_postup3
            // 
            this.lb_postup3.BackColor = System.Drawing.Color.Silver;
            this.lb_postup3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_postup3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_postup3.ForeColor = System.Drawing.Color.Black;
            this.lb_postup3.Location = new System.Drawing.Point(698, 97);
            this.lb_postup3.Name = "lb_postup3";
            this.lb_postup3.Size = new System.Drawing.Size(205, 43);
            this.lb_postup3.TabIndex = 14;
            this.lb_postup3.Text = "postup3";
            this.lb_postup3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_postup3.Visible = false;
            // 
            // lb_finale1
            // 
            this.lb_finale1.BackColor = System.Drawing.Color.Silver;
            this.lb_finale1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_finale1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_finale1.ForeColor = System.Drawing.Color.Black;
            this.lb_finale1.Location = new System.Drawing.Point(467, 97);
            this.lb_finale1.Name = "lb_finale1";
            this.lb_finale1.Size = new System.Drawing.Size(205, 43);
            this.lb_finale1.TabIndex = 16;
            this.lb_finale1.Text = "finale1";
            this.lb_finale1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_finale1.Visible = false;
            // 
            // lb_finale2
            // 
            this.lb_finale2.BackColor = System.Drawing.Color.Silver;
            this.lb_finale2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_finale2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_finale2.ForeColor = System.Drawing.Color.Black;
            this.lb_finale2.Location = new System.Drawing.Point(467, 160);
            this.lb_finale2.Name = "lb_finale2";
            this.lb_finale2.Size = new System.Drawing.Size(205, 43);
            this.lb_finale2.TabIndex = 17;
            this.lb_finale2.Text = "finale2";
            this.lb_finale2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_finale2.Visible = false;
            // 
            // lb_finale4
            // 
            this.lb_finale4.BackColor = System.Drawing.Color.Silver;
            this.lb_finale4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_finale4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_finale4.ForeColor = System.Drawing.Color.Black;
            this.lb_finale4.Location = new System.Drawing.Point(467, 288);
            this.lb_finale4.Name = "lb_finale4";
            this.lb_finale4.Size = new System.Drawing.Size(205, 43);
            this.lb_finale4.TabIndex = 19;
            this.lb_finale4.Text = "finale4";
            this.lb_finale4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_finale4.Visible = false;
            // 
            // lb_finale3
            // 
            this.lb_finale3.BackColor = System.Drawing.Color.Silver;
            this.lb_finale3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_finale3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_finale3.ForeColor = System.Drawing.Color.Black;
            this.lb_finale3.Location = new System.Drawing.Point(467, 225);
            this.lb_finale3.Name = "lb_finale3";
            this.lb_finale3.Size = new System.Drawing.Size(205, 43);
            this.lb_finale3.TabIndex = 18;
            this.lb_finale3.Text = "finale3";
            this.lb_finale3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_finale3.Visible = false;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // bt_vytvor
            // 
            this.bt_vytvor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(239)))));
            this.bt_vytvor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_vytvor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_vytvor.ForeColor = System.Drawing.Color.Black;
            this.bt_vytvor.Location = new System.Drawing.Point(270, 414);
            this.bt_vytvor.Name = "bt_vytvor";
            this.bt_vytvor.Size = new System.Drawing.Size(176, 56);
            this.bt_vytvor.TabIndex = 20;
            this.bt_vytvor.Text = "Vytvor pavúka";
            this.bt_vytvor.UseVisualStyleBackColor = false;
            this.bt_vytvor.Click += new System.EventHandler(this.bt_vytvor_Click);
            // 
            // bt_vymaz
            // 
            this.bt_vymaz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(239)))));
            this.bt_vymaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_vymaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_vymaz.ForeColor = System.Drawing.Color.Black;
            this.bt_vymaz.Location = new System.Drawing.Point(270, 487);
            this.bt_vymaz.Name = "bt_vymaz";
            this.bt_vymaz.Size = new System.Drawing.Size(176, 56);
            this.bt_vymaz.TabIndex = 21;
            this.bt_vymaz.Text = "Vymaž pavúka";
            this.bt_vymaz.UseVisualStyleBackColor = false;
            this.bt_vymaz.Click += new System.EventHandler(this.bt_vymaz_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(239)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(479, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 56);
            this.button1.TabIndex = 22;
            this.button1.Text = "Odohraj zápasy";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(753, 468);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 31);
            this.label1.TabIndex = 23;
            this.label1.Text = "WORK IN PROGRESS";
            // 
            // pavuk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_vymaz);
            this.Controls.Add(this.bt_vytvor);
            this.Controls.Add(this.lb_finale4);
            this.Controls.Add(this.lb_finale3);
            this.Controls.Add(this.lb_finale2);
            this.Controls.Add(this.lb_finale1);
            this.Controls.Add(this.lb_postup4);
            this.Controls.Add(this.lb_postup3);
            this.Controls.Add(this.lb_team8);
            this.Controls.Add(this.lb_team7);
            this.Controls.Add(this.lb_team6);
            this.Controls.Add(this.lb_team5);
            this.Controls.Add(this.lb_postup2);
            this.Controls.Add(this.lb_postup1);
            this.Controls.Add(this.lb_team4);
            this.Controls.Add(this.lb_team3);
            this.Controls.Add(this.lb_team2);
            this.Controls.Add(this.lb_team1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "pavuk";
            this.Text = "pavuk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_team1;
        private System.Windows.Forms.Label lb_team2;
        private System.Windows.Forms.Label lb_team4;
        private System.Windows.Forms.Label lb_team3;
        private System.Windows.Forms.Label lb_postup1;
        private System.Windows.Forms.Label lb_postup2;
        private System.Windows.Forms.Label lb_team8;
        private System.Windows.Forms.Label lb_team7;
        private System.Windows.Forms.Label lb_team6;
        private System.Windows.Forms.Label lb_team5;
        private System.Windows.Forms.Label lb_postup4;
        private System.Windows.Forms.Label lb_postup3;
        private System.Windows.Forms.Label lb_finale1;
        private System.Windows.Forms.Label lb_finale2;
        private System.Windows.Forms.Label lb_finale4;
        private System.Windows.Forms.Label lb_finale3;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Button bt_vytvor;
        private System.Windows.Forms.Button bt_vymaz;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}