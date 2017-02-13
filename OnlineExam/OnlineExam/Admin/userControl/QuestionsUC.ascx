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
</style>

<table class="auto-style1">
    <tr>
        <td class="auto-style6">Select Course To Edit Quetsions </td>
        <td class="auto-style3">
            &nbsp;<asp:DropDownList ID="ddl_EditQuestion" runat="server" OnSelectedIndexChanged="ddl_EditQuestion_SelectedIndexChanged" AutoPostBack="True">
            </asp:DropDownList>
            </td>
        <td class="auto-style4">
            &nbsp;</td>
        <td class="auto-style5">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2" colspan="5">
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
                    <asp:TemplateField HeaderText="Ans1">
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
                    <asp:TemplateField HeaderText="Ans2">
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
                    <asp:TemplateField HeaderText="Ans3">
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
                    <asp:TemplateField HeaderText="Ans4">
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
        <td class="auto-style3">
            &nbsp;</td>
        <td class="auto-style4">
            <asp:Label ID="lbl_status" runat="server"></asp:Label>
        </td>
        <td class="auto-style5">
            &nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td colspan="5">
            <asp:Button ID="btn_CreateQuestion" runat="server" CssClass="btn btn-primary" OnClick="btn_CreateQuestion_Click" Text="Add" Width="150px" />
            <asp:Button ID="btn_ManageQuestion" runat="server" CssClass="btn btn-primary" OnClick="btn_ManageQuestion_Click" Text="Manage" Width="150px" />
            <asp:Button ID="btn_cancel" runat="server" CssClass="btn btn-default" OnClick="btn_cancel_Click" Text="Cancel" Width="150px" />
        </td>
    </tr>
    <tr>
        <td colspan="5">
            <asp:Panel ID="pl_createQ" runat="server">
                <uc1:AddQuestion ID="AddQuestion1" runat="server" />
            </asp:Panel>
        </td>
    </tr>
    <tr>
        <td colspan="5">
            <asp:Panel ID="pl_manage" runat="server">
                <uc2:Edit ID="Edit1" runat="server" />
            </asp:Panel>
        </td>
    </tr>
    <tr>
        <td colspan="5">&nbsp;</td>
    </tr>
    </table>

