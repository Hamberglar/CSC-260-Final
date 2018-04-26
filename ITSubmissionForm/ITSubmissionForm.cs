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

            PresentInventory.Bag = Convert.ToBoolean(chkBag.CheckState);
            PresentInventory.PowerCord = Convert.ToBoolean(chkPowerCord.CheckState);
            PresentInventory.UsbDrive = Convert.ToBoolean(chkExternal.CheckState);
            PresentInventory.CompactDiscs = Convert.ToBoolean(chkDiscs.CheckState);
            PresentInventory.Mouse = Convert.ToBoolean(chkMouse.CheckState);
            PresentInventory.Keyboard = Convert.ToBoolean(chkKeyboard.CheckState);

            PresentUser.Phone1 = txtPhone1.Text;
            PresentUser.Phone2 = txtPhone2.Text;
            PresentUser.Email = txtEmail.Text;
            PresentUser.Address = txtAddress.Text;
            PresentUser.Password = txtPassword.Text;

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
            }
        }
    }
}
