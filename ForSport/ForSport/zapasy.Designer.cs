namespace ForSport
{
    partial class zapasy
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
            this.bt_generuj = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_generuj
            // 
            this.bt_generuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_generuj.ForeColor = System.Drawing.Color.Black;
            this.bt_generuj.Location = new System.Drawing.Point(342, 246);
            this.bt_generuj.Name = "bt_generuj";
            this.bt_generuj.Size = new System.Drawing.Size(186, 94);
            this.bt_generuj.TabIndex = 0;
            this.bt_generuj.Text = "Generuj zápasy";
            this.bt_generuj.UseVisualStyleBackColor = true;
            this.bt_generuj.Click += new System.EventHandler(this.bt_generuj_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(597, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 94);
            this.button1.TabIndex = 1;
            this.button1.Text = "Vyhodnoť zápasy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // zapasy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 600);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_generuj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "zapasy";
            this.Text = "zapasy";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_generuj;
        private System.Windows.Forms.Button button1;
    }
}