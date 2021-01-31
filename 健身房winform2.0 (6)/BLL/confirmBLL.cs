using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
namespace BLL
{
    public     class confirmBLL
    {
        confirmDAL cdl = new confirmDAL();
        public bool confirm(string con,string date)
        {
           
           int a=  cdl.confirm(con,date);
            if (a>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable cxconfirm()  //显示用户通知
        {              
            return cdl.cxconfirm();
        }
    }
}
