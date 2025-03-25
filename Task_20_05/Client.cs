using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_20_05
{
    enum AccessLevel
    {
        Guest,
        User,
        Moderator,
        Admin
    }

    class Client
    {
        AccessLevel client;

        public Client(AccessLevel client)
        {
            this.client = client;
        }

        /// <summary>
        /// чтение для всех кроме модератора
        /// </summary>
        public void Read()
        {
            if ((int)client != (int)AccessLevel.Moderator) Console.WriteLine($"{client} читает...");
            else Console.WriteLine($"{client} не имеет столько прав");
        }

        /// <summary>
        /// Создание контента только для пользователя и админа
        /// </summary>
        public void CreateContent()
        {
            if ((int)client >= (int)AccessLevel.User && (int)client != (int)AccessLevel.Moderator) Console.WriteLine($"{client} создаёт контент...");
            else Console.WriteLine($"{client} не имеет столько прав");
        }

        /// <summary>
        /// Удаление контента только для модератора и админа
        /// </summary>
        public void DeleteContent()
        {
            if ((int)client >= (int)AccessLevel.Moderator) Console.WriteLine($"{client} удаляет контент...");
            else Console.WriteLine($"{client} не имеет столько прав");
        }
    }
}
