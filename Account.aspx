<%@ Page Title="" Language="C#" MasterPageFile="~/CustMaster.Master" AutoEventWireup="true" CodeBehind="account.aspx.cs" Inherits="CustomerUI.account" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 184px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
   
   <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/viewcustomer.aspx">View Customer Details</asp:HyperLink>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/vcbid.aspx">View Customer Details By ID</asp:HyperLink> &nbsp;&nbsp;&nbsp; 
    <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/viewaccount.aspx">View Account Details</asp:HyperLink>
    &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/ViewJoin.aspx">View Joint Details</asp:HyperLink>
    </p>
    <p>
        Your Account ID is-<asp:Label ID="aid1" runat="server" Text="null"></asp:Label>
    </p>
    <p>
        Account Start Date-<asp:Label ID="asd" runat="server" Text="null"></asp:Label>
    </p>
    <p>
        Account Status-
        <asp:Label ID="astatus" runat="server" Text="null"></asp:Label>
        <br />
    </p>
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">Enter Existing Customer ID-</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Enter Customer ID" ForeColor="#3366FF"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">Enter Amount(min 500)-</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Enter Amount" ForeColor="#3366FF"></asp:RequiredFieldValidator>
                <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="Enter Correct Range" ForeColor="#FF0066" MaximumValue="10000" MinimumValue="500" Type="Integer"></asp:RangeValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">Select Account Type-</td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>Savings</asp:ListItem>
                    <asp:ListItem>Current</asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="DropDownList1" ErrorMessage="Select Account type" ForeColor="#3366FF"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Create Account" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
