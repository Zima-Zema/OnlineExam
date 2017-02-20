using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace OnlineExam.Code
{
    public class ExamBL
    {
        public static SqlDataReader GenerateExam(int crsid,int mcq,int tf)
        {
            string stored = "Generate_Exam";
            SqlParameter[] param = {
                new SqlParameter("@course",crsid),
                new SqlParameter("@mcq",mcq),
                new SqlParameter("@tf",tf)
            };
            return DBLayer.SelectWithDml(stored, param);
        }
        public static DataTable GenerateExamDT(int crsid, int mcq, int tf)
        {
            string stored = "Generate_Exam";
            SqlParameter[] param = {
                new SqlParameter("@course",crsid),
                new SqlParameter("@mcq",mcq),
                new SqlParameter("@tf",tf)
            };
            return DBLayer.SelectData(stored, param);
        }

        public static DataTable GetExamByDate(string date)
        {
            string stored = "Get_Exam_By_Date";
            SqlParameter[] param = { new SqlParameter("@date", date) };
            return DBLayer.SelectData(stored, param);
        }
        public static DataTable GetCorrectiveByCourse(int cid)
        {
            string stored = "Get_Corrective_By_Course";
            SqlParameter[] param = { new SqlParameter("@cid", cid) };
            return DBLayer.SelectData(stored, param);
        }
        public static DataTable GetCorrectiveByDept(int deptid)
        {
            string stored = "Get_Corrective_By_Dept";
            SqlParameter[] param = { new SqlParameter("@deptid", deptid) };
            return DBLayer.SelectData(stored, param);
        }

        public static int AssignStdToExam (int sid,int eid)
        {
            string stored = "Assign_Std_To_Exam";
            SqlParameter[] param = { new SqlParameter("@St_id", sid), new SqlParameter("@exam_id", eid) };
            return DBLayer.DmlOperation(stored, param);
        }
        public static DataTable GetAssignedExamByStdID(int sid)
        {
            string stored = "Get_AssignedExam_By_StdID";
            SqlParameter[] param = {new SqlParameter("@sid",sid)};
            return DBLayer.SelectData(stored, param);
        }
        public static DataTable Get_Question_By_Exam(int ex_id)
        {
            string stored = "Get_Question_By_Exam";
            SqlParameter[] param = { new SqlParameter("@eid", ex_id) };
            return DBLayer.SelectData(stored, param);
        }
        public static int CorrectExam (int st_id,int E_id)
        {
            string stored = "Correct_Exam";
            SqlParameter[] param = { new SqlParameter("@St_id", st_id), new SqlParameter("@exam_id", E_id) };
            return DBLayer.DmlOperation(stored, param);

        }

        public static int ExamAnswers(int StID,int ExamID,string ans1, string ans2, string ans3, string ans4, string ans5, string ans6, string ans7, string ans8, string ans9, string ans10)
        {
            string stored = "Exam_Answers";
            SqlParameter[] param = {
                new SqlParameter("@St_id", StID),
                new SqlParameter("@exam_id", ExamID),
                new SqlParameter("@ans1",ans1 ),
                new SqlParameter("@ans2", ans2),
                new SqlParameter("@ans3", ans3),
                new SqlParameter("@ans4", ans4),
                new SqlParameter("@ans5", ans5),
                new SqlParameter("@ans6", ans6),
                new SqlParameter("@ans7", ans7),
                new SqlParameter("@ans8", ans8),
                new SqlParameter("@ans9", ans9),
                new SqlParameter("@ans10", ans10)
            };
            return DBLayer.DmlOperation(stored, param);
        }
    }
}