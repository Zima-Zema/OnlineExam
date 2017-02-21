<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="QuestionsUC.ascx.cs" Inherits="WebApplication1.Admin.QuestionsUC" %>
<%@ Register src="AddQuestion.ascx" tagname="AddQuestion" tagprefix="uc1" %>
<%@ Register src="Edit.ascx" tagname="Edit" tagprefix="uc2" %>
<style type="text/css">

    .auto-style1 {
        width: 100%;
    }
    .auto-style2 {
    }
    .auto-style3 {
        width: 28px;
    }
    .auto-style4 {
        width: 131px;
    }
    .auto-style5 {
        width: 132px;
    }
    .auto-style6 {
        width: 276px;
    }
    .auto-style7 {
        width: 67px;
    }
</style>

<table class="auto-style1">
    <tr>
        <td class="auto-style6">Select Course To Edit Quetsions </td>
        <td class="auto-style3" colspan="2">
            &nbsp;<asp:DropDownList ID="ddl_EditQuestion" runat="server" OnSelectedIndexChanged="ddl_EditQuestion_SelectedIndexChanged" AutoPostBack="True">
            </asp:DropDownList>
            </td>
        <td class="auto-style4">
            &nbsp;</td>
        <td class="auto-style5" colspan="2">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2" colspan="7">
            <br />
            <asp:DetailsView ID="gv_EditQuestion" runat="server" AllowPaging="True" AutoGenerateRows="False" Height="50px" OnPageIndexChanging="DetailsView1_PageIndexChanging1" Width="567px" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <CommandRowStyle BackColor="#D1DDF1" Font-Bold="True" />
                <EditRowStyle BackColor="#2461BF" />
                <FieldHeaderStyle BackColor="#DEE8F5" Font-Bold="True" />
                <Fields>
<asp:TemplateField HeaderText="ID">
    <EditItemTemplate>
        <asp:Label ID="Label10" runat="server" Text='<%# Bind("id") %>'></asp:Label>
    </EditItemTemplate>
<InsertItemTemplate>
<asp:TextBox runat="server" Text='<%# Bind("id") %>' id="TextBox2"></asp:TextBox>
</InsertItemTemplate>
<ItemTemplate>
<asp:Label runat="server" Text='<%# Bind("Question_id") %>' id="Label2"></asp:Label>
</ItemTemplate>
</asp:TemplateField>
                    <asp:TemplateField HeaderText="Question">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("question") %>' Width="300px"></asp:TextBox>
                        </EditItemTemplate>
                        <InsertItemTemplate>
                            <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("question") %>' Width="300px"></asp:TextBox>
                        </InsertItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label3" runat="server" Text='<%# Bind("Question_Head") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Grade">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("model_ans") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <InsertItemTemplate>
                            <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("model_ans") %>'></asp:TextBox>
                        </InsertItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label4" runat="server" Text='<%# Bind("Quesion_Grade") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Quetion_type">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox5" runat="server" Text='<%# Bind("que_type") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <InsertItemTemplate>
                            <asp:TextBox ID="TextBox5" runat="server" Text='<%# Bind("que_type") %>'></asp:TextBox>
                        </InsertItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label5" runat="server" Text='<%# Bind("Question_type") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="ModelAnswer">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                        </EditItemTemplate>
                        <InsertItemTemplate>
                            <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
                        </InsertItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label10" runat="server" Text='<%# Bind("Model") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="A">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox7" runat="server" Text='<%# Bind("ans1") %>' Width="300px"></asp:TextBox>
                        </EditItemTemplate>
                        <InsertItemTemplate>
                            <asp:TextBox ID="TextBox7" runat="server" Text='<%# Bind("ans1") %>' Width="300px"></asp:TextBox>
                        </InsertItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label7" runat="server" Text='<%# Bind("Ans1") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="B">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox8" runat="server" Text='<%# Bind("ans2") %>' Width="300px"></asp:TextBox>
                        </EditItemTemplate>
                        <InsertItemTemplate>
                            <asp:TextBox ID="TextBox8" runat="server" Text='<%# Bind("ans2") %>' Width="300px"></asp:TextBox>
                        </InsertItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label8" runat="server" Text='<%# Bind("Ans2") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="C">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox9" runat="server" Text='<%# Bind("ans3") %>' Width="300px"></asp:TextBox>
                        </EditItemTemplate>
                        <InsertItemTemplate>
                            <asp:TextBox ID="TextBox9" runat="server" Text='<%# Bind("ans3") %>' Width="300px"></asp:TextBox>
                        </InsertItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label9" runat="server" Text='<%# Bind("Ans3") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="D">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("ans4") %>' Width="300px"></asp:TextBox>
                        </EditItemTemplate>
                        <InsertItemTemplate>
                            <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("ans4") %>' Width="300px"></asp:TextBox>
                        </InsertItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%# Bind("Ans4") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Fields>
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
            </asp:DetailsView>
        </td>
    </tr>
    <tr>
        <td class="auto-style6">&nbsp;</td>
        <td class="auto-style3" colspan="2">
            &nbsp;</td>
        <td class="auto-style4">
            <asp:Label ID="lbl_status" runat="server"></asp:Label>
        </td>
        <td class="auto-style5" colspan="2">
            &nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td colspan="2" class="auto-style7">
            <asp:Button ID="btn_CreateQuestion" runat="server" CssClass="btn btn-primary" OnClick="btn_CreateQuestion_Click" Text="Add" Width="150px" />
        </td>
        <td colspan="3">
            <asp:Button ID="btn_ManageQuestion" runat="server" CssClass="btn btn-primary" OnClick="btn_ManageQuestion_Click" Text="Manage" Width="150px" />
        </td>
        <td colspan="2">
            <asp:Button ID="btn_cancel" runat="server" CssClass="btn btn-default" OnClick="btn_cancel_Click" Text="Cancel" Width="150px" />
        </td>
    </tr>
    <tr>
        <td colspan="7">
            <asp:Panel ID="pl_createQ" runat="server">
                <uc1:AddQuestion ID="AddQuestion1" runat="server" />
            </asp:Panel>
        </td>
    </tr>
    <tr>
        <td colspan="7">
            <asp:Panel ID="pl_manage" runat="server">
                <table style="width:100%;">
                    <tr>
                        <td class="auto-style7">
                            <asp:Label ID="lbl_course" runat="server" Text="Courses"></asp:Label>
                        </td>
                        <td colspan="2">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style7">
                            <asp:Label ID="lbl_Q" runat="server" Text="Questions"></asp:Label>
                        </td>
                        <td colspan="2">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="4">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style7">&nbsp;</td>
                        <td colspan="2">
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
                                            <asp:Label ID="lbl_tftupe" runat="server" CssClass="col-md-2 control-label" Text="Type"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:DropDownList ID="ddl_tfType" runat="server" Enabled="False">
                                            </asp:DropDownList>
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
                                            <asp:Label ID="Label11" runat="server" CssClass="col-md-2 control-label" Text="Grade"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="txt_tfGrade" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txt_tfGrade" ErrorMessage="Grade Must Be Number" ValidationExpression="\d+"></asp:RegularExpressionValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="2">
                                            <asp:Panel ID="pl_trueToMcq" runat="server">
                                            </asp:Panel>
                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style7">&nbsp;</td>
                        <td colspan="2">
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
                                            <asp:Label ID="lbl_mcqtype" runat="server" CssClass="col-md-2 control-label" Text="Type"></asp:Label>
                                        </td>
                                        <td>
                                            <asp:DropDownList ID="ddl_mcqType" runat="server" Enabled="False">
                                            </asp:DropDownList>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style5">
                                            <asp:Label ID="Label12" runat="server" CssClass="col-md-2 control-label" Text="Grade"></asp:Label>
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
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style7">
                            <asp:Button ID="btn_update" runat="server" CssClass="btn btn-primary" Text="Update" Width="150px" OnClick="btn_update_Click" />
                        </td>
                        <td class="auto-style6">
                            <asp:Button ID="btn_delete" runat="server" OnClientClick="return confirm('Are you sure you want to delete this Question?');" CssClass="btn btn-danger" Text="Delete" Width="150px" OnClick="btn_delete_Click" />
                        </td>
                        <td colspan="2">
                            <asp:Button ID="btn_cancel0" runat="server" Text="Cancel" Width="150px" CssClass="btn btn-default" OnClick="btn_cancel0_Click" />
                            <asp:Label ID="lbl_status0" runat="server"></asp:Label>
                        </td>
                    </tr>
                </table>
            </asp:Panel>
        </td>
    </tr>
    <tr>
        <td colspan="7">&nbsp;</td>
    </tr>
    </table>

