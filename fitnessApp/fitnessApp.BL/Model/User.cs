using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitnessApp.BL.Model
{

    /// <summary>
    /// Пользователь.
    /// </summary>

    [Serializable]
    internal class User
    {
        public string Name { get; } //для того, что бы параметр был readOnly

        public Gender Gender { get; }

        public DateTime BirthDate { get; }

        public double Weight { get; set; }

        public double Height { get; set; }


        //Конструктор
        public User(
            string name,
            Gender gender,
            DateTime birthDate,
            double weight,
            double height)

        {
            Name = name;
            Gender = gender;
            BirthDate = birthDate;
            Weight = weight;
            Height = height;

            //Проверки на корректность данных
            #region Проверка условий
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("имя пользователя не может быть пустым или null", nameof(name));
            }
            if (Gender == null)
            {
                throw new ArgumentException("пол не может быть null.", nameof(Gender));
            }
            if (BirthDate < DateTime.Parse("01.01.1900") || BirthDate > DateTime.Now)
            {
                throw new ArgumentException("дата не можеть быть такой");
            }
            if (Weight <= 0)
            {
                throw new ArgumentException("Вес там с ошибкой. Исправь!");
            }
            if (Height <= 0)
            {
                throw new ArgumentException("Рост не может быть меньше либо равен нулю", nameof(Height));
            }
            #endregion

        }

    }