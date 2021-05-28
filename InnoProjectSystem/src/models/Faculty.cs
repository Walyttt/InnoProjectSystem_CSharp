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

        /*根据FNo删除数据库教师信息，同时删除该教师负责的项目*/
        public static void DeleteByFno(string fno)
        {
            string cmdTxt1 = "Delete From Project Where FNo=@fno";
            string cmdTxt2 = "Delete From Faculty Where FNo=@fno";
            SqlConnection cnn1 = DbUtil.getConnection();
            SqlConnection cnn2 = DbUtil.getConnection();
            SqlCommand cmd1 = new SqlCommand(cmdTxt1, cnn1);
            SqlCommand cmd2 = new SqlCommand(cmdTxt2, cnn2);
            cmd1.Parameters.AddWithValue("@fno", fno);
            cmd1.Parameters.AddWithValue("@fno", fno);

            try
            {
                cnn1.Open();
                cnn2.Open();
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cnn1.Close();
                cnn2.Close();
            }
            catch(Exception e)
            {
                ;
            }
            finally
            {
                if (cnn1.State == System.Data.ConnectionState.Open)
                    cnn1.Close();
                if (cnn2.State == System.Data.ConnectionState.Open)
                    cnn2.Close();
            }
            return;
        } 
    }
}
