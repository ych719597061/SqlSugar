using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;
using SugarTest.Models;

namespace SugarTest
{
    public static class SqlSugarClientExtisons
    {
        public static void SaveOrUpdate2(this SqlSugarClient db, object obj)
        {
            //可以写自已的代码

            try
            {
                db.BeginTran();//开启事务
                               //db.BeginTran(IsolationLevel.ReadCommitted);+3重载可以设置事世隔离级别


                db.CommitTran();//提交事务
            }
            catch (Exception)
            {
                db.RollbackTran();//回滚事务
                throw;
            }
        }

    }
}
