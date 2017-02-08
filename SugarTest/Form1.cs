using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using SqlSugar;
using SugarTest.Dao;
using SugarTest.Models;
using SugarTest.Pager;
using ThreadState = System.Diagnostics.ThreadState;

namespace SugarTest
{
    public partial class Form1 : Form
    {

        public InsertMethods insert = new InsertMethods();
        public SelectMethod SelectMethod = new SelectMethod();
        public static bool ret = false;
        List<Thread> listThread = new List<Thread>();
        public Thread insertThread = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            startThread startThread = new startThread(StrThread);
            // IAsyncResult result = startThread.BeginInvoke(new AsyncCallback(AddComplete), null);
            IAsyncResult asyncResult = startThread.BeginInvoke(AddComplete, null);//简写方式
            InsertBtn.Text = "正在插入中";
            InsertBtn.Enabled = false;
        }



        public delegate string startThread();
        private void button1_Click(object sender, EventArgs e)
        {

            using (var db = SugarDao.GetInstance())
            {
                int i = int.Parse(textBox2.Text);
                Student singleOrDefault = db.Queryable<Student>().SingleOrDefault(x => x.id == i);
                if (singleOrDefault != null)
                { showMsg(string.Format("ID:{0} 名字:{1} 学校ID{2} ", singleOrDefault.id, singleOrDefault.name, singleOrDefault.sch_id)); }
                else
                {
                    showMsg("没找到啊");
                }
            }
        }
        /// <summary>
        /// 显示消息
        /// </summary>
        /// <param name="msg"></param>
        public void showMsg(string msg)
        {
            if (textBox1.InvokeRequired)
            {
                textBox1.Invoke(new MethodInvoker(delegate
                {
                    textBox1.AppendText(string.Format("{0} \r\n", msg));

                }));
            }
            else
            {
                textBox1.AppendText(string.Format("{0} \r\n", msg));
            }
        }

        private void AddComplete(IAsyncResult ar)
        {
            Console.WriteLine("方法执行完毕");
            if (InsertBtn.InvokeRequired)
            {
                button1.Invoke(new MethodInvoker(delegate
                {
                    InsertBtn.Enabled = true;
                    InsertBtn.Text = "插入10000条数据";
                }));
            }
            else
            {
                InsertBtn.Enabled = true;
                InsertBtn.Text = "插入10000条数据";

            }
        }

        public string StrThread()
        {
            string b = insert.InsertTest();
            return b;
        }
        /// <summary>
        ///显示当前插入的数据库数据量
        /// </summary>
        public delegate void ShowInsertNum();
        private void button2_Click(object sender, EventArgs e)
        {
            ShowInsertNum showInsert = new ShowInsertNum(ShowNum);
            IAsyncResult asyncResult = showInsert.BeginInvoke(null, null);//简写方式
            button2.Enabled = false;
        }

        private void ShowNum()
        {
            while (true)
            {
                string num = insert.ShowNum();
                if (label2.InvokeRequired)
                {
                    label2.Invoke(new MethodInvoker(delegate
                    {

                        label2.Text = num;
                    }));
                }
                else
                {
                    label2.Text = num;
                }
                Thread.Sleep(100);
            }

        }
        /// <summary>
        /// 显示批量插入速度
        /// </summary>
        public delegate void ShowSpeedNum();
        private void Form1_Load(object sender, EventArgs e)
        {
            //ShowSpeedNum sowShowSpeedNum = new ShowSpeedNum(ShowSpeed);
            //sowShowSpeedNum.BeginInvoke(null, null);
            pager1.PageCurrent = 1;
            pager1.EventPaging += new EventPagingHandler(Target);
            pager1.Bind();


        }

        private int Target(EventPagingArg eventPagingArg)
        {
            int pageIndex = pager1.PageCurrent;
            int pageSize = pager1.PageSize;
            int pageNum = 0;
            int pageCount = 0;

            using (var db = SugarDao.GetInstance())
            {
                List<Student> page = db.Queryable<Student>()
                    .Where(c => c.id > 1)
                    .OrderBy(it => it.id)
                    .ToPageList(pageIndex, pageSize, ref pageCount);
                string msg = "";
                foreach (Student student in page)
                {
                    msg += string.Format("  ID号:{0},名字:{1},学校号:{2} \r\n", student.id, student.name, student.sch_id);
                }
                textBox1.Text = "";
                showMsg(msg);
            }

            pager1.NMax = pageCount;
            return pageCount;
        }

        private void ShowSpeed()
        {
            int oldNum = 0;
            int newNum = 0;
            while (true)
            {
                string num = insert.ShowNum();//原始数量
                if (!string.IsNullOrEmpty(num))
                {
                    oldNum = int.Parse(num);
                    Thread.Sleep(1000);
                    string strNum = insert.ShowNum();
                    if (!string.IsNullOrEmpty(strNum))
                    {
                        newNum = int.Parse(strNum);
                    }
                    if (label3.InvokeRequired)
                    {
                        label3.Invoke(new MethodInvoker(delegate
                        {
                            label3.Text = "" + (newNum - oldNum);
                        }));
                    }
                    else
                    {
                        label3.Text = "" + (newNum - oldNum);
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            using (var db = SugarDao.GetInstance())
            {
                db.CommandTimeOut = 30000;

                try
                {
                    db.BeginTran();//开启事务
                                   //db.BeginTran(IsolationLevel.ReadCommitted);+3重载可以设置事世隔离级别
                    Test t = new Test()
                    {
                        F_Int32 = 1,
                        F_String = "Test",
                        F_Float = 1,
                        F_DateTime = DateTime.Now,
                        F_Byte = 1,
                        F_Bool = true,
                        Id = System.Guid.NewGuid().ToString("N").Substring(0, 10)
                    };

                    db.SqlBulkCopy(GetInsertList());
                    db.Insert(t);
                    db.CommitTran();//提交事务
                    throw new MyException("数不在范围内");

                }
                catch (Exception)
                {
                    db.RollbackTran();//回滚事务
                                      //  throw;
                }
            }

        }
        class MyException : ApplicationException
        {
            //public MyException(){}  
            public MyException(string message) : base(message) { }

            public override string Message
            {
                get
                {
                    return base.Message;
                }
            }
        }
        private static List<Student> GetInsertList()
        {
            List<Student> list = new List<Student>()
                {
                     new Student()
                {
                     name="张"+new Random().Next(1,int.MaxValue),
                     isOk=true,
                     sch_id=1
                },
                 new Student()
                {
                     name="张"+new Random().Next(1,int.MaxValue),
                     isOk=false,
                     sch_id=2
                }
                };
            return list;
        }

        private void btn_singleFieldList_Click(object sender, EventArgs e)
        {
            string msg = SelectMethod.SingleFieldList();
            showMsg(msg);
        }

        private void btn_single_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_num.Text))
            {
                MessageBox.Show("请输入数量");
            }
            else
            {
                string num = tb_num.Text;
                if (IsNumber(num))
                {
                    string msg = SelectMethod.SelectSingle(num);
                    showMsg(msg);
                }
                else
                {
                    MessageBox.Show("请输入数字");

                }

            }
        }



        public bool IsNumber(String strNumber)
        {
            Regex objNotNumberPattern = new Regex("[^0-9.-]");
            Regex objTwoDotPattern = new Regex("[0-9]*[.][0-9]*[.][0-9]*");
            Regex objTwoMinusPattern = new Regex("[0-9]*[-][0-9]*[-][0-9]*");
            String strValidRealPattern = "^([-]|[.]|[-.]|[0-9])[0-9]*[.]*[0-9]+$";
            String strValidIntegerPattern = "^([-]|[0-9])[0-9]*$";
            Regex objNumberPattern = new Regex("(" + strValidRealPattern + ")|(" + strValidIntegerPattern + ")");

            return !objNotNumberPattern.IsMatch(strNumber) &&
                   !objTwoDotPattern.IsMatch(strNumber) &&
                   !objTwoMinusPattern.IsMatch(strNumber) &&
                   objNumberPattern.IsMatch(strNumber);
        }

        private void btnSinglePk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_num.Text))
            {
                MessageBox.Show("请输入数量");
            }
            else
            {
                string num = tb_num.Text;
                if (IsNumber(num))
                {
                    string msg = SelectMethod.SelectSinglePk(num);
                    showMsg(msg);
                }
                else
                {
                    MessageBox.Show("请输入数字");

                }

            }
        }

        private void btn_singleOrDefault_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_num.Text))
            {
                MessageBox.Show("请输入数量");
            }
            else
            {
                string num = tb_num.Text;
                if (IsNumber(num))
                {
                    string msg = SelectMethod.SingleOrDefault(num);
                    showMsg(msg);
                }
                else
                {
                    MessageBox.Show("请输入数字");

                }

            }
        }

        private void btn_single2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_num.Text))
            {
                MessageBox.Show("请输入数量");
            }
            else
            {
                string num = tb_num.Text;
                if (IsNumber(num))
                {
                    string msg = SelectMethod.Single2(num);
                    showMsg(msg);
                }
                else
                {
                    MessageBox.Show("请输入数字");

                }

            }
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_num.Text))
            {
                MessageBox.Show("请输入数量");
            }
            else
            {
                string num = tb_num.Text;
                if (IsNumber(num))
                {
                    string msg = SelectMethod.First1(num);
                    showMsg(msg);
                }
                else
                {
                    MessageBox.Show("请输入数字");

                }

            }
        }

        private void btn_first2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_num.Text))
            {
                MessageBox.Show("请输入数量");
            }
            else
            {
                string num = tb_num.Text;
                if (IsNumber(num))
                {
                    string msg = SelectMethod.First2(num);
                    showMsg(msg);
                }
                else
                {
                    MessageBox.Show("请输入数字");

                }

            }
        }

        private void btn_selectNum_Click(object sender, EventArgs e)
        {
            string msg = SelectMethod.SelectCount();
            showMsg(msg);
        }

        private void btn_skip_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_num.Text))
            {
                MessageBox.Show("请输入数量");
            }
            else
            {
                string num = tb_num.Text;
                if (IsNumber(num))
                {
                    string msg = SelectMethod.skipXAll(num);
                    showMsg(msg);
                }
                else
                {
                    MessageBox.Show("请输入数字");

                }

            }
        }

        private void btn_take_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_num.Text))
            {
                MessageBox.Show("请输入数量");
            }
            else
            {
                string num = tb_num.Text;
                if (IsNumber(num))
                {
                    string msg = SelectMethod.TakeXdata(num);
                    showMsg(msg);
                }
                else
                {
                    MessageBox.Show("请输入数字");

                }

            }
        }

        private void btn_Like_Click(object sender, EventArgs e)
        {
            string msg = SelectMethod.LikeAnUnlike(tb_num.Text);
            showMsg(msg);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string msg = SelectMethod.SelectWhere(textBox3.Text);
            showMsg(msg);
        }

        private void btn_MaxId_Click(object sender, EventArgs e)
        {
            string msg = SelectMethod.GetMaxId();
            showMsg(msg);
        }

        private void btn_MinId_Click(object sender, EventArgs e)
        {
            string msg = SelectMethod.GetMinId();
            showMsg(msg);
        }

        private void btn_IsAnyExist_Click(object sender, EventArgs e)
        {
            string msg = SelectMethod.IsAnyExist(textBox3.Text);
            showMsg(msg);
        }

        private void btn_soft_Click(object sender, EventArgs e)
        {
            string msg = SelectMethod.SoftData(textBox4.Text);
            showMsg(msg);
        }

        private void btn_PageSelect_Click(object sender, EventArgs e)
        {

            int pageCount = 0;
            int pageIndex = 0;
            int pageSize = 10;
            int pageNum = 0;

            //  using (var db = SugarDao.GetInstance())
            //  {
            //      var page = db.Queryable<Student>().Where(c => c.id > 1).OrderBy(it => it.id).ToPageList(pageIndex, pageSize, ref pageCount);
            //      MessageBox.Show("" + pageCount / pageSize);
            //  }
            pager1.NMax = pageCount;
            pager1.PageCount = pageCount / pageSize;
            pager1.PageSize = pageSize;
            pager1.PageCurrent = pageIndex;

        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            string msg = SelectMethod.InSelect(textBox5.Text);
            showMsg(msg);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string msg = SelectMethod.GroupSelect(textBox6.Text);
            showMsg(msg);
        }
    }
}
