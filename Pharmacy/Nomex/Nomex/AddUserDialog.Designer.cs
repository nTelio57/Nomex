
namespace Nomex
{
    partial class AddUserDialog
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
            this.UserPersonalCode = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserPersonalCode
            // 
            this.UserPersonalCode.Location = new System.Drawing.Point(38, 47);
            this.UserPersonalCode.Name = "UserPersonalCode";
            this.UserPersonalCode.PlaceholderText = "Vartotojo kodas";
            this.UserPersonalCode.Size = new System.Drawing.Size(302, 23);
            this.UserPersonalCode.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Patvirtinti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(214, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 39);
            this.button2.TabIndex = 2;
            this.button2.Text = "Atšaukti";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddUserDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 191);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UserPersonalCode);
            this.Name = "AddUserDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Įvesti vartotojo kodą";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserPersonalCode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}