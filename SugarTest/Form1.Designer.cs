namespace SugarTest
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.InsertBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_Like = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_num = new System.Windows.Forms.TextBox();
            this.btn_take = new System.Windows.Forms.Button();
            this.btn_skip = new System.Windows.Forms.Button();
            this.btn_selectNum = new System.Windows.Forms.Button();
            this.btn_first2 = new System.Windows.Forms.Button();
            this.btn_first = new System.Windows.Forms.Button();
            this.btn_singleFieldList = new System.Windows.Forms.Button();
            this.btn_single2 = new System.Windows.Forms.Button();
            this.btn_singleOrDefault = new System.Windows.Forms.Button();
            this.btnSinglePk = new System.Windows.Forms.Button();
            this.btn_single = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.btn_MinId = new System.Windows.Forms.Button();
            this.btn_MaxId = new System.Windows.Forms.Button();
            this.btn_IsAnyExist = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btn_soft = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btn_in = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_group = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.pager1 = new SugarTest.Pager.Pager();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // InsertBtn
            // 
            this.InsertBtn.Location = new System.Drawing.Point(12, 12);
            this.InsertBtn.Name = "InsertBtn";
            this.InsertBtn.Size = new System.Drawing.Size(108, 23);
            this.InsertBtn.TabIndex = 0;
            this.InsertBtn.Text = "插入10000条数据";
            this.InsertBtn.UseVisualStyleBackColor = true;
            this.InsertBtn.Click += new System.EventHandler(this.InsertBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "查询单条数据";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "显示插入数量";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(435, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 48);
            this.label2.TabIndex = 4;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("幼圆", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(126, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 48);
            this.label3.TabIndex = 5;
            this.label3.Text = "0条/分钟";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "更新或者插入";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 303);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(862, 196);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(126, 99);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(146, 21);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 128);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(866, 169);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_Like);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tb_num);
            this.tabPage1.Controls.Add(this.btn_take);
            this.tabPage1.Controls.Add(this.btn_skip);
            this.tabPage1.Controls.Add(this.btn_selectNum);
            this.tabPage1.Controls.Add(this.btn_first2);
            this.tabPage1.Controls.Add(this.btn_first);
            this.tabPage1.Controls.Add(this.btn_singleFieldList);
            this.tabPage1.Controls.Add(this.btn_single2);
            this.tabPage1.Controls.Add(this.btn_singleOrDefault);
            this.tabPage1.Controls.Add(this.btnSinglePk);
            this.tabPage1.Controls.Add(this.btn_single);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(858, 143);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "基本查询";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_Like
            // 
            this.btn_Like.Location = new System.Drawing.Point(449, 84);
            this.btn_Like.Name = "btn_Like";
            this.btn_Like.Size = new System.Drawing.Size(179, 23);
            this.btn_Like.TabIndex = 12;
            this.btn_Like.Text = "模糊查询";
            this.btn_Like.UseVisualStyleBackColor = true;
            this.btn_Like.Click += new System.EventHandler(this.btn_Like_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(402, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "参数框";
            // 
            // tb_num
            // 
            this.tb_num.Location = new System.Drawing.Point(449, 119);
            this.tb_num.Name = "tb_num";
            this.tb_num.Size = new System.Drawing.Size(179, 21);
            this.tb_num.TabIndex = 10;
            this.tb_num.Text = "3";
            // 
            // btn_take
            // 
            this.btn_take.Location = new System.Drawing.Point(449, 55);
            this.btn_take.Name = "btn_take";
            this.btn_take.Size = new System.Drawing.Size(179, 23);
            this.btn_take.TabIndex = 9;
            this.btn_take.Text = "取前X条";
            this.btn_take.UseVisualStyleBackColor = true;
            this.btn_take.Click += new System.EventHandler(this.btn_take_Click);
            // 
            // btn_skip
            // 
            this.btn_skip.Location = new System.Drawing.Point(449, 27);
            this.btn_skip.Name = "btn_skip";
            this.btn_skip.Size = new System.Drawing.Size(179, 23);
            this.btn_skip.TabIndex = 8;
            this.btn_skip.Text = "从第X条开始以后取所有";
            this.btn_skip.UseVisualStyleBackColor = true;
            this.btn_skip.Click += new System.EventHandler(this.btn_skip_Click);
            // 
            // btn_selectNum
            // 
            this.btn_selectNum.Location = new System.Drawing.Point(263, 113);
            this.btn_selectNum.Name = "btn_selectNum";
            this.btn_selectNum.Size = new System.Drawing.Size(115, 23);
            this.btn_selectNum.TabIndex = 7;
            this.btn_selectNum.Text = "查询条数";
            this.btn_selectNum.UseVisualStyleBackColor = true;
            this.btn_selectNum.Click += new System.EventHandler(this.btn_selectNum_Click);
            // 
            // btn_first2
            // 
            this.btn_first2.Location = new System.Drawing.Point(263, 84);
            this.btn_first2.Name = "btn_first2";
            this.btn_first2.Size = new System.Drawing.Size(115, 23);
            this.btn_first2.TabIndex = 6;
            this.btn_first2.Text = "查询第一条2";
            this.btn_first2.UseVisualStyleBackColor = true;
            this.btn_first2.Click += new System.EventHandler(this.btn_first2_Click);
            // 
            // btn_first
            // 
            this.btn_first.Location = new System.Drawing.Point(263, 55);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(115, 23);
            this.btn_first.TabIndex = 5;
            this.btn_first.Text = "查询第一条";
            this.btn_first.UseVisualStyleBackColor = true;
            this.btn_first.Click += new System.EventHandler(this.btn_first_Click);
            // 
            // btn_singleFieldList
            // 
            this.btn_singleFieldList.Location = new System.Drawing.Point(263, 27);
            this.btn_singleFieldList.Name = "btn_singleFieldList";
            this.btn_singleFieldList.Size = new System.Drawing.Size(115, 23);
            this.btn_singleFieldList.TabIndex = 4;
            this.btn_singleFieldList.Text = "查询所有的Id";
            this.btn_singleFieldList.UseVisualStyleBackColor = true;
            this.btn_singleFieldList.Click += new System.EventHandler(this.btn_singleFieldList_Click);
            // 
            // btn_single2
            // 
            this.btn_single2.Location = new System.Drawing.Point(7, 114);
            this.btn_single2.Name = "btn_single2";
            this.btn_single2.Size = new System.Drawing.Size(198, 23);
            this.btn_single2.TabIndex = 3;
            this.btn_single2.Text = "查询单条没有记录返回空对象2";
            this.btn_single2.UseVisualStyleBackColor = true;
            this.btn_single2.Click += new System.EventHandler(this.btn_single2_Click);
            // 
            // btn_singleOrDefault
            // 
            this.btn_singleOrDefault.Location = new System.Drawing.Point(7, 85);
            this.btn_singleOrDefault.Name = "btn_singleOrDefault";
            this.btn_singleOrDefault.Size = new System.Drawing.Size(198, 23);
            this.btn_singleOrDefault.TabIndex = 2;
            this.btn_singleOrDefault.Text = "查询单条没有记录返回空对象";
            this.btn_singleOrDefault.UseVisualStyleBackColor = true;
            this.btn_singleOrDefault.Click += new System.EventHandler(this.btn_singleOrDefault_Click);
            // 
            // btnSinglePk
            // 
            this.btnSinglePk.Location = new System.Drawing.Point(7, 56);
            this.btnSinglePk.Name = "btnSinglePk";
            this.btnSinglePk.Size = new System.Drawing.Size(97, 23);
            this.btnSinglePk.TabIndex = 1;
            this.btnSinglePk.Text = "查询根据主键";
            this.btnSinglePk.UseVisualStyleBackColor = true;
            this.btnSinglePk.Click += new System.EventHandler(this.btnSinglePk_Click);
            // 
            // btn_single
            // 
            this.btn_single.Location = new System.Drawing.Point(7, 27);
            this.btn_single.Name = "btn_single";
            this.btn_single.Size = new System.Drawing.Size(97, 23);
            this.btn_single.TabIndex = 0;
            this.btn_single.Text = "查询单条";
            this.btn_single.UseVisualStyleBackColor = true;
            this.btn_single.Click += new System.EventHandler(this.btn_single_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.btn_MinId);
            this.tabPage6.Controls.Add(this.btn_MaxId);
            this.tabPage6.Controls.Add(this.btn_IsAnyExist);
            this.tabPage6.Controls.Add(this.textBox3);
            this.tabPage6.Controls.Add(this.button4);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(858, 143);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "查询2";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // btn_MinId
            // 
            this.btn_MinId.Location = new System.Drawing.Point(4, 101);
            this.btn_MinId.Name = "btn_MinId";
            this.btn_MinId.Size = new System.Drawing.Size(116, 23);
            this.btn_MinId.TabIndex = 4;
            this.btn_MinId.Text = "最小ID";
            this.btn_MinId.UseVisualStyleBackColor = true;
            this.btn_MinId.Click += new System.EventHandler(this.btn_MinId_Click);
            // 
            // btn_MaxId
            // 
            this.btn_MaxId.Location = new System.Drawing.Point(3, 71);
            this.btn_MaxId.Name = "btn_MaxId";
            this.btn_MaxId.Size = new System.Drawing.Size(117, 23);
            this.btn_MaxId.TabIndex = 3;
            this.btn_MaxId.Text = "获取最大Id";
            this.btn_MaxId.UseVisualStyleBackColor = true;
            this.btn_MaxId.Click += new System.EventHandler(this.btn_MaxId_Click);
            // 
            // btn_IsAnyExist
            // 
            this.btn_IsAnyExist.Location = new System.Drawing.Point(3, 42);
            this.btn_IsAnyExist.Name = "btn_IsAnyExist";
            this.btn_IsAnyExist.Size = new System.Drawing.Size(117, 23);
            this.btn_IsAnyExist.TabIndex = 2;
            this.btn_IsAnyExist.Text = "是否存在记录";
            this.btn_IsAnyExist.UseVisualStyleBackColor = true;
            this.btn_IsAnyExist.Click += new System.EventHandler(this.btn_IsAnyExist_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(139, 13);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(183, 21);
            this.textBox3.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 13);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "Where查询";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.btn_soft);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(858, 143);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "排序";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(138, 20);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(263, 21);
            this.textBox4.TabIndex = 1;
            // 
            // btn_soft
            // 
            this.btn_soft.Location = new System.Drawing.Point(20, 19);
            this.btn_soft.Name = "btn_soft";
            this.btn_soft.Size = new System.Drawing.Size(75, 23);
            this.btn_soft.TabIndex = 0;
            this.btn_soft.Text = "排序";
            this.btn_soft.UseVisualStyleBackColor = true;
            this.btn_soft.Click += new System.EventHandler(this.btn_soft_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pager1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(858, 143);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "分页";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.textBox5);
            this.tabPage4.Controls.Add(this.btn_in);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(858, 143);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "IN操作";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(118, 18);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(418, 21);
            this.textBox5.TabIndex = 1;
            // 
            // btn_in
            // 
            this.btn_in.Location = new System.Drawing.Point(21, 16);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(75, 23);
            this.btn_in.TabIndex = 0;
            this.btn_in.Text = "in查询";
            this.btn_in.UseVisualStyleBackColor = true;
            this.btn_in.Click += new System.EventHandler(this.btn_in_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.textBox6);
            this.tabPage5.Controls.Add(this.btn_group);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(858, 143);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "分组查询";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(290, 99);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "清屏";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_group
            // 
            this.btn_group.Location = new System.Drawing.Point(3, 19);
            this.btn_group.Name = "btn_group";
            this.btn_group.Size = new System.Drawing.Size(75, 23);
            this.btn_group.TabIndex = 0;
            this.btn_group.Text = "分组查询";
            this.btn_group.UseVisualStyleBackColor = true;
            this.btn_group.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(84, 21);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(469, 21);
            this.textBox6.TabIndex = 1;
            this.textBox6.Text = "Sex,count(*) Count";
            // 
            // pager1
            // 
            this.pager1.Location = new System.Drawing.Point(6, 6);
            this.pager1.Name = "pager1";
            this.pager1.NMax = 0;
            this.pager1.PageCount = 0;
            this.pager1.PageCurrent = 0;
            this.pager1.PageSize = 20;
            this.pager1.Size = new System.Drawing.Size(821, 30);
            this.pager1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 511);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.InsertBtn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InsertBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnSinglePk;
        private System.Windows.Forms.Button btn_single;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btn_singleFieldList;
        private System.Windows.Forms.Button btn_single2;
        private System.Windows.Forms.Button btn_singleOrDefault;
        private System.Windows.Forms.Button btn_skip;
        private System.Windows.Forms.Button btn_selectNum;
        private System.Windows.Forms.Button btn_first2;
        private System.Windows.Forms.Button btn_first;
        private System.Windows.Forms.Button btn_take;
        private System.Windows.Forms.TextBox tb_num;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Like;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btn_IsAnyExist;
        private System.Windows.Forms.Button btn_MaxId;
        private System.Windows.Forms.Button btn_MinId;
        private System.Windows.Forms.Button btn_soft;
        private System.Windows.Forms.TextBox textBox4;
        private Pager.Pager pager1;
        private System.Windows.Forms.Button btn_in;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_group;
        private System.Windows.Forms.TextBox textBox6;
    }
}

