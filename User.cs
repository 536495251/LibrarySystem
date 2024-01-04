using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystemVersion2
{
    public class User
    {
        public string UserAccount;
        public string UserPassword;
        public string UserName;
        public string UserSex;
        public string UserTelephone;
        public string UserAddress;
        public int UserAge;
        public int UserBorrowCount=10;
        public bool UserIsFrozen=false;

       /*public User(string userAccount, string userPassword, string userName, string userSex, string userTelephone, string userAddress, int userAge)
        {
            UserAccount = userAccount;
            UserPassword = userPassword;
            UserName = userName;
            UserSex = userSex;
            UserTelephone = userTelephone;
            UserAddress = userAddress;
            UserAge = userAge;

        }*/
        public User(string userAccount, string userPassword, string userName, string userSex, string userTelephone, string userAddress, int userAge,int borrowCount,bool isfrozen)
        {
            UserAccount = userAccount;
            UserPassword = userPassword;
            UserName = userName;
            UserSex = userSex;
            UserTelephone = userTelephone;
            UserAddress = userAddress;
            UserAge = userAge;
            UserBorrowCount = borrowCount;
            UserIsFrozen = isfrozen;
        }
        public User()
        {

        }
    }
}
