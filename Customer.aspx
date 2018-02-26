<%@ Page Title="" Language="C#" MasterPageFile="~/CustMaster.Master" AutoEventWireup="true" CodeBehind="Customer.aspx.cs" Inherits="CustomerUI.Customer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 100%;
            height: 209px;
        }
        .auto-style3 {
            width: 214px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    &nbsp;&nbsp;&nbsp;&nbsp;
   
   <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/viewcustomer.aspx">View Customer Details</asp:HyperLink> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/vcbid.aspx">View Customer Details By ID</asp:HyperLink> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
    <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/viewaccount.aspx">View Account Details</asp:HyperLink>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/ViewJoin.aspx">View Joint Details</asp:HyperLink>
&nbsp;&nbsp;
    <br />
&nbsp;<table class="auto-style2">
        <tr>
            <td class="auto-style3">Customer Name-</td>
            <td>
                <asp:TextBox ID="cname" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="cname" ErrorMessage="Enter Customer Name" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">Gender-</td>
            <td>
                <asp:DropDownList ID="ddlgender" runat="server">
                    <asp:ListItem Value="Male">Male</asp:ListItem>
                    <asp:ListItem Value="Female">Female</asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="ddlgender" ErrorMessage="Select Gender" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">Date of Birth-(YYYY-MM-DD)</td>
            <td>
                <asp:TextBox ID="dob" runat="server" TextMode="DateTime"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="dob" ErrorMessage="Enter DOB(YYYY-MM-DD)" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">Contact No-</td>
            <td>
                <asp:TextBox ID="cno" runat="server" TextMode="Number"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="cno" ErrorMessage="Enter Contact No" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">City-</td>
            <td>
                <asp:TextBox ID="city" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="city" ErrorMessage="Enter City" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;&nbsp;&nbsp; </td>
            <td>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Register" Width="127px" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
        <strong id="label" style="font-size: x-large; font-family: Calibri; font-weight: bold">
    <br />
    Your Customer Id is -&nbsp;&nbsp; </strong>&nbsp;<asp:Label ID="Label1" runat="server" Text="NULL"></asp:Label>
    <br />
    <br />
    If New Customer and want to add account details, then click here-
    <asp:HyperLink ID="Here0" runat="server" NavigateUrl="~/account.aspx">Here</asp:HyperLink>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    If Existing Customer and want to add account deatails, then click here-<asp:HyperLink ID="Here1" runat="server" NavigateUrl="~/account.aspx">Here</asp:HyperLink>
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>
