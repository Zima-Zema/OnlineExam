<%@ Page Title="" Language="C#" MasterPageFile="~/instructor.Master" AutoEventWireup="true" CodeBehind="Students_have_corrective_exam_by_course.aspx.cs" Inherits="OnlineExam.Students_have_corrective_exam_by_course" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 294px;
        }
        .auto-style2 {
            width: 186px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form id="form1" runat="server">
        
            <br />
            <table class="nav-justified">
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style2">
                        <asp:Label ID="Label1" runat="server" Text="Select Course No"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlcourse" runat="server" AutoPostBack="True" CssClass="col-xs-offset-0" OnSelectedIndexChanged="ddlcourse_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <br />
                        <br />
                    </td>
                    <td colspan="2">
                        <asp:Label ID="lblresult" runat="server"></asp:Label>
                        <br />
                        <asp:GridView ID="gvCorrectiveByCourse" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="gvCorrectiveByCourse_SelectedIndexChanged" Width="568px">
                            <AlternatingRowStyle BackColor="White" />
                            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                            <SortedAscendingCellStyle BackColor="#FDF5AC" />
                            <SortedAscendingHeaderStyle BackColor="#4D0000" />
                            <SortedDescendingCellStyle BackColor="#FCF6C0" />
                            <SortedDescendingHeaderStyle BackColor="#820000" />
                        </asp:GridView>
                    </td>
                </tr>
            </table>
        
    </form>
</asp:Content>