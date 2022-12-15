using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clash_Royale_Web.Models
{
    public class AllPlayData
    {
        //создадим лист что б загрузить данные
        public List<Entiti> AllEntite { get; set; }
        public Language languagePlay { get; set; } //можем использовать то что в клуасе
        public string PlayerName { get; set; }
        public string PlayerMap { get; set; }
        public int PlayerSpeed { get; set; }//скороcть
    }
}
