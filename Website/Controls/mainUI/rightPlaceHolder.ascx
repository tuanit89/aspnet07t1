<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="rightPlaceHolder.ascx.cs" Inherits="Website.Controls.mainUI.rightPlaceHolder" %>
<div id="rightColumn" class="clearfix">
    <div class="box infoBox highlightBox">
        <strong>Vào Facebook để lướt duocday sướng hơn! <a href="#">Xem cách vào facebook không bị chặn.</a></strong>
    </div>

    <a class="buttons spaceBottom btnStartToShare" href="/upload">Click để bắt đầu chia sẻ những bức ảnh vui!</a><!--end button starting to share-->

    <div class="box darkBox">
        <h3 class="topUsers">Top danh hài</h3>
        <ul class="topUsersSort topUsersSortHome">
            <li><a href="#" data-sort="week" class="selected">tuần</a> / </li>
            <li><a href="#" data-sort="month">tháng</a> / </li>
            <li><a href="#" data-sort="all">tất cả</a> </li>
        </ul>
        <div class="clear">
        </div>
        <div id="topUserContent">
            <div class="topUsers">

                <div class="item">
                    <a href='#'>
                        <img src="avatar/08d57241-7.jpg" />
                        <div class="info">
                            <span class="name">được đấy</span> <span class="likes">10000</span>
                        </div>
                    </a>
                </div>

            </div>
            <div class="clear">
            </div>
            <div class="moreTop">
                <%-- <a href="/top-user/week">xem th&#234;m &#187;</a>--%>
            </div>
        </div>
    </div>

    <div class="fixedScrollDetector"></div>
    <div class="box darkBox socialBox">
        <h3>Ủng hộ duocday.com nhé bạn ^^</h3>
        <div class="media facebook">
            <div class="fb-like" data-href=" http://www.facebook.com/duocdaydotcom" data-send="false" data-width="270" data-show-faces="false"></div>
        </div>
        <div class="media twitter">
            <a href="https://twitter.com/tuanit89" class="twitter-follow-button" data-show-count="true" data-size="large">Follow duocday</a>
        </div>
        <div class="media google" style="border-bottom: none">
            <div class="g-plusone" data-href="http://www.duocday.com/" data-size="medium"></div>
            <p>DuocDay trên Google+</p>
        </div>
    </div>

    <div class="fixedScroll">
        <div style="float: left; width: 300px; height: 400px; color: blanchedalmond"></div>
        <!-- haivl-trang-chu-bottom-small -->
    </div>
    <!--aaa-->
</div>
