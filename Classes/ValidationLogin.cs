﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoorStoreV2.Classes
{
    public class ValidationLogin
    {
        public static bool Validation(string login)
        {
            var input = login;

            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Поле с логином пустое", "Ошибка");
                return false;
            }

            var hasMiniMaxChars = new Regex(@".{5,12}");
            var hasLowerChar = new Regex(@"[a-z]+");

            if (!hasLowerChar.IsMatch(input))
            {
                MessageBox.Show("Логин должен содержать хотя бы одну строчную букву", "Ошибка");
                return false;
            }
            else if (!hasMiniMaxChars.IsMatch(input))
            {
                MessageBox.Show("Логин должен быть длиннее 5 символов", "Ошибка");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
