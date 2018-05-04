using System;
using System.Windows.Forms;

namespace ITSubmissionForm
{
    public partial class FormCheckIn : Form
    {
        public FormCheckIn()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            //initialize
            Case presentCase = new Case(txtTech.Text, rtxtIssueDescription.Text, TimeWidget.Value);
            Inventory presentInventory = new Inventory(txtBrand.Text, txtModel.Text, chkBag.Checked, chkPowerCord.Checked, chkExternal.Checked, chkDiscs.Checked, chkKeyboard.Checked, chkMouse.Checked, txtOther.Text);
            User presentUser = new User(txtName.Text, txtPassword.Text, txtPhone1.Text, txtPhone2.Text, txtEmail.Text, txtAddress.Text);
            HelpdeskUser presentHDUser = new HelpdeskUser(txtName.Text, txtPassword.Text, txtPhone1.Text, txtPhone2.Text, txtEmail.Text, txtAddress.Text);
            //Right now, there's really not much of a difference between User and HDUser, except that HDUser is bigger.
            //It's something I'd like to have expanded on if I had more time to think about ways to differentiate them in the main.
            //One thing I'm missing is how to pass objects into a function or instantiate objects and have them available outside of the function they were made in.

            //To demonstrate, we initialized an object for both user and hduser previously, but they're the same until we get to this part:
            if (cmbBoxHelpDesk.SelectedIndex >= 0)
            {
                presentHDUser.Organization = presentHDUser.UpdateDetails(cmbBoxHelpDesk.SelectedText);
            }

            /*the following is just a placeholder for further API/database integration.
            This just lets you see that it's working, essentially.
            Not intended for long term use.*/
            if (txtName.Text != "")
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\temp\outputexample.txt", true))
                {
                    file.WriteLine("Case ID: " + Convert.ToString(presentCase.ID));
                    file.WriteLine("Name: " + presentUser.Name);
                    file.WriteLine("Email: " + presentUser.Email);
                    file.WriteLine("Phone1: " + presentUser.Phone1);
                    file.WriteLine("Phone2: " + presentUser.Phone2);
                    file.WriteLine("Address: " + presentUser.Address);
                    file.WriteLine("Password: " + presentUser.Password);
                    file.WriteLine("Helpdesk User?: " + presentHDUser.Plan);
                    file.WriteLine("Organization: " + presentHDUser.Organization);
                    file.WriteLine("Description of Issue:");
                    file.WriteLine(presentCase.Issue);
                    file.WriteLine("Technician: " + presentCase.Tech);
                    file.WriteLine("Brand/Model: " + presentInventory.Brand + presentInventory.Model);
                    file.WriteLine("Date & Time: " + Convert.ToString(presentCase.Date));
                    file.WriteLine("Customer dropped off: ");
                    if (presentInventory.Bag)
                    {
                        file.WriteLine("Bag");
                    }
                    if (presentInventory.PowerCord)
                    {
                        file.WriteLine("Power Cord");
                    }
                    if (presentInventory.UsbDrive)
                    {
                        file.WriteLine("USB Drive");
                    }
                    if (presentInventory.CompactDiscs)
                    {
                        file.WriteLine("CDs");
                    }
                    if (presentInventory.Mouse)
                    {
                        file.WriteLine("Mouse");
                    }
                    if (presentInventory.Keyboard)
                    {
                        file.WriteLine("Keyboard");
                    }
                    file.WriteLine("\n");
                }
            }

            else
            {
                //Display an error message dialog if the user omits a name. No other fields are required, as they may not have need of them.
                MessageBox.Show("You cannot create a ticket without a name.", "No Name", MessageBoxButtons.OK);
            }
            

            //submit also clears, so the next user can enter their information
            ClearEntries();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            //confirmation dialog
            var confirmResult = MessageBox.Show("Are you sure you want to clear all entries?",
                                     "Confirm Clear",
                                     MessageBoxButtons.YesNo);
            //if yes, call the clear function
            if (confirmResult == DialogResult.Yes)
            {
                ClearEntries();
            }
            //if no, do nothing
        }

        private void ClearEntries()
        {
            //this should clear all the entries
            txtTech.Text = "";
            rtxtIssueDescription.Text = "";
            TimeWidget.Value = System.DateTime.Now; //this was added so that the time doesn't stay the same for every user. When hitting submit or clear, the the time on the clock resets.
            chkBag.Checked = false;
            chkPowerCord.Checked = false;
            chkExternal.Checked = false;
            chkDiscs.Checked = false;
            chkMouse.Checked = false;
            chkKeyboard.Checked = false;
            cmbBoxHelpDesk.SelectedIndex = -1; //this means to reset the drop down menu to unselected. 0 = silver, 1 = gold.
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
