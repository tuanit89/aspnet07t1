<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CS.aspx.cs" Inherits="CS" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <meta property="og:type" content="haivlcom:photo" />
    <meta property="og:url" content="http://duocday.com" />
    <meta property="og:title" content="thử thôi nhé" />
        <meta property="og:description" content="Click để xem hình ảnh và tham gia chém gió" />    
    <meta property="og:image" content="http://s2.haivl.com/data/photos2/20130724/363f4b5d469c4ba5a8a689873e2db872/thumbnail-fa8287bb57f943dbad0d877042b9f74c.jpg" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <a id="lnkFacebook" target="blank" runat="server">Facebook Share</a>
    <a href="https://www.facebook.com/sharer/sharer.php?u=http://duocday/CS.aspx" target="_blank">

  Share on Facebook
</a>
   <a href="#" 
  onclick="
    window.open(
      'https://www.facebook.com/sharer/sharer.php?u='+encodeURIComponent(parse.com), 
      'facebook-share-dialog', 
      'width=626,he