<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="forms_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>AUTOSALONI - Login</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="min-vh-100 d-flex justify-content-center align-items-md-center">
            <div class="container">

                <div class="row justify-content-center">
                    <div class="col-12 col-sm-10 col-md-8 col-lg-6">
                        <div>
                            <img src="../images/logo.png" class="w-100" />
                        </div>
                        <div>
                            <div class="card shadow">
                                <div class="card-body">
                                    <h5 class="card-title text-center text-primary">Login</h5>
                                    <div class="mb-3">
                                        <label for="email" class="form-label">Email</label>

                                        <asp:TextBox ID="txtUSR" runat="server" CssClass="form-control" placeholder="password"></asp:TextBox>
                                    </div>
                                    <div class="mb-3">
                                        <label for="password" class="form-label">Password</label>

                                        <asp:TextBox ID="txtPWD" runat="server" CssClass="form-control" placeholder="password" TextMode="Password"></asp:TextBox>
                                    </div>

                                    <asp:Button ID="btnLogin" runat="server" Text="Button" OnClick="btnLogin_Click" CssClass="btn btn-primary w-100" />

                                    <div class="d-flex justify-content-between">
                                        <a href="#" class="card-link m-0">Card link</a>
                                        <a href="#" class="card-link m-0">Another link</a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
</body>
</html>
