using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nomex.Models;
using Nomex.Utilities;

namespace Nomex
{
    public partial class Form1 : Form
    {
        public APIControl ApiControl;
        public Form1()
        {
            InitializeComponent();
            ApiControl = new APIControl();
            SetupDosageComboBox();
        }

        private void NewMedicineButton_Click(object sender, EventArgs e)
        {
            Form modal = new AddMedicineDialog(this);
            modal.ShowDialog();
        }

        public void AddMedicineManually(Medicine medicine)
        {
            MedicineBagTable.Rows.Add( medicine.Name, medicine.Barcode, medicine.Price);
            SetUsageView(medicine, medicine.usageTemplate);
        }

        private void ClearMedicinesButton_Click(object sender, EventArgs e)
        {
            MedicineBagTable.Rows.Clear();
        }

        void SetupDosageComboBox()
        {
            foreach (var dosage in Util.GetValues<Dosage>())
            {
                DosageComboBox.Items.Add(dosage.ToString());
            }
        }

        void SetUsageView(Medicine medicine, Usage usage)
        {
            MedicineTitleLabel.Text = medicine.Name;
            DosageComboBox.SelectedIndex = (int)usage.Dosage;
            UsageDescriptionText.Text = usage.Description;
        }

        private void MedicineBagTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            DataGridViewCellCollection cells = MedicineBagTable.SelectedRows[0].Cells;
            string asmensKodas = cells[0].Value + "";
            SetPersonsWindow(long.Parse(asmensKodas));
        }
    }
}
