﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Thoat.aspx.cs" Inherits="Thoat" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script language="javascript" type="text/javascript">
        
            FB.logout(function () {
                top.location.href = 'url'
            });
        
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <a href="#" onclick="FB.logout();">logout</a>
    </div>
    </form>
</body>
</html>
