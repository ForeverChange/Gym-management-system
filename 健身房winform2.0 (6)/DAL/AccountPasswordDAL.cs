using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DAL
{
    public  class AccountPasswordDAL
    {
        DBHelper db = new DBHelper(); 
        //下面是登录密码是否正确
        public DataTable Login(string usename, string usepwd)
        {
            string sql = string.Format("SELECT [ID],[CoachAccount],[CoachPassword],[iSRead]FROM [dbo].[AccountPassword] where [CoachAccount]='{0}' and [CoachPassword]='{1}' ", usename, usepwd);
            return db.cx(sql);
        }

        //下面是注册代码
        public int zc (string usename,string usepwd,int  rank)
        {
            string sql = string.Format("INSERT INTO [dbo].[AccountPassword]([CoachAccount],[CoachPassword],[iSRead])VALUES('{0}','{1}','{2}')",usename,usename,rank);
            int a = db.zsg(sql);
            return a;
        }

        /// <summary>
        /// 下面是新数据库方法
        /// </summary>
        /// <param name="usename"></param>
        /// <param name="usepwd"></param>
        /// <returns></returns>
        /// 
        //下面是登录密码是否正确
        public DataTable Login1(string usename, string usepwd)
        {
            string sql = string.Format("SELECT* FROM [dbo].[Member] where [CoachAccount]='{0}' and [CoachPassword]='{1}' ", usename, usepwd);
            return db.cx(sql);
        }



        //下面是注册代码
        public int zc1(string usename, string usepwd, int rank)
        {
            string sql = string.Format("INSERT INTO [dbo].[Member]([CoachAccount],[CoachPassword],[iSRead])VALUES('{0}','{1}','{2}'  )", usename, usename, rank);
            int a = db.zsg(sql);
            return a;
        }

        public DataTable cxname(string name) //判断是否有相同账号注册
        {
            string sql = string.Format("select * from Member where CoachAccount='{0}'", name);
            return db.cx(sql);
        }
    }
}
