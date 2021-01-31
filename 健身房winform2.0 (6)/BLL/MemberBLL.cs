using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
namespace BLL
{
    public   class MemberBLL
    {
        MemberDAL MDL = new MemberDAL();
        public DataTable xians()
        {          
            DataTable dt = MDL.xians();
            return dt;
        }
        //下面是删除
        public bool del(int id)
        {

            int a = MDL.del(id);
            if (a>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable xianscomuser() //用户课程下拉框
        {
            return MDL.xianscomuser();
        }
        public bool useradd(string Membername, string MemberGender, string MemberAddress, int curriculumTypeId, int DaysRemaining,int cardnumber,int income) //用户添加
        {
            int a= MDL.useradd(Membername, MemberGender, MemberAddress, curriculumTypeId, DaysRemaining, cardnumber, income);
            if (a>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable xg(int id)  //这个是修改赋值
        {
            return MDL.xg(id);
        }
        //下面是查询
        public DataTable select(string xlk, string name)
        {
            string sql = string.Format("SELECT * FROM Member  AS A JOIN curriculum AS B ON A.curriculumTypeId=B.curriculumTypeId where 1>0");
            if (!string.IsNullOrEmpty(xlk))
            {
                sql += string.Format("and curriculumTypeName like '%{0}%' ", xlk);
            }
            if (!string.IsNullOrEmpty(name))
            {
                sql += string.Format("and curriculumTypeName like '%{0}%' ", name);
            }
            return MDL.select(xlk,name);
        }
        public bool update(string Membername, string MemberGender, string MemberAddress, int curriculumTypeId, int DaysRemaining, int cardnumber, int income ,int id)  //修改用户的值
        {
            int a= MDL.update(Membername, MemberGender, MemberAddress, curriculumTypeId, DaysRemaining, cardnumber,income, id);
            if (a>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable yzyh(string Id)  //验证是不是会员
        {
          
            return MDL.yzyh(Id);
        }
    }
 
}
