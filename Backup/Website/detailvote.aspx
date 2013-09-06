<%@ Page Title="" Language="C#" MasterPageFile="~/Hot.master" AutoEventWireup="true" CodeFile="Detailvote.aspx.cs" Inherits="Detailvote" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <div class="box photoDetails">

//sau nay goi gag bang

       <%-- <asp:DataList ID="dtl" runat="server">
            <ItemTemplate>--%>
                <div class="photoInfo">
                    <h1>
<%--                     <%= Gag. %>--%>
                        Được đấy
                        </h1>
                    <div class="stats">
                        <span class="views">Lượt xem: <span class="number">1000</span></span> <span class="comments">
                            Lượt bình luận: <span class="number">1000</span></span>
                    </div>
                    <div class="source">
                        <span class="source">Nguồn: <span class="text">Duocday.com</span></span>
                    </div>
                </div>
                <div class="uploader">
                    Đăng 10 phút trước bởi
                    <div>
                        <img src="avatar/3ff78193-5.jpg" />
                        <div class="info"><a href="#">
                             được đấy
                        </a><span class="likes" title="lượt thích"> 10000 </span></div>
                        <%--<div class="info">
                            <span class="likes" title="lượt thích"><asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></span>
                        </div>--%>
                        <div class="clear">
                        </div>
                    </div>
                </div>
                <div class="clear">
                </div>
                <div class="fixedScrollDetector" data-fixedtop="43">
                </div>
                <div class="likeButton fixedScroll ">
                    <div class="text">
                        Thích ảnh này ?
                    </div>
                <div class="navButtons">
             <a class="prev" href="#" > <<Ảnh trước</a> <a class="#">Ảnh sau>> </a></div>
                    <div class="fbLikeButton">
                        <div class="fb-like" data-href="#" data-send="false"
                            data-show-faces="false" data-layout="button_count">
                        </div>
                        <a name="fb_share" type="button_count" share_url="#"
                            href="http://www.facebook.com/sharer.php">Share</a>
                       
                    </div>
                </div>
                <div class="clear">
                </div> 
                <asp:Panel runat="server" ID="image" Visible="true">
                <div class="photoImg">
                    <img class="thumbImg" alt="được đấy" src="anh/medium-d1d68c1f6d8a452894dac308f93f9039-400.jpg"></img>
                </div>
                </asp:Panel>
                <asp:Panel runat="server" ID="video" Visible="false">
                    <div class="photoImg">
                    <iframe width="650" height="365" src="#" frameborder="0" allowfullscreen></iframe>
                </div>
                </asp:Panel>
                <div class="featuredFanPage">
                    <h4>
                        Like duocday trên Facebook để được cười nhiều hơn ^^</h4>
                    <div class="fb-like" data-href="http://www.facebook.com/duocdaydotcom" data-send="false"
                        data-width="600" data-show-faces="false">
                    </div>
                </div>
                <div class="commentContainer">
                    <h4>
                        Bình luận <a href="#" class="report">Báo cáo vi phạm</a></h4>
                    <div class="fb-comments" data-href="#" data-num-posts="10"
                        data-width="655">
                    </div>
                </div>
<%--            </ItemTemplate>
        </asp:DataList>--%>
        <%--<div>
            <!-- haivl-trang-hinh-anh-duoi-anh -->
            <div id='div-gpt-ad-1346990951948-0' style='width: 655px; height: 150px; display: none;
                margin-top: 10px'>
                <script type='text/javascript'>
                    googletag.cmd.push(function () { googletag.display('div-gpt-ad-1346990951948-0'); });
                </script>
            </div>
        </div>--%>
    </div>
</asp:Content>

