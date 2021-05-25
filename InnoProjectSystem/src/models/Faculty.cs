using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using InnoProjectSystem.src.Util;

namespace InnoProjectSystem.src.models
{
    public class Faculty
    {
		private string fNo;
		private string fName;
		private string fGender;
		private string fTitle;
		private string fCollege;
		private string fEmail;

        public Faculty()
        {
        }

        public Faculty(string fNo = "", string fName = "", string fGender = "", string fTitle = "", string fCollege = "", string fEmail = "")
        {
            this.FNo = fNo;
            this.FName = fName;
            this.FGender = fGender;
            this.FTitle = fTitle;
            this.FCollege = fCollege;
            this.FEmail = fEmail;
        }

        public string FNo { get => fNo; set => fNo = value; }
        public string FName { get => fName; set => fName = value; }
        public string FGender { get => fGender; set => fGender = value; }
        public string FTitle { get => fTitle; set => fTitle = value; }
        public string FCollege { get => fCollege; set => fCollege = value; }
        public string FEmail { get => fEmail; set => fEmail = value; }

        /*以下是Faculty方法*/

        /*根据FNo删除数据库教师信息*/
        public static void DeleteByFno(string fno)
        {
            string cmdTxt = "Delete From Faculty Where FNo=@fno";
            SqlConnection cnn = DbUtil.getConnection();
            SqlCommand cmd = new SqlCommand(cmdTxt, cnn);
            cmd.Parameters.AddWithValue("@fno", fno);

            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
            catch(Exception e)
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
