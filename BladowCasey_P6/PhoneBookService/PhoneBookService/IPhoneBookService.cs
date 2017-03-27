//---------------------------------------------------------------------------------------------------
// <copyright company="Casey Bladow" file="IPhoneBookService.cs"> All Rights Reserved.
// Information Contained Herein is Proprietary and Confidential.</copyright>
// <summary>This file contains the IPhoneBookService interface definition for exercise 30.3</summary>
//----------------------------------------------------------------------------------------------------

using System.ServiceModel;
using System.ServiceModel.Web;

namespace PhoneBookService
{
    /// <summary>
    /// The service inteface for interacting with the PhoneBook service.
    /// </summary>
    [ServiceContract]
    public interface IPhoneBookService
    {
        /// <summary>
        /// Adds a contact to the database.
        /// </summary>
        /// <param name="lastName">Last name of the contact to tbe added.</param>
        /// <param name="firstName">First name of the contact to be added.</param>
        /// <param name="phoneNumber">Phone number of the contact to be added.</param>
        /// <returns>A <c>string</c>.</returns>
        [OperationContract]
        [WebGet(UriTemplate = "/AddEntry/{lastName},{firstName},{phoneNUmber}", BodyStyle = WebMessageBodyStyle.Wrapped)]
        string AddEntry(string lastName, string firstName, string phoneNumber);

        /// <summary>
        /// Finds contacts in the database with last names matching the supplied value.
        /// </summary>
        /// <param name="lastName">The last anme to search for in the database.</param>
        /// <returns>A <c>string</c> array that contains the contact that matched the supplied value for thier last name.</returns>
        [OperationContract]
        [WebGet(UriTemplate = "/GetEntries/{lastName}", BodyStyle = WebMessageBodyStyle.Wrapped)]
        string[] GetEntries(string lastName);

    }
}
