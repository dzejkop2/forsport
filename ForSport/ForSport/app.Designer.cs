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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_vysledky = new System.Windows.Forms.Button();
            this.bt_forum = new System.Windows.Forms.Button();
            this.bt_live = new System.Windows.Forms.Button();
            this.bt_kurzy = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(239)))));
            this.panel1.Location = new System.Drawing.Point(-2, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1185, 72);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel2.Controls.Add(this.bt_vysledky);
            this.panel2.Controls.Add(this.bt_forum);
            this.panel2.Controls.Add(this.bt_live);
            this.panel2.Controls.Add(this.bt_kurzy);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(-2, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1162, 40);
            this.panel2.TabIndex = 1;
            // 
            // bt_vysledky
            // 
            this.bt_vysledky.BackColor = System.Drawing.SystemColors.GrayText;
            this.bt_vysledky.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_vysledky.Font = new System.Drawing.Font("Roboto Serif 20pt 20pt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_vysledky.ForeColor = System.Drawing.Color.White;
            this.bt_vysledky.Location = new System.Drawing.Point(380, 4);
            this.bt_vysledky.Name = "bt_vysledky";
            this.bt_vysledky.Size = new System.Drawing.Size(100, 33);
            this.bt_vysledky.TabIndex = 0;
            this.bt_vysledky.Text = "Výsledky";
            this.bt_vysledky.UseVisualStyleBackColor = false;
            // 
            // bt_forum
            // 
            this.bt_forum.BackColor = System.Drawing.SystemColors.GrayText;
            this.bt_forum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_forum.Font = new System.Drawing.Font("Roboto Serif 20pt 20pt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_forum.ForeColor = System.Drawing.Color.White;
            this.bt_forum.Location = new System.Drawing.Point(260, 3);
            this.bt_forum.Name = "bt_forum";
            this.bt_forum.Size = new System.Drawing.Size(100, 34);
            this.bt_forum.TabIndex = 0;
            this.bt_forum.Text = "Fórum";
            this.bt_forum.UseVisualStyleBackColor = false;
            // 
            // bt_live
            // 
            this.bt_live.BackColor = System.Drawing.SystemColors.GrayText;
            this.bt_live.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_live.Font = new System.Drawing.Font("Roboto Serif 20pt 20pt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_live.ForeColor = System.Drawing.Color.White;
            this.bt_live.Location = new System.Drawing.Point(137, 3);
            this.bt_live.Name = "bt_live";
            this.bt_live.Size = new System.Drawing.Size(100, 34);
            this.bt_live.TabIndex = 0;
            this.bt_live.Text = "LIVE";
            this.bt_live.UseVisualStyleBackColor = false;
            // 
            // bt_kurzy
            // 
            this.bt_kurzy.BackColor = System.Drawing.SystemColors.GrayText;
            this.bt_kurzy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_kurzy.Font = new System.Drawing.Font("Roboto Serif 20pt 20pt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_kurzy.ForeColor = System.Drawing.Color.White;
            this.bt_kurzy.Location = new System.Drawing.Point(14, 3);
            this.bt_kurzy.Name = "bt_kurzy";
            this.bt_kurzy.Size = new System.Drawing.Size(100, 34);
            this.bt_kurzy.TabIndex = 0;
            this.bt_kurzy.Text = "Kurzy";
            this.bt_kurzy.UseVisualStyleBackColor = false;
            // 
            // app
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1157, 588);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "app";
            this.Text = "ForSport";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bt_kurzy;
        private System.Windows.Forms.Button bt_vysledky;
        private System.Windows.Forms.Button bt_forum;
        private System.Windows.Forms.Button bt_live;
    }
}