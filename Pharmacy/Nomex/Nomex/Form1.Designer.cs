﻿
namespace Nomex
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BasePanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.DosageLabel = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.UserPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.NewUserButton = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.MedicineBagPanel = new System.Windows.Forms.Panel();
            this.MedicineBagTable = new System.Windows.Forms.DataGridView();
            this.Medicine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClearMedicinesButton = new System.Windows.Forms.Button();
            this.NewMedicineButton = new System.Windows.Forms.Button();
            this.BasePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.UserPanel.SuspendLayout();
            this.MedicineBagPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MedicineBagTable)).BeginInit();
            this.SuspendLayout();
            // 
            // BasePanel
            // 
            this.BasePanel.Controls.Add(this.panel1);
            this.BasePanel.Controls.Add(this.UserPanel);
            this.BasePanel.Controls.Add(this.MedicineBagPanel);
            this.BasePanel.Location = new System.Drawing.Point(12, 12);
            this.BasePanel.Name = "BasePanel";
            this.BasePanel.Size = new System.Drawing.Size(1240, 657);
            this.BasePanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.DosageLabel);
            this.panel1.Controls.Add(this.richTextBox2);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Location = new System.Drawing.Point(674, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 469);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Aprašymas ";
            // 
            // DosageLabel
            // 
            this.DosageLabel.AutoSize = true;
            this.DosageLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DosageLabel.Location = new System.Drawing.Point(13, 11);
            this.DosageLabel.Name = "DosageLabel";
            this.DosageLabel.Size = new System.Drawing.Size(98, 19);
            this.DosageLabel.TabIndex = 3;
            this.DosageLabel.Text = "Kada vartoti?";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox2.Location = new System.Drawing.Point(13, 33);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(530, 112);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(13, 170);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(530, 299);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // UserPanel
            // 
            this.UserPanel.Controls.Add(this.button1);
            this.UserPanel.Controls.Add(this.NewUserButton);
            this.UserPanel.Controls.Add(this.NameLabel);
            this.UserPanel.Location = new System.Drawing.Point(674, 24);
            this.UserPanel.Name = "UserPanel";
            this.UserPanel.Size = new System.Drawing.Size(543, 134);
            this.UserPanel.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(412, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 52);
            this.button1.TabIndex = 5;
            this.button1.Text = "Išsaugoti krepšelį";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // NewUserButton
            // 
            this.NewUserButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NewUserButton.Location = new System.Drawing.Point(13, 17);
            this.NewUserButton.Name = "NewUserButton";
            this.NewUserButton.Size = new System.Drawing.Size(139, 31);
            this.NewUserButton.TabIndex = 1;
            this.NewUserButton.Text = "Įvesti vartotojo kodą";
            this.NewUserButton.UseVisualStyleBackColor = true;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameLabel.Location = new System.Drawing.Point(13, 58);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(203, 41);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name (15646)";
            // 
            // MedicineBagPanel
            // 
            this.MedicineBagPanel.Controls.Add(this.MedicineBagTable);
            this.MedicineBagPanel.Controls.Add(this.ClearMedicinesButton);
            this.MedicineBagPanel.Controls.Add(this.NewMedicineButton);
            this.MedicineBagPanel.Location = new System.Drawing.Point(24, 24);
            this.MedicineBagPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MedicineBagPanel.Name = "MedicineBagPanel";
            this.MedicineBagPanel.Size = new System.Drawing.Size(647, 609);
            this.MedicineBagPanel.TabIndex = 0;
            // 
            // MedicineBagTable
            // 
            this.MedicineBagTable.AllowUserToAddRows = false;
            this.MedicineBagTable.AllowUserToDeleteRows = false;
            this.MedicineBagTable.AllowUserToResizeColumns = false;
            this.MedicineBagTable.AllowUserToResizeRows = false;
            this.MedicineBagTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MedicineBagTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MedicineBagTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Medicine,
            this.Barcode,
            this.Price});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MedicineBagTable.DefaultCellStyle = dataGridViewCellStyle1;
            this.MedicineBagTable.Location = new System.Drawing.Point(15, 58);
            this.MedicineBagTable.Name = "MedicineBagTable";
            this.MedicineBagTable.ReadOnly = true;
            this.MedicineBagTable.RowHeadersVisible = false;
            this.MedicineBagTable.RowHeadersWidth = 4;
            this.MedicineBagTable.RowTemplate.Height = 25;
            this.MedicineBagTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MedicineBagTable.Size = new System.Drawing.Size(606, 551);
            this.MedicineBagTable.TabIndex = 3;
            // 
            // Medicine
            // 
            this.Medicine.HeaderText = "Pavadinimas";
            this.Medicine.Name = "Medicine";
            this.Medicine.ReadOnly = true;
            // 
            // Barcode
            // 
            this.Barcode.FillWeight = 50F;
            this.Barcode.HeaderText = "Prekės kodas";
            this.Barcode.Name = "Barcode";
            this.Barcode.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.FillWeight = 20F;
            this.Price.HeaderText = "Kaina";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // ClearMedicinesButton
            // 
            this.ClearMedicinesButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClearMedicinesButton.Location = new System.Drawing.Point(177, 17);
            this.ClearMedicinesButton.Name = "ClearMedicinesButton";
            this.ClearMedicinesButton.Size = new System.Drawing.Size(125, 31);
            this.ClearMedicinesButton.TabIndex = 2;
            this.ClearMedicinesButton.Text = "Išvalyti krepšelį";
            this.ClearMedicinesButton.UseVisualStyleBackColor = true;
            this.ClearMedicinesButton.Click += new System.EventHandler(this.ClearMedicinesButton_Click);
            // 
            // NewMedicineButton
            // 
            this.NewMedicineButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.NewMedicineButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NewMedicineButton.Location = new System.Drawing.Point(15, 17);
            this.NewMedicineButton.Margin = new System.Windows.Forms.Padding(5);
            this.NewMedicineButton.Name = "NewMedicineButton";
            this.NewMedicineButton.Size = new System.Drawing.Size(125, 31);
            this.NewMedicineButton.TabIndex = 0;
            this.NewMedicineButton.Text = "Pridėti vaistą";
            this.NewMedicineButton.UseVisualStyleBackColor = false;
            this.NewMedicineButton.Click += new System.EventHandler(this.NewMedicineButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.BasePanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nomex";
            this.BasePanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.UserPanel.ResumeLayout(false);
            this.UserPanel.PerformLayout();
            this.MedicineBagPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MedicineBagTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BasePanel;
        private System.Windows.Forms.Panel MedicineBagPanel;
        private System.Windows.Forms.Button NewMedicineButton;
        private System.Windows.Forms.Panel UserPanel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button ClearMedicinesButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DosageLabel;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button NewUserButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView MedicineBagTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medicine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}

