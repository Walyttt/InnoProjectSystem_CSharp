using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using InnoProjectSystem.src.Util;

namespace InnoProjectSystem.src.models
{
    public class Project
    {
		private string pNo;
		private string pName;
		private string fName;
		private string ptName;
		private string subName;
		private string colName;
		private int pGroup;

        public Project()
        {
        }

        public Project(string pNo = null, string pName = null, string fName = null, string ptName = null, string subName = null, string colName = null, int pGroup = 0)
        {
            this.PNo = pNo;
            this.PName = pName;
            this.FName = fName;
            this.PtName = ptName;
            this.SubName = subName;
            this.ColName = colName;
            this.PGroup = pGroup;
        }

        public string PNo { get => pNo; set => pNo = value; }
        public string PName { get => pName; set => pName = value; }
        public string FName { get => fName; set => fName = value; }
        public string PtName { get => ptName; set => ptName = value; }
        public string SubName { get => subName; set => subName = value; }
        public string ColName { get => colName; set => colName = value; }
        public int PGroup { get => pGroup; set => pGroup = value; }


        /*根据PNo删除数据库教师信息*/
        public static void DeleteByPno(string pno)
        {
            string cmdTxt = "Delete From Project Where PNo=@pno";
            SqlConnection cnn = DbUtil.getConnection();
            SqlCommand cmd = new SqlCommand(cmdTxt, cnn);
            cmd.Parameters.AddWithValue("@pno", pno);

            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
            catch (Exception e)
            {
                ;
            }
            finally
            {
                if (cnn.State == System.Data.ConnectionState.Open)
                    cnn.Close();
            }
            return;
        }
    }
}
