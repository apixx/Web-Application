<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="WebApplication.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 23px;
        }
        .auto-style3 {
            width: 128px;
        }
        .auto-style4 {
            height: 23px;
            width: 128px;
            text-align: left;
        }
        .auto-style5 {
            width: 128px;
            text-align: left;
        }
        .auto-style6 {
            width: 150px;
        }
        .auto-style7 {
            height: 23px;
            width: 150px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Registration Form</h1>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style5">Username:</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="TextBoxUsername" runat="server" Width="150px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxUsername" ErrorMessage="Username is Required" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">E-mail:</td>
                    <td class="auto-style7">
                        <asp:TextBox ID="TextBoxEmail" runat="server" Width="150px"></asp:TextBox>
                    </td>
                    <td class="auto-style2">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBoxEmail" ErrorMessage="E-mail is Required" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        <br />
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBoxEmail" ErrorMessage="Enter a valid Email" ForeColor="#FF3300" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Password:</td>
                    <td class="auto-style7">
                        <asp:TextBox ID="TextBoxPassword" runat="server" TextMode="Password" Width="150px"></asp:TextBox>
                    </td>
                    <td class="auto-style2">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBoxPassword" ErrorMessage="Password is Required" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">Confirm Password:</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="TextBoxConfirmPassword" runat="server" TextMode="Password" Width="150px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBoxConfirmPassword" ErrorMessage="Confirm Password is Required" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        <br />
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBoxPassword" ControlToValidate="TextBoxConfirmPassword" ErrorMessage="Password doesn't match" ForeColor="#FF3300"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">Name:</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="TextBoxName" runat="server" Width="150px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBoxName" ErrorMessage="Name is Required" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">Address:</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="TextBoxAddress" runat="server" Width="150px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBoxAddress" ErrorMessage="Address is Required" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style6">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Register" />
                        <input id="Reset1" type="reset" value="Clear" /></td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
