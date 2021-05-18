<%@ Page Title="" Language="C#" MasterPageFile="~/Student.Master" AutoEventWireup="true" CodeBehind="MyProfile.aspx.cs" Inherits="Cims.MyProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <table style="width: 100%" cellspacing="10" align="center" class="tblAll">
                <tr>
                    <td colspan="6">
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" HeaderText="Following error occurs....."
                            ShowMessageBox="false"
                            DisplayMode="List"
                            ShowSummary="true"
                            ForeColor="Red"
                            Font-Italic="true" />
                    </td>
                </tr>
                <tr>
                    <td colspan="6">
                        <fieldset id="lblFieldSet1">
                            <legend>
                                <label id="lblPersonalDetails" style="font-weight: bold">Personal Details</label>
                            </legend>
                            <table class="tblAll" style="width: 100%">
                                <tr>
                                    <td>
                                        <asp:Label ID="lblFName" runat="server" Text="First Name"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtFirstName" MaxLength="50" runat="server"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="rfvFirstName" ControlToValidate="txtFirstName" runat="server" ErrorMessage="First Name is required" Text="*" ForeColor="Red" ToolTip="First Name is required"></asp:RequiredFieldValidator>
                                    </td>
                                    <td>
                                        <asp:Label ID="lblMiddleName" runat="server" Text="Middle Name"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtMiddleName" MaxLength="10" runat="server"></asp:TextBox>

                                    </td>
                                    <td>
                                        <asp:Label ID="lblLastName" runat="server" Text="Last Name"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtLastName" MaxLength="50" runat="server"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="rfvLastName" ControlToValidate="txtLastName" runat="server" ErrorMessage="Last Name is required" Text="*" ForeColor="Red" ToolTip="Last Name is required"></asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>

                                    <td>
                                        <asp:Label ID="lblMNo" runat="server" Text="Mobile No"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtMno" MaxLength="10" runat="server"></asp:TextBox>
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"
                                            ControlToValidate="txtMno" ErrorMessage="Enetr 10 digit mo number" Text="*" ForeColor="Red" ToolTip="Enetr 10 digit mo number"
                                            ValidationExpression="[0-9]{10}"></asp:RegularExpressionValidator>
                                    </td>
                                    <td>
                                        <asp:Label ID="lblPno" runat="server" Text="Phone No"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtPno" MaxLength="15" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="lblAddress" runat="server" Text="Address"></asp:Label>
                                    </td>
                                    <td colspan="5">
                                        <asp:TextBox ID="txtAddress" Rows="4" Columns="57" MaxLength="500" TextMode="MultiLine" runat="server"></asp:TextBox>
                                        <asp:RequiredFieldValidator runat="server" ControlToValidate="txtAddress" ID="rfvAddress" ErrorMessage="Address is Required" Text="*" ForeColor="red" ToolTip="Address is Required"></asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                            </table>
                        </fieldset>
                    </td>
                </tr>

                <tr>
                    <td colspan="6">
                        <%--  <asp:Label ID="Label1" runat="server" Text="Acadmic Details"></asp:Label>--%>
                        <fieldset id="lblFieldSet">
                            <legend>
                                <label id="lblAcedmicDetails" style="font-weight: bold">
                                    Academic Details</label>
                            </legend>
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
                                        <asp:RequiredFieldValidator ID="rfvmaths" ControlToValidate="txtmathes" runat="server" ErrorMessage="Marks is required" Text="*" ForeColor="Red" ToolTip="Marks is required"></asp:RequiredFieldValidator>
                                        <asp:RangeValidator runat="server" ID="rngDate" ControlToValidate="txtmathes" Type="Integer" MinimumValue="35" MaximumValue="100" ErrorMessage="Please Enter marks between 35 to 100" />
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtscience" MaxLength="50" runat="server"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="rvfscience" ControlToValidate="txtscience" runat="server" ErrorMessage="Marks is required" Text="*" ForeColor="Red" ToolTip="Marks is required"></asp:RequiredFieldValidator>
                                        <asp:RangeValidator runat="server" ID="RangeValidator1" ControlToValidate="txtscience" Type="Integer" MinimumValue="35" MaximumValue="100" ErrorMessage="Please Enter marks between 35 to 100" />
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtenglish" MaxLength="50" runat="server"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="rvfenglish" ControlToValidate="txtenglish" runat="server" ErrorMessage="Marks is required" Text="*" ForeColor="Red" ToolTip="Marks is required"></asp:RequiredFieldValidator>
                                        <asp:RangeValidator runat="server" ID="RangeValidator2" ControlToValidate="txtenglish" Type="Integer" MinimumValue="35" MaximumValue="100" ErrorMessage="Please Enter marks between 35 to 100" />
                                    </td>
                                </tr>
                            </table>
                        </fieldset>

                    </td>
                </tr>

                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnUpdate" CssClass="clsSave" runat="server" Text="Update" OnClick="btnUpdate_Click" />
                        <asp:Button ID="btnCancel" CssClass="clsSave" runat="server" Text="Cancel" CausesValidation="false" />
                    </td>
                </tr>

            </table>
</asp:Content>
