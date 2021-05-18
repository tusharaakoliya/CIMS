<%@ Page Title="" Language="C#" MasterPageFile="~/Student.Master" AutoEventWireup="true" CodeBehind="Marks.aspx.cs" Inherits="Cims.Marks" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="css/admin.css" />
    <table width="100%">
        <tr>
            <td style="width: 13%" valign="top" id="tdadminmenu" runat="server">
                <div id="navigation">

                    <ul class="top-level">
                        <li id="Marks"><a href="BranchList.aspx">Marks</a></li>
                    </ul>

                </div>
            </td>

            <td style="width: 77%" id="tdConent" runat="server">
                <table style="width: 100%" class="tblAll">
                    <tr>
                        <td style="width: 15%"></td>
                        <td style="width: 28%">
                            <asp:Label ID="Label1" runat="server" Text="Maths"></asp:Label>
                        </td>
                        <td style="width: 28%">
                            <asp:Label ID="Label2" runat="server" Text="Science"></asp:Label>
                        </td>
                        <td style="width: 28%">
                            <asp:Label ID="Label3" runat="server" Text="English"></asp:Label>
                        </td>

                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblmaths" runat="server" Text="Enter Your marks : "></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtmathes" MaxLength="50" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvmaths" ControlToValidate="txtmathes" runat="server" ErrorMessage="*" ForeColor="Red" ToolTip="Marks is required"></asp:RequiredFieldValidator>

                        </td>
                        <td>
                            <asp:TextBox ID="txtscience" MaxLength="50" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rvfscience" ControlToValidate="txtscience" runat="server" ErrorMessage="*" ForeColor="Red" ToolTip="Marks is required"></asp:RequiredFieldValidator>
                        </td>
                        <td>
                            <asp:TextBox ID="txtenglish" MaxLength="50" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rvfenglish" ControlToValidate="txtenglish" runat="server" ErrorMessage="*" ForeColor="Red" ToolTip="Marks is required"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>
                            <asp:Button ID="btnSave" CssClass="clsSave" runat="server" Text="Save" />
                            <asp:Button ID="btnCancel" CssClass="clsSave" runat="server" Text="Cancel" CausesValidation="false" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>

</asp:Content>
