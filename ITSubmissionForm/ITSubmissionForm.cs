using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITSubmissionForm
{
    public partial class FormCheckIn : Form
    {
        public FormCheckIn()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            //initialize our instances; we should only need one of each;
            Case PresentCase = new Case(rtxtIssueDescription.Text);
            Inventory PresentInventory = new Inventory(txtBrand.Text, txtModel.Text);
            User PresentUser = new User(txtName.Text);
            HelpdeskUser PresentHDUser = new HelpdeskUser(txtName.Text, Convert.ToString(CmbBoxHelpDesk.SelectedItem));


            //record all the entries for the case class
            PresentCase.Tech = txtTech.Text;
            PresentCase.Date = TimeWidget.Value;

            //record all the entires for the inventory class
            PresentInventory.Bag = chkBag.Checked;
            PresentInventory.PowerCord = chkPowerCord.Checked;
            PresentInventory.UsbDrive = chkExternal.Checked;
            PresentInventory.CompactDiscs = chkDiscs.Checked;
            PresentInventory.Mouse = chkMouse.Checked;
            PresentInventory.Keyboard = chkKeyboard.Checked;
            PresentInventory.Other = txtOther.Text;

            //record all the entris for the user class
            if(CmbBoxHelpDesk.SelectedIndex > 0)
            {
                PresentHDUser.Phone1 = txtPhone1.Text;
                PresentHDUser.Phone2 = txtPhone2.Text;
                PresentHDUser.Email = txtEmail.Text;
                PresentHDUser.Address = txtAddress.Text;
                PresentHDUser.Password = txtPassword.Text;
            }
            else
            {
                PresentUser.Phone1 = txtPhone1.Text;
                PresentUser.Phone2 = txtPhone2.Text;
                PresentUser.Email = txtEmail.Text;
                PresentUser.Address = txtAddress.Text;
                PresentUser.Password = txtPassword.Text;
            }

            //the following is just a placeholder for further API/database integration.
            //This just lets you see that it's working, essentially.
            //Not intended for long term use.
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\temp\outputexample.txt", true))
            {
                file.WriteLine("Case ID: " + Convert.ToString(PresentCase.CaseID));
                file.WriteLine("Name: " + PresentUser.Name);
                file.WriteLine("Email: " + PresentUser.Email);
                file.WriteLine("Phone1: " + PresentUser.Phone1);
                file.WriteLine("Phone2: " + PresentUser.Phone2);
                file.WriteLine("Address: " + PresentUser.Address);
                file.WriteLine("Password: " + PresentUser.Password);
                file.WriteLine("Helpdesk User?: " + PresentHDUser.Plan);
                file.WriteLine("Description of Issue:");
                file.WriteLine(PresentCase.Issue);
                file.WriteLine("Technician: " + PresentCase.Tech);
                file.WriteLine("Brand/Model: " + PresentInventory.ComputerBrand + PresentInventory.ComputerModel);
                file.WriteLine("Date & Time: " + Convert.ToString(PresentCase.Date));
                file.WriteLine("Customer dropped off: ");
                if (PresentInventory.Bag)
                {
                    file.WriteLine("Bag");
                }
                if (PresentInventory.PowerCord)
                {
                    file.WriteLine("Power Cord");
                }
                if (PresentInventory.UsbDrive)
                {
                    file.WriteLine("USB Drive");
                }
                if (PresentInventory.CompactDiscs)
                {
                    file.WriteLine("CDs");
                }
                if (PresentInventory.Mouse)
                {
                    file.WriteLine("Mouse");
                }
                if (PresentInventory.Keyboard)
                {
                    file.WriteLine("Keyboard");
                }
                file.WriteLine("\n");
            }

            //submit also clears, so the next user can enter their information
            ClearEntries();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to clear all entries?",
                                     "Confirm Clear",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                ClearEntries();
            }
            else
            {
                //don't do anything
            }
        }

        private void ClearEntries()
        {
            //this should clear all the entries
            txtTech.Text = "";
            rtxtIssueDescription.Text = "";
            chkBag.Checked = false;
            chkPowerCord.Checked = false;
            chkExternal.Checked = false;
            chkDiscs.Checked = false;
            chkMouse.Checked = false;
            chkKeyboard.Checked = false;
            CmbBoxHelpDesk.SelectedIndex = -1;
            txtOther.Text = "Other";
            txtBrand.Text = "";
            txtModel.Text = "";
            txtName.Text = "";
            txtPhone1.Text = "";
            txtPhone2.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            txtPassword.Text = "";
        }
    }
}
