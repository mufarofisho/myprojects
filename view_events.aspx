<%@ Page Language="C#" AutoEventWireup="true" CodeFile="view_events.aspx.cs" Inherits="view_events" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link href="bootstrap/css/bootstrap.min.css" rel="stylesheet" type="text/css"/>
    <script type="text/javascript"  src="bootstrap/js/bootstrap.min.js"></script>
    <script type="text/javascript" src="bootstrap/js/jquery.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
     <div class="row">
    <div class="col-md-6 col-md-offset-3">
 <div class="alert alert-info">Welcome! : <strong><a href=home.aspx>Create Event</a></strong>  | <strong><a href=view_events.aspx>View Events</a></strong> | <strong><a href=join.aspx>Join Events</a></strong> | <strong><a href=members.aspx>Members</a></strong></div>

 </div>
 </div>
 <div class="row">
    <div class="col-md-6 col-md-offset-3">
 <div class="panel panel-default alert-info" >
                <div class="panel-heading h4 text-primary text-center">
                    Event List</div>
<div class="panel-body">
 <div class="form-group">
                            <div class="col-md-offset-2 col-md-10">
                         
                                <asp:label cssclass="label label-danger" id="lblmsg" runat="server"></asp:label>
                                <br />
                            </div>
</div>


       <asp:GridView ID="GridView1" runat="server" Width="100%">
                                </asp:GridView>


<div class="row">
<div class="col-md-4 col-md-offset-4">
<hr/>
</div>
</div>
</div>
</div>
</div>
</div>
</div>
 </form>
</body>
</html>
