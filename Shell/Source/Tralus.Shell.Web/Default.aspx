<%@ Page Language="C#" AutoEventWireup="true" Inherits="Default" EnableViewState="false"
    ValidateRequest="false" CodeBehind="Default.aspx.cs" %>
<%@ Register Assembly="DevExpress.ExpressApp.Web.v15.2, Version=15.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" 
    Namespace="DevExpress.ExpressApp.Web.Templates" TagPrefix="cc3" %>
<%@ Register Assembly="DevExpress.ExpressApp.Web.v15.2, Version=15.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.ExpressApp.Web.Controls" TagPrefix="cc4" %>
<!DOCTYPE html>
<html>
<script src="Scripts/jquery-2.1.4.min.js"></script>
<script src="Scripts/bootstrap-datepicker-all.js"></script>
<script src="Scripts/bootstrap-clockpicker.min.js"></script>
<script src="Scripts/knockout-3.3.0.js"></script>
<link href="Content/tralus.css" rel="stylesheet" />
<link href="Content/datepicker3.css" rel="stylesheet" />
<link href="Content/bootstrap-clockpicker.min.css" rel="stylesheet" />

<head runat="server">
    <title>Main Page</title>
    <meta http-equiv="Expires" content="0" />
</head>
<body class="VerticalTemplate">
    <form id="form2" runat="server">
    <cc4:ASPxProgressControl ID="ProgressControl" runat="server" />
    <div runat="server" id="Content" />
    </form>
</body>
</html>
