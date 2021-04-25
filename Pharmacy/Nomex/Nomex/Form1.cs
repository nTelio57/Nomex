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

namespace Nomex
{
    public partial class Form1 : Form
    {
        public APIControl ApiControl;
        public Form1()
        {
            InitializeComponent();
            ApiControl = new APIControl();
        }

        private void NewMedicineButton_Click(object sender, EventArgs e)
        {
            Form modal = new AddMedicineDialog(this);
            modal.ShowDialog();
        }

        public void AddMedicineManually(Medicine medicine)
        {
            MedicineBagTable.Rows.Add( medicine.Name, medicine.Barcode, medicine.Price);
        }

        private void ClearMedicinesButton_Click(object sender, EventArgs e)
        {
            MedicineBagTable.Rows.Clear();
        }
    }
}
