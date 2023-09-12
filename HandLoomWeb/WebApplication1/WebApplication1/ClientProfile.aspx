<%@ Page Title="ClientProfile" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="ClientProfile.aspx.cs" Inherits="WebApplication1.Client_Profile" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1 style=" text-align: center; color:darkred;">Login</h1>
Mobile no : 7990213036&nbsp; :&nbsp;
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <br />
    OTP&nbsp;&nbsp; :&nbsp;&nbsp;
    <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
    <br />
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" Text="Login successfull"></asp:Label>
    <br />
    <br />
    <br />
</asp:Content>

