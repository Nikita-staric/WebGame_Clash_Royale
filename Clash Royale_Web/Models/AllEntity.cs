using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clash_Royale_Web.Models
{
    public class AllEntity
    {
        //создадим список и загрузим всех персонажей
        public List<Entiti> AllCreatures { get; }= new List<Entiti>();
        //создаем калоду
        public AllEntity(string field)//передаем данные на каком поле мы играем 
        {
            //если дракон находиться в пустели -то медлено ,в аду-быстро
            //  AllCreatures = new List<Entiti>();

            //создали карту
            AllCreatures.Add(new Entiti(" Fairy", 100, 79, 2, 454, 88, " d"));
            AllCreatures.Add(new Entiti("Dragon", 100, 30, 33, 454, 11, " d"));
            AllCreatures.Add(new Entiti(" Paradin", 333, 60, 70, 454, 8, " d"));
            AllCreatures.Add(new Entiti("Volk", 1000, 34, 343, 2, 666, " d"));
                        


        }
    }
}
