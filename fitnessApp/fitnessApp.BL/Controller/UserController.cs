using fitnessApp.BL.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace fitnessApp.BL.Controller
{
    internal class UserController
    {
        public User User { get; }

        public UserController(User user)
        {
            User = user ?? throw new ArgumentNullException("Пользователь не может быть равен null", nameof(user));
        }
    //Сереализация
    /// <summary>
    /// Сохранить данные пользователя
    /// </summary>

        public void Save()
        {
            var formatter = new BinaryFormatter();

            using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, User);
            }
        }

        //ДЕсереализация
        /// <summary>
        /// Получить данные пользователя.
        /// </summary>
        /// <returns> Пользователь приложения</returns>
        public User Load()
        {
            var formatter = new BinaryFormatter();

            using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
               if(formatter.Deserialize(fs) is User user)
                {
                    return user;
                }
                else
                {
                    throw new FileLoadException("Не удалось сериализовать пользователя", "users.dat");
                }
            }
        }

    }
}
