using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clash_Royale_Web.Models
{
    //персонажи
    public class Entiti
    {
        public string TypeEnitu { get; set; }
        public int HelthEntity { get; set; }
        public int AtackEntity { get; set; }
        public int DictanceAtackEntity { get; set; }
        public int SpeesEntity { get; set; }
        public int PriceEntity { get; set; }
        public string CaldEntity { get; set; }
      
        //как дать свойство нашим полям
        public Entiti(string nameType,int helth,int distance,int attack ,int speed,int cost,string card)
        {
            TypeEnitu = nameType;
            HelthEntity = helth;
            AtackEntity = attack;
            DictanceAtackEntity = distance;
            SpeesEntity = speed;
            PriceEntity = cost;
            CaldEntity = card;
        }
    }
}
