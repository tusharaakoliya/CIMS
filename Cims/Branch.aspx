<%@ Page Title="" Language="C#" MasterPageFile="~/Student.Master" AutoEventWireup="true" CodeBehind="Branch.aspx.cs" Inherits="Cims.Brach" %>

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
                        <asp:Label ID="lblbranchname" runat="server" Text="Branch Name"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtbranchName" MaxLength="50" runat="server"  Width="190px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvBranchName" ControlToValidate="txtbranchName" runat="server" ErrorMessage="*" ForeColor="Red" ToolTip="Branch Name is required"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblDescription" runat="server" Text="Description"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtDescription" MaxLength="10" runat="server" TextMode="MultiLine" Rows="4" Columns="57"></asp:TextBox>

                    </td>

                </tr>
                <tr>
                    <td>
                        <asp:Label runat="server" ID="lblCourse" Text="Course"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlCourses" runat="server" AppendDataBoundItems="true">
                            <asp:ListItem Text="-- Select Course --" Value="0"></asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator runat="server" ID="reqddlCourses" InitialValue="0" ControlToValidate="ddlCourses" ErrorMessage="*" ToolTip="Course is required"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
                        <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" CausesValidation="false" />
                    </td>
                </tr>
            </table>
        </fieldset>
    </div>
</asp:Content>
