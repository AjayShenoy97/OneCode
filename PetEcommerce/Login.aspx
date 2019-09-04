<%@ Page Title="" Language="C#" MasterPageFile="~/TK9Store.Master" UnobtrusiveValidationMode="none" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PetEcommerce.Login" %>
<asp:Content ID="contentHead" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="contentBody" ContentPlaceHolderID="cphK9StoreMasterPage" runat="server">
    <div id="blockage" class="blockageWall" runat="server"></div>
    <div class="container col-xs-10 col-sm-10 col-md-6 col-lg-5">
        <div class="dogImage displayContent col-xs-12 col-sm-12 col-md-6 col-lg-6">
            <asp:Image ID="imgLogin" runat="server" ImageUrl="~/Images/loginImage.png" />
        </div>

        <div class="formLogin col-xs-12 col-sm-12 col-md-6 col-lg-6">
            <h1>Login Form</h1>
            <div class="loginDetails">
                <div>
                    <asp:Label ID="lblEmailId" runat="server" Text="Email Id"></asp:Label>
                </div>
                <div>
                    <asp:TextBox ID="txtEmailId" PlaceHolder="Email Id" runat="server"></asp:TextBox>
                </div>
                <div class="rfvValidator">
                    <asp:RequiredFieldValidator ID="rfvUserName" ControlToValidate="txtEmailId" runat="server" ErrorMessage="Email Id Required" ForeColor="red"></asp:RequiredFieldValidator>
                </div>

                <div>
                    <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
                </div>
                <div>
                    <input id="txtPassword" placeholder="Enter Password" runat="server" type="password" />
                    <div class="rfvValidator">
                        <asp:RequiredFieldValidator ID="rfvPassword" ControlToValidate="txtPassword" runat="server" ForeColor="red" ErrorMessage="Password Required"></asp:RequiredFieldValidator>
                    </div>
                </div>
            </div>
            <div class="loginButton">
                <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
            </div>
            <div class="newUser" style="text-align: center">
                <asp:HyperLink ID="hlNewUser" runat="server">New User</asp:HyperLink>
            </div>
            <div class="invalidPassword">
                <asp:Label ID="lblInvalidUser" runat="server" Text=""></asp:Label>
            </div>
        </div>
        

    </div>
</asp:Content>
