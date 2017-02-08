using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;

namespace SugarTest.Dao
{
    public class SqlSugarAutoCloseClient : SqlSugarClient
    {
        public SqlSugarAutoCloseClient(string connectionString)
            : base(connectionString)
        {

        }
        protected override void ExecLogEvent(string sql, SqlParameter[] pars, bool isStarting = true)
        {
            base.ExecLogEvent(sql, pars, isStarting);
            if (isStarting == false && IsDr == false)
            {
                Close();
            }
        }
        internal void RequestParasToSqlParameters(SqlParameterCollection oldParas)
        {
            var oldParaList = oldParas.Cast<SqlParameter>().ToList();
            var paraDictionarAll = SqlSugarTool.GetParameterDictionary();
            if (paraDictionarAll != null && paraDictionarAll.Count() > 0)
            {

                foreach (KeyValuePair<string, string> it in paraDictionarAll)
                {

                    var par = new SqlParameter("@" + it.Key, it.Value);
                    if (!oldParaList.Any(oldPara => oldPara.ParameterName == ("@" + it.Key)))
                    {
                        oldParas.Add(par);
                    }
                }
            }
        }
        private bool IsDr = false;
        public override SqlDataReader GetReader(string sql, params SqlParameter[] pars)
        {
            SetCurrentConnection(false);
            ExecLogEvent(sql, pars, true);
            SqlCommand sqlCommand = new SqlCommand(sql, _sqlConnection);
            sqlCommand.CommandType = this.CommandType;
            sqlCommand.CommandTimeout = this.CommandTimeOut;
            if (_tran != null)
            {
                sqlCommand.Transaction = _tran;
            }
            if (pars != null)
                sqlCommand.Parameters.AddRange(pars);
            if (this.IsGetPageParas)
            {
                RequestParasToSqlParameters(sqlCommand.Parameters);
            }
            CheckConnect();
            IsDr = true;
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);//dr关闭连接对象也关闭
            if (this.IsClearParameters)
                sqlCommand.Parameters.Clear();
            ExecLogEvent(sql, pars, false);
            IsDr = false;
            return sqlDataReader;
        }
        public override void CommitTran()
        {
            base.CommitTran();
            Close();
        }
        public override void RollbackTran()
        {
            base.RollbackTran();
            Close();
        }
        private void Close()
        {
            if (base._tran == null && _sqlConnection.State != ConnectionState.Closed)
            {
                _sqlConnection.Close();
            }
        }
    }
}
