//---------------------------------------------------------------------------------------------------
// <copyright company="Casey Bladow" file="EntryForm.aspx"> All Rights Reserved.
// Information Contained Herein is Proprietary and Confidential.</copyright>
// <summary>This file contains the ASP.NET client entry form for exercise 30.3</summary>
//----------------------------------------------------------------------------------------------------

using PhoneBookClient.PhoneBookService;
using System;

namespace PhoneBookClient
{
    public partial class EntryForm : System.Web.UI.Page
    {
        protected async void findButton_Click(object sender, EventArgs e)
        {

            // Clear the list box on the form and validate the input from the form
            this.resultsListBox.Items.Clear();
            string lastName = this.findLastNameTextBox.Text.TrimEnd();
            if (isInputValid(lastName))
            {
                // if the input is invalid, then simply return and do no work
                return;
            }

            // Create an instance of the PhoneBookService client and scope it to the service inovocation
            using (PhoneBookServiceClient client = new PhoneBookServiceClient())
            {
                try
                {
                    // Call the service's GetEntriesAsync method to get the requested entries
                    var results = await client.GetEntriesAsync(lastName);
                    foreach (string result in results)
                    {
                        // Loop over each of the returned contacts and add them to the list box on the form
                        this.resultsListBox.Items.Add(result);
                    }
                }
                catch (Exception ex)
                {
                    // If an exception is thrown and the excpetion's message to the list box on the form
                    this.resultsListBox.Items.Add(ex.Message);
                }                
            }
        }

        protected async void addEntryButton_Click(object sender, EventArgs e)
        {
            // Clear the list box on the form and validate the input from the form
            this.resultsListBox.Items.Clear();
            string lastName = this.lastNameTextBox.Text.TrimEnd();
            string firstName = this.firstNameTextBox.Text.TrimEnd();
            string phoneNumber = this.phoneNumberTextBox.Text.TrimEnd();
            if (isInputValid(lastName) && isInputValid(firstName) && isInputValid(phoneNumber))
            {
                return;
            }

            // Create an instance of the PhoneBookService client and scope it to the service inovocation
            using (PhoneBookServiceClient client = new PhoneBookServiceClient())
            {
                try
                {
                    var results = await client.AddEntryAsync(lastName, firstName, phoneNumber);
                    
                    // Add the success message to the list box
                    this.resultsListBox.Items.Add(results);
                }
                catch (Exception ex)
                {
                    // If an exception is thrown and the excpetion's message to the list box on the form
                    this.resultsListBox.Items.Add(ex.Message);
                }
            }            
        }

        /// <summary>
        /// Check to make sure the supplied string is not null or empty
        /// </summary>
        /// <param name="inputString">The <c>string</c> to check</param>
        /// <returns>The result of a call to <c>string.IsNullOrEmpty</c></returns>
        private static bool isInputValid(string inputString)
        {
            return string.IsNullOrEmpty(inputString);
        }
    }
}