using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient

namespace InnoProjectSystem.Util
{
    public class DbUtil
    {
        /*
         DbUtil类用于数据库连接和关闭等相关操作
        */

        private String dbUrl = "jdbc:oracle:thin:@localhost:1521/InnoProject";  //数据库
        private String dbUserName = "sys as sysdba";    //用户名
        private String dbPassword = "cztczt";   //密码
        private String jdbcName = "oracle.jdbc.driver.OracleDriver";	//驱动名

        public DbUtil()
        {

        }

        public OdbcConnection DbConnect()
        {

        }
    }
}
