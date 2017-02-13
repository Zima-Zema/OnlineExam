using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace OnlineExam
{
    public class Questions
    {
        public static DataTable GetAll()
        {
            string stored = "Get_Questions";
            return DBLayer.SelectData(stored);
        }
        public static DataTable GetQuestionByCourse(int id)
        {
            string stored = "Get_Question_By_Course";
            SqlParameter[] param = { new SqlParameter("@cid", id) };
            return DBLayer.SelectData(stored, param);
        }
        public static DataTable GetQuestionByID(int id)
        {
            string stored = "Get_Question_by_ID";
            SqlParameter[] param = { new SqlParameter("@id", id) };
            return DBLayer.SelectData(stored,param);
        }
        public static DataTable GetQuestionByCrsID(int id)
        {
            string stored = "Get_Questions_By_CrsID";
            SqlParameter[] param = { new SqlParameter("@crsid", id) };
            return DBLayer.SelectData(stored, param);

        }
        public static DataTable GetMcqQuestionByID(int id)
        {
            string stored = "Get_McqQuestion_by_ID";
            SqlParameter[] param = { new SqlParameter("@qid", id) };
            return DBLayer.SelectData(stored, param);
        }
        public static int Create_Question(string type, int grade, string model, string head, int courseid)
        {
            string stored = "Add_Question";
            SqlParameter[] param = {
                new SqlParameter("@type",type),
                new SqlParameter("@grade",grade),
                new SqlParameter("@moans",model),
                new SqlParameter("@head",head),
                new SqlParameter("@courseid",courseid)};
            return DBLayer.DmlOperation(stored, param);
        }
        public static int Edit_Question(int id,string type, int grade, string model, string head, int courseid)
        {
            string stored = "Edit_Question";
            SqlParameter[] param = {
                new SqlParameter("@Qid",id),
                new SqlParameter("@type",type),
                new SqlParameter("@grade",grade),
                new SqlParameter("@moans",model),
                new SqlParameter("@head",head),
                new SqlParameter("@courseid",courseid)};
            return DBLayer.DmlOperation(stored, param);
        }
        public static int Remove_Question(int id)
        {
            string stored = "Remove_Question";
            SqlParameter[] param = {new SqlParameter("@Qid",id)};
            return DBLayer.DmlOperation(stored, param);
        }
        public static int Create_MCQ(string type, int grade, string model, string head, int courseid,string A,string txtA, string B, string txtB, string C, string txtC, string D, string txtD)
        {
            string stored = "Add_Full_MCQ_Question";
            SqlParameter[] param = {
                new SqlParameter("@type",type),
                new SqlParameter("@grade",grade),
                new SqlParameter("@moans",model),
                new SqlParameter("@head",head),
                new SqlParameter("@courseid",courseid),
                new SqlParameter("@ChoisCharA",A),new SqlParameter("@choicetextA",txtA),
                new SqlParameter("@ChoisCharB",B),new SqlParameter("@choicetextB",txtB),
                new SqlParameter("@ChoisCharC",C),new SqlParameter("@choicetextC",txtC),
                new SqlParameter("@ChoisCharD",D),new SqlParameter("@choicetextD",txtD)};
            return DBLayer.DmlOperation(stored, param);
        }
        public static int Edit_MCQ(int Qid,string type, int grade, string model, string head, int courseid, string A, string txtA, string B, string txtB, string C, string txtC, string D, string txtD)
        {
            string stored = "Edit_Full_MCQ_Question";
            SqlParameter[] param = {
                new SqlParameter("@Qid",Qid),
                new SqlParameter("@type",type),
                new SqlParameter("@grade",grade),
                new SqlParameter("@moans",model),
                new SqlParameter("@head",head),
                new SqlParameter("@courseid",courseid),
                new SqlParameter("@ChoisCharA",A),new SqlParameter("@choicetextA",txtA),
                new SqlParameter("@ChoisCharB",B),new SqlParameter("@choicetextB",txtB),
                new SqlParameter("@ChoisCharC",C),new SqlParameter("@choicetextC",txtC),
                new SqlParameter("@ChoisCharD",D),new SqlParameter("@choicetextD",txtD)};
            return DBLayer.DmlOperation(stored, param);
        }

    }
}