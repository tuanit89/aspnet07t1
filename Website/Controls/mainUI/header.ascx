<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="header.ascx.cs" Inherits="Website.Controls.mainUI.header" %>
<div id="header">
    <div id="headerContent">
        <a href="/" id="logo">duocday</a>
        <ul id="menuBar">
            <li class="selected"><a href="/Bai-Hot">Hot</a></li>
            <li><a href="/Dep">Đẹp ++</a></li>
            <li><a href="/Xa-Stress">Xả Stress</a></li>
            <li><a href="/Cam-Xuc">Cảm xúc</a></li>
            <li><a href="/Bai-Cu">Cũ</a></li>
            <li><a href="/Binh-Chon">Bình chọn</a></li>
            <li><a href="/Tim-Kiem" target="_blank">Tìm kiếm</a></li>
        </ul>
       <%-- <div id="upanh">
                        <a class="upload" href="/Dang-Anh" rel="nofollow">Đăng ảnh</a>
                    </div>--%>
        <%--<div id="loginPanel">
            <a class="loginButton" href="login.aspx">Đăng nhập</a>
        </div>
        --%>
       
        <div id="headerRight">
                <% if( UserLogged==null) { %>
                    <div class="login">
                        <a href="/Account" rel="nofollow">Đăng nhập</a>
                    </div>
                 <% } else   { %>

                    <a href="/account/notification" class="notiButton" title="Thông báo" rel="nofollow"></a>
                    <div class="avatar noNoti"><a href="/uploader/24675" class="avatarLink" title="<%= UserLogged.Fullname %>">
                            <img src="<%= UserLogged.ProfilePicture %>" width="30px" height="30px">
                        </a>
                        <div class="blank"></div>
                        <ul>
                            <li><a href="/Uploader/<%=UserLogged.Id %>" rel="nofollow">Ảnh của bạn</a></li>
                            <li><a href="/Account/Edit" rel="nofollow">Thông tin cá nhân</a></li>
                            <li><a href="/Account/Password" rel="nofollow">Đổi mật khẩu</a></li>
                            <li><a href="/Account/Logout" rel="nofollow">Thoát</a></li>
                        </ul>
                    </div>
                <% } %>
        </div>
         <div class="clear"></div>
    </div>
</div>
