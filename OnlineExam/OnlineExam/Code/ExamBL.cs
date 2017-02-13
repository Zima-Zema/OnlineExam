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

    }
}