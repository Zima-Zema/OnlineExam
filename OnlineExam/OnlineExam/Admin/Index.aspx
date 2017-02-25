<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/admin.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="OnlineExam.Admin.Index" enableEventValidation="false" %>
<%@ Register src="userControl/instructor.ascx" tagname="instructor" tagprefix="uc1" %>
<%@ Register src="userControl/DepartmentWebUserControl1.ascx" tagname="DepartmentWebUserControl1" tagprefix="uc2" %>
<%@ Register src="userControl/student.ascx" tagname="student" tagprefix="uc3" %>
<%@ Register Src="~/Admin/userControl/Crs_UC.ascx" TagPrefix="uc1" TagName="Crs_UC" %>
<%@ Register Src="~/Admin/userControl/QuestionsUC.ascx" TagPrefix="uc1" TagName="QuestionsUC" %>
<%@ Register Src="~/Admin/userControl/Topic_UC.ascx" TagPrefix="uc1" TagName="Topic_UC" %>
<%@ Register Src="~/Admin/userControl/DepartmentManagerWebUserControl.ascx" TagPrefix="uc1" TagName="DepartmentManagerWebUserControl" %>
<%@ Register Src="~/Admin/userControl/TopicPerCourseWebUserControl.ascx" TagPrefix="uc1" TagName="TopicPerCourseWebUserControl" %>
<%@ Register Src="~/Admin/userControl/InstructorsPerCourseWebUserControl.ascx" TagPrefix="uc1" TagName="InstructorsPerCourseWebUserControl" %>
<%@ Register Src="~/Admin/userControl/QuestionsPerCourseWebUserControl.ascx" TagPrefix="uc1" TagName="QuestionsPerCourseWebUserControl" %>
<%@ Register Src="~/Admin/userControl/Displayall_Instructors.ascx" TagPrefix="uc1" TagName="Displayall_Instructors" %>
<%@ Register Src="~/Admin/userControl/GenerateExam.ascx" TagPrefix="uc1" TagName="GenerateExam" %>
<%@ Register Src="~/Admin/userControl/adminprofile.ascx" TagPrefix="uc1" TagName="adminprofile" %>
<%@ Register Src="~/Admin/userControl/SalaryOfAllInstructorsWebUserControl.ascx" TagPrefix="uc1" TagName="SalaryOfAllInstructorsWebUserControl" %>
<%@ Register Src="~/Admin/userControl/CourseWithAvgGradeWebUserControl.ascx" TagPrefix="uc1" TagName="CourseWithAvgGradeWebUserControl" %>
<%@ Register Src="~/Admin/userControl/StudenExamsByDate.ascx" TagPrefix="uc1" TagName="StudenExamsByDate" %>
<%@ Register Src="~/Admin/userControl/StudentcorrectivByCourseWebUserControl.ascx" TagPrefix="uc1" TagName="StudentcorrectivByCourseWebUserControl" %>
<%@ Register Src="~/Admin/userControl/StudentCorrectiveByDeptWebUserControl.ascx" TagPrefix="uc1" TagName="StudentCorrectiveByDeptWebUserControl" %>















<asp:Content ID="Content1" ContentPlaceHolderID="MainContent1" runat="server">
    </asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder1">
     <section id="secondary_bar">
        <div class="user">
            <p>
            &nbsp;&nbsp;
                </p>
            <!-- <a class="logout_user" href="#" title="Logout">Logout</a> -->
        </div>
      
    </section>
    <aside id="sidebar" class="column" style="width: 246px; text-align: left; height: 5614px;">
        <form class="quick_search">
        &nbsp;</form>
        <hr />
        <h3>Content</h3>
        <ul class="toggle" style="list-style-type: none;">
            <li class="auto-style1" >
                <asp:Button runat="server" Text="Students Info." CausesValidation="false" href="#" Width="200px" ID="student_btn" CssClass="btn btn-default" OnClick="student_btn_Click" ValidateRequestMode="Disabled"></asp:Button></li>
            <li class="auto-style1">
                <asp:Button runat="server" Text="Instructors Info." CausesValidation="false" href="#" Width="200px" ID="ins_btn" CssClass="btn btn-default" OnClick="ins_btn_Click" ValidateRequestMode="Disabled"></asp:Button></li>
            <li class="auto-style1">
                <asp:Button runat="server" Text="Questions Info." CausesValidation="false" href="#" Width="200px" ID="que_btn" CssClass="btn btn-default" OnClick="que_btn_Click" ValidateRequestMode="Disabled"></asp:Button></li>
            <li class="auto-style1">
                <asp:Button runat="server" Text="Departments Info." CausesValidation="false" href="#" Width="200px" ID="dept_btn" CssClass="btn btn-default" OnClick="dept_btn_Click" ValidateRequestMode="Disabled"></asp:Button></li>
            <li class="auto-style1">
                <asp:Button runat="server" Text="Courses Info." CausesValidation="false" href="#" Width="200px" ID="Crs_btn" CssClass="btn btn-default" OnClick="Crs_btn_Click" ValidateRequestMode="Disabled"></asp:Button></li>
            <li class="auto-style1">
                <asp:Button runat="server" Text="Topics Info." CausesValidation="false" href="#" Width="200px" ID="Topic_btn" CssClass="btn btn-default" OnClick="Topic_btn_Click" ValidateRequestMode="Disabled"></asp:Button></li>
            <li class="auto-style1">
                <asp:Button ID="btn_deptManager" runat="server" CausesValidation="false" Text="Departments and Managers" Width="200px" CssClass="btn btn-default" OnClick="btn_deptManager_Click" ValidateRequestMode="Disabled" />
            </li>
            <li class="auto-style1">
                <asp:Button ID="btn_topicCrs" runat="server" CausesValidation="false" Text="Topics per Course" Width="200px" CssClass="btn btn-default" OnClick="btn_topicCrs_Click" ValidateRequestMode="Disabled" />
            </li>
            <li class="auto-style1">
                <asp:Button ID="btn_ins" runat="server" CausesValidation="false" Text="Instructor per Course" Width="200px" CssClass="btn btn-default" OnClick="btn_ins_Click" ValidateRequestMode="Disabled" />
            </li>
            <li class="auto-style1">
                <asp:Button ID="btn_QuesCrs" runat="server" CausesValidation="false" Text="Questions per Course" Width="200px" CssClass="btn btn-default" OnClick="btn_QuesCrs_Click" ValidateRequestMode="Disabled" />
            </li>
            <li class="auto-style1">
                <asp:Button ID="btn_allINS" runat="server" CausesValidation="false" Text="Display All Instructors" Width="200px" CssClass="btn btn-default" OnClick="btn_allINS_Click" ValidateRequestMode="Disabled" />
            </li>
            <li class="auto-style1">
                <asp:Button ID="btn_generate" runat="server" CausesValidation="false" Text="Generate Exam" Width="200px" CssClass="btn btn-default" OnClick="btn_generate_Click" ValidateRequestMode="Disabled" />
            </li>
            <li class="auto-style1">
                <asp:Button ID="btn_salaryINS" runat="server" CausesValidation="false" Text="Salary of all instructors" Width="200px" CssClass="btn btn-default" OnClick="btn_salaryINS_Click" ValidateRequestMode="Disabled" />
            </li>
            <li class="auto-style1">
                <asp:Button ID="btn_courseAVG" runat="server" CausesValidation="false" Text="course with avg grade" Width="199px" CssClass="btn btn-default" OnClick="btn_courseAVG_Click" ValidateRequestMode="Disabled" />
            </li>
            <li class="auto-style1">
                <asp:Button ID="btn_stdExamdate" runat="server" CausesValidation="false" Text="Students exams By date" Width="200px" CssClass="btn btn-default" OnClick="btn_stdExamdate_Click" ValidateRequestMode="Disabled" />
            </li>
            <li class="auto-style1">
                <asp:Button ID="btn_correctiveCourse" runat="server" CausesValidation="false" Text="Corrective Students By Course" Width="200px" CssClass="btn btn-default" OnClick="btn_correctiveCourse_Click" ValidateRequestMode="Disabled" />
            </li>
            <li class="auto-style1">
                <asp:Button ID="btn_correctiveDept" runat="server" CausesValidation="false" Text="Corrective Students By Dept" Width="200px" CssClass="btn btn-default" OnClick="btn_correctiveDept_Click" ValidateRequestMode="Disabled" />
            </li>
        </ul>

        <footer>
            <hr />
            <p><strong>Copyright &copy; 2016 Examination System</strong></p>
        </footer>
    </aside>


    <section class="column" style="width: auto; position: absolute; left: 380px; top: 143px;">

        <!-- end of stats article -->
        <asp:Panel runat="server" id="pnl_ins" class="module width_3_quarter" Visible="False">
            <uc1:instructor ID="uc_Ins" runat="server" />
            
        </asp:Panel>
        <asp:panel runat="server" id="dept_pnl" class="module width_3_quarter" Visible="False">
            <uc2:DepartmentWebUserControl1 ID="DepartmentWebUserControl11" runat="server" />
            
        </asp:panel>
        <asp:panel runat="server" id="stud_pnl" class="module width_3_quarter">
            <uc3:student ID="student1" runat="server" />
            
        </asp:panel>
        <asp:panel runat="server"  id="course_pnl" class="module width_3_quarter" Visible="False">
            <uc1:Crs_UC runat="server" id="Crs_UC" />
        </asp:panel>
        <asp:panel runat="server"  id="Que_pnl" class="module width_3_quarter" Visible="False">
            <uc1:QuestionsUC runat="server" id="QuestionsUC" />
        </asp:panel>

        <asp:panel runat="server"  id="tpic_pnl" class="module width_3_quarter" Visible="False">
            <uc1:Topic_UC runat="server" id="Topic_UC" />
        </asp:panel>

        <asp:panel runat="server"  id="dept_manag" class="module width_3_quarter" Visible="False">
            <uc1:DepartmentManagerWebUserControl runat="server" id="DepartmentManagerWebUserControl" />
        </asp:panel>

        <asp:panel runat="server"  id="topicpercrs" class="module width_3_quarter" Visible="False">
            <uc1:TopicPerCourseWebUserControl runat="server" id="TopicPerCourseWebUserControl" />
        </asp:panel>

        <asp:panel runat="server"  id="Instrpercourse" class="module width_3_quarter" Visible="False">
            <uc1:InstructorsPerCourseWebUserControl runat="server" id="InstructorsPerCourseWebUserControl" />
        </asp:panel>

        <asp:panel runat="server"  id="quepercourse" class="module width_3_quarter" Visible="False">
            <uc1:QuestionsPerCourseWebUserControl runat="server" id="QuestionsPerCourseWebUserControl" />
        </asp:panel>

        <asp:panel runat="server"  id="dispInstructor" class="module width_3_quarter" Visible="False">
            <uc1:Displayall_Instructors runat="server" id="Displayall_Instructors" />
        </asp:panel>

        <asp:panel runat="server"  id="GenerateExam" class="module width_3_quarter" Visible="False">
            <uc1:GenerateExam runat="server" id="GenerateExam1" />
        </asp:panel>

        <asp:panel runat="server"  id="Profileee" class="module width_3_quarter" Visible="False">
            <uc1:adminprofile runat="server" id="adminprofile" />
            <br />
        </asp:panel>

        <asp:panel runat="server"  id="InsSalary" class="module width_3_quarter" Visible="False">
            <uc1:SalaryOfAllInstructorsWebUserControl runat="server" id="SalaryOfAllInstructorsWebUserControl" />
            <br />
            <br />
        </asp:panel>

        <asp:panel runat="server"  id="avggrade" class="module width_3_quarter" Visible="False">
            <uc1:CourseWithAvgGradeWebUserControl runat="server" id="CourseWithAvgGradeWebUserControl" />
            
        </asp:panel>

        <asp:panel runat="server"  id="dateexam" class="module width_3_quarter" Visible="False">
            <uc1:StudenExamsByDate runat="server" id="StudenExamsByDate" />
        </asp:panel>
        <asp:panel runat="server"  id="correctiveCrs" class="module width_3_quarter" Visible="False">
            <uc1:StudentcorrectivByCourseWebUserControl runat="server" id="StudentcorrectivByCourseWebUserControl" />
        </asp:panel>
        <asp:panel runat="server"  id="correctiveDept" class="module width_3_quarter" Visible="False">
            <uc1:StudentCorrectiveByDeptWebUserControl runat="server" id="StudentCorrectiveByDeptWebUserControl" />
        </asp:panel>

        <div class="clear"></div>

        <!-- end of post new article -->

        <!-- end of styles article -->
        <div class="spacer"></div>
    </section>

</asp:Content>

