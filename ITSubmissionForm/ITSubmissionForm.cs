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
            Case PresentCase = new Case(rtxtIssueDescription.Text);
            Inventory PresentInventory = new Inventory(txtBrand.Text, txtModel.Text);
            User PresentUser = new User(txtName.Text);

            PresentCase.Tech = txtTech.Text;
            PresentCase.Date = Convert.ToString(CalendarWidget.SelectionStart);
            PresentCase.Time = txtTime.Text;

            txtTech.Text = "";
            txtTime.Text = "";
            rtxtIssueDescription.Text = "";

            PresentInventory.Bag = chkBag.Checked;
            PresentInventory.PowerCord = chkPowerCord.Checked;
            PresentInventory.UsbDrive = chkExternal.Checked;
            PresentInventory.CompactDiscs = chkDiscs.Checked;
            PresentInventory.Mouse = chkMouse.Checked;
            PresentInventory.Keyboard = chkKeyboard.Checked;
            PresentInventory.Other = txtOther.Text;

            chkBag.Checked = false;
            chkPowerCord.Checked = false;
            chkExternal.Checked = false;
            chkDiscs.Checked = false;
            chkMouse.Checked = false;
            chkKeyboard.Checked = false;
            txtOther.Text = "";
            txtBrand.Text = "";
            txtModel.Text = "";

            PresentUser.Phone1 = txtPhone1.Text;
            PresentUser.Phone2 = txtPhone2.Text;
            PresentUser.Email = txtEmail.Text;
            PresentUser.Address = txtAddress.Text;
            PresentUser.Password = txtPassword.Text;

            txtName.Text = "";
            txtPhone1.Text = "";
            txtPhone2.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            txtPassword.Text = "";

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\temp\outputexample.txt", true))
            {
                file.WriteLine("Case ID: " + Convert.ToString(PresentCase.CaseID));
                file.WriteLine("Name: " + PresentUser.Name);
                file.WriteLine("Email: " + PresentUser.Email);
                file.WriteLine("Phone1: " + PresentUser.Phone1);
                file.WriteLine("Phone2: " + PresentUser.Phone2);
                file.WriteLine("Address: " + PresentUser.Address);
                file.WriteLine("Password: " + PresentUser.Password);
                file.WriteLine("Description of Issue:");
                file.WriteLine(PresentCase.Issue);
                file.WriteLine("Technician: " + PresentCase.Tech);
                file.WriteLine("Brand/Model: " + PresentInventory.ComputerBrand + PresentInventory.ComputerModel);
                file.WriteLine("Date: " + PresentCase.Date);
                file.WriteLine("Time: " + PresentCase.Time);
                file.WriteLine("Customer dropped off: ");
                if (PresentInventory.Bag)
                {
                    file.Write("Bag, ");
                }
                if (PresentInventory.PowerCord)
                {
                    file.Write("Power Cord, ");
                }
                if (PresentInventory.UsbDrive)
                {
                    file.Write("USB Drive, ");
                }
                if (PresentInventory.CompactDiscs)
                {
                    file.Write("CDs, ");
                }
                if (PresentInventory.Mouse)
                {
                    file.Write("Mouse, ");
                }
                if (PresentInventory.Keyboard)
                {
                    file.Write("Keyboard, ");
                }
                file.WriteLine("\n");
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtTech.Text = "";
            txtTime.Text = "";
            rtxtIssueDescription.Text = "";
            chkBag.Checked = false;
            chkPowerCord.Checked = false;
            chkExternal.Checked = false;
            chkDiscs.Checked = false;
            chkMouse.Checked = false;
            chkKeyboard.Checked = false;
            txtOther.Text = "";
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
