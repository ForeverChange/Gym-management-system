using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
namespace BLL
{
    public class AccountPasswordBLL
    {
        AccountPasswordDAL APDL = new AccountPasswordDAL();


        public bool zc(string usename, string usepwd, int rank)  //注册
        {
            
            int a = APDL.zc(usename,usepwd,rank);
            if (a>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable Login(string usename, string usepwd)
        {
            DataTable dt = APDL.Login(usename,usepwd);
            return dt;
        }

        ////新方法
        ///

        public DataTable Login1(string usename, string usepwd) //新登录
        {
            DataTable dt = APDL.Login1(usename, usepwd);
            return dt;
        }

        public bool zc1(string usename, string usepwd, int rank)  //新注册
        {

            int a = APDL.zc1(usename, usepwd, rank);
            if (a > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable cxname(string name) //判断是否有相同账号注册
        {
            
            return APDL.cxname(name);
        }
    }
}
