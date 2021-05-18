<%@ Page Title="" Language="C#" MasterPageFile="~/Student.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Cims.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <fieldset id="Fieldset1">
        <legend style="background-color: ButtonShadow; padding: 10px;">
            <label id="lblcont" style="background-color: ButtonShadow; color: White; font-family: Trebuchet MS;
                font-weight: bold; font-size: 12pt;">
                &nbsp;Login&nbsp;</label>
        </legend>
        <center>
            <table width="100%" cellpadding="0" cellspacing="7" border="0" style="margin: 12px">
                <tr>
                   
                    <td colspan="6"  style="color: #5E5A80;text-align:center; font-size: 24pt">Login 
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                        <hr style="color: #363258">
                    </td>
                </tr>
                <tr>
                    <td style="width: 35%; color: Black" align="right">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        Username
                    </td>
                    <td style="width: 5%">
                        :
                    </td>
                    <td align="left" style="width: 60%">
                        <asp:TextBox ID="txtUsername" runat="server" Width="210px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUsername"
                            ErrorMessage="Enter Login ID" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td style="width: 35%; color: Black" align="right">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        Password
                    </td>
                    <td style="width: 5%">
                        :
                    </td>
                    <td align="left" style="width: 60%">
                        <asp:TextBox ID="txtPassword" runat="server" Width="210px" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter  Password"
                            ForeColor="Red" ControlToValidate="txtPassword"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                        <hr style="color: #363258">
                    </td>
                </tr>
                <tr>
                    <td colspan="3" align="center">
                        <asp:Button ID="btnlogin" runat="server" Text="Login" Width="135px" Height="29px" OnClick="btnlogin_Click"/>&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                        <hr style="color: #363258">
                    </td>
                </tr>
                <tr>
                    <td style="color: #0099ff;" align="center" colspan="3">
                        <asp:HyperLink ID="hlnkregister" Text="Register Here" runat="server" NavigateUrl="~/Register.aspx"
                            Font-Bold="True" Font-Underline="True"></asp:HyperLink>
                    </td>
                   <%-- <td style="color: #0099ff;" align="right">
                        <asp:HyperLink ID="hlnlkfgtpass" Text="Forgot Password ?" runat="server" NavigateUrl="~/user/forgot password.aspx"
                            Font-Bold="True" Font-Underline="True"></asp:HyperLink>
                    </td>
                    <td style="color: #0099ff;" align="center" colspan="2">
                        <asp:HyperLink ID="hlnkregister" Text="Register Here" runat="server" NavigateUrl="~/user/register.aspx"
                            Font-Bold="True" Font-Underline="True"></asp:HyperLink>
                    </td>--%>
                </tr>
                <tr>
                    <td colspan="3">
                        <hr style="color: #363258">
                    </td>
                </tr>
            </table>
        </center>
    </fieldset>
</asp:Content>
