<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserPlaceHolder.ascx.cs" Inherits="Website.Controls.mainUI.UserPlaceHolder" %>
<div id="rightColumn" class="clearfix">
    <div id="rightscrl">
        <div class="fixedScrollDetector"></div>
        <div class="fixedScroll fixedWidth">
            <div class="box darkBox userInfo">
                <div class="avatar">
                    <img src="<%= UserLogged.ProfilePicture %>" alt="<%= UserLogged.Fullname %>" />
                    <div class="name">
                        <h2><%= UserLogged.Fullname %></h2>
                        <span>Tham gia từ: <%= UserLogged.JoinedDate.ToString("dd-MM-yyyy") %></span>
                    </div>
                </div>
                <div class="clear">
                </div>
                <div class="stats">
                    <div>
                        Số ảnh đã đăng: <span class="number"><%= UserLogged.TotalUpload %></span>
                    </div>
                    <div>
                        Được like: <span class="number"><%= UserLogged.TotalLike %></span> lần
                    </div>
                    <div>
                        Được bình luận: <span class="number"><%= UserLogged.TotalComment %></span> lần
                    </div>
                    <div>
                        Được xem: <span class="number"><%= UserLogged.TotalView %></span> lần
                    </div>
                    <div>
                        Thứ hạng: <span class="number"><%= UserLogged.Rank %></span>
                    </div>
                    <div class="about">
                           <%= UserLogged.Description %>
                    </div>
                    <%--<div>
                        Facebook: <a rel="nofollow" target="_blank" href="#">được đấy</a>
                    </div>--%>
                    <% if (UserLogged.Website.Length > 0)
                       { %>
                    <div class="websites">
                        <div id="wscaption">
                            <div id="wslist">
                                <ul>
                                    <li><a rel="nofollow" target="_blank" href="<%= UserLogged.Website %>"><%=UserLogged.Website %></a></li>
                                </ul>
                            </div>
                            <div class="clear"></div>
                        </div>
                        
                    </div>
                    <% } %>
                    <div class="clear"></div>
                </div>
            </div>
        </div>
    </div>
</div>
