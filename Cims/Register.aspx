<%@ Page Title="" Language="C#" MasterPageFile="~/Student.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Cims.Register" %>

<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

      <script type="text/javascript">
        $(function () {
            $("#<%= txtDob.ClientID %>").datepicker();
        });
    </script>

 
    <div>
        <fieldset id="Fieldset1">
            <legend style="background-color: #787878; padding: 10px;">
                <label id="lblcont" class="lblfieldSet">
                    &nbsp;Register&nbsp;</label>
            </legend>

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
                                        <asp:Label ID="lblEmail" runat="server" Text="Email (Username)"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtEmail" MaxLength="100" runat="server" EnableClientScript="true"></asp:TextBox>

                                        <asp:RequiredFieldValidator runat="server" ControlToValidate="txtEmail" ID="rfvEmail" ErrorMessage="Email (Username) is required" Text="*" ForeColor="Red" ToolTip="Email (Username) is required"></asp:RequiredFieldValidator>
                                        <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="Invalid Email" Text="*" ForeColor="Red" ToolTip="Invalid Email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">
                                        </asp:RegularExpressionValidator>
                                    </td>
                                    <td>
                                        <asp:Label ID="lblPwd" runat="server" Text="Password"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox runat="server" TextMode="Password" MaxLength="20" ID="txtPassword"></asp:TextBox>
                                        <asp:RequiredFieldValidator runat="server" ControlToValidate="txtPassword" ID="rfvPassword" ErrorMessage="Password is required" Text="*" ForeColor="Red" ToolTip="Password is required"></asp:RequiredFieldValidator>
                                    </td>
                                    <td>
                                        <asp:Label ID="lblCnfmPwd" runat="server" Text="Confirm Password"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox runat="server" TextMode="Password" MaxLength="20" ID="txtConfirmPassword"></asp:TextBox>
                                        <asp:RequiredFieldValidator runat="server" ControlToValidate="txtConfirmPassword" ID="rfvCnfmPed" ErrorMessage="Confirm Password is required" Text="*" ForeColor="Red" ToolTip="Confirm Password is required"></asp:RequiredFieldValidator>
                                        <asp:CompareValidator runat="server" ControlToCompare="txtPassword" ControlToValidate="txtConfirmPassword" ErrorMessage="*" ForeColor="Red" ToolTip="Password and confirm password are not match"></asp:CompareValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="lblGender" runat="server" Text="Gender"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:RadioButton ID="rbMale" Text="Male" Checked="true" runat="server" GroupName="Gender" />
                                        <asp:RadioButton ID="rbFemale" Text="Female" runat="server" GroupName="Gender" />
                                    </td>
                                    <td>
                                        <asp:Label ID="lblDob" runat="server" Text="Dob"></asp:Label>

                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtDob" runat="server" TextMode="Date"></asp:TextBox>

                                    <%--    <img src="~images/calender.png" />--%>

                                        <asp:RequiredFieldValidator runat="server" ControlToValidate="txtDob" ID="rfvDob" ErrorMessage="Dob is Required" Text="*" ForeColor="Red" ToolTip="Dob is Required"></asp:RequiredFieldValidator>
                                        <%--<asp:RegularExpressionValidator
                                            ValidationExpression="^([0-9]|0[1-9]|1[012])\/([0-9]|0[1-9]|[12][0-9]|3[01])\/(19|20)\d\d$"
                                            ControlToValidate="txtDob" ErrorMessage="Invalid Format. Use MM/DD/YYYY" runat="server" Text="*" ToolTip="Invalid Format. Use MM/DD/YYYY">
                                        </asp:RegularExpressionValidator>--%>
                                        <%--<asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtDob" ErrorMessage="Invalid date format, please enter date in MM/dd/yyyy" Text="*" Operator="DataTypeCheck" Type="Date" ToolTip="Invalid date format, please enter date in MM/dd/yyyy"></asp:CompareValidator>--%>
                                    </td>
                                    <td>
                                        <asp:Label ID="lblState" runat="server" Text="State"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:DropDownList ID="ddlState" runat="server">
                                            <asp:ListItem Text="-- Select State --" Value=""></asp:ListItem>
                                            <asp:ListItem Text="Gujarat" Value="1"></asp:ListItem>
                                            <asp:ListItem Text="Mp" Value="2"></asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>

                                    <td>
                                        <asp:Label ID="lblCity" runat="server" Text="City"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtCity" MaxLength="50" runat="server"></asp:TextBox>
                                    </td>
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
                        <asp:Button ID="btnSave" CssClass="clsSave" runat="server" Text="Save" OnClick="btnSave_Click" />
                        <asp:Button ID="btnCancel" CssClass="clsSave" runat="server" Text="Cancel" CausesValidation="false" OnClick="btnCancel_Click" />
                    </td>
                </tr>

            </table>
        </fieldset>
    </div>
</asp:Content>


