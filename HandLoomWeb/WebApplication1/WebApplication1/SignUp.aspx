<%@ Page Title="SignUP" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="WebApplication1.SignUp" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
 <p>Registration /Sign up form</p>
    <p>Name :
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p>Mobile No :
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
    <p>Email :
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    </p>
    <p>Password :
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    </p>
    <p>Gender <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem>Male</asp:ListItem>
            <asp:ListItem>Female</asp:ListItem>
            <asp:ListItem>other</asp:ListItem>
        </asp:RadioButtonList>
    </p>
    <p>DateOfBirth:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</p>
    <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
    <p></p>
    <p>
        <asp:Button ID="Button1" runat="server" Height="26px"  Text="Submit" Width="200px" OnClick="Button1_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Reset" Width="127px" />
    </p>
    <p></p>
    <p></p>
    <p></p>





</asp:Content>
