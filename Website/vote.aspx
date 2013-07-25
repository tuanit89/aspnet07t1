<%@ Page Title="" Language="C#" MasterPageFile="~/Hot.master" AutoEventWireup="true" CodeFile="vote.aspx.cs" Inherits="vote" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="box">
        <h3>
            Bình chọn ảnh</h3>
       <%-- <div class="tips">
            <b>Bạn</b> là người góp phần quyết định những hình ảnh này có được hiển thị ở trang
            chủ hay không.
            <br />
            Hãy <b>click </b>vào cái nút <span class="iconVoteUp"></span>hoặc <span class="iconVoteDown">
            </span>ở mỗi hình ảnh dưới đây để <b>bình chọn</b> nào!
            <br />
            <br />
            <b>Chú ý: ảnh sau khi đăng khoảng 10 phút mới xuất hiện trên trang bình chọn</b>
        </div>--%>
        <div class="photoList">
        <asp:DataList ID="dtlphoto" runat="server">
                <ItemTemplate>
                    <div class="photoListItem">
                        <div class="listItemSeparator">
                        </div>
                        <div class="thumbnail">
                            <a href="<%#"detailvote.aspx?ID="+Eval("idPic") %>" target="_blank">
                                <img src='<%#Eval("url") %>' alt='<%#Eval("tieuDe") %>' class="thumbImg" />
                                <asp:Literal ID="Literal1" runat="server"></asp:Literal>
                            </a>
                        </div>
                        <div class="info">
                            <h2>
                                <a target="_blank" href="<%#"detailvote.aspx?ID="+Eval("idPic") %>">
                                <%#Eval("tieuDe") %>
                                   </a>
                            </h2>
                            <div class="uploader">
                                Đăng bởi <a href="<%#"photoupload.aspx?user="+Eval("idUser") %>">
                                    <%#Eval("tenHienThi") %></a>  <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label> </div>
                            <div class="stats">
                                <div class="viewComments">
                                    <span class="views" title="lượt xem"><%#Eval("luotXem") %></span> <span class="comments" title="lượt bình luận">
                                        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></span>
                                </div>
                                <div class="clear">
                                </div>
                            </div>
                            <div>
                                <div fb-xfbml-state="rendered" class="fb-like fb_edge_widget_with_comment fb_iframe_widget"
                                    data-href="<%#"http://duocday.com/Detailphoto.aspx?ID="+Eval("idPic") %>" data-send="false" data-layout="button_count"
                                    data-width="90" data-show-faces="false">
                                </div>
                                <a name="fb_share" type="button_count" share_url="<%#"http://duocday.com/Detailphoto.aspx?ID="+Eval("idPic") %>"
                                    href="http://www.facebook.com/sharer.php">Share</a>
                               
                            </div>
                            <div  class="vote">
                       <div id="<%#"chan"+Eval("idPic") %>" class="voteDown">
                <a   href="javascript:updatechan(<%#Eval("idPic") %>)"><span>chán</span></a>
            </div>
            <div id="<%#"hay"+Eval("idPic") %>" class="voteUp">
                <a href="javascript:updatehay(<%#Eval("idPic") %>)"><span>hay</span></a>
            </div>
                    </div>
                        </div>
                        <div class="clear">
                        </div>
                    </div>
                </ItemTemplate>
            </asp:DataList>
            <%--<div class="photoListItem" data-id="420343">
                <div class="listItemSeparator">
                </div>
                <div class="thumbnail">
                    <a href="#" target="_blank">
                        <img src="anh/medium-d1d68c1f6d8a452894dac308f93f9039-400.jpg" alt="Soledad của Westlife - h&#244;m nay t&#236;nh cờ nghe lại b&#224;i n&#224;y bỗng dưng thấy sao m&#224; nghẹn ng&#224;o qu&#225; :( :( :("
                            class="thumbImg" />
                    </a>
                </div>
                <div class="info">
                    <h2>
                        <a target="_blank" href="#">Soledad của Westlife - hôm nay tình cờ nghe
                            lại bài này bỗng dưng thấy sao mà nghẹn ngào quá </a>
                    </h2>
                    <div class="uploader">
                        Đăng bởi <a href="#">Huỳnh Minh Bee</a> 44 ph&#250;t trước</div>
                    <div class="stats">
                        <span class="views" title="lượt xem">4.522</span> <span class="comments" title="lượt b&#236;nh luận">
                            32</span>
                    </div>
                    <div>
                        <div class="fb-like" data-href="http://www.duocday.com/Detailphoto.aspx" data-send="false"
                            data-layout="button_count" data-width="90" data-show-faces="false">
                        </div>
                        <a name="fb_share" type="button_count" share_url="http://www.duocday.com/Detailphoto.aspx" href="http://www.facebook.com/sharer.php">
                            Share</a>
                        <%--<script src="http://static.ak.fbcdn.net/connect.php/js/FB.Share" type="text/javascript"></script>
                       <script src="Scripts/FB.Share.js" type="text/javascript"></script>
                    </div>
                    <div class="vote">
                        <div class="voteDown">
                            <a class="voteButton first " data-id="420343" data-upvote="false" href="#"><span>Chán</span></a>
                        </div>
                        <div class="voteUp">
                            <a class="voteButton " data-id="420343" data-upvote="true" href="#"><span>hay</span></a>
                        </div>
                    </div>
                </div>
                <div class="clear">
                </div>
            </div>
            <div id="listEnd">
            </div>
            <div class="listItemSeparator">
            </div>
            <p class="loading" style="display: none">
                <img src="http://s.haivl.com/content/images/loading.gif" />
                <br />
                Äang táº£i th&#234;m áº£nh...
            </p>
        </div>--%>
        <div class="clear">
        </div>
    </div>
    </div>
</asp:Content>

