using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;
using SugarTest.Dao;
using SugarTest.Models;

namespace SugarTest
{
    public class SelectMethod
    {
        public string SelectSingle(string id)
        {
            try
            {
                using (var db = SugarDao.GetInstance())
                {
                    int i = int.Parse(id);
                    Student single = db.Queryable<Student>().Single(x => x.id == i);
                    if (single != null)
                    {
                        string msg = string.Format("ID号:{0},名字:{1},学校号:{2}", single.id, single.name, single.sch_id);
                        return retMsg("查询单条数据", msg);
                    }
                    else
                    {
                        return retMsg("查询单条数据", "没报错--没找到对应数据");

                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return retMsg("查询单条数据", "后台报错--没找到对应数据");
            }

        }

        public string retMsg(string title, string msg)
        {
            return string.Format("========={0}=========\r\n {1}\r\n {2}\r\n", title, msg, DateTime.Now.ToString("yyyy-MM-dd  HH:mm:ss:fff"));
        }

        public string SelectSinglePk(string num)
        {
            try
            {
                using (var db = SugarDao.GetInstance())
                {
                    int i = int.Parse(num);
                    Student singleByPk = db.Queryable<Student>().InSingle(i);
                    if (singleByPk != null)
                    {
                        string msg = string.Format("ID号:{0},名字:{1},学校号:{2}", singleByPk.id, singleByPk.name, singleByPk.sch_id);
                        return retMsg("查询单条根据主键", msg);
                    }
                    else
                    {
                        return retMsg("查询单条根据主键", "没报错--没找到对应数据");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return retMsg("查询单条根据主键", "报错--没找到对应数据");

            }

        }

        public string SingleOrDefault(string num)
        {
            try
            {
                using (var db = SugarDao.GetInstance())
                {
                    int i = int.Parse(num);
                    Student singleByPk = db.Queryable<Student>().SingleOrDefault(c => c.id == i);
                    if (singleByPk != null)
                    {
                        string msg = string.Format("ID号:{0},名字:{1},学校号:{2}", singleByPk.id, singleByPk.name, singleByPk.sch_id);
                        return retMsg("查询单条没有记录返回空对象", msg);
                    }
                    else
                    {
                        return retMsg("查询单条没有记录返回空对象", "没报错--返回空对象");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return retMsg("查询单条没有记录返回空对象", "报错--没找到对应数据");

            }
        }

        public string Single2(string num)
        {
            try
            {
                using (var db = SugarDao.GetInstance())
                {
                    int i = int.Parse(num);
                    Student singleByPk = db.Queryable<Student>().Where(c => c.id == i).SingleOrDefault();
                    if (singleByPk != null)
                    {
                        string msg = string.Format("ID号:{0},名字:{1},学校号:{2}", singleByPk.id, singleByPk.name, singleByPk.sch_id);
                        return retMsg("查询单条没有记录返回空对象2", msg);
                    }
                    else
                    {
                        return retMsg("查询单条没有记录返回空对象2", "没报错--返回空对象");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return retMsg("查询单条没有记录返回空对象2", "报错--没找到对应数据");

            }
        }

        public string SingleFieldList()
        {
            try
            {
                using (var db = SugarDao.GetInstance())
                {
                    List<int> list = db.Queryable<Student>().Select<int>(x => x.id).ToList();
                    if (list.Count > 0)
                    {
                        string msg = "";
                        foreach (int li in list)
                        {
                            msg += "ID:" + li + "\t";
                        }
                        return retMsg("查询所有的Id", msg);

                    }
                    else
                    {
                        return retMsg("查询所有的Id", "数组为0");

                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return retMsg("查询所有的Id", "报错了!!!!");

            }
        }

        public string First1(string num)
        {
            try
            {
                using (var db = SugarDao.GetInstance())
                {
                    int i = int.Parse(num);
                    Student singleByPk = db.Queryable<Student>().Where(c => c.id == i).First();
                    if (singleByPk != null)
                    {
                        string msg = string.Format("ID号:{0},名字:{1},学校号:{2}", singleByPk.id, singleByPk.name, singleByPk.sch_id);
                        return retMsg("查询第一条", msg);
                    }
                    else
                    {
                        return retMsg("查询第一条", "报错");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return retMsg("查询第一条", "报错--没找到对应数据");

            }
        }

        public string First2(string num)
        {
            try
            {
                using (var db = SugarDao.GetInstance())
                {
                    int i = int.Parse(num);
                    Student singleByPk = db.Queryable<Student>().Where(c => c.id == i).FirstOrDefault();
                    if (singleByPk != null)
                    {
                        string msg = string.Format("ID号:{0},名字:{1},学校号:{2}", singleByPk.id, singleByPk.name, singleByPk.sch_id);
                        return retMsg("查询第一条2", msg);
                    }
                    else
                    {
                        return retMsg("查询第一条2", "报错");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return retMsg("查询第一条2", "报错--没找到对应数据");

            }
        }

        public string SelectCount()
        {
            try
            {
                using (var db = SugarDao.GetInstance())
                {
                    int count = db.Queryable<Student>().Where(c => c.id > 0).Count();
                    if (count > 0)
                    {
                        return retMsg("查询条数", "数量为" + count);
                    }
                    else
                    {
                        return retMsg("查询条数", "数量为0");

                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return retMsg("查询条数", "报错了!!!!");

            }
        }

        public string skipXAll(string num)
        {
            try
            {
                using (var db = SugarDao.GetInstance())
                {
                    int i = int.Parse(num);
                    string msg = "";
                    List<Student> skip = db.Queryable<Student>().Where(c => c.id > 0).OrderBy(it => it.id).Skip(i).ToList();
                    foreach (Student student in skip)
                    {
                        msg += string.Format("  ID号:{0},名字:{1},学校号:{2} \r\n", student.id, student.name, student.sch_id);
                    }
                    return retMsg("从第X条开始以后取所有", msg);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return retMsg("从第X条开始以后取所有", "报错了!!!!");

            }
        }

        public string TakeXdata(string num)
        {
            try
            {
                using (var db = SugarDao.GetInstance())
                {
                    int i = int.Parse(num);
                    string msg = "";
                    List<Student> take = db.Queryable<Student>().Where(c => c.id > 0).OrderBy(it => it.id).Take(i).ToList();
                    foreach (Student student in take)
                    {
                        msg += string.Format("  ID号:{0},名字:{1},学校号:{2} \r\n", student.id, student.name, student.sch_id);
                    }
                    return retMsg("取前X条", msg);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return retMsg("取前X条", "报错了!!!!");

            }
        }

        public string LikeAnUnlike(string text)
        {
            try
            {
                using (var db = SugarDao.GetInstance())
                {

                    string msg = "";
                    List<Student> notLike = db.Queryable<Student>().Where(c => !c.name.Contains(text)).ToList();
                    foreach (Student student in notLike)
                    {
                        msg += string.Format("  ID号:{0},名字:{1},学校号:{2} \r\n", student.id, student.name, student.sch_id);
                    }
                    string msg2 = "";
                    List<Student> like = db.Queryable<Student>().Where(c => c.name.Contains(text)).ToList();
                    foreach (Student student in like)
                    {
                        msg2 += string.Format("  ID号:{0},名字:{1},学校号:{2} \r\n", student.id, student.name, student.sch_id);
                    }
                    return retMsg("Not like", msg) + "\r\n" + retMsg("Like", msg2);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return retMsg("取前X条", "报错了!!!!");

            }
        }

        public string SelectWhere(string text)
        {
            try
            {
                using (var db = SugarDao.GetInstance())
                {

                    string msg = "";
                    List<Student> notLike = db.Queryable<Student>().Where(c => "a" == "a").Where("id>0 and id in( select 1)").ToList();
                    string json = db.Queryable<Student>().Where(c => "a" == "a").Where("id>0 and id in( select 1)").ToJson();
                    string json2 = db.Queryable<Student>().Where("id>@id", new { id = 0 }).ToJson();
                    foreach (Student student in notLike)
                    {
                        msg += string.Format("  ID号:{0},名字:{1},学校号:{2} \r\n", student.id, student.name, student.sch_id);
                    }
                    return retMsg("支持字符串Where", msg + "\r\n" + json + "\r\n" + json2);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return retMsg("支持字符串Where", "报错了!!!!");

            }
        }

        public string GetMaxId()
        {
            try
            {
                using (var db = SugarDao.GetInstance())
                {

                    object maxId = db.Queryable<Student>().Max(it => it.id);
                    int maxId1 = db.Queryable<Student>().Max(it => it.id).ObjToInt();//拉姆达
                    int maxId2 = db.Queryable<Student>().Max<int>("id"); //字符串写法
                    string msg = string.Format("最大ID三种写法 对象ID: {0}  拉姆达ID: {1} 字符串ID: {2}", maxId, maxId1, maxId2);
                    return retMsg("获取最大Id", msg);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return retMsg("获取最大Id", "报错了!!!!");

            }
        }

        public string GetMinId()
        {
            try
            {
                using (var db = SugarDao.GetInstance())
                {

                    object minId = db.Queryable<Student>().Min(it => it.id);
                    int minId1 = db.Queryable<Student>().Where(c => c.id > 0).Min(it => it.id).ObjToInt();//拉姆达
                    int minId2 = db.Queryable<Student>().Where(c => c.id > 0).Min<int>("id");//字符串写法
                    string msg = string.Format("最小ID三种写法 对象ID: {0}  拉姆达ID: {1} 字符串ID: {2}", minId, minId1, minId1);
                    return retMsg("获取最小Id", msg);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return retMsg("获取最小Id", "报错了!!!!");

            }
        }

        public string IsAnyExist(string textBox3Text)
        {
            try
            {
                using (var db = SugarDao.GetInstance())
                {
                    int i = int.Parse(textBox3Text);
                    bool isAny1 = db.Queryable<Student>().Any(c => c.id == i);
                    string msg = string.Format("是否存在记录  输入参数 {0}   {1}", textBox3Text, isAny1);
                    return retMsg("是否存在记录", msg);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return retMsg("是否存在记录", "报错了!!!!");

            }
        }

        public string SoftData(string textBox4Text)
        {
            try
            {
                using (var db = SugarDao.GetInstance())
                {
                    string msg = "";
                    var orderList = db.Queryable<Student>().OrderBy(textBox4Text).ToList();//字符串支持多个排序
                                                                                           //可以多个order by表达示
                    var order2List = db.Queryable<Student>().OrderBy(it => it.name).OrderBy(it => it.id, OrderByType.Desc).ToList(); // order by name as ,order by id desc
                    foreach (Student student in orderList)
                    {
                        msg += string.Format("  ID号:{0},名字:{1},学校号:{2} \r\n", student.id, student.name, student.sch_id);
                    }
                    string msg2 = "";
                    foreach (Student student in order2List)
                    {
                        msg2 += string.Format("  ID号:{0},名字:{1},学校号:{2} \r\n", student.id, student.name, student.sch_id);
                    }
                    return retMsg("排序", "正序" + msg + "\r\n" + "倒序" + msg2);


                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return retMsg("排序", "报错了!!!!");

            }
        }

        public string InSelect(string textBox5Text)
        {
            try
            {
                using (var db = SugarDao.GetInstance())
                {

                    var intArray = new[] { "4", "2", "3" };
                    var intList = intArray.ToList();
                    var listNew = db.Queryable<Student>().Where(x => intArray.Contains(x.name)).ToJson();
                    var list0 = db.Queryable<Student>().In(it => it.id, 1, 2, 3).ToJson();
                    var list1 = db.Queryable<Student>().In(it => it.id, intArray).ToJson();
                    var list2 = db.Queryable<Student>().In("id", intArray).ToJson();
                    var list3 = db.Queryable<Student>().In(it => it.id, intList).ToJson();
                    var list4 = db.Queryable<Student>().In("id", intList).ToJson();
                    var list6 = db.Queryable<Student>().In(intList).ToJson();//不设置字段默认主键
                    string msg = string.Format("\nlistNew :\r\n{0}\n list0\r\n{1} \nlist1\r\n{2}\nlist2\r\n{3}\nlist3\r\n{4}\nlist4\r\n{5}\nlist6\r\n{6}", listNew, list0, list1, list2, list3, list4, list6);
                    return retMsg("in操作", msg);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return retMsg("in操作", "报错了!!!!");

            }

        }

        public string GroupSelect(string textBox6Text)
        {
            try
            {
                using (var db = SugarDao.GetInstance())
                {

                    // var list7 = db.Queryable<Student>().Where(c => c.id < 20).GroupBy(it => it.sex).Select("sex,count(*) Count").ToDynamic();
                    string list8 = db.Queryable<Student>().Where(c => c.id < 20).GroupBy(it => it.sex).GroupBy(it => it.id).Select(textBox6Text).ToJson();
                    string list9 = db.Queryable<Student>().Where(c => c.id < 20).GroupBy(it => it.sex).Select<StudentGroup>(textBox6Text).ToJson();
                    string list10 = db.Queryable<Student>().Where(c => c.id < 20).GroupBy("sex").Select<StudentGroup>(textBox6Text).ToJson();
                    return retMsg("分组查询1", list8)+"\r\n"+retMsg("分组查询2", list9)+"\r\n"+ retMsg("分组查询3", list10);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return retMsg("分组查询", "报错了!!!!");

            }
        }
    }
}
