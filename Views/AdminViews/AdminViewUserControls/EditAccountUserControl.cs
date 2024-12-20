using Orange_POS.Helpers;
using Orange_POS.Models;
using Orange_POS.Repositories;
using Orange_POS.Views.SharedViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;
using static Orange_POS.Views.SharedViews.SharedViewsUserControl.AdminLoginUserControl;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;



namespace Orange_POS.Views.AdminViews.AdminViewUserControls
{
    public partial class EditAccountUserControl : UserControl
    {
        public event Action BackToSettingsEventHandler;
        public event Action UserUpdatedEventHandler;
        private readonly UsersRepository usersRepository = new UsersRepository();
        private readonly InputValidation inputValidation = new InputValidation();
      
        public EditAccountUserControl()
        {
            InitializeComponent();
            SetUserDetails();
        }

      
        
        public void SetUserDetails()
        {

            CurrentName.Text = $"{GetUser.FirstName} {GetUser.MiddleName} {GetUser.LastName}" ?? "Not Logged In";
            CurrentUsername.Text = GetUser.Username ?? "Not Logged In";
            CurrentEmail.Text = GetUser.Email ?? "Not Logged In";
            CurrentContact.Text = GetUser.ContactNumber ?? "Not Logged In";
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            BackToSettingsEventHandler?.Invoke();
            EditFirstName.Clear();
            EditLastName.Clear();
            EditMiddleName.Clear();
            EditEmail.Clear();
            EditContactNumber.Clear();
            EditUsername.Clear();
        }

   
        private void EditAccountButton_Click(object sender, EventArgs e)
        {
            string firstName = EditFirstName.Text;
            string lastName = EditLastName.Text;
            string middleName = EditMiddleName.Text;
            string email = EditEmail.Text;
            string contactNumber = EditContactNumber.Text;
            string username = EditUsername.Text;

            string currentUsername = CurrentUsername.Text;

            try
            {
               
                if (string.IsNullOrEmpty(contactNumber) || contactNumber.Length != 11 || !contactNumber.All(char.IsDigit))
                {
                    MessageBox.Show("Contact Number must be 11 digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(middleName) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(contactNumber) || string.IsNullOrEmpty(email))
                {
                    MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (inputValidation.ContainsInvalidCharacters(firstName) || inputValidation.ContainsInvalidCharacters(lastName) || inputValidation.ContainsInvalidCharacters(middleName))
                {
                    MessageBox.Show("Names should not contain numbers and special characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                if (!inputValidation.ValidateUsername(username))
                {
                    MessageBox.Show("Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }
                else
                {
                    bool updateuser = usersRepository.UpdateUserAccount(currentUsername, username, firstName, lastName, middleName, contactNumber, email);
                    if (updateuser)
                    {
                        MessageBox.Show("User account updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }


                EditFirstName.Clear();
                EditLastName.Clear();
                EditMiddleName.Clear();
                EditEmail.Clear();
                EditContactNumber.Clear();
                EditUsername.Clear();
            }
            catch (Exception ex)
            {
                throw new Exception("An error has occured while accessing the database", ex);
            }
            UserUpdatedEventHandler?.Invoke();  
            BackToSettingsEventHandler?.Invoke();
        }
    }
}
