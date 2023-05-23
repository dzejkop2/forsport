namespace ForSport
{
    partial class forum
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
            this.tb_sprava = new System.Windows.Forms.TextBox();
            this.bt_zverejni = new System.Windows.Forms.Button();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_nick = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_post = new System.Windows.Forms.Label();
            this.lb_post_odpoved = new System.Windows.Forms.Label();
            this.lb_cas = new System.Windows.Forms.Label();
            this.lb_cas_odpoved = new System.Windows.Forms.Label();
            this.panel_main.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_sprava
            // 
            this.tb_sprava.Location = new System.Drawing.Point(23, 28);
            this.tb_sprava.Multiline = true;
            this.tb_sprava.Name = "tb_sprava";
            this.tb_sprava.Size = new System.Drawing.Size(475, 75);
            this.tb_sprava.TabIndex = 16;
            // 
            // bt_zverejni
            // 
            this.bt_zverejni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(239)))));
            this.bt_zverejni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_zverejni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_zverejni.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_zverejni.Location = new System.Drawing.Point(530, 48);
            this.bt_zverejni.Name = "bt_zverejni";
            this.bt_zverejni.Size = new System.Drawing.Size(100, 37);
            this.bt_zverejni.TabIndex = 17;
            this.bt_zverejni.Text = "Zverejni";
            this.bt_zverejni.UseVisualStyleBackColor = false;
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.White;
            this.panel_main.Controls.Add(this.panel2);
            this.panel_main.Controls.Add(this.panel1);
            this.panel_main.Location = new System.Drawing.Point(23, 129);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1105, 444);
            this.panel_main.TabIndex = 1000;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(233)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.lb_cas);
            this.panel1.Controls.Add(this.lb_post);
            this.panel1.Controls.Add(this.lb_nick);
            this.panel1.Location = new System.Drawing.Point(8, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 90);
            this.panel1.TabIndex = 0;
            // 
            // lb_nick
            // 
            this.lb_nick.AutoSize = true;
            this.lb_nick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nick.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(124)))), ((int)(((byte)(196)))));
            this.lb_nick.Location = new System.Drawing.Point(3, 10);
            this.lb_nick.Name = "lb_nick";
            this.lb_nick.Size = new System.Drawing.Size(58, 20);
            this.lb_nick.TabIndex = 0;
            this.lb_nick.Text = "lb_nick";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(248)))), ((int)(((byte)(253)))));
            this.panel2.Controls.Add(this.lb_cas_odpoved);
            this.panel2.Controls.Add(this.lb_post_odpoved);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(68, 126);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(407, 90);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(124)))), ((int)(((byte)(196)))));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "lb_nick_odpoved";
            // 
            // lb_post
            // 
            this.lb_post.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(248)))), ((int)(((byte)(253)))));
            this.lb_post.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_post.ForeColor = System.Drawing.Color.Black;
            this.lb_post.Location = new System.Drawing.Point(7, 34);
            this.lb_post.Name = "lb_post";
            this.lb_post.Size = new System.Drawing.Size(446, 43);
            this.lb_post.TabIndex = 1;
            this.lb_post.Text = "lb_post, hadam kazdy pochopil";
            // 
            // lb_post_odpoved
            // 
            this.lb_post_odpoved.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(233)))), ((int)(((byte)(250)))));
            this.lb_post_odpoved.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_post_odpoved.ForeColor = System.Drawing.Color.Black;
            this.lb_post_odpoved.Location = new System.Drawing.Point(5, 33);
            this.lb_post_odpoved.Name = "lb_post_odpoved";
            this.lb_post_odpoved.Size = new System.Drawing.Size(388, 42);
            this.lb_post_odpoved.TabIndex = 2;
            this.lb_post_odpoved.Text = "lb_post_odpoved, hadam kazdy pochopil";
            // 
            // lb_cas
            // 
            this.lb_cas.AutoSize = true;
            this.lb_cas.ForeColor = System.Drawing.Color.Black;
            this.lb_cas.Location = new System.Drawing.Point(415, 10);
            this.lb_cas.Name = "lb_cas";
            this.lb_cas.Size = new System.Drawing.Size(38, 13);
            this.lb_cas.TabIndex = 2;
            this.lb_cas.Text = "lb_cas";
            // 
            // lb_cas_odpoved
            // 
            this.lb_cas_odpoved.AutoSize = true;
            this.lb_cas_odpoved.ForeColor = System.Drawing.Color.Black;
            this.lb_cas_odpoved.Location = new System.Drawing.Point(318, 4);
            this.lb_cas_odpoved.Name = "lb_cas_odpoved";
            this.lb_cas_odpoved.Size = new System.Drawing.Size(86, 13);
            this.lb_cas_odpoved.TabIndex = 3;
            this.lb_cas_odpoved.Text = "lb_cas_odpoved";
            // 
            // forum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 600);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.bt_zverejni);
            this.Controls.Add(this.tb_sprava);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "forum";
            this.Text = "forum";
            this.panel_main.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_sprava;
        private System.Windows.Forms.Button bt_zverejni;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_nick;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_cas_odpoved;
        private System.Windows.Forms.Label lb_post_odpoved;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_cas;
        private System.Windows.Forms.Label lb_post;
    }
}