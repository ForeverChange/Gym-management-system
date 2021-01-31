using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DAL
{
     public  class MemberDAL
    {
        DBHelper db = new DBHelper();
        public DataTable xians()
        {
            string sql = string.Format("SELECT * FROM Member  AS A JOIN curriculum AS B ON A.curriculumTypeId=B.curriculumTypeId WHERE A.Isclear=1 ");
            DataTable dt = db.cx(sql);
            return dt;
        }
        //下面是删除
        public int del(int id)
        {
            string sql = string.Format("UPDATE [dbo].[Member]SET [Isclear] =0 WHERE ID='{0}'", id);
            int a = db.zsg(sql);
            return a;
        }
        public DataTable xianscomuser() //用户课程下拉框
        {
            string sql = string.Format("select * from curriculum");
            return db.cx(sql);
        }
        public int useradd(string Membername,string MemberGender,string MemberAddress,int curriculumTypeId,int DaysRemaining,int cardnumber,int income)  //添加用户
        {
            string sql = string.Format("INSERT INTO [dbo].[Member]([Membername],[MemberGender],[MemberAddress],[curriculumTypeId],[DaysRemaining],cardnumber,[Isclear],income)VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", Membername, MemberGender, MemberAddress, curriculumTypeId, DaysRemaining, cardnumber,'1',income);
            return db.zsg(sql) ;
        }

        public DataTable xg(int id)  //这个是修改赋值
        {
            string sql = string.Format("SELECT * FROM Member  AS A JOIN curriculum AS B ON A.curriculumTypeId=B.curriculumTypeId WHERE A.Isclear=1 and ID='{0} '",id);
            return db.cx(sql);
        }
        public DataTable select(string xlk,string name )
        {
            string sql = string.Format("SELECT * FROM Member  AS A JOIN curriculum AS B ON A.curriculumTypeId=B.curriculumTypeId where 1>0 and Isclear=1");  //这里是细节
            if (!string.IsNullOrEmpty(xlk))
            {
                sql += string.Format("and a.curriculumTypeId like '{0}' ", xlk);
            }
            if (!string.IsNullOrEmpty(name))
            {
                sql += string.Format("and Membername like '%{0}%' ", name);
            }
            return db.cx(sql);
        }
        public int update(string Membername, string MemberGender, string MemberAddress, int curriculumTypeId, int DaysRemaining, int cardnumber ,int income,int id)  //修改用户的值
        {
            String sql = string.Format("UPDATE [dbo].[Member]SET [Membername] = '{0}',[MemberGender] = '{1}',[MemberAddress] = '{2}',[curriculumTypeId] = '{3}',[DaysRemaining] = '{4}',[cardnumber] = '{5}' ,income='{6}' WHERE ID='{7}'", Membername, MemberGender, MemberAddress, curriculumTypeId, DaysRemaining, cardnumber,income, id);
            return db.zsg(sql);
        }
        public DataTable yzyh(string Id)  //验证是不是会员
        {
            string sql = string.Format("select *  from Member where Membername='{0}'",Id);
            return db.cx(sql) ;
        }

    }
}
