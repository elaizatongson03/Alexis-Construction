using System;

namespace AlexConstruction
{
    partial class Login
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
            this.alexconstructionlbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.usernametxtfield = new System.Windows.Forms.TextBox();
            this.passtxtfield = new System.Windows.Forms.TextBox();
            this.usernamelbl = new System.Windows.Forms.Label();
            this.passlbl = new System.Windows.Forms.Label();
            this.loginbtn = new System.Windows.Forms.Button();
            this.Resetlbl = new System.Windows.Forms.Label();
            this.exitlbl = new System.Windows.Forms.Label();
            this.workerpic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.workerpic)).BeginInit();
            this.SuspendLayout();
            // 
            // alexconstructionlbl
            // 
            this.alexconstructionlbl.AutoSize = true;
            this.alexconstructionlbl.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alexconstructionlbl.Location = new System.Drawing.Point(277, 99);
            this.alexconstructionlbl.Name = "alexconstructionlbl";
            this.alexconstructionlbl.Size = new System.Drawing.Size(280, 40);
            this.alexconstructionlbl.TabIndex = 0;
            this.alexconstructionlbl.Text = "Alexis Construction";
            this.alexconstructionlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 493);
            this.panel1.TabIndex = 1;
            // 
            // usernametxtfield
            // 
            this.usernametxtfield.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametxtfield.Location = new System.Drawing.Point(254, 199);
            this.usernametxtfield.Multiline = true;
            this.usernametxtfield.Name = "usernametxtfield";
            this.usernametxtfield.PasswordChar = '*';
            this.usernametxtfield.Size = new System.Drawing.Size(305, 37);
            this.usernametxtfield.TabIndex = 3;
            this.usernametxtfield.UseSystemPasswordChar = true;
            this.usernametxtfield.TextChanged += new System.EventHandler(this.usernametxtfield_TextChanged);
            // 
            // passtxtfield
            // 
            this.passtxtfield.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passtxtfield.Location = new System.Drawing.Point(254, 297);
            this.passtxtfield.Multiline = true;
            this.passtxtfield.Name = "passtxtfield";
            this.passtxtfield.Size = new System.Drawing.Size(305, 37);
            this.passtxtfield.TabIndex = 4;
            this.passtxtfield.UseSystemPasswordChar = true;
            this.passtxtfield.TextChanged += new System.EventHandler(this.passtxtfield_TextChanged);
            // 
            // usernamelbl
            // 
            this.usernamelbl.AutoSize = true;
            this.usernamelbl.BackColor = System.Drawing.Color.Transparent;
            this.usernamelbl.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelbl.ForeColor = System.Drawing.Color.Black;
            this.usernamelbl.Location = new System.Drawing.Point(249, 169);
            this.usernamelbl.Name = "usernamelbl";
            this.usernamelbl.Size = new System.Drawing.Size(110, 28);
            this.usernamelbl.TabIndex = 6;
            this.usernamelbl.Text = "Username";
            // 
            // passlbl
            // 
            this.passlbl.AutoSize = true;
            this.passlbl.BackColor = System.Drawing.Color.Transparent;
            this.passlbl.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passlbl.ForeColor = System.Drawing.Color.Black;
            this.passlbl.Location = new System.Drawing.Point(249, 267);
            this.passlbl.Name = "passlbl";
            this.passlbl.Size = new System.Drawing.Size(102, 28);
            this.passlbl.TabIndex = 7;
            this.passlbl.Text = "Password";
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.Color.Black;
            this.loginbtn.FlatAppearance.BorderSize = 0;
            this.loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginbtn.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.ForeColor = System.Drawing.Color.Lime;
            this.loginbtn.Location = new System.Drawing.Point(333, 363);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(151, 42);
            this.loginbtn.TabIndex = 8;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // Resetlbl
            // 
            this.Resetlbl.BackColor = System.Drawing.Color.Black;
            this.Resetlbl.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resetlbl.ForeColor = System.Drawing.Color.Red;
            this.Resetlbl.Location = new System.Drawing.Point(333, 429);
            this.Resetlbl.Name = "Resetlbl";
            this.Resetlbl.Size = new System.Drawing.Size(151, 42);
            this.Resetlbl.TabIndex = 9;
            this.Resetlbl.Text = "Reset";
            this.Resetlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitlbl
            // 
            this.exitlbl.BackColor = System.Drawing.Color.Transparent;
            this.exitlbl.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitlbl.ForeColor = System.Drawing.Color.Black;
            this.exitlbl.Location = new System.Drawing.Point(582, 9);
            this.exitlbl.Name = "exitlbl";
            this.exitlbl.Size = new System.Drawing.Size(39, 42);
            this.exitlbl.TabIndex = 10;
            this.exitlbl.Text = "X";
            this.exitlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // workerpic
            // 
            this.workerpic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.workerpic.Image = global::AlexConstruction.Properties.Resources.worker;
            this.workerpic.Location = new System.Drawing.Point(373, 27);
            this.workerpic.Name = "workerpic";
            this.workerpic.Size = new System.Drawing.Size(64, 69);
            this.workerpic.TabIndex = 2;
            this.workerpic.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(633, 493);
            this.Controls.Add(this.exitlbl);
            this.Controls.Add(this.Resetlbl);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.passlbl);
            this.Controls.Add(this.usernamelbl);
            this.Controls.Add(this.passtxtfield);
            this.Controls.Add(this.usernametxtfield);
            this.Controls.Add(this.workerpic);
            this.Controls.Add(this.alexconstructionlbl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.workerpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label alexconstructionlbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox workerpic;
        private System.Windows.Forms.TextBox usernametxtfield;
        private System.Windows.Forms.TextBox passtxtfield;
        private System.Windows.Forms.Label usernamelbl;
        private System.Windows.Forms.Label passlbl;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Label Resetlbl;
        private System.Windows.Forms.Label exitlbl;
        private readonly EventHandler passtxtfield_TextChanged;
    }
}

