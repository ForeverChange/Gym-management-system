using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DAL
{
    public  class confirmDAL
    {
        DBHelper db = new DBHelper();
        public int confirm(string con,string date)  //通知
        {
            string sql = string.Format("INSERT INTO [dbo].[confirm] ([confirm],[datetimecon],isread)VALUES('{0}','{1}','1')",con,date);
            return db.zsg(sql);
        }
        public DataTable cxconfirm()  //显示用户通知
        {
            string sql = string.Format("SELECT TOP 1 * FROM confirm order by ID desc;");
            return db.cx(sql) ;
        }
    }
}
