namespace ForSport
{
    partial class poziadavka
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
            this.bt_accept = new System.Windows.Forms.Button();
            this.bt_deny = new System.Windows.Forms.Button();
            this.lb_user = new System.Windows.Forms.Label();
            this.lb_sprava = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_accept
            // 
            this.bt_accept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(239)))));
            this.bt_accept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_accept.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_accept.ForeColor = System.Drawing.Color.Black;
            this.bt_accept.Location = new System.Drawing.Point(85, 342);
            this.bt_accept.Name = "bt_accept";
            this.bt_accept.Size = new System.Drawing.Size(150, 150);
            this.bt_accept.TabIndex = 1;
            this.bt_accept.Text = "Potvrdiť";
            this.bt_accept.UseVisualStyleBackColor = false;
            this.bt_accept.Click += new System.EventHandler(this.bt_accept_Click);
            // 
            // bt_deny
            // 
            this.bt_deny.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(239)))));
            this.bt_deny.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_deny.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_deny.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_deny.ForeColor = System.Drawing.Color.Black;
            this.bt_deny.Location = new System.Drawing.Point(332, 342);
            this.bt_deny.Name = "bt_deny";
            this.bt_deny.Size = new System.Drawing.Size(150, 150);
            this.bt_deny.TabIndex = 2;
            this.bt_deny.Text = "Nepotvrdiť";
            this.bt_deny.UseVisualStyleBackColor = false;
            this.bt_deny.Click += new System.EventHandler(this.bt_deny_Click);
            // 
            // lb_user
            // 
            this.lb_user.AutoSize = true;
            this.lb_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(239)))));
            this.lb_user.Location = new System.Drawing.Point(58, 54);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(70, 25);
            this.lb_user.TabIndex = 3;
            this.lb_user.Text = "label1";
            // 
            // lb_sprava
            // 
            this.lb_sprava.AutoSize = true;
            this.lb_sprava.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sprava.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(161)))), ((int)(((byte)(62)))));
            this.lb_sprava.Location = new System.Drawing.Point(60, 132);
            this.lb_sprava.Name = "lb_sprava";
            this.lb_sprava.Size = new System.Drawing.Size(51, 20);
            this.lb_sprava.TabIndex = 4;
            this.lb_sprava.Text = "label1";
            // 
            // poziadavka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(562, 537);
            this.Controls.Add(this.lb_sprava);
            this.Controls.Add(this.lb_user);
            this.Controls.Add(this.bt_deny);
            this.Controls.Add(this.bt_accept);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "poziadavka";
            this.Text = "poziadavka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_accept;
        private System.Windows.Forms.Button bt_deny;
        private System.Windows.Forms.Label lb_user;
        private System.Windows.Forms.Label lb_sprava;
    }
}