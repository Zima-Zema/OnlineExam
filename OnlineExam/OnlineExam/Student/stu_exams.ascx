<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="stu_exams.ascx.cs" Inherits="WebApplication1.Student.Stu_UC.stu_exams" %>
<style type="text/css">
    .auto-style1 {
        width: 706px;
    }
</style>
&nbsp;
<table style="width:100%;">
    <tr>
        <td colspan="2">
<asp:Panel ID="pl_stud_Exam" runat="server" Width="1015px">
    <asp:GridView ID="gv_StudentExam" runat="server" AutoGenerateSelectButton="True" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanging="gv_StudentExam_SelectedIndexChanging">
        <AlternatingRowStyle BackColor="White" />
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lbl_examstatus" runat="server"></asp:Label>
</asp:Panel>
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:Panel ID="pl_exam" runat="server">
                <asp:DetailsView ID="dv_exam" runat="server" AllowPaging="True" AutoGenerateRows="False" Height="50px" OnPageIndexChanging="DetailsView1_PageIndexChanging1" Width="567px" CellPadding="4" ForeColor="#333333" GridLines="None" OnPageIndexChanged="dv_exam_PageIndexChanged">
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
                                <asp:TextBox ID="TextBox11" runat="server" Text='<%# Bind("question") %>' Width="300px"></asp:TextBox>
                            </InsertItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label3" runat="server" Text='<%# Bind("Question_Head") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Ans1">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox7" runat="server" Text='<%# Bind("ans1") %>' Width="300px"></asp:TextBox>
                            </EditItemTemplate>
                            <InsertItemTemplate>
                                <asp:TextBox ID="TextBox15" runat="server" Text='<%# Bind("ans1") %>' Width="300px"></asp:TextBox>
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
                                <asp:TextBox ID="TextBox16" runat="server" Text='<%# Bind("ans2") %>' Width="300px"></asp:TextBox>
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
                                <asp:TextBox ID="TextBox17" runat="server" Text='<%# Bind("ans3") %>' Width="300px"></asp:TextBox>
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
                                <asp:TextBox ID="TextBox18" runat="server" Text='<%# Bind("ans4") %>' Width="300px"></asp:TextBox>
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
            </asp:Panel>
        </td>
    </tr>
    <tr>
        <td class="auto-style1">
    <asp:Button ID="btn_Submit" runat="server" OnClick="Button1_Click" Text="Submit" Visible="False" CssClass="btn btn-primary" Width="142px" />
    <asp:Label ID="lbl_status" runat="server" Visible="False"></asp:Label>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style1">
            <asp:Panel ID="pl_mcqans" runat="server">
                <asp:DropDownList ID="ddl_Mcqans" runat="server" CssClass="form-control" OnSelectedIndexChanged="ddl_Mcqans_SelectedIndexChanged" AutoPostBack="True">
                </asp:DropDownList>
            </asp:Panel>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style1">
            <asp:Panel ID="pl_tfans" runat="server" Width="124px">
                <asp:DropDownList ID="ddl_tfans" runat="server" CssClass="form-control" AutoPostBack="True" OnSelectedIndexChanged="ddl_tfans_SelectedIndexChanged">
                </asp:DropDownList>
            </asp:Panel>
        </td>
        <td>&nbsp;</td>
    </tr>
</table>
