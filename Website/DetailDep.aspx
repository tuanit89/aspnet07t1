<%@ Page Title="" Language="C#" MasterPageFile="~/Hot.master" AutoEventWireup="true" CodeFile="detaildep.aspx.cs" Inherits="DetailDep" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<div class="box photoDetails">
        <asp:DataList ID="dtl" runat="server">
            <ItemTemplate>
                <div class="photoInfo">
                    <h1>
                      <%#Eval("tieuDe") %>
                        </h1>
                    <div class="stats">
                        <span class="views">Lượt xem: <span class="number"><%#Eval("luotXem") %></span></span> <span class="comments">
                            Lượt bình luận: <span class="number"><asp:Label ID="Label2" runat="server" Text=""></asp:Label></span></span>
                    </div>
                    <div class="source">
                        <span class="source">Nguồn: <span class="text"><%#Eval("nguonPic") %></span></span>
                    </div>
                </div>
                <div class="uploader">
                    Đăng <asp:Label ID="Label1" runat="server" Text=""></asp:Label> trước bởi
                    <div>
                        <img src="<%#Eval("avatar") %>" />
                        <div class="info"><a href="photoupload.aspx?user=<%#Eval("idUser") %>">
                             <%#Eval("tenHienThi") %>
                        </a><span class="likes" title="lượt thích"> <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label> </span></div>
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
                <asp:Literal ID="Literal2" runat="server"></asp:Literal>
                    <div class="fbLikeButton">
                        <div class="fb-like" data-href="<%#"http://duocday.com/Detailphoto.aspx?ID="+Eval("idPic") %>" data-send="false"
                            data-show-faces="false" data-layout="button_count">
                        </div>
                        <a name="fb_share" type="button_count" share_url="<%#"http://duocday.com/Detailphoto.aspx?ID="+Eval("idPic") %>"
                            href="http://www.facebook.com/sharer.php">Share</a>
                       
                    </div>
                    <asp:Literal ID="Literal1" runat="server"></asp:Literal>
                   <%-- <div class="navButtons">
                        <a class="prev" href="#" title="">Ảnh trước</a> <a class="next" href="#"
                            title="">Ảnh sau</a>
                    </div>--%>
                </div>
                <div class="clear">
                </div> 
                <asp:Panel runat="server" ID="image" Visible="false">
                <div class="photoImg">
                    <img class="thumbImg" alt="<%#Eval("tieuDe") %>" src='<%#Eval("url") %>'></img>
                </div>
                </asp:Panel>
                <asp:Panel runat="server" ID="video" Visible="false">
                    <div class="photoImg">
                    <iframe width="650" height="365" src="<%#Eval("urlVideo") %>" frameborder="0" allowfullscreen></iframe>
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
                    <div class="fb-comments" data-href="<%#"http://duocday.com/detaildep.aspx?ID="+Eval("idPic") %>" data-num-posts="10"
                        data-width="655">
                    </div>
                </div>
            </ItemTemplate>
        </asp:DataList>
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

