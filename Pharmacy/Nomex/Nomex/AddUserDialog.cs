using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nomex.Models;

namespace Nomex
{
    public partial class AddUserDialog : Form
    {
        private Form1 _parentForm;
        public AddUserDialog(Form1 parent)
        {
            InitializeComponent();
            _parentForm = parent;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = _parentForm.ApiControl.GetUserByCode(UserPersonalCode.Text);
            if (user != null)
            {
                _parentForm.SetCurrentUser(user);
                Close();
            }
            else
            {
                //label2.Visible = true;
                //errorProvider1.SetError(label1, "Prekės kodas nerastas");
                Console.WriteLine(user);
            }
        }
    }
}
