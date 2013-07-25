<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>









<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1"><meta http-equiv="content-language" content="vi" /><title>
	Ảnh vui 
</title>
        <script src="Scripts/jquery-1.6.2.min.js" type="text/javascript"></script>
    <link rel="stylesheet" href="css/duocday.css" type="text/css" />
    <script src="Scripts/duocday.js" type="text/javascript"></script>
    <script src="Scripts/jquery.cookie.js" type="text/javascript"></script>
     <script src="Scripts/FB.Share.js" type="text/javascript"></script>
     <script language="javascript" type="text/javascript">
         function updateRecord() {

                 $.ajax({
                     type: "POST",
                     url: "MultipleUpdateWebService.asmx/updatehay",
                 
                     dataType: "json",
                     contentType: "application/json",
                     async: false,
                     success: function (message) {
                         ProductData(message.d);

                     },
                     error: function () {
                         alert("Some error occured!");

                     }
                 });

         }
     </script>
    
</head>
<body>
    
    <form method="post" action="vote.aspx" id="form1" runat="server">


    <div id="content">
        <div id="mainContainer">
            <div id="header">
                <div id="headerContent">
                    <a href="/" id="logo">duocday</a>
                    <ul id="menuBar">
                        <li class="selected"><a href="default.aspx">Hot</a></li>
                        <li><a href="old.aspx">Cũ</a></li>
                        <li><a href="vote.aspx">Bình chọn</a></li>
                        <li><a href="#">Xả Stress</a></li>
                        <li><a href="#">Cảm xúc</a></li>
                        <li><a href="#" target="_blank">Tìm kiếm nâng cao</a></li>
                    </ul>
                    <div id="loginPanel">
                        <a class="profileButton" href="photoupload.aspx?user=1">longnt </a><ul><li><a href="photoupload.aspx?user=1">Ảnh của bạn</a></li><li><a href="messenger.aspx?user=1">Thông báo </a></li><li><a href="profile.aspx?user=1">Thông tin cá nhân</a></li><li> <a id="auth-logoutlink" href="#">Thoát</a></li></ul>                  
                    </div>
                    <div id="upanh">
                        <a class="upload" href="/upload">Đăng ảnh</a>
                    </div>
                    <div class="clear">
                    </div>
                </div>
            </div>
            <div style="float: left; width: 985px; margin-bottom: 5px;">
                <div id="thongdiep">
                    ` <b class="dinhdang">Chạy thông điệp</b>
                    <div class="buttonhotro">
                        <a href="#">Hiện 18 +</a> <a href="#">Dạng lưới</a>
                    </div>
                </div>
                <div id="timkiem">
                    Phần tìm kiếm
                </div>
            </div>
            <div id="leftColumn">
                

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
        </div>
        <div class="photoList">
        <table id="ContentPlaceHolder1_ContentPlaceHolder1_dtlphoto" cellspacing="0" style="border-collapse:collapse;">
	<tr>
		<td>
                    <div class="photoListItem">
                        <div class="listItemSeparator">
                        </div>
                        <div class="thumbnail">
                            <a href="Detailphoto.aspx?ID=1" target="_blank">
                                <img src='http://localhost:3961/avatar/30883b79-6.jpg                                                                                                                                                                                                                                                                 ' alt='gdgdgd' class="thumbImg" />
                            </a>
                        </div>
                        <div class="info">
                            <h2>
                                <a target="_blank" href="Detailphoto.aspx?ID=1">
                                gdgdgd
                                   </a>
                            </h2>
                            <div class="uploader">
                                Đăng bởi <a href="photoupload.aspx?user=1">
                                    longnt</a>  <span id="ContentPlaceHolder1_ContentPlaceHolder1_dtlphoto_Label1_0">3 ngày</span> </div>
                            <div class="stats">
                                <div class="viewComments">
                                    <span class="views" title="lượt xem">0</span> <span class="comments" title="lượt bình luận">
                                        <span id="ContentPlaceHolder1_ContentPlaceHolder1_dtlphoto_Label2_0">0</span></span>
                                </div>
                                <div class="clear">
                                </div>
                            </div>
                            <div>
                                <div fb-xfbml-state="rendered" class="fb-like fb_edge_widget_with_comment fb_iframe_widget"
                                    data-href="Detailphoto.aspx?ID=1" data-send="false" data-layout="button_count"
                                    data-width="90" data-show-faces="false">
                                </div>
                                <a name="fb_share" type="button_count" share_url="Detailphoto.aspx?ID=1"
                                    href="http://www.facebook.com/sharer.php">Share</a>
                               
                            </div>
                            <div class="vote">
                        <div class="voteDown">
                            <a href="javascript:updateRecord()"><span>Chán</span></a>
                        </div>
                        <div class="voteUp">
                            <a class="voteButton " data-id="420343" data-upvote="true" href="#"><span>hay</span></a>
                        </div>
                    </div>
                        </div>
                        <div class="clear">
                        </div>
                    </div>
                </td>
	</tr><tr>
		<td>
                    <div class="photoListItem">
                        <div class="listItemSeparator">
                        </div>
                        <div class="thumbnail">
                            <a href="Detailphoto.aspx?ID=2" target="_blank">
                                <img src='https://www.youtube.com/watch?v=W-r3xAKWTbQ                                                                                                                                                                                                                                                                 ' alt='' class="thumbImg" />
                            </a>
                        </div>
                        <div class="info">
                            <h2>
                                <a target="_blank" href="Detailphoto.aspx?ID=2">
                                
                                   </a>
                            </h2>
                            <div class="uploader">
                                Đăng bởi <a href="photoupload.aspx?user=1">
                                    longnt</a>  <span id="ContentPlaceHolder1_ContentPlaceHolder1_dtlphoto_Label1_1">2 ngày</span> </div>
                            <div class="stats">
                                <div class="viewComments">
                                    <span class="views" title="lượt xem">0</span> <span class="comments" title="lượt bình luận">
                                        <span id="ContentPlaceHolder1_ContentPlaceHolder1_dtlphoto_Label2_1">0</span></span>
                                </div>
                                <div class="clear">
                                </div>
                            </div>
                            <div>
                                <div fb-xfbml-state="rendered" class="fb-like fb_edge_widget_with_comment fb_iframe_widget"
                                    data-href="Detailphoto.aspx?ID=2" data-send="false" data-layout="button_count"
                                    data-width="90" data-show-faces="false">
                                </div>
                                <a name="fb_share" type="button_count" share_url="Detailphoto.aspx?ID=2"
                                    href="http://www.facebook.com/sharer.php">Share</a>
                               
                            </div>
                            <div class="vote">
                        <div class="voteDown">
                            <a class="voteButton first " data-id="420343" data-upvote="false" href="javascript:updateRecord(2)"><span>Chán</span></a>
                        </div>
                        <div class="voteUp">
                            <a class="voteButton " data-id="420343" data-upvote="true" href="#"><span>hay</span></a>
                        </div>
                    </div>
                        </div>
                        <div class="clear">
                        </div>
                    </div>
                </td>
	</tr>
</table>
            
                       
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
        <asp:CheckBox ID="chk" runat="server" Checked="true"  Text="gdfgdg"/>
        <div class="clear">
        </div>
    </div>


                <div id="footer">
                    <ul class="left">
                        <li>© 2013 <a href="#" target="_blank">Appvl</a></li>
                    </ul>
                    <ul class="right">
                        <li><a href="#">Liên hệ</a> </li>
                        <li>·<a href="#">Giới thiệu</a> </li>
                        <li>·<a href="#">FAQ</a> </li>
                        <li>·<a href="#">Điều khoản</a> </li>
                        <li>·<a href="#">Cách vào Facebook</a> </li>
                        <li>·<a href="#" target="_blank">RSS</a> </li>
                        <li>·<a href=" http://www.facebook.com/duocdaydotcom" target="_blank">Facebook</a>
                        </li>
                    </ul>
                    <div class="clear">
                    </div>
                </div>
            </div>
            <div id="rightColumn">
                <div class="" id="rightscrl">
                    

    <div class="box darkBox socialBox">
    <h3>
        Ủng hộ duocday bạn nhé ^^</h3>
    <div class="media facebook">
        <div class="fb-like" data-href=" http://www.facebook.com/duocdaydotcom" data-send="false"
            data-width="270" data-show-faces="false">
        </div>
    </div>
    <div class="media twitter">
        <a href="https://twitter.com/" class="twitter-follow-button" data-show-count="true"
            data-size="large">Follow duocday</a>
        <script type="text/javascript">
            !function (d, s, id) { var js, fjs = d.getElementsByTagName(s)[0]; if (!d.getElementById(id)) { js = d.createElement(s); js.id = id; js.src = "//platform.twitter.com/widgets.js"; fjs.parentNode.insertBefore(js, fjs); } } (document, "script", "twitter-wjs");
        </script>
    </div>
    <div class="media google" style="border-bottom: none">
        <div class="g-plusone" data-href="http://www.duocday.com/">
        </div>
        <script type="text/javascript">
            (function () {
                var po = document.createElement('script'); po.type = 'text/javascript'; po.async = true;
                po.src = 'https://apis.google.com/js/plusone.js';
                var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(po, s);
            })();
        </script>
    </div>
    
</div>

    <div class="fixedScrollDetector">
    </div>
    <div class="fixedScroll">
        
		<div style="float:left;width:300px;height:400px;background-color:Black;">
        
        </div>
		
		<!-- haivl-trang-chu-bottom-small -->
		<div id='div-gpt-ad-1366006398362-0' style='width:300px; height:90px;display: none'>
			<script type='text/javascript'>
			    googletag.cmd.push(function () { googletag.display('div-gpt-ad-1366006398362-0'); });
			</script>
		</div>
       
    </div>
       
    </div>

                </div>
            </div>
            <div class="clear">
            </div>
        </div>
    </div>
    </form>
    <script type="text/javascript">
        duocday.Facebook.init("560041050701551");
    </script>
    <script type="text/javascript">
        duocday.ListPhoto.init("new", 1);
    </script>
    <script type="text/javascript">
        duocday.Uploader.init(190570, 1);
    </script>
</body>
</html>
