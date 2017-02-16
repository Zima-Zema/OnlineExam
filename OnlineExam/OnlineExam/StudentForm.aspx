<%@ Page Title="" Language="C#" MasterPageFile="~/SStudentsMaster.Master" AutoEventWireup="true" CodeBehind="StudentForm.aspx.cs" Inherits="OnlineExam.StudentForm" %>
<%@ Register src="Student/stu_exams.ascx" tagname="stu_exams" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <uc1:stu_exams ID="stu_exams1" runat="server" />
    </form>
</asp:Content>
