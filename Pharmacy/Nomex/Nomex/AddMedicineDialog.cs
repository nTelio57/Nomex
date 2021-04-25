using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nomex
{
    public partial class AddMedicineDialog : Form
    {
        private Form1 _parentForm;
        public AddMedicineDialog()
        {
            InitializeComponent();
        }

        public AddMedicineDialog(Form1 parent)
        {
            InitializeComponent();
            _parentForm = parent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Medicine medicine = _parentForm.ApiControl.GetMedicineByBarcode(MedicineBarcodeText.Text);
            if (medicine != null)
            {
                _parentForm.AddMedicineManually(medicine);
                Close();
            }
            else
            {
                errorProvider1.SetError(label1, "Prekės kodas nerastas");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
