using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;
using System.Data;
using System.Net;
using System.Security.Principal;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing;
using System.IO;
using System.Diagnostics.Eventing.Reader;
using System.Drawing.Imaging;
using System.Web;

namespace LibrarySystemVersion2
{
    internal class DButil
    {
        private static  string ConnectionString = @"Data Source=Zhangzhen;Initial Catalog=LibrarySystem;Integrated Security=True;MultipleActiveResultSets=True;Connect Timeout=30;Encrypt=False;";
        // 打开数据库连接
        private static SqlConnection OpenConnection()
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            try
            {
                connection.Open();
                return connection;
            }
            catch (Exception ex)
            {
                Console.WriteLine("打开数据库连接时出错：" + ex.Message);
                return null;
            }
        }
        // 关闭数据库连接
        private static void CloseConnection(SqlConnection connection)
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
        ////////////////////////////////////////////////////////////////////登录注册

        // 查询表AdminTablle
        static public bool LoginAdmin(string adminaccount, string adminpassword)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM AdminTable WHERE AdminAccount=@Account AND AdminPassword=@Password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Account", adminaccount);
                    command.Parameters.AddWithValue("@Password", adminpassword);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }
        // 查询表UserTable
        static public bool LoginUser(string useraccount, string userpassword)
        {
            using (SqlConnection connection = OpenConnection())
            {
                if (connection == null)
                {
                    CloseConnection(connection);
                    return false;
                }

                string query = "SELECT * FROM UserTable WHERE UserAccount = @Account AND UserPassword = @Password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Account", useraccount);
                    command.Parameters.AddWithValue("@Password", userpassword);

                    object resultObj = command.ExecuteScalar();

                    if (resultObj != null && resultObj != DBNull.Value)
                    {
                        int result = Convert.ToInt32(resultObj);
                        return result > 0;
                    }
                    return false;
                }
            }

        }
        public static bool SigninUser(string account, string password, string name, string sex, int age, string address, string telephone)
        {
            
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO UserTable (UserAccount, UserPassword, UserName, UserSex, UserAge, UserAddress, UserTelephone) " +
                                   "VALUES (@UserAccount, @UserPassword, @UserName, @UserSex, @UserAge, @UserAddress, @UserTelephone)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // 使用参数化查询以防止 SQL 注入攻击
                        command.Parameters.AddWithValue("@UserAccount", account);
                        command.Parameters.AddWithValue("@UserPassword", password);
                        command.Parameters.AddWithValue("@UserName", name);
                        command.Parameters.AddWithValue("@UserSex", sex);
                        command.Parameters.AddWithValue("@UserAge", age);
                        command.Parameters.AddWithValue("@UserAddress", address);
                        command.Parameters.AddWithValue("@UserTelephone", telephone);
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            
        }

        /// ///////////////////////////////////////////////////////////////////////管理用户


        // 用户查询 DataGridView 显示数据
        static public void UserQueryAll(DataGridView dgv)
        {
            using (SqlConnection connection = OpenConnection())
            {
                if (connection == null)
                {
                    CloseConnection(connection);
                }
                string query = "SELECT UserID,UserAccount,UserName,UserSex,UserAge,UserIsFrozen,UserTelephone FROM UserTable";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();

                            adapter.Fill(dataTable);

                            dgv.DataSource = dataTable;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }

                }

            }
        }
        static public void UserQueryAllSimple(DataGridView dgv)
        {
            using (SqlConnection connection = OpenConnection())
            {
                if (connection == null)
                {
                    CloseConnection(connection);
                }
                string query = "SELECT UserID,UserAccount,UserName,UserIsFrozen,UserBorrowCount FROM UserTable";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();

                            adapter.Fill(dataTable);

                            dgv.DataSource = dataTable;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }

                }

            }
        }
        public static User Finduser(string account, string password)
        {
            User user = null;
            using (SqlConnection connection = OpenConnection())
            {
                if (connection == null)
                {
                    CloseConnection(connection);
                    return null;
                }

                string query = "SELECT * FROM UserTable WHERE UserAccount = @Account AND UserPassword = @Password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Account", account);
                    command.Parameters.AddWithValue("@Password", password);
                    try
                    {

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                user = new User(reader["UserAccount"].ToString(), reader["UserPassword"].ToString(), reader["UserName"].ToString(), reader["UserSex"].ToString(), reader["UserTelephone"].ToString(), reader["UserAddress"].ToString(), Convert.ToInt32(reader["UserAge"]), Convert.ToInt32(reader["UserBorrowCount"]), Convert.ToBoolean(reader["UserIsFrozen"]));
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
            return user;
        }
        public static int FinduserID(string account, string password)
        {
            int id;
            using (SqlConnection connection = OpenConnection())
            {
                if (connection == null)
                {
                    CloseConnection(connection);
                    return 0;
                }

                string query = "SELECT UserID FROM UserTable WHERE UserAccount = @Account AND UserPassword = @Password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Account", account);
                    command.Parameters.AddWithValue("@Password", password);
                    try
                    {

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                id = Convert.ToInt32(reader["UserID"]);
                                return id;
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("DBError::" + ex.Message);
                    }

                }

            }
            return 0;
        }
        // 用户模糊查询 DataGridView 显示数据
        static public void UserQuery(DataGridView dgv, string account, string name, string tel, string address)
        {
            using (SqlConnection connection = OpenConnection())
            {
                if (connection == null)
                {
                    CloseConnection(connection);
                    return;
                }

                string query = "SELECT * FROM UserTable WHERE 1 = 1";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (!string.IsNullOrEmpty(account))
                    {
                        command.CommandText += " AND UserAccount LIKE @Account";
                        command.Parameters.AddWithValue("@Account", "%" + account + "%");
                    }

                    if (!string.IsNullOrEmpty(name))
                    {
                        command.CommandText += " AND UserName LIKE @Name";
                        command.Parameters.AddWithValue("@Name", "%" + name + "%");
                    }

                    if (!string.IsNullOrEmpty(tel))
                    {
                        command.CommandText += " AND UserTelephone LIKE @Tel";
                        command.Parameters.AddWithValue("@Tel", "%" + tel + "%");
                    }

                    if (!string.IsNullOrEmpty(address))
                    {
                        command.CommandText += " AND UserAddress LIKE @Address";
                        command.Parameters.AddWithValue("@Address", "%" + address + "%");
                    }

                    try
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();

                            adapter.Fill(dataTable);

                            dgv.DataSource = dataTable;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
        // 通过id查询用户是否存在
        public static bool UserExistsByID(int ID)
        {
            using (SqlConnection connection = OpenConnection())
            {
                if (connection == null)
                {
                    CloseConnection(connection);
                    return false;
                }

                string query = "SELECT COUNT(*) FROM UserTable WHERE UserID = @UserID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", ID);

                    try
                    {
                        int userCount = (int)command.ExecuteScalar();
                        return userCount > 0;
                    }
                    catch (Exception)
                    {

                        return false;
                    }
                }
            }
        }

        // 通过ID查询用户
        public static User UserQueryByID(int ID)
        {
            User user = null;
            using (SqlConnection connection = OpenConnection())
            {
                if (connection == null)
                {
                    CloseConnection(connection);
                    return null;
                }

                string query = "SELECT * FROM UserTable WHERE UserID=" + ID.ToString();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                user = new User(reader["UserAccount"].ToString(), reader["UserPassword"].ToString(), reader["UserName"].ToString(), reader["UserSex"].ToString(), reader["UserTelephone"].ToString(), reader["UserAddress"].ToString(), Convert.ToInt32(reader["UserAge"]), Convert.ToInt32(reader["UserBorrowCount"]), Convert.ToBoolean(reader["UserIsFrozen"]));
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            return user;
        }
        // 通过ID查询用户后删除用户
        public static bool UserDeleteByID(int ID)
        {
            using (SqlConnection connection = OpenConnection())
            {
                if (connection == null)
                {
                    CloseConnection(connection);
                    return false;
                }

                string query = "DELETE FROM UserTable WHERE UserID = @UserID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", ID);

                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();


                        return rowsAffected > 0;
                    }
                    catch (Exception es)
                    {
                        MessageBox.Show("Error" + es);
                        return false;
                    }
                }
            }
        }
        // 修改用户相关信息
        public static bool UserAlter(User user)
        {
            using (SqlConnection connection = OpenConnection())
            {
                if (connection == null)
                {
                    CloseConnection(connection);
                    return false;
                }
                string query = "UPDATE UserTable SET UserName = @Name, UserAddress = @Address,UserSex=@Sex,UserAge=@Age,UserTelephone=@Telephone WHERE UserAccount = @Account AND UserPassword=@Password";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", user.UserName);
                    command.Parameters.AddWithValue("@Sex", user.UserSex);
                    command.Parameters.AddWithValue("@Age", user.UserAge);
                    command.Parameters.AddWithValue("@Address", user.UserAddress);
                    command.Parameters.AddWithValue("@Telephone", user.UserTelephone);
                    command.Parameters.AddWithValue("@Account", user.UserAccount);
                    command.Parameters.AddWithValue("@Password", user.UserPassword);


                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("DBError" + ex.Message);
                        return false;
                    }
                }
            }
        }
        public static bool UserAlterByID(int ID, int UserBorrowCount, bool UserIsFrozen)
        {
            using (SqlConnection connection = OpenConnection())
            {
                if (connection == null)
                {
                    CloseConnection(connection);
                    return false;
                }
                string query = "UPDATE UserTable SET UserBorrowCount = @Count, UserIsFrozen = @IsFrozen WHERE UserID = @ID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Count", UserBorrowCount);
                    command.Parameters.AddWithValue("@IsFrozen", UserIsFrozen);
                    command.Parameters.AddWithValue("@ID", ID);
                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                        return false;
                    }
                }
            }
        }
        // 冻结用户
        public static bool UserFrozenByID(int ID, bool UserIsFrozen)
        {
            using (SqlConnection connection = OpenConnection())
            {
                if (connection == null)
                {
                    CloseConnection(connection);
                    return false;
                }
                string query = "UPDATE UserTable SET UserIsFrozen = @IsFrozen WHERE UserID = @ID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    
                    command.Parameters.AddWithValue("@IsFrozen", UserIsFrozen);
                    command.Parameters.AddWithValue("@ID", ID);
                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////// 用户反馈消息与管理员接收消息  ////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //发送消息
        public static bool UserSentMessage(Message message)
        {            
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO MessageTable (Message, UserID, DateTime) " +
                                   "VALUES (@Message, @UserID, @DateTime)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Message", message.message);
                        command.Parameters.AddWithValue("@UserID", message.userid);
                        command.Parameters.AddWithValue("@DateTime", message.datetime);

                        try
                        {
                            int rowsAffected = command.ExecuteNonQuery();
                            return rowsAffected > 0;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("DBError" + ex.Message);
                            return false;
                        }
                    }
                }            
        }
        // 接收消息
        public static void AdminAcceptMessage(DataGridView dgv)
        {
            using (SqlConnection connection = OpenConnection())
            {
                if (connection == null)
                {
                    return ;
                }

                string query = "SELECT MessageID,UserID,DateTime FROM MessageTable";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();

                            adapter.Fill(dataTable);

                            dgv.DataSource = dataTable;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("错误：" + ex.Message);
                    }
                }
            }
        }
        public static Message FindMessageByID(int id)
        {
            Message message = null;
            using (SqlConnection connection = OpenConnection())
            {
                if (connection == null)
                {
                    CloseConnection(connection);
                    return null;
                }

                string query = "SELECT * FROM MessageTable WHERE MessageID = @ID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    try
                    {

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                message = new Message(Convert.ToInt32(reader["MessageID"]), reader["Message"].ToString(), Convert.ToInt32(reader["UserID"]), Convert.ToDateTime(reader["DateTime"]));
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
            return message;
        }
        // 删除消息
        public static bool MessageDeleteByID(int messageid)
        {
            using (SqlConnection connection = OpenConnection())
            {
                if (connection == null)
                {
                    CloseConnection(connection);
                    return false;
                }

                string query = "DELETE FROM MessageTable WHERE MessageID = @ID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", messageid);

                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();


                        return rowsAffected > 0;
                    }
                    catch (Exception es)
                    {
                        MessageBox.Show("Error" + es);
                        return false;
                    }
                }
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////用户主页业务
        //////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////
        //显示归还表
        static public void AdminQueryAllReturn(DataGridView dgv)
        {
            using (SqlConnection connection = OpenConnection())
            {
                if (connection == null)
                {
                    CloseConnection(connection);
                }
                string query = "SELECT ReturnID,BorrowBookID,ReturnBookScore,ReturnDate FROM ReturnTable";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();

                            adapter.Fill(dataTable);

                            dgv.DataSource = dataTable;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }

                }

            }
        }
        //datagridview显示借阅表
        static public void AdminQueryAllBorrow(DataGridView dgv)
        {
            using (SqlConnection connection = OpenConnection())
            {
                if (connection == null)
                {
                    CloseConnection(connection);
                }
                string query = "SELECT BorrowBookID,BookID,UserID,BorrowDate,ReturnDate,BookCount FROM BorrowTable";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();

                            adapter.Fill(dataTable);

                            dgv.DataSource = dataTable;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }

                }

            }
        }
        //删除借阅记录
        static public bool BorrowDelete(int borrowID)
        {
            using (SqlConnection connection = OpenConnection())
            {
                if (connection == null)
                {
                    CloseConnection(connection);
                }
                string query = "DELETE FROM BorrowTable WHERE BorrowBookID=@ID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", borrowID);
                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();


                        return rowsAffected > 0;
                    }
                    catch (Exception es)
                    {
                        MessageBox.Show("Error" + es);
                        return false;
                    }
                }

            }
        }
        // 通过BorrowID查询BookID
        public static Borrow BookQueryByBorrowID(int ID)
        {
            Borrow borrow = null;
            using (SqlConnection connection = OpenConnection())
            {
                if (connection == null)
                {
                    CloseConnection(connection);
                    return null;
                }

                string query = "SELECT * FROM BorrowTable WHERE BorrowBookID=" + ID;

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                borrow = new Borrow(Convert.ToInt32(reader["BorrowBookID"]), Convert.ToInt32(reader["BookID"]), Convert.ToDateTime(reader["BorrowDate"]), Convert.ToDateTime(reader["ReturnDate"]));
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            return borrow;
        }
        // 查找全部图书
        public static bool BookQueryAll(DataGridView dgv)
        {
            using (SqlConnection connection = OpenConnection())
            {
                if (connection == null)
                {
                    CloseConnection(connection);
                    return false;
                }
                string query = "SELECT BookImage,BookID,BookName,BookCount,BookBorrowCount,BookCategory FROM BookTable";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dgv.DataSource = dataTable;
                            
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }

                }
                return true;
            }
        }
        // 模糊查找对应图书
        static public void BookQuery(DataGridView dgv, string bookname, string press)
        {   

            using (SqlConnection connection = OpenConnection())
            {
                if (connection == null)
                {
                    CloseConnection(connection);
                    return;
                }

                string query = "SELECT * FROM BookTable WHERE 1 = 1";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (!string.IsNullOrEmpty(bookname))
                    {
                        command.CommandText += " AND BookName LIKE @Name";
                        command.Parameters.AddWithValue("@Name", "%" + bookname + "%");
                    }

                    if (!string.IsNullOrEmpty(press))
                    {
                        command.CommandText += " AND BookPress LIKE @Press";
                        command.Parameters.AddWithValue("@Press", "%" + press + "%");
                    }
                    try
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();

                            adapter.Fill(dataTable);

                            dgv.DataSource = dataTable;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }


        // 借阅图书
        public static bool BookBorrow(int bookID,int userID, DateTime borrowTime,DateTime returnTime,int borrowCount)
        {
            if (BookBorrowCountUpedate(bookID, borrowCount)&&UserBorrowCountUpedate(userID,borrowCount))
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO BorrowTable (BookID, UserID, BorrowDate, ReturnDate,BookCount) " +
                                   "VALUES (@BookID, @UserID, @BorrowDate, @ReturnDate, @BorrowCount)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookID", bookID);
                        command.Parameters.AddWithValue("@UserID", userID);
                        command.Parameters.AddWithValue("@BorrowDate", borrowTime);
                        command.Parameters.AddWithValue("@ReturnDate", returnTime);
                        command.Parameters.AddWithValue("@BorrowCount", borrowCount);
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }             
            }
            else
            { return false; }
        }
        // 用户借阅量更新
        public static bool UserBorrowCountUpedate(int UserID, int BookBorrowCount)
        {
            using (SqlConnection connection = OpenConnection())
            {
                if (connection == null)
                {
                    CloseConnection(connection);
                    return false;
                }
                string query = "UPDATE UserTable SET UserBorrowCount = UserBorrowCount-@Count WHERE UserID = @ID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Count", BookBorrowCount);
                    command.Parameters.AddWithValue("@ID", UserID);
                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("用户借阅量更新失败: " + ex.Message);
                        return false;
                    }
                }
            }
        }
        // 模糊查找对应图书
        static public void BookQueryByName(DataGridView dgv, string bookname)
        {

            using (SqlConnection connection = OpenConnection())
            {
                if (connection == null)
                {
                    CloseConnection(connection);
                    return;
                }

                string query = "SELECT * FROM BookTable WHERE 1 = 1";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (!string.IsNullOrEmpty(bookname))
                    {
                        command.CommandText += " AND BookName LIKE @Name";
                        command.Parameters.AddWithValue("@Name", "%" + bookname + "%");
                    }
                    try
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();

                            adapter.Fill(dataTable);

                            dgv.DataSource = dataTable;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
        //图书借阅量和数量更新
        public static bool BookBorrowCountUpedate(int BookID,int BookBorrowCount)
        {
            using (SqlConnection connection = OpenConnection())
            {
                if (connection == null)
                {
                    CloseConnection(connection);
                    return false;
                }
                string query = "UPDATE BookTable SET BookBorrowCount=COALESCE(BookBorrowCount, 0)+@Count,BookCount = BookCount-@Count WHERE BookID = @ID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Count", BookBorrowCount);
                    command.Parameters.AddWithValue("@ID", BookID);
                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("借阅量更新失败: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        // 图片转二进制数组
        public static byte[] ConvertImageToByteArray(Image image)
        {

            if (image == null)
            {
 
                MessageBox.Show("Error: Image null");
                return null;
            }

            using (MemoryStream ms = new MemoryStream())
            {
                try
                {
                    // 保存图像到MemoryStream
                    image.Save(ms, ImageFormat.Jpeg);
                    return ms.ToArray();
                }catch(Exception)
                {
                    return null;
                }
              
            }
        }
        
        public static void AdjustDataGridView(DataGridView dataGridView)
        {
            string columnName = "BookImage";
            DataGridViewImageColumn imageColumn = (DataGridViewImageColumn)dataGridView.Columns[columnName];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Normal;
            dataGridView.Columns[columnName].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                byte[] imageDataBytes = (byte[])row.Cells[columnName].Value;
                using (MemoryStream ms = new MemoryStream(imageDataBytes))
                {
                    Image image = Image.FromStream(ms);
                    row.Height = image.Height;
                }
                row.Cells[columnName].Style.WrapMode = DataGridViewTriState.True;
            }

        }
        // 图书添加
        public static bool BookAdd(string BookName, int BookNum, string BookPress, string BookCategory, int BookISBN, string BookIntroduce, Image BookPicture)
        {

            {
                byte[] ByteBookPicture = ConvertImageToByteArray(BookPicture);
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO BookTable (BookName, BookPress,BookCount, ISBN,BookCategory , BookRemark,BookImage) " +
                                   "VALUES (@AdminAddBookName, @AdminAddBookPress, @AdminAddBookCount, @AdminAddBookISBN, @AdminAddBookCategory, @AdminAddBookRemark,@AdminAddBookImage)";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {                  
                        command.Parameters.AddWithValue("@AdminAddBookName", BookName);
                        command.Parameters.AddWithValue("@AdminAddBookCount", BookNum);
                        command.Parameters.AddWithValue("@AdminAddBookPress", BookPress);
                        command.Parameters.AddWithValue("@AdminAddBookCategory", BookCategory);
                        command.Parameters.AddWithValue("@AdminAddBookISBN", BookISBN);
                        command.Parameters.AddWithValue("@AdminAddBookRemark", BookIntroduce);
                        command.Parameters.AddWithValue("@AdminAddBookImage", ByteBookPicture);

                        try
                        {
                            int rowsAffected = command.ExecuteNonQuery();
                            return rowsAffected > 0;
                        }
                        catch (Exception es)
                        {
                            MessageBox.Show("Error" + es);
                            return false;
                        }
                    }
                }
            }
        }
      // 借阅图书查询
      public static void BookBorrowQuery(int id,DataGridView dgv)
      {
            using (SqlConnection connection = OpenConnection())
            {
                if (connection == null)
                {
                    CloseConnection(connection);
                    return ;
                }
                string query = "SELECT BorrowBookID, BookID,BorrowDate,ReturnDate,BookCount FROM BorrowTable WHERE UserID=@ID AND BookCount!=0";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID",id);
                    try
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dgv.DataSource = dataTable;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
                return;
            }
      }
        // 二进制数据转图片
        private static Image ConvertImage(byte[] bytesimage)
        {
            using (MemoryStream memoryStream = new MemoryStream(bytesimage))
            {
                Image BookImage = Image.FromStream(memoryStream);
                return BookImage;
            }
        }
        // 通过ID查询图书
        public static Book BookQueryByID(int ID)
        {
            Book book = null;
            using (SqlConnection connection = OpenConnection())
            {
                if (connection == null)
                {
                    CloseConnection(connection);
                    return null;
                }

                string query = "SELECT * FROM BookTable WHERE BookID=" + ID;

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {   
                                if(reader["BookBorrowCount"]!=DBNull.Value)
                                    book = new Book(reader["BookName"].ToString(), reader["BookPress"].ToString(), Convert.ToInt32(reader["BookCount"]), Convert.ToInt32(reader["BookBorrowCount"]), Convert.ToInt32(reader["ISBN"]), reader["BookCategory"].ToString(), reader["BookRemark"].ToString(), ConvertImage((byte[])reader["BookImage"]));
                                else
                                    book= new Book(reader["BookName"].ToString(), reader["BookPress"].ToString(), Convert.ToInt32(reader["BookCount"]),0, Convert.ToInt32(reader["ISBN"]), reader["BookCategory"].ToString(), reader["BookRemark"].ToString(), ConvertImage((byte[])reader["BookImage"]));
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            return book;
        }


        // 归还图书
        // 更新借阅表的记录
        public static bool BorrowBookUpdate(int borrowID,int returnBookCount)
        {

            using (SqlConnection connection = OpenConnection())
            {
                if (connection == null)
                {
                    CloseConnection(connection);
                    return false;
                }

                string query = "UPDATE BorrowTable SET BookCount = BookCount-@Count WHERE BorrowBookID = @ID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", borrowID);
                    command.Parameters.AddWithValue("@Count", returnBookCount);
                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("更新借阅表记录失败: " + ex.Message);
                        return false;
                    }
                }
            }
        }
        // 用户借阅量更新
        public static bool UserReturnCountUpedate(int UserID, int BookReturnCount)
        {
            using (SqlConnection connection = OpenConnection())
            {
                if (connection == null)
                {
                    CloseConnection(connection);
                    return false;
                }
                string query = "UPDATE UserTable SET UserBorrowCount = UserBorrowCount+@Count WHERE UserID = @ID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Count", BookReturnCount);
                    command.Parameters.AddWithValue("@ID", UserID);
                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("用户借阅量更新失败: " + ex.Message);
                        return false;
                    }
                }
            }
        }
        //图书数量更新
        public static bool BookReturnUpedate(int BookID, int BookReturnCount)
        {
            using (SqlConnection connection = OpenConnection())
            {
                if (connection == null)
                {
                    CloseConnection(connection);
                    return false;
                }
                string query = "UPDATE BookTable SET BookCount = BookCount+@Count WHERE BookID = @ID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Count", BookReturnCount);
                    command.Parameters.AddWithValue("@ID", BookID);
                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("图书数量更新失败: " + ex.Message);
                        return false;
                    }
                }
            }
        }
        private static bool RecommendAddOrUpdate(int userid, int bookid, int bookscore)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                // 查询是否已存在相同的UserID和BookID的记录
                string selectQuery = "SELECT Score FROM RecommendTable WHERE UserID = @UserID AND BookID = @BookID";

                using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
                {
                    selectCommand.Parameters.AddWithValue("@UserID", userid);
                    selectCommand.Parameters.AddWithValue("@BookID", bookid);

                    object existingScore = selectCommand.ExecuteScalar();

                    if (existingScore != null) // 已存在记录
                    {
                        int currentScore = Convert.ToInt32(existingScore);

                        // 选择较大的Score更新记录
                        int newScore = Math.Max(currentScore, bookscore);

                        // 更新记录
                        string updateQuery = "UPDATE RecommendTable SET Score = @Score WHERE UserID = @UserID AND BookID = @BookID";

                        using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                        {
                            updateCommand.Parameters.AddWithValue("@UserID", userid);
                            updateCommand.Parameters.AddWithValue("@BookID", bookid);
                            updateCommand.Parameters.AddWithValue("@Score", newScore);

                            try
                            {
                                int rowsAffected = updateCommand.ExecuteNonQuery();
                                return rowsAffected > 0;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("更新推荐表错误！" + ex);
                                return false;
                            }
                        }
                    }
                    else // 不存在记录，插入新记录
                    {
                        string insertQuery = "INSERT INTO RecommendTable (UserID, BookID, Score) VALUES (@UserID, @BookID, @Score)";

                        using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                        {
                            insertCommand.Parameters.AddWithValue("@UserID", userid);
                            insertCommand.Parameters.AddWithValue("@BookID", bookid);
                            insertCommand.Parameters.AddWithValue("@Score", bookscore);

                            try
                            {
                                int rowsAffected = insertCommand.ExecuteNonQuery();
                                return rowsAffected > 0;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("添加推荐表错误！" + ex);
                                return false;
                            }
                        }
                    }
                }
            }
        }

        // 图书归还
        public static bool ReturnBook(int borrowID, int userID, int bookID, int returnBookCount,int ReturnBookScore,DateTime returnTime)
        {
            // 首先删除借阅表的记录
            if (BorrowBookUpdate(borrowID,returnBookCount))
            {
                // 更新练级的表
                //添加推荐表记录
                if (UserReturnCountUpedate(userID, returnBookCount) && BookReturnUpedate(bookID, returnBookCount) && RecommendAddOrUpdate(userID, bookID, ReturnBookScore))
                {
                  
                    // 添加记录到ReturnTable

                    using (SqlConnection connection = new SqlConnection(ConnectionString))
                    {
                        connection.Open();
                        string query = "INSERT INTO ReturnTable (BorrowBookID,ReturnBookScore,ReturnDate) " +
                                       "VALUES (@BorrowID, @Score,@Date)";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@BorrowID", borrowID);
                            command.Parameters.AddWithValue("@Score", ReturnBookScore);
                            command.Parameters.AddWithValue("@Date", returnTime);
                            try
                            {
                                int rowsAffected = command.ExecuteNonQuery();
                                return rowsAffected > 0;
                            }
                            catch (Exception es)
                            {
                                MessageBox.Show("Error" + es);
                                return false;
                            }
                        }
                    }
                    
                }
                return false;
            }
            return false;
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////管理员管理书籍////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // 通过ID查询图书后删除图书
        public static bool BookDeleteByID(int ID)
        {
            using (SqlConnection connection = OpenConnection())
            {
                if (connection == null)
                {
                    CloseConnection(connection);
                    return false;
                }

                string query = "DELETE FROM BookTable WHERE BookID = @BookID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@BookID", ID);

                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();


                        return rowsAffected > 0;
                    }
                    catch (Exception es)
                    {
                        MessageBox.Show("Error" + es);
                        return false;
                    }
                }
            }
        }
        static public void BookQueryAllSimple(DataGridView dgv)
        {
            using (SqlConnection connection = OpenConnection())
            {
                if (connection == null)
                {
                    CloseConnection(connection);
                }
                string query = "SELECT BookID,BookName,BookPress,BookCount,ISBN,BookCategory,BookRemark,BookImage FROM BookTable";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();

                            adapter.Fill(dataTable);

                            dgv.DataSource = dataTable;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }

                }

            }
        }

        //通过ID修改图书信息
        public static bool BookAlterByID(int ID, string BookName, string BookPress, int Count, int ISBN, string Category, Image image)
        {         
            using (SqlConnection connection = OpenConnection())
            {
                byte[] ByteBookPicture = ConvertImageToByteArray(image);

                if (connection == null)
                {
                    CloseConnection(connection);
                    return false;
                }
                string query = "UPDATE BookTable SET BookName = @ModifyBookName, BookPress = @ModifyBookPress,BookCount=@ModifyBookCount,ISBN=@ModifyISBN,BookCategory=@ModifyBookCategory";
                    if (ByteBookPicture != null)
                    {
                    query += ",BookImage = @ModifyBookImage ";
                    }
                query += " WHERE BookID = @ID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ModifyBookName", BookName);
                    command.Parameters.AddWithValue("@ModifyBookPress", BookPress);
                    command.Parameters.AddWithValue("@ModifyBookCount", Count);
                    command.Parameters.AddWithValue("@ModifyISBN", ISBN);
                    command.Parameters.AddWithValue("@ModifyBookCategory", Category);
                    if (ByteBookPicture != null)
                    {
                        command.Parameters.AddWithValue("@ModifyBookImage", ByteBookPicture);
                    }
                    command.Parameters.AddWithValue("@ID", ID);
                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                        return false;
                    }
                }
            }
        }
        // 通过id查询用户是否存在
        public static bool BookExistsByID(int ID)
        {
            using (SqlConnection connection = OpenConnection())
            {
                if (connection == null)
                {
                    CloseConnection(connection);
                    return false;
                }

                string query = "SELECT COUNT(*) FROM BookTable WHERE BookID = @BookID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@BookID", ID);

                    try
                    {
                        int bookCount = (int)command.ExecuteScalar();
                        return bookCount > 0;
                    }
                    catch (Exception)
                    {

                        return false;
                    }
                }
            }
        }




        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////用户推荐算法/////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// 协同推荐，多用户，可调相似度最小阈值
        /// </summary>
        /// <param name="targetUserId"></param>
        /// 当前用户ID和相似度的最小阈值一般设置到0.5到0.8
        /// <param name="similarityThreshold"></param>
        /// <returns></returns>
        public static int[] CollaborativeFilteringRecommendation(int targetUserId, double similarityThreshold)
        {
            List<int> recommendedBooks = new List<int>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                // 获取目标用户喜欢的图书列表
                List<int> targetUserLikedBooks = GetUserLikedBooks(targetUserId, connection);

                // 获取其他用户的喜欢的图书列表，并计算相似度
                Dictionary<int, double> userSimilarities = new Dictionary<int, double>();
                foreach (int userId in GetUserIds(connection))
                {
                    if (userId == targetUserId)
                        continue;

                    List<int> otherUserLikedBooks = GetUserLikedBooks(userId, connection);

                    // 计算用户相似度，这里使用皮尔逊相关系数
                    double similarity = CalculateSimilarity(targetUserLikedBooks, otherUserLikedBooks);

                    userSimilarities.Add(userId, similarity);
                }

                // 根据相似度排序其他用户，选择相似度高于阈值的用户进行推荐
                var sortedSimilarities = userSimilarities.OrderByDescending(kv => kv.Value);
                var topSimilarUsers = sortedSimilarities.Where(kv => kv.Value > similarityThreshold).ToList();

                // 获取相似用户喜欢的图书列表，并过滤掉目标用户已经喜欢的图书
                foreach (var similarUser in topSimilarUsers)
                {
                    List<int> similarUserLikedBooks = GetUserLikedBooks(similarUser.Key, connection);
                    recommendedBooks.AddRange(similarUserLikedBooks.Except(targetUserLikedBooks));
                }
            }

            return recommendedBooks.Distinct().ToArray();
        }

        /// <summary>
        /// 协同推荐，单用户
        /// </summary>
        /// <param name="targetUserId"></param>
        /// <returns></returns>
        public static int [] CollaborativeFilteringRecommendation(int targetUserId)
        {
            List<int> recommendedBooks = new List<int>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                // 获取目标用户喜欢的图书列表
                List<int> targetUserLikedBooks = GetUserLikedBooks(targetUserId, connection);
                //MessageBox.Show("获取目标用户喜欢的图书列表");
                // 获取其他用户的喜欢的图书列表，并计算相似度
                Dictionary<int, double> userSimilarities = new Dictionary<int, double>();
                foreach (int userId in GetUserIds(connection))
                {
                    if (userId == targetUserId)
                        continue;

                    List<int> otherUserLikedBooks = GetUserLikedBooks(userId, connection);

                    // 计算用户相似度，这里可以使用不同的相似度计算方法
                    double similarity = CalculateSimilarity(targetUserLikedBooks, otherUserLikedBooks);

                    userSimilarities.Add(userId, similarity);
                }
                //MessageBox.Show("根据相似度排序其他用户，选择相似度较高的用户进行推荐");
                // 根据相似度排序其他用户，选择相似度较高的用户进行推荐
                var sortedSimilarities = userSimilarities.OrderByDescending(kv => kv.Value);
                int topSimilarUser = sortedSimilarities.First().Key;

                // 获取相似用户喜欢的图书列表
                List<int> topSimilarUserLikedBooks = GetUserLikedBooks(topSimilarUser, connection);

                // 过滤掉目标用户已经喜欢的图书
                recommendedBooks = topSimilarUserLikedBooks.Except(targetUserLikedBooks).ToList();
                //MessageBox.Show("过滤掉目标用户已经喜欢的图书");
            }

            return recommendedBooks.ToArray();
        }

        private static List<int> GetUserLikedBooks(int userId, SqlConnection connection)
        {
            List<int> likedBooks = new List<int>();

            string query = "SELECT BookID FROM RecommendTable WHERE UserID = @UserID";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@UserID", userId);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        likedBooks.Add(Convert.ToInt32(reader["BookID"]));
                    }
                }
            }

            return likedBooks;
        }

        private static List<int> GetUserIds(SqlConnection connection)
        {
            List<int> userIds = new List<int>();

            string query = "SELECT DISTINCT UserID FROM RecommendTable";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        userIds.Add(Convert.ToInt32(reader["UserID"]));
                    }
                }
            }

            return userIds;
        }
        private static double CalculateSimilarity(List<int> user1Books, List<int> user2Books)
        {
            if (user1Books.Count != user2Books.Count)
            {
                // 处理集合长度不同的情况
                return 0.0;
            }

            int n = user1Books.Count;

            double sum1 = user1Books.Sum();
            double sum2 = user2Books.Sum();

            double sum1Sq = user1Books.Sum(book => Math.Pow(book, 2));
            double sum2Sq = user2Books.Sum(book => Math.Pow(book, 2));

            double pSum = user1Books.Select((book1, index) => book1 * user2Books[index]).Sum();

            // 计算皮尔逊相关系数
            double num = pSum - (sum1 * sum2 / n);
            double den = Math.Sqrt((sum1Sq - Math.Pow(sum1, 2) / n) * (sum2Sq - Math.Pow(sum2, 2) / n));

            if (den == 0)
            {
                return 0.0; // 避免除以零
            }

            return num / den;
        }





    }
}

