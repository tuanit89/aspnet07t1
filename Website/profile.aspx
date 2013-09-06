<%@ Page Title="" Language="C#" MasterPageFile="~/MasterUser.master" AutoEventWireup="true" Inherits="profile" Codebehind="profile.aspx.cs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="box infoBox inputForm updateAccount">
    <h3>Cập nhật thông tin cá nhân</h3>

<p class="required"> 
            <label for="Email">Email</label>
                <input class="text mediumWidth"  disabled="disabled" id="Email" name="Email" type="text" value='kaiwa88@gmail.com' />            
            
        </p>
        <p class="required">
            <label for="Name">Tên hiển thị</label>
            
            <input class="text mediumWidth"  disabled="disabled" id="Text1" name="Email" type="text" value='được đấy' />
        </p>
        <p>
            <%--<input class="checkboxLabel" id="chkhienface" name="chkhienface" runat="server" type="checkbox" />
            <label class="checkboxLabel" for="IsDisplayFacebokProfile">Hiện địa chỉ Facebook ở trang cá nhân</label>--%>
            <input class="checkboxLabel" id="chkhienface" name="chkhienface" runat="server" type="checkbox" />
            <label class="checkboxLabel" for="chkhienface">Hiện địa chỉ Facebook ở trang cá nhân</label>
        </p>
        <p>
            <label>Avatar</label>
            <img class="avatar" src="avatar/8c7a221b-c.jpg" width="100" height="100" />
            <asp:FileUpload ID="avatar" runat="server" />
            
            
        </p> 
        <p>
            <label for="Websites">Website</label>
            <%--<asp:TextBox class="text mediumWidth" cols="20" id="Websites" TextMode="MultiLine" runat="server" ></asp:TextBox>--%>
            <textarea class="text mediumWidth" cols="20" id="Websites" name="Websites" rows="2">
            
            </textarea>
            
        </p>
        <p>
            <label for="About">Giới thiệu</label>
          
            <textarea class="text mediumWidth" cols="20" id="gt" name="gt" rows="2">
            
            </textarea>
            
        </p>
        <p class="buttonSet">
            <button type="submit" class="buttons submitButton" onclick="btn_click()" runat="server">Cập nhật</button>
            
            <a class="buttons cancelButtons" href="Default.aspx">Bỏ qua</a>
        </p></div>
    
</asp:Content>


