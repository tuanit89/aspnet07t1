<%@ Page Title="" Language="C#" MasterPageFile="~/DefaultPage.master" AutoEventWireup="true" Inherits="login" Codebehind="login.aspx.cs" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%--<asp:Button ID="Button1" runat="server" Text="Button" onclick="Button1_Click" />--%>
    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/fb-login-button.png" OnClick="Button1_Click"/>
     
<hr />

<%--<div id="auth-status"><asp:Button runat="server" Text="Button"></asp:Button>
<div id="auth-loggedout">

<div class="fb-login-button" autologoutlink="true" scope="email,user_checkins">Login with Facebook</div>
</div>
<div id="auth-loggedin" style="display: none">

</div>
</div>--%>
</asp:Content>

