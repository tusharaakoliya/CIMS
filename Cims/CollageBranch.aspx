<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="CollageBranch.aspx.cs" Inherits="Cims.CollageBranch" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div>
        <fieldset id="Fieldset1">
            <legend style="background-color: ButtonShadow; padding: 10px;">
                <label id="lblcont" class="lblfieldSet">
                    &nbsp;Branches&nbsp;</label>
            </legend>
            <table class="tblAll">
                <tr>
                    <td>
                        <asp:Label ID="lblclgname" runat="server" Text="Collage"></asp:Label>
                    </td>
                    <td>

                        <asp:DropDownList ID="ddlcollage" runat="server" AppendDataBoundItems="true">
                            <asp:ListItem Text="-- Select Collage --" Value="0"></asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator runat="server" ID="rfvcollage" InitialValue="0" ControlToValidate="ddlCollage" ErrorMessage="*" ToolTip="Collage is required"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblcoursename" runat="server" Text="Branch"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlBranch" runat="server" AppendDataBoundItems="true">
                            <asp:ListItem Text="-- Select Branch --" Value="0"></asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator runat="server" ID="reqddlBranch" InitialValue="0" ControlToValidate="ddlBranch" ErrorMessage="*" ToolTip="Branch is required"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblSeat" Text="Total Seat" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtSeat" MaxLength="3" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" ID="rvfSeat" ControlToValidate="txtSeat" ErrorMessage="*" ToolTip="Seat is required"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="revSeat" ControlToValidate="txtSeat" runat="server" ErrorMessage="*" ToolTip="Only Number is allowed" ValidationExpression="\d+"></asp:RegularExpressionValidator>
                    </td>
                </tr>

                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" Style="height: 26px" />
                        <asp:Button ID="btnCancel" runat="server" Text="Cancel" CausesValidation="false" OnClick="btnCancel_Click" />
                    </td>
                </tr>
            </table>
        </fieldset>
    </div>
</asp:Content>
