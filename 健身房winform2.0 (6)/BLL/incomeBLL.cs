using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
namespace BLL
{
    public class incomeBLL
    {
        incomeDAL idl = new incomeDAL();
        public DataTable xianshy()  //显示会员人数
        {       
            return idl.xianshy(); ;
        }
        public DataTable xianshycard()  //显示会员卡数量
        {
            return idl.xianshycard(); 
        }
        public DataTable xiansincome()//显示收入
        {    
            return idl.xiansincome();
        }
        /////////
        /// 
         public DataTable xiansday(string account)  //显示会员剩余天数
        {
            return idl.xiansday(account); 
        }

        public DataTable xiansincome(string account)  //显示会员剩余天数
        {
            return idl.xiansincome(account);
        }
        public DataTable xianscardnum(string account)  //显示会员购卡数量
        {
            return idl.xianscardnum(account);
        }
    }
}
