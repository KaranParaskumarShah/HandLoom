<%@ Page Title="Login" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Login.aspx.cs" Inherits="WebApplication1.Login" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1 style=" text-align: center; color:darkred;">Login</h1>
Username
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="checkEmail" runat="server" ></asp:Label>
    <br />
    Password
    <asp:TextBox ID="TextBox2" runat="server" ></asp:TextBox>
    <br />
    <asp:Label ID="checkPassword" runat="server" ></asp:Label>
    <br />
   &nbsp;
    <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
    <br />
    <br />
    <asp:Label ID="errorMessage" runat="server" >   </asp:Label>
    <br />
    <br />
    <br />

    
</asp:Content>
