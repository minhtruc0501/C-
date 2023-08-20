using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThaiMinhTruc.Model;

namespace ThaiMinhTruc.DAL
{
    
    internal class LoginDAL
    {
        private string connectionString = @"Data Source=DESKTOP-QHN6DLG;Initial Catalog=Quanlybanhang2;User Id=sa; Password=sa";

        // Other methods...

        public bool ValidateUser(LoginBEL Login)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM Taikhoan WHERE TaiKhoan = @Username AND MatKhau = @Password";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", Login.TaiKhoan);
                    command.Parameters.AddWithValue("@Password", Login.Matkhau);

                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
                catch (Exception)
                {
                    // Handle any errors that may occur during the database operation.
                    // For example, log the error or display an error message.
                    return false;
                }
            }
        }
    }
}
