<%@ Page Language="C#" AutoEventWireup="true" CodeFile="register.aspx.cs" Inherits="register" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="bootstrap/css/bootstrap.min.css" rel="stylesheet"/>
    <script type="text/javascript"  src="bootstrap/js/bootstrap.min.js"></script>
    <script type="text/javascript" src="bootstrap/js/jquery.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
   <div class="container">

    <div class="row">
    <div class="col-md-6 col-md-offset-3">
    <div style="max-width: 800px;">
            <div class="panel panel-default alert-info" >
                <div class="panel-heading h4 text-primary text-center">
Create Account</div>
<div class="panel-body">
                    <div class="form-horizontal" role="form">
                        <div class="form-group">
                            <label class="col-md-2 control-label" for="txtusr">Username</label>
                            <div class="col-md-10">
                                <asp:textbox class="form-control" id="txtusr" placeholder="Enter Username" runat="server"></asp:textbox>
                            </div>
</div>
<div class="form-group">
                            <label class="col-md-2 control-label" for="txtpwd" >Password</label>
                            <div class="col-md-10">
                                <asp:textbox class="form-control" id="txtpwd" placeholder="Enter Password" runat="server" textmode="Password"></asp:textbox>
                            </div>
</div>
<div class="form-group">
                            <label class="col-md-2 control-label" for="txtpwd" >Confirm Password</label>
                            <div class="col-md-10">
                                <asp:textbox class="form-control" id="txtcon" placeholder="Confirm Password" runat="server" textmode="Password"></asp:textbox>
                            </div>
</div>
<div class="form-group">
                            <div class="col-md-offset-2 col-md-10">
                                <asp:label cssclass="label label-danger" id="lblmsg" runat="server"></asp:label>
                            </div>
</div>
<div class="form-group">
                            <div class="col-md-offset-2 col-md-10">
                             <asp:button class="btn btn-success" id="btnRegister" onclick="btnRegister_Click" runat="server" text="Submit">
                            </asp:button></div>
</div>
<div class="form-group">
                            <div class="col-md-offset-2 col-md-10">
                                <asp:label id="creat_account" runat="server"><a href="index.aspx">Already Registered</a></asp:label>
                            </div>
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
