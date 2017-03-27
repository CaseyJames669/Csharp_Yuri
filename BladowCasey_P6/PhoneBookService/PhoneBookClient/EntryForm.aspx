<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EntryForm.aspx.cs" Inherits="PhoneBookClient.EntryForm"  Async="true"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" Text="Phone Book"></asp:Label>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Add an entry to the phone book:"></asp:Label>
        </p>
        <asp:Label ID="Label3" runat="server" Text="Last name: "></asp:Label>
        <asp:TextBox ID="lastNameTextBox" runat="server"></asp:TextBox>
        <p>
            First name:
            <asp:TextBox ID="firstNameTextBox" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="Label4" runat="server" Text="Phone Number: "></asp:Label>
        <asp:TextBox ID="phoneNumberTextBox" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="addEntryButton" runat="server" Text="Add Phone Book Entry" OnClick="addEntryButton_Click" />
        </p>
        <asp:Label ID="Label5" runat="server" Text="Locate entries in the phone book:"></asp:Label>
        <p>
            <asp:Label ID="Label6" runat="server" Text="Last name: "></asp:Label>
            <asp:TextBox ID="findLastNameTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="findButton" runat="server" OnClick="findButton_Click" Text="Find Entries by Last Name" />
        </p>
        <asp:Label ID="Label7" runat="server" Text="Results:"></asp:Label>
        <br />
        <asp:ListBox ID="resultsListBox" runat="server" Width="238px"></asp:ListBox>
    </form>
</body>
</html>
