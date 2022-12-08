using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace fitnessApp.BL.Model
{/// <summary>
/// делать XML комментарии надо ко всем public методам
/// </summary>
    public class Gender
    {
        public string Name { get; }

        //Конструктор
        public Gender(string name)
        {
            if(string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("name пустое или null, а это н едопустимо", nameof(name));
            }
            Name = name;
        }

    }
}
