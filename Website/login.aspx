<%@ Page Title="" Language="C#" MasterPageFile="~/MasterBase.Master" AutoEventWireup="true" Inherits="login" Codebehind="login.aspx.cs" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Đăng nhập</h3>
    <div id="checkingStatus" style="display: none;">
        <h4><img src="/content/images/icons/loading.gif"> Đang kiểm tra kết nối của bạn với Facebook. Ấn F5 nếu thực hiện quá lâu. Thử <a href="http://forum.haivl.com/threads/4016/" target="_blank">Xóa cache trình duyệt</a> nếu vẫn không được.</h4>
    </div>
    <div id="loginPanel">
        <p>Click vào nút dưới đây để đăng nhập với tài khoản Facebook của bạn. Tài khoản của bạn trên <strong>duocday</strong> sẽ tự động được tạo sau lần đăng nhập đầu tiên mà không cần đăng ký.</p>
    </div>

   <div class="fb-login-button" data-show-faces="false" data-width="400" data-max-rows="1" data-scope="email,publish_actions,user_birthday"></div>
     <div>
        <h4>Hoặc <a href="/account/loginpassword">đăng nhập bằng mật khẩu</a> nếu bạn đã có tài khoản trên được đấy.</h4>
    </div>
    <div>Chú ý: bằng việc đăng nhập bạn đã đồng ý với <a href="/tos">Điều khoản sử dụng</a> của <strong>duocday.com</strong>.</div>
    <div style="display: none">
        <form method="POST" name="postFB" id="loginForm" action="/API/Login.ashx">
            <input type="hidden" name="accesstoken" id="accesstoken"/>
        </form>
    </div>
    <script type="text/javascript">
        
        window.fbAsyncInit = function() {
            FB.getLoginStatus(function (response) {
                if (response.authResponse) {
                    console.log(response);
                    $("#checkingStatus").show();
                    submitToken(response);
                } else {
                    $("#checkingStatus").hide();
                }
            });
            
            //subcribe event when user change login app
            FB.Event.subscribe('auth.authResponseChange', function (response) {
                if (response.authResponse) {
                    submitToken(response);
                }
            });
        };
        var isLoaded = false;
        function submitToken(response) {
            if (isLoaded)
                return;
            isLoaded = true;
            console.log(isLoaded);
            console.log(response.authResponse.accessToken);
            $("#accesstoken").val(response.authResponse.accessToken);
            $("#loginForm").submit();
        }
    </script>
</asp:Content>

