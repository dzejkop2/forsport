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
            this.button1 = new System.Windows.Forms.Button();
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
            this.panel_main.Location = new System.Drawing.Point(171, 12);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(831, 489);
            this.panel_main.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 519);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 49);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kurzy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 600);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "kurzy";
            this.Text = "kurzy";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Button button1;
    }
}