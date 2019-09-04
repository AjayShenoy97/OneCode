<%@ Page Title="" Language="C#" MasterPageFile="~/TK9Store.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="PetEcommerce.Registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphK9StoreMasterPage" runat="server">
    <div id="blockage" class="blockageWall" runat="server"></div>
    <div class="container newContainer col-xs-10 col-sm-10 col-md-4 col-lg-3">
        <div>
           <h1>
               <asp:Label ID="lblRegistration" runat="server" Text="REGISTRATION FORM"></asp:Label>
           </h1> 
        </div>
        <div class="formContent col-xs-12 col-sm-12 col-md-10 col-lg-10">
            <asp:TextBox CssClass="textBox" ID="txtFirstName" PlaceHolder="First Name" runat="server"></asp:TextBox>
            <hr />
            <asp:TextBox CssClass="textBox" ID="txtLandmark" PlaceHolder="Landmark" runat="server"></asp:TextBox>
            <hr />
            <asp:TextBox CssClass="textBox" ID="txtCity" PlaceHolder="City" runat="server"></asp:TextBox>
            <hr />
            <asp:TextBox CssClass="textBox" ID="txtPincode" PlaceHolder="Pincode" runat="server"></asp:TextBox>
            <hr />
            <asp:TextBox CssClass="textBox" ID="txtState" PlaceHolder="State" runat="server"></asp:TextBox>
            <hr />
            <asp:TextBox CssClass="textBox" ID="txtContact" PlaceHolder="Contact Number" runat="server"></asp:TextBox>
            <hr />
            <asp:TextBox CssClass="textBox" ID="txtEmailId" PlaceHolder="Email ID" runat="server"></asp:TextBox>
            <hr />
            <asp:TextBox CssClass="textBox" ID="txtPassword" PlaceHolder="Password" runat="server"></asp:TextBox>
            <hr />
            <asp:TextBox CssClass="textBox" ID="txtConfirmPW" PlaceHolder="Confirm Password" runat="server"></asp:TextBox>
            <hr />
             <div class="loginButton">
                <asp:Button ID="btnSignUp" runat="server" Text="Sign Up" />
            </div>
            <div class="newUser">
                <asp:HyperLink ID="hlRegUser" runat="server">Already a Member? Login Here!</asp:HyperLink>
            </div>
        </div>
        
    </div>
</asp:Content>
