<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AddQuestion.ascx.cs" Inherits="OnlineExam.Admin.userControl.AddQuestion" %>
<style type="text/css">
    .auto-style1 {
        height: 23px;
    }
    .auto-style2 {
        width: 152px;
    }
    .auto-style3 {
        height: 23px;
        width: 152px;
    }
    .auto-style4 {
        width: 108px;
    }
    .auto-style5 {
        width: 109px;
    }
    .auto-style6 {
        height: 23px;
        width: 140px;
    }
</style>

<table style="width:100%;">
    <tr>
        <td class="auto-style2">
            <asp:Label ID="lbl_course" runat="server" CssClass="col-md-2 control-label" Text="Select Course"></asp:Label>
        </td>
        <td colspan="2">
            <asp:DropDownList ID="ddl_course" runat="server" CssClass="form-control" AutoPostBack="True">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="auto-style3">
            <asp:Label ID="lbl_questionType" runat="server" CssClass="col-md-2 control-label" Text="Question Type"></asp:Label>
        </td>
        <td class="auto-style6">
            <asp:Button ID="btn_mcqType" runat="server" OnClick="Button1_Click" Text="MCQ" CssClass="btn btn-primary" Width="150px" />
        </td>
        <td class="auto-style1">
            <asp:Button ID="btn_tfType" runat="server" OnClick="Button2_Click" Text="TF" CssClass="btn btn-primary" Width="150px" />
        </td>
    </tr>
    <tr>
        <td class="auto-style2">&nbsp;</td>
        <td colspan="2">
            <asp:Panel ID="pl_true" runat="server">
                <table style="width:100%;">
                    <tr>
                        <td class="auto-style4">
                            <asp:Label ID="lbl_head" runat="server" CssClass="col-md-2 control-label" Text="Question Head"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txt_tfHead" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfv_Qhead" runat="server" ControlToValidate="txt_tfHead" ErrorMessage="Please Enter Question Head"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style4">
                            <asp:Label ID="lbl_model" runat="server" CssClass="col-md-2 control-label" Text="Model Answer"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddl_tfModel" runat="server" CssClass="form-control" AutoPostBack="True">
                            </asp:DropDownList>
                            <asp:RequiredFieldValidator ID="rfv_Qhead1" runat="server" ControlToValidate="ddl_tfModel" ErrorMessage="Please Enter Model Answer"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style4">
                            <asp:Label ID="Label2" runat="server" CssClass="col-md-2 control-label" Text="Grade"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txt_tfGrade" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txt_tfGrade" ErrorMessage="Grade Must Be Number" ValidationExpression="\d+"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
                </table>
            </asp:Panel>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">&nbsp;</td>
        <td colspan="2">
            <asp:Panel ID="pl_mcq" runat="server">
                <table style="width:100%;">
                    <tr>
                        <td class="auto-style5">
                            <asp:Label ID="lbl_head0" runat="server" CssClass="col-md-2 control-label" Text="Question Head"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txt_mcqHead" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfv_Qhead0" runat="server" ControlToValidate="txt_mcqHead" ErrorMessage="Please Enter Question Head"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style5">
                            <asp:Label ID="Label4" runat="server" CssClass="col-md-2 control-label" Text="Grade"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txt_mcqGrade" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txt_mcqGrade" ErrorMessage="Grade Must be Number" ValidationExpression="\d+"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style5">
                            <asp:Label ID="lbl_A" runat="server" CssClass="col-md-2 control-label" Text="A"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txt_ansA" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfv_Qhead3" runat="server" ControlToValidate="txt_ansA" ErrorMessage="*"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style5">
                            <asp:Label ID="lbl_B" runat="server" CssClass="col-md-2 control-label" Text="B"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txt_ansB" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfv_Qhead4" runat="server" ControlToValidate="txt_ansB" ErrorMessage="*"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style5">
                            <asp:Label ID="lbl_C" runat="server" CssClass="col-md-2 control-label" Text="C"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txt_ansC" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfv_Qhead5" runat="server" ControlToValidate="txt_ansC" ErrorMessage="*"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style5">
                            <asp:Label ID="lbl_D" runat="server" CssClass="col-md-2 control-label" Text="D"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txt_ansD" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfv_Qhead6" runat="server" ControlToValidate="txt_ansD" ErrorMessage="*"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style5">
                            <asp:Label ID="lbl_model1" runat="server" CssClass="col-md-2 control-label" Text="Model Answer"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddl_mcqModel" runat="server" CssClass="form-control" AutoPostBack="True">
                            </asp:DropDownList>
                            <asp:RequiredFieldValidator ID="rfv_Qhead2" runat="server" ControlToValidate="ddl_mcqModel" ErrorMessage="Please Enter Model Answer"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                </table>
            </asp:Panel>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">&nbsp;</td>
        <td colspan="2">
            <asp:Button ID="btn_insert" runat="server" CssClass="btn btn-primary" OnClick="btn_insert_Click" Text="Create" Width="200px" />
            <asp:Button ID="btn_cancel" runat="server" CssClass="btn btn-danger" CausesValidation="False" OnClick="btn_cancel_Click" Text="Cancel" Width="150px" />
            <asp:Label ID="lbl_status" runat="server"></asp:Label>
        </td>
    </tr>
</table>

