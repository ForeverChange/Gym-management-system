using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DAL
{
    public    class incomeDAL
    {
        DBHelper db = new DBHelper();
        public DataTable xianshy()  //显示会员人数
        {
            string sql = string.Format("select * from Member where Membername is not null  ");
            return db.cx(sql); ;
        }
        public DataTable xianshycard()  //显示会员卡数量
        {
            string sql = string.Format("select sum(cardnumber) as xx  from Member   ");
            return db.cx(sql); ;
        }
        public DataTable xiansincome()//显示收入
        {
            string sql = string.Format("select sum(income) as xx  from Member ");
            return db.cx(sql); 
        }
        /// <summary>
        /// 以下是用户的现实
        /// </summary>
        /// <returns></returns>
        public DataTable xiansday(string account)  //显示会员剩余天数
        {
            string sql = string.Format("select DaysRemaining from Member where Membername='{0}' ", account);
            return db.cx(sql); 
        }
        public DataTable xiansincome(string account)  //显示会员消费
        { 
            string sql = string.Format("select income from Member where Membername='{0}' ", account);
            return db.cx(sql);
        }
        public DataTable xianscardnum(string account)  //显示会员购卡数量
        {
            string sql = string.Format("select cardnumber from Member where Membername='{0}' ", account);
            return db.cx(sql);
        }
    }
}
