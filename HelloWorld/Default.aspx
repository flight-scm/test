<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="HelloWorld._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Welcome to ASP.NET! 
    </h2>
    <p>
       This is Eric's testing for auto-building! 
    </p>
    <p>
        1st Light Tech.
    </p>
    A: <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="True" 
    ontextchanged="TextBox1_TextChanged"></asp:TextBox>
    B: <asp:TextBox ID="TextBox2" runat="server" AutoPostBack="True"
    ontextchanged="TextBox2_TextChanged"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="Submit" onclick="Button1_Click"/>
  
    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    <asp:Label ID="Label2" runat="server" Visible="False"></asp:Label>
    
    <asp:HiddenField ID="HiddenField1" runat="server" Value="false" />
    <asp:HiddenField ID="HiddenField2" runat="server" Value="false" />

</asp:Content>
