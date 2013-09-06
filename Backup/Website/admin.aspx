<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPage.master" AutoEventWireup="true" CodeFile="admin.aspx.cs" Inherits="admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<asp:GridView ID="GRV" runat="server" AutoGenerateColumns="false" OnRowCommand="GRV_Click"
                    BorderWidth="2" CellPadding="2" OnRowDataBound="GridView_RowDataBound"
                    HeaderStyle-BackColor="LightSkyBlue"
                    AllowPaging="true" PageSize="30"
                    Width="100%" CellSpacing="10">
                    <Columns>
                    <asp:BoundField DataField="tieuDe" HeaderText="tiêu đề ảnh" ControlStyle-ForeColor="LightSkyBlue" />
                    <asp:CheckBoxField DataField="hienAnh" HeaderText="hiện ảnh" />

                    <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton runat="server" ID="lbChon" Width="35px" CommandArgument='<%#Eval("idPic")+"|C" %>' CssClass="iconupdate2">update</asp:LinkButton>
                     </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton runat="server" ID="lbxoa" Width="30px" CommandArgument='<%#Eval("idPic")+"|X" %>'>delete</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
        <asp:DataList ID="dtl" runat="server">
            <ItemTemplate>
                <div class="photoInfo">
                    <h1>
                      <%#Eval("tieuDe") %>
                        </h1>
                    <div class="source">
                        <span class="source">Nguồn: <span class="text"><%#Eval("nguonPic") %></span></span>
                    </div>
                </div>
                <div class="clear">
                </div>
                <div class="fixedScrollDetector" data-fixedtop="43">
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
                <asp:CheckBox ID="CheckBox1" Text="Hiện 18+" runat="server" Checked='<%#Eval("hien18") %>' />
            </ItemTemplate>
        </asp:DataList>
        <asp:Button ID="Button1" runat="server" Text="Cập nhật" OnClick="btn_click" />
</asp:Content>


