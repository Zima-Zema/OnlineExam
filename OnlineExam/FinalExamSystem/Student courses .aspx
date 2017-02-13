﻿<%@ Page Title="" Language="C#" MasterPageFile="~/instructor.master" AutoEventWireup="true" CodeFile="Student courses .aspx.cs" Inherits="Student_courses_" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 127px;
        }
        .auto-style2 {
            width: 74px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form id="form1" runat="server">
        <p>
            <table class="nav-justified">
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style1">
                        <asp:Label ID="Label1" runat="server" Text="Enter Student No"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlstudent" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlstudent_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style1">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td colspan="2">
                        <asp:GridView ID="gvStudCourse" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="561px">
                            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                            <EditRowStyle BackColor="#999999" />
                            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                            <SortedAscendingCellStyle BackColor="#E9E7E2" />
                            <SortedAscendingHeaderStyle BackColor="#506C8C" />
                            <SortedDescendingCellStyle BackColor="#FFFDF8" />
                            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                        </asp:GridView>
                    </td>
                </tr>
            </table>
        </p>
        <p>
            <asp:Label ID="lblresult" runat="server"></asp:Label>
            <br />
        </p>
    </form>
</asp:Content>
