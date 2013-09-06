<%@ Page Language="C#" AutoEventWireup="true" Inherits="loginAdmin" Codebehind="loginAdmin.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table border="0" cellpadding="1" cellspacing="0" style="width: 314px; border-collapse: collapse;
                                height: 231px">
                                <tr>
                                    <td style="height: 250px" valign="top">
                                        <table border="0" cellpadding="0">
                                            <tr>
                                                <td valign="top" align="center" colspan="2" style="height: 45px">
                                                    <asp:Label ID="Label1" runat="server" AssociatedControlID="UserName" Font-Bold="True"
                                                        Font-Size="X-Large" ForeColor="Red" Height="33px" Width="91px">ĐĂNG NHẬP HỆ THỐNG</asp:Label></td>
                                            </tr>
                                            <tr>
                                                <td align="right" style="width: 100px">
                                                    <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName" Font-Bold="True"
                                                        Font-Size="Small" Width="49px">Tài khoản :</asp:Label></td>
                                                <td style="width: 248px">
                                                    <asp:TextBox ID="UserName" runat="server" Width="170px"></asp:TextBox>
                                                   
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="right" style="width: 100px">
                                                    <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password" Font-Bold="True"
                                                        Font-Size="Small">Mật khẩu:</asp:Label></td>
                                                <td style="width: 248px">
                                                    <asp:TextBox ID="Password" runat="server" TextMode="Password" Width="170px"></asp:TextBox>
                                                   
                                                </td>
                                            </tr>
                                            
                                           
                                            <tr>
                                                <td align="center" colspan="2">
                                                    <asp:Button ID="LoginButton" runat="server" CommandName="Login" Text="Đăng nhập"
                                                        ValidationGroup="Login1" Width="100px" onclick="LoginButton_Click" />
                                                </td>
                                            </tr>
                                        </table>
                                        <br />
                                        <br />
                                        <br />
                                    </td>
                                </tr>
                            </table>
    </div>
    </form>
</body>
</html>
