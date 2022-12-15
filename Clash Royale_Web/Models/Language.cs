using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clash_Royale_Web.Models
{
    public class Language
    {
         public string Play { get; }
        public string Setting { get; }
        public string ConfigLange { get; }
        public string ConfigMap { get; }
        public string ConfigBack { get; }
       


        public  Language(string chose)
        {
            if (chose == "Ru")//если м вібрали язік UA то
            {
                Play = "ИГРАТЬ";
                Setting = "Настройка";
                ConfigLange = "Вибор языка";
                ConfigMap = "Выбор картЫ";
                ConfigBack = "До глаавного Персонажа";
            }
            else if (chose == "En")
            {
                Play = "Plaay ";
                Setting = "Setting";
                ConfigLange = "Language setting";
                ConfigMap = "Choose of map";
                ConfigBack = "Back to main menu";
            }

        }
    }
}
