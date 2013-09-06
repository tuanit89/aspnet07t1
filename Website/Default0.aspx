<%@ Page Title="" Language="C#" MasterPageFile="~/DefaultPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default0" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="box">
        <h3>
            Ảnh mới</h3>
                     <div class="photoList">
            <asp:DataList ID="dtlphoto" runat="server">
                <ItemTemplate>
                    <div class="photoListItem">
                        <div class="listItemSeparator">
                        </div>
                        <div class="thumbnail">
                            <a href="<%#"Detailphoto.aspx?ID="+Eval("idPic") %>" target="_blank">
                                <img src='<%#Eval("url") %>' alt='<%#Eval("tieuDe") %>' class="thumbImg" />
                                <asp:Literal ID="Literal1" runat="server"></asp:Literal>
                            </a>
                        </div>
                        <div class="info">
                            <h2>
                                <a target="_blank" href="<%#"Detailphoto.aspx?ID="+Eval("idPic") %>">
                                <%#Eval("tieuDe") %>
                                   </a>
                            </h2>
                            <div class="uploader">
                                Đăng bởi <a href="<%#"photoupload.aspx?user="+Eval("idUser") %>">
                                    <%#Eval("tenHienThi") %></a>  <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label> trước</div>
                            <div class="stats">
                                <div class="viewComments">
                                    <span class="views" title="lượt xem"><%#Eval("luotXem") %></span> <span class="comments" title="lượt bình luận">
                                        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></span>
                                </div>
                                <div class="clear">
                                </div>
                            </div>
                            <div>
                               <%-- <div fb-xfbml-state="rendered" class="fb-like fb_edge_widget_with_comment fb_iframe_widget"
                                    data-href="<%#"http://duocday.com/Detailphoto.aspx?ID="+Eval("idPic") %>" data-send="false" data-layout="button_count"
                                    data-width="0" data data-show-faces="true">
                                </div>--%>
                                <iframe src="//www.facebook.com/plugins/like.php?href=<%#"http://duocday.com/Detailphoto.aspx?ID="+Eval("idPic") %>2Fdocs%2Freference%2Fplugins%2Flike&amp;send=false&amp;layout=button_count&amp;width=90&amp;show_faces=true&amp;font&amp;colorscheme=light&amp;action=like&amp;height=21" scrolling="no" frameborder="0" style="border:none; overflow:hidden; width:90px; height:21px;" allowTransparency="true"></iframe>
                                <a name="fb_share" type="button_count" share_url="<%#"http://duocday.com/Detailphoto.aspx?ID="+Eval("idPic") %>"
                                    href="http://www.facebook.com/sharer.php">Share</a>
                               
                            </div>
                        </div>
                        <div class="clear">
                        </div>
                    </div>
                </ItemTemplate>
            </asp:DataList>
            <div id="listEnd">
            </div>
            <div class="listItemSeparator">
            </div>
        </div>
        <div class="clear">
        </div>
    </div>
</asp:Content>

