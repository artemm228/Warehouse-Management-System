namespace Warehouse_Management_System
{
    partial class Form_Registration
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
            this.lblogin = new System.Windows.Forms.Label();
            this.btnsign = new System.Windows.Forms.Button();
            this.tbnewpassword = new System.Windows.Forms.TextBox();
            this.tbsurname = new System.Windows.Forms.TextBox();
            this.tbname = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbRegister = new System.Windows.Forms.Label();
            this.lbclose = new System.Windows.Forms.Label();
            this.btnmask = new System.Windows.Forms.Button();
            this.tbnewlogin = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.lblogin);
            this.panel1.Controls.Add(this.btnsign);
            this.panel1.Controls.Add(this.tbsurname);
            this.panel1.Controls.Add(this.tbname);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnmask);
            this.panel1.Controls.Add(this.tbnewlogin);
            this.panel1.Controls.Add(this.tbnewpassword);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 366);
            this.panel1.TabIndex = 0;
            // 
            // lblogin
            // 
            this.lblogin.AutoSize = true;
            this.lblogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblogin.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblogin.Location = new System.Drawing.Point(283, 343);
            this.lblogin.Name = "lblogin";
            this.lblogin.Size = new System.Drawing.Size(49, 16);
            this.lblogin.TabIndex = 11;
            this.lblogin.Text = "Log in?";
            this.lblogin.Click += new System.EventHandler(this.lblogin_Click);
            // 
            // btnsign
            // 
            this.btnsign.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnsign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsign.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnsign.Location = new System.Drawing.Point(206, 304);
            this.btnsign.Name = "btnsign";
            this.btnsign.Size = new System.Drawing.Size(213, 36);
            this.btnsign.TabIndex = 7;
            this.btnsign.Text = "Sign Up";
            this.btnsign.UseVisualStyleBackColor = false;
            this.btnsign.Click += new System.EventHandler(this.btnsign_Click);
            // 
            // tbnewpassword
            // 
            this.tbnewpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbnewpassword.Location = new System.Drawing.Point(376, 262);
            this.tbnewpassword.MaxLength = 24;
            this.tbnewpassword.Multiline = true;
            this.tbnewpassword.Name = "tbnewpassword";
            this.tbnewpassword.Size = new System.Drawing.Size(213, 30);
            this.tbnewpassword.TabIndex = 6;
            this.tbnewpassword.Enter += new System.EventHandler(this.tbnewpassword_Enter);
            this.tbnewpassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbnewpassword_KeyPress);
            this.tbnewpassword.Leave += new System.EventHandler(this.tbnewpassword_Leave);
            // 
            // tbsurname
            // 
            this.tbsurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbsurname.Location = new System.Drawing.Point(376, 210);
            this.tbsurname.MaxLength = 29;
            this.tbsurname.Multiline = true;
            this.tbsurname.Name = "tbsurname";
            this.tbsurname.Size = new System.Drawing.Size(213, 30);
            this.tbsurname.TabIndex = 5;
            this.tbsurname.Enter += new System.EventHandler(this.tbsurname_Enter);
            this.tbsurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbsurname_KeyPress);
            this.tbsurname.Leave += new System.EventHandler(this.tbsurname_Leave);
            // 
            // tbname
            // 
            this.tbname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbname.Location = new System.Drawing.Point(31, 209);
            this.tbname.MaxLength = 29;
            this.tbname.Multiline = true;
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(213, 30);
            this.tbname.TabIndex = 3;
            this.tbname.Enter += new System.EventHandler(this.tbname_Enter);
            this.tbname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbname_KeyPress);
            this.tbname.Leave += new System.EventHandler(this.tbname_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Warehouse_Management_System.Properties.Resources.add_user;
            this.pictureBox1.Location = new System.Drawing.Point(236, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.lbRegister);
            this.panel2.Controls.Add(this.lbclose);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(627, 54);
            this.panel2.TabIndex = 0;
            // 
            // lbRegister
            // 
            this.lbRegister.AutoSize = true;
            this.lbRegister.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbRegister.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbRegister.Location = new System.Drawing.Point(230, 11);
            this.lbRegister.Name = "lbRegister";
            this.lbRegister.Size = new System.Drawing.Size(174, 31);
            this.lbRegister.TabIndex = 2;
            this.lbRegister.Text = "Register Form";
            // 
            // lbclose
            // 
            this.lbclose.AutoSize = true;
            this.lbclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbclose.Location = new System.Drawing.Point(600, 0);
            this.lbclose.Name = "lbclose";
            this.lbclose.Size = new System.Drawing.Size(27, 25);
            this.lbclose.TabIndex = 1;
            this.lbclose.Text = "X";
            this.lbclose.Click += new System.EventHandler(this.lbclose_Click);
            // 
            // btnmask
            // 
            this.btnmask.BackColor = System.Drawing.SystemColors.Info;
            this.btnmask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmask.Image = global::Warehouse_Management_System.Properties.Resources.hide;
            this.btnmask.Location = new System.Drawing.Point(550, 263);
            this.btnmask.Name = "btnmask";
            this.btnmask.Size = new System.Drawing.Size(38, 28);
            this.btnmask.TabIndex = 9;
            this.btnmask.UseVisualStyleBackColor = false;
            this.btnmask.Click += new System.EventHandler(this.btnmask_Click);
            // 
            // tbnewlogin
            // 
            this.tbnewlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbnewlogin.Location = new System.Drawing.Point(31, 263);
            this.tbnewlogin.MaxLength = 24;
            this.tbnewlogin.Multiline = true;
            this.tbnewlogin.Name = "tbnewlogin";
            this.tbnewlogin.Size = new System.Drawing.Size(213, 30);
            this.tbnewlogin.TabIndex = 4;
            this.tbnewlogin.Enter += new System.EventHandler(this.tbnewlogin_Enter);
            this.tbnewlogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbnewlogin_KeyPress);
            this.tbnewlogin.Leave += new System.EventHandler(this.tbnewlogin_Leave);
            // 
            // Form_Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 369);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Registration";
            this.Text = "Form_Registration";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbclose;
        private System.Windows.Forms.Label lbRegister;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbnewpassword;
        private System.Windows.Forms.TextBox tbsurname;
        private System.Windows.Forms.TextBox tbnewlogin;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Button btnsign;
        private System.Windows.Forms.Button btnmask;
        private System.Windows.Forms.Label lblogin;
    }
}