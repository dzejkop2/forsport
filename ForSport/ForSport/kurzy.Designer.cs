namespace ForSport
{
    partial class kurzy
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_vysledok = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_kurzvysledok = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(662, 504);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 98);
            this.label1.TabIndex = 5;
            this.label1.Text = "TOTO BUDU KURZY (KEBY VAM TO NEDOPLO)";
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.White;
            this.panel_main.Location = new System.Drawing.Point(12, 12);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(831, 489);
            this.panel_main.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_kurzvysledok);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lb_vysledok);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(864, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 489);
            this.panel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(22, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Vysledok";
            // 
            // lb_vysledok
            // 
            this.lb_vysledok.AutoSize = true;
            this.lb_vysledok.Location = new System.Drawing.Point(133, 30);
            this.lb_vysledok.Name = "lb_vysledok";
            this.lb_vysledok.Size = new System.Drawing.Size(35, 13);
            this.lb_vysledok.TabIndex = 1;
            this.lb_vysledok.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(22, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kurz";
            // 
            // lb_kurzvysledok
            // 
            this.lb_kurzvysledok.AutoSize = true;
            this.lb_kurzvysledok.Location = new System.Drawing.Point(133, 115);
            this.lb_kurzvysledok.Name = "lb_kurzvysledok";
            this.lb_kurzvysledok.Size = new System.Drawing.Size(35, 13);
            this.lb_kurzvysledok.TabIndex = 3;
            this.lb_kurzvysledok.Text = "label3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(194, 523);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // kurzy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 600);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "kurzy";
            this.Text = "kurzy";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_kurzvysledok;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_vysledok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}