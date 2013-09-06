<%@ Page Title="" Language="C#" MasterPageFile="~/MasterUpload.master" AutoEventWireup="true" Inherits="uploadanh" Codebehind="upload.aspx.cs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<script language="Javascript" type="text/javascript">
    function fileanh() {
        //window.location.href = document.getElementById('ololo').href;
        document.getElementById('duongdan').style.display = 'none';
        document.getElementById('fileanh').style.display = 'block';
        
    }
    function ddanh() {
        //window.location.href = document.getElementById('ololo').href;
        document.getElementById('duongdan').style.display = 'block';
        document.getElementById('fileanh').style.display = 'none';
    }
    function picture() {
        //window.location.href = document.getElementById('ololo').href;
        document.getElementById('picture').style.display = 'block';
        document.getElementById('video').style.display = 'none';
    }
    function video() {
        //window.location.href = document.getElementById('ololo').href;
        document.getElementById('video').style.display = 'block';
        document.getElementById('picture').style.display = 'none';
    }
</script>
<div class="box inputForm upload">
    <div id="picture" style="display:block;">
        <h3>
            Đăng hình ảnh mới
            <a href="javascript:video()" class="toggleMode">Đăng video</a>
        </h3>
        <p>
            <asp:Label ID="thongbao" runat="server" Font-Bold="true" ></asp:Label>
            
        </p>
        <p>
                <label for="Caption">Chuyên mục ảnh</label>
            <dropdownlist id = "drpchuyenmuc" name="drpchuyenmuc"></dropdownlist>
             <asp:Label ID="thbaomuc" runat="server" Font-Bold="true" ForeColor="Red" Text=""></asp:Label>
            </p>
        <p>
                
                <a style="font-weight:bold" href="javascript:fileanh()">Upload file ảnh</a>/<a style="font-weight:bold" href="javascript:ddanh()">Đường dẫn ảnh</a>
                <div id = "fileanh" style="display:block;">
                <input id="file" name="file" runat="server" type="file" />
                
                </div>
                 <div id = "duongdan" style="display:none;">
                <input class="text" id="ddanh" name="chkhienface" runat="server" type="text" />
                
                </div>
            
                 <input id="thbaofile" name="thbaofile" runat="server" type="text" />
            </p>
            <p>
                <label for="Caption">Tiêu đề của ảnh</label>
               <input class="text largeWidth" id="txttieudeanh" name="txttieudeanh" runat="server" type="text" />
               <input class="text" id="thbaotdeanh" name="thbaotdeanh" runat="server" type="text" />
           

            </p>

            <p>
                <input class="checkBoxWidth" id="chknguonanh" runat="server" type="checkbox" />
                <label class="checkboxLabel" for="chknguonanh">Ảnh này do tôi tự làm!</label>
            </p>
            <p>
                <label for="Source">Nguồn của ảnh</label>
                <input class="text largeWidth" id="nguonanh" type="text" runat="server" />
                 
                  <input id="thbaonguonanh" name="thbaonguonanh" runat="server" type="text" />
            </p>
            <p class="buttonSet">
                    <%--<asp:Button ID="Button2" runat="server" Text="Đăng ảnh" Height="32" BackColor="#00A5F0" OnClick="btnanh_click" />--%>
                    
               <input id="Text1" name="thbaonguonanh" runat="server" type="button" />
            </p>
        
     </div>
     <div id="video" style="display:none;">
                <h3>
            Đăng video
            <a class="toggleMode" href="javascript:picture()">Đăng ảnh</a>
        </h3>
        <%--<div class="tips">
            Bạn biết video clip hài hước, vui nhộn trên Youtube? Hãy chia sẻ tiếng cười với mọi người bằng cách đăng lên haivl. 
            Và đừng quên đọc <b style="color: red">Nội quy</b> ở bên phải nhé!
        </div>--%>
                <p >
                <label for="Caption">Chuyên mục ảnh</label>
                <dropdownlist id="drpchuyenmuc" name="drpchuyenmuc"></dropdownlist>
            </p>
        <p >
                <label for="YoutubeUrl">Đường dẫn đến video Youtube</label>
                <label class="help">Copy từ thanh địa chỉ trình duyệt mà bạn đang xem Youtube</label>
                <label class="help">Ví dụ: http://www.youtube.com/watch?v=9bZkp7q19f0</label>
                <input class="text largeWidth" id="ddvideo"  type="text" runat="server" />
                
            </p>
            <div id="youtubeEmbed"></div>
            <p >
                <label for="Caption">Tiêu đề của video</label>
                <input class="text largeWidth" id="tdevideo" name="Caption" type="text" runat="server" />
                
            </p>
            <p class="buttonSet">
                <button class="buttons submitButton" type="submit" id="Button1">
                    Đăng video</button>
                    <%--<asp:Button ID="Button1" runat="server" Text="Đăng video" Height="32" BackColor="#00A5F0" OnClick="btvideo_click" />--%>
            </p>
     </div>
</div>
</asp:Content>

