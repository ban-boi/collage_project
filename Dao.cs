using System.Data.SqlClient;

namespace KeepingAccounts
{
    class Dao
    {
        SqlConnection sc;
        public SqlConnection connect()//当调用这个方法，会返回一个数据库连接的对象sc
        {
            string str = @"Server=LAPTOP-0FUH4M20;Database=KeepAccountsDB;User Id=sa;Password=Redking77171137;Integrated Security=True";//数据库连接字符
            sc = new SqlConnection(str);//创建数据库连接对象
            sc.Open();//打开数据库
            return sc;//返回数据库连接对象
        }
        public SqlCommand command(string sql)//封装了对数据库的操作，将数据库操作语句用string传过去，生成对数据库操作的一个对象
        {
            SqlCommand cmd = new SqlCommand(sql, connect());
            return cmd;
        }
        public int Execute(string sql)//更新操作
        {
            return command(sql).ExecuteNonQuery();
        }
        public SqlDataReader read(string sql)//读取操作
        {
            return command(sql).ExecuteReader();
        }
        public void DaoClose()
        {
            sc.Close();//关闭数据库连接
        }
    }
}
