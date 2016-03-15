<%@ Page Language="C#" AutoEventWireup="true" CodeFile="home.aspx.cs" Inherits="home" %>

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
 <div class="alert alert-info">Welcome! : <strong><a href=home.aspx>Create Event</a></strong>  | <strong><a href=view_events.aspx>View Events</a></strong> | <strong><a href=join.aspx>Join Events</a></strong> | <strong><a href=members.aspx>Members</a></strong> | <strong><a href=index.aspx>Logout</a></strong> </div>
 </div>
 </div>

    <div class="row">
    <div class="col-md-6 col-md-offset-3">
    <div style="max-width: 800px;">
            <div class="panel panel-default alert-info" >
                <div class="panel-heading h4 text-primary text-center">
Create Event</div>
<div class="panel-body">
                    <div class="form-horizontal" role="form">
                        <div class="form-group">
                            <label class="col-md-2 control-label" for="txtusr">Event Name</label>
                            <div class="col-md-10">
                                <asp:textbox class="form-control" id="txtev" placeholder="Enter Event" runat="server"></asp:textbox>
                            </div>
</div>

<div class="form-group">
                            <div class="col-md-offset-2 col-md-10">
                                <asp:label cssclass="label label-danger" id="lblmsg" runat="server"></asp:label>
                            </div>
</div>

<div class="form-group">
                            <div class="col-md-offset-2 col-md-10">
                             <asp:button class="btn btn-success" id="btnCreate" onclick="btnCreate_Click" runat="server" text="Submit">
                            </asp:button></div>
</div>

</div>
</div>
</div>
</div>
<div class="form-group">
                            <div class="col-md-offset-2 col-md-10">
                              <asp:label cssclass="label alert-info" id="lblsuccess" runat="server"></asp:label>
                           </div>
                           
</div>
</div>
</div>
</div>

</form>
</body>
</html>
