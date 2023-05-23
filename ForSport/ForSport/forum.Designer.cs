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
            this.panel_main.Location = new System.Drawing.Point(23, 129);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1105, 444);
            this.panel_main.TabIndex = 1000;
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_sprava;
        private System.Windows.Forms.Button bt_zverejni;
        private System.Windows.Forms.Panel panel_main;
    }
}