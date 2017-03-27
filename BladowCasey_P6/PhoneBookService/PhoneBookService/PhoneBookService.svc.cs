//---------------------------------------------------------------------------------------------------
// <copyright company="Casey Bladow" file="PhoneBookService.cs"> All Rights Reserved.
// Information Contained Herein is Proprietary and Confidential.</copyright>
// <summary>This file contains the PhoneBookService implementation for exercise 30.3</summary>
//----------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;

namespace PhoneBookService
{
    /// <summary>
    /// The <c>PhoneBookService</c> class contains the implementation of the <c>IPhoneBookService</c> interface.  This class contains the methods that actually interact
    /// with the PhoneBook database.  Thesehose methods are actually called when a client of the <c>IPhoneBookService</c> interface invokes the inface's methods.
    /// </summary>
    /// <remarks>NOTE: In order to launch WCF Test Client for testing this service, please select PhoneBookService.svc or PhoneBookService.svc.cs at the Solution Explorer
    /// and start debugging.</remarks>
    public class PhoneBookService : IPhoneBookService
    {
        // Class variable to hold the delimiter for the returned contact data
        private static char delim = ',';

        /// <summary>
        /// Adds a new contact to the database.
        /// </summary>
        /// <param name="lastName">The last name of the contact.</param>
        /// <param name="firstName">The first name of the contact.</param>
        /// <param name="phoneNumber">The phone number of the contact.</param>
        /// <returns>A <c>string</c> stating "Contact added" if the contact was successfully added to the database.</returns>
        /// <exception cref="ArgumentException">Thrown if any of the supplied values is over length.</exception>
        public string AddEntry(string lastName, string firstName, string phoneNumber)
        {
            // Validate the supplied paramters
            validateContact(lastName, firstName, phoneNumber);
            
            // Create a DataContext and scope it to the database interaction
            using (PhoneBookDatabaseDataContext dataContext = new PhoneBookDatabaseDataContext())
            {
               // Call the AddEntry stored procedure in the database to add the contact
                dataContext.AddEntry(lastName, firstName, phoneNumber);               
            }

            // Return a message stating that the contact was added successfully
            return "Contact added";
        }

        /// <summary>
        /// Returns the contacts that have last names matching the supplied value.
        /// </summary>
        /// <param name="lastName">The last anme to search for in the database.</param>
        /// <returns>An array of <c>string</c>s that contain the matching contacts.  Each entry in the <c>Array</c> contains the contact data in the format:
        ///  "lastName,firstName,phoneNumber".</returns>
        ///  <exception cref="ArgumentException">Thrown if the supplied last name to search for is over length.</exception>
        public string[] GetEntries(string lastName)
        {
            // Validate the supplied value for lastName
            if (lastName.Length > 50)
            {
                throw new ArgumentException("Last name is longer than 50 characters", "lastName");
            }

            // List to hold the returned contacts
            List<string> entries = new List<string>();

            // Create a DataContext and scope it to the database interaction
            using (PhoneBookDatabaseDataContext dataContext = new PhoneBookDatabaseDataContext())
            {
                // Call the GetEntries stored procedure in the PhoneBook database
                var results = dataContext.GetEntries(lastName).ToList();
            
                // Loop over the returned contacts and populate the reulsts list, formatting each contact that was found into a single string
                foreach (PhoneBook entry in results)
                {
                    entries.Add(formatRecord(entry.LastName) + formatRecord(entry.FirstName) + entry.PhoneNumber.TrimEnd());
                }                               
            }

            // Return the results list as an arry of strings
            return entries.ToArray();
        }

        /// <summary>
        /// Formats a string as required.
        /// </summary>
        /// <param name="dataValue">The <c>string to be formatted.</c></param>
        /// <returns>A <c>string</c> with trailing whitespace removed and with a ',' appended to it.</returns>
        private static string formatRecord(string dataValue)
        {
            // Remove trailing whitespce and append a ',' to the supplied string
            return dataValue.TrimEnd() + delim;
        }

        /// <summary>
        /// Validates the length of the contact paramters.
        /// </summary>
        /// <param name="lastName">The last name to validate.</param>
        /// <param name="firstName">The first name to vlidate.</param>
        /// <param name="phoneNumber">The phone number to validate.</param>
        /// <exception cref="ArgumentException">Thrown if any of the paramters are over length.</exception>
        private static void validateContact(string lastName, string firstName, string phoneNumber)
        {
            if(lastName.Length > 50)
            {
                throw new ArgumentException("Last name is longer than 50 characters", "lastName");
            }
            if (firstName.Length > 50)
            {
                throw new ArgumentException("First name is longer than 50 characters", "firstName");
            }
            if (phoneNumber.Length > 15)
            {
                throw new ArgumentException("Phone Number is longer than 15 characters", "phoneNumber");
            }
        }
    }
}
