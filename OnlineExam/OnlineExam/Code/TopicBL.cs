using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace OnlineExam.Code
{
    public class TopicBL
    {
        public static DataTable GetAllTopic()
        {
            string stored = "Get_All_Topics";
            return DBLayer.SelectData(stored);
        }
        public static int Add_Topic(string name)
        {
            SqlParameter[] SParameter = { new SqlParameter("@name", name) };
            int x = DBLayer.DmlOperation("Add_Topic", SParameter);
            return x;

        }
        public static int Edit_Topic(string newname, int id)
        {
            SqlParameter[] SParameter = {new SqlParameter("@name",newname),
            new SqlParameter("@id", id) };
            int x = DBLayer.DmlOperation("Edit_Topic", SParameter);
            return x;
        }
        public static int Remove_Topic(int id)
        {
            SqlParameter[] SParameter = { new SqlParameter("@id", id) };
            int x = DBLayer.DmlOperation("Remove_Topic", SParameter);
            return x;
        }
        //
        public static int Remove_TopicByName(string name)
        {
            SqlParameter[] SParameter = { new SqlParameter("name", name) };
            int x = DBLayer.DmlOperation("Remove_TopicByName", SParameter);
            return x;
        }
        public static DataTable GetTopicById(int topid)
        {
            string stored = "Get_Topic_By_Id";
            SqlParameter[] param = { new SqlParameter("@topid", topid) };
            return  DBLayer.SelectData(stored,param);
           
        }
        public static DataTable Get_Topic_By_Name(string name)
        {
            string stored = "Get_Topic_By_Name";
            SqlParameter[] param = { new SqlParameter("@name", name) };
            return DBLayer.SelectData(stored, param);
        }

    }
}