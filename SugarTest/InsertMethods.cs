using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SqlSugar;
using SugarTest.Dao;
using SugarTest.Models;

namespace SugarTest
{
    public class InsertMethods
    {
        public static int num { get; set; }

        public void Test(object state)
        {
            Console.WriteLine("helloWord" + DateTime.Now);
            Console.WriteLine(string.Format("当前线程名:{0}当前线程号{1}", Thread.CurrentThread.Name, Thread.CurrentThread.ManagedThreadId));

            while (true)
            {
                Thread.Sleep(1000);


            }
        }
        /// <summary>
        /// 批量插入数据测试
        /// </summary>
        public string InsertTest()
        {

            Console.WriteLine("正在初始化!");
            try
            {
                using (var db = SugarDao.GetInstance())
                {
                    //   bool ret = db.SqlBulkCopy(GetList);
                    bool ret = db.SqlBulkCopy(GetInsertList);
                    Console.WriteLine(ret);
                    return "" + ret;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
                //  throw;
            }

        }
        private static List<Student> GetInsertList
        {
            get
            {
                List<Student> list = new List<Student>();
                for (int i = 0; i < 1000; i++)
                {
                    Student student = new Student()
                    {
                        name = System.Guid.NewGuid().ToString(),
                        isOk = true,
                        sch_id = 1
                    };
                    list.Add(student);
                }
                return list;
            }
        }
        /// <summary>
        /// 初始化数据
        /// </summary>
        private static List<Test> GetList
        {
            get
            {
                List<Test> list = new List<Test>();
                for (int i = 0; i < 1000000; i++)
                {
                    Test t = new Test()
                    {
                        F_Int32 = 1,
                        F_String = "Test",
                        F_Float = 1,
                        F_DateTime = DateTime.Now,
                        F_Byte = 1,
                        F_Bool = true,
                        Id = GetGuid(),

                    };
                    list.Add(t);
                }
                return list;
            }
        }

        private static Test GetTest
        {

            get
            {
                Test t = new Test()
                {
                    F_Int32 = 1,
                    F_String = "Test",
                    F_Float = 1,
                    F_DateTime = DateTime.Now,
                    F_Byte = 1,
                    F_Bool = true,
                    Id = "321321"
                };
                return t;
            }
        }

        public static string GetGuid()
        {
            return System.Guid.NewGuid().ToString("N").Substring(0, 10);
        }

        public void SaveOrUpdate()
        {
            try
            {
                using (var db = SugarDao.GetInstance())
                {
                    var ret = db.SaveOrUpdate(GetTest);
                  
                    Console.WriteLine(ret);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

            }

        }

        public string ShowNum()
        {
            string num = "";
            using (var db = SugarDao.GetInstance())
            {
                var a = db.SqlQuery<int>("SELECT COUNT(1) FROM Test;").SingleOrDefault();
                num = "" + a;
            }
            return num;
        }

       

    }
}
