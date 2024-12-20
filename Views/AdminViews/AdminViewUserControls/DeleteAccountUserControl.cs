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
using System.Windows.Forms;
using static Orange_POS.Views.SharedViews.SharedViewsUserControl.AdminLoginUserControl;

namespace Orange_POS.Views.AdminViews.AdminViewUserControls
{
    public partial class DeleteAccountUserControl : UserControl
    {
        public event Action BackToSettingsEventHandler;
        private readonly UsersRepository usersRepository = new UsersRepository();
        private readonly MainLoginView mainLoginView = new MainLoginView();
        private List<Users> allUsers; 


        public DeleteAccountUserControl()
        {
            InitializeComponent();
            LoadUsersIntoGridView();
            UserSearchBox.TextChanged += UserSearchBox_TextChanged;
        }


        private void BackButton_Click(object sender, EventArgs e)
        {
            BackToSettingsEventHandler?.Invoke();
        }

        private void DeleteAccount_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (UsersDataGridView.SelectedRows.Count > 0)
                {
                    
                    string username = UsersDataGridView.SelectedRows[0].Cells["Username"].Value.ToString();
                    DialogResult confirmResult = MessageBox.Show($"Are you sure you want to delete the user '{username}'?", "Confirm Delete", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                      
                        UsersRepository usersRepository = new UsersRepository();
                        bool isDeleted = usersRepository.DeleteUser(username); 

                        if (isDeleted)
                        {
                            MessageBox.Show($"User '{username}' deleted successfully.");
                            LoadUsersIntoGridView();
                        }
                        else
                        {
                            MessageBox.Show($"Failed to delete the user '{username}'.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a user to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

        }

     

        public void LoadUsersIntoGridView()
        {
           
            try
            {

                allUsers = usersRepository.GetAllUsers();
                if (allUsers == null || allUsers.Count == 0)
                {
                    MessageBox.Show("No users found.");
                    return;
                }

                UsersDataGridView.DataSource = allUsers;
                if (UsersDataGridView.Columns.Contains("Password"))
                {
                    UsersDataGridView.Columns["Password"].Visible = false;
                }
                if (UsersDataGridView.Columns.Contains("MiddleName"))
                {
                    UsersDataGridView.Columns["MiddleName"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }


        private void UserSearchBox_TextChanged(object sender, EventArgs e)
        {
            ApplySearchFilter(UserSearchBox.Text);
        }


        private void ApplySearchFilter(string searchQuery)
        {
            if (string.IsNullOrWhiteSpace(searchQuery))
            {
                UsersDataGridView.DataSource = allUsers; 
            }
            else
            {
                List<Users> filteredUsers = new List<Users>();
                foreach (var user in allUsers)
                {
                    if (
                        (user.Username != null && user.Username.ToLower().Contains(searchQuery.ToLower())) ||
                        (user.FirstName != null && user.FirstName.ToLower().Contains(searchQuery.ToLower())) ||
                        (user.LastName != null && user.LastName.ToLower().Contains(searchQuery.ToLower())) ||
                        (user.Email != null && user.Email.ToLower().Contains(searchQuery.ToLower())) ||
                        (user.Contactnumber != null && user.Contactnumber.ToLower().Contains(searchQuery.ToLower())) ||
                        (user.User_Role != null && user.User_Role.ToLower().Contains(searchQuery.ToLower())) ||
                        (user.Middlename != null && user.Middlename.ToLower().Contains(searchQuery.ToLower()))
                    )
                    {
                        filteredUsers.Add(user);
                    }
                }
                UsersDataGridView.DataSource = filteredUsers;
            }

            if (UsersDataGridView.Columns.Contains("Password"))
            {
                UsersDataGridView.Columns["Password"].Visible = false;
            }
            if (UsersDataGridView.Columns.Contains("MiddleName"))
            {
                UsersDataGridView.Columns["MiddleName"].Visible = false;
            }
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {
            LoadUsersIntoGridView();

          
        }
    }
}
