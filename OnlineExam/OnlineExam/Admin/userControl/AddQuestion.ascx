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
</style>

<table style="width:100%;">
    <tr>
        <td class="auto-style2">
            <asp:Label ID="lbl_course" runat="server" CssClass="col-md-2 control-label" Text="Select Course"></asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddl_course" runat="server" CssClass="form-control">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="auto-style3">
            <asp:Label ID="lbl_questionType" runat="server" CssClass="col-md-2 control-label" Text="Question Type"></asp:Label>
        </td>
        <td class="auto-style1">
            <asp:DropDownList ID="ddl_Qtype" runat="server" CssClass="form-control" OnSelectedIndexChanged="ddl_Qtype_SelectedIndexChanged">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">&nbsp;</td>
        <td>
            <asp:Panel ID="pl_true" runat="server">
                <table style="width:100%;">
                    <tr>
                        <td class="auto-style4">
                            <asp:Label ID="lbl_head" runat="server" CssClass="col-md-2 control-label" Text="Question Head"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txt_tfHead" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style4">
                            <asp:Label ID="lbl_model" runat="server" CssClass="col-md-2 control-label" Text="Model Answer"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddl_tfModel" runat="server" CssClass="form-control">
                            </asp:DropDownList>
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
        <td>
            <asp:Panel ID="pl_mcq" runat="server">
                <table style="width:100%;">
                    <tr>
                        <td class="auto-style5">
                            <asp:Label ID="lbl_head0" runat="server" CssClass="col-md-2 control-label" Text="Question Head"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txt_mcqHead" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
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
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style5">
                            <asp:Label ID="lbl_B" runat="server" CssClass="col-md-2 control-label" Text="B"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txt_ansB" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style5">
                            <asp:Label ID="lbl_C" runat="server" CssClass="col-md-2 control-label" Text="C"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txt_ansC" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style5">
                            <asp:Label ID="lbl_D" runat="server" CssClass="col-md-2 control-label" Text="D"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txt_ansD" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style5">
                            <asp:Label ID="lbl_model1" runat="server" CssClass="col-md-2 control-label" Text="Model Answer"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddl_mcqModel" runat="server" CssClass="form-control">
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table>
            </asp:Panel>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">&nbsp;</td>
        <td>
            <asp:Button ID="btn_insert" runat="server" CssClass="btn btn-primary" OnClick="btn_insert_Click" Text="Create" Width="200px" />
            <asp:Button ID="btn_cancel" runat="server" CssClass="btn btn-danger" OnClick="btn_cancel_Click" Text="Cancel" Width="150px" />
            <asp:Label ID="lbl_status" runat="server"></asp:Label>
        </td>
    </tr>
</table>

