<%@ Page Title="" Language="C#" MasterPageFile="~/MasterUser.master" AutoEventWireup="true" CodeFile="messenger.aspx.cs" Inherits="messenger" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="box minHeightBox notifications">
    <h3>
        Thông báo của bạn</h3>
        <ul class="notificationList">

<li class="notificationItem">
    <div class="clearfix">
        <div class="notificationContent noti_accountCreated">
            Chào mừng bạn đến với duocday.com. Hãy <a href="#">đặt mật khẩu</a> cho tài khoản của bạn để có thể sử dụng cách đăng nhập bằng email và mật khẩu khi không vào được Facebook.
            <span class="sentDatetime">
                14/5/2013 10:24 SA
            </span>
        </div>
    </div>
</li>
            <li class="moreHolder"></li>
        </ul>
</div>
</asp:Content>

