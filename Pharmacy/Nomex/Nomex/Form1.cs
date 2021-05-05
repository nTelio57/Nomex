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
using System.Runtime.InteropServices;

namespace Nomex
{
    public partial class Form1 : Form
    {
        public APIControl ApiControl;
        private List<Recipe> recipeList;
        private User currentUser;
        private int selectedIndex = -1;
        public Form1()
        {
            recipeList = new List<Recipe>();
            AllocConsole();
            InitializeComponent();
            ApiControl = new APIControl();
            SetupDosageComboBox();
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        private void NewMedicineButton_Click(object sender, EventArgs e)
        {
            Form modal = new AddMedicineDialog(this);
            modal.ShowDialog();
        }

        public void AddMedicineManually(Medicine medicine)
        {
            var recipe = new Recipe { MedicineId = medicine.Id, UsageId = medicine.usageTemplate.Id, Usage = medicine.usageTemplate, Medicine = medicine};
            recipeList.Add(recipe);

            MedicineBagTable.Rows.Add( medicine.Name, medicine.Barcode, medicine.Price);
            SetUsageView(medicine, medicine.usageTemplate);
        }

        private void ClearMedicinesButton_Click(object sender, EventArgs e)
        {
            ClearRecipes();
            ClearUsage();
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

            selectedIndex = e.RowIndex;

            SetUsageView(recipeList[selectedIndex].Medicine, recipeList[selectedIndex].Usage);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentUser != null)
            {
                ApiControl.PostRecipeListToUser(currentUser, recipeList);
                ClearRecipes();
                ClearCurrentUser();
                ClearUsage();
            }
            
        }

        private void MedicineBagTable_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            Console.WriteLine("eegeg "+MedicineBagTable.SelectedRows[0].Index);
        }

        private void NewUserButton_Click(object sender, EventArgs e)
        {
            Form modal = new AddUserDialog(this);
            modal.ShowDialog();
        }

        public void SetCurrentUser(User user)
        {
            currentUser = user;
            NameLabel.Text = $"{user.Name} ({user.PersonalCode})";
        }

        private void ClearCurrentUser()
        {
            currentUser = null;
            NameLabel.Text = "Laukiama vartotojo";
        }

        private void ClearRecipes()
        {
            selectedIndex = -1;
            MedicineBagTable.Rows.Clear();
            recipeList.Clear();
        }

        private void ClearUsage()
        {
            MedicineTitleLabel.Text = "";
            DosageComboBox.SelectedIndex = -1;
            UsageDescriptionText.Text = "";
        }

        private void UsageDescriptionText_TextChanged(object sender, EventArgs e)
        {
            if (selectedIndex == -1)
                return;

            recipeList[selectedIndex].Usage.Description = UsageDescriptionText.Text;
        }

        private void DosageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedIndex == -1)
                return;
            
            recipeList[selectedIndex].Usage.Dosage = (Dosage) DosageComboBox.SelectedIndex;

        }
    }
}
