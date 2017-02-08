using System;
using SqlSugar;

namespace SugarTest.Dao
{
    /// <summary>
    /// SqlSugar
    /// </summary>
    public class SugarDao
    {
        //禁止实例化
        private SugarDao()
        {

        }
        public static string ConnectionString
        {
            get
            {
                string reval = "server=192.168.1.128;uid=sa;pwd=Ych15659119947;database=SqlSugarTest"; //这里可以动态根据cookies或session实现多库切换
                return reval;
            }
        }
        public static SqlSugarClient GetInstance()
        {
            
            var db = new SqlSugarAutoCloseClient(ConnectionString);
            db.IsEnableLogEvent = true;//启用日志事件
            db.LogEventStarting = (sql, par) =>
            {
                Console.WriteLine(sql + " " + par + "\r\n");
            };
            return db;
        }
    }
}