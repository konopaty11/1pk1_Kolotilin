using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_14_04
{
    /*
     * Определите класс User, который будет иметь статическое свойство CurrentUser, \
     * представляющеетекущегопользователя, и метод для его установки.
    */
    internal class User
    {
        static string currentUser;
        public static string CurrentUser
        {
            get => currentUser;
            private set => currentUser = value;
        }

        public static void SetCurrentUser(string currrentUser) { currentUser = currrentUser; }
    }
}
