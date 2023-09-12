<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WebApplication1.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:RadioButtonList ID="Male" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" Width="242px">Male
    </asp:RadioButtonList>
    <asp:RadioButtonList ID="Female" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged2" Width="250px">Female
    </asp:RadioButtonList>
    <asp:ListBox ID="ListBox1" runat="server" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Height="135px" Width="606px">
        <asp:ListItem Value="7990213036">Karan Mobile No</asp:ListItem>
        <asp:ListItem>mummy</asp:ListItem>
        <asp:ListItem></asp:ListItem>
    </asp:ListBox>





</asp:Content>
