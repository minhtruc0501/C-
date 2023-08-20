using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThaiMinhTruc.DAL;
using ThaiMinhTruc.Model;

namespace ThaiMinhTruc.BAL
{
    internal class Login
    {
        private LoginDAL LoginDAL;
        public string ConnectionString { get; set; }

        public Login()
        {
            LoginDAL = new LoginDAL();
        }
    }
}
