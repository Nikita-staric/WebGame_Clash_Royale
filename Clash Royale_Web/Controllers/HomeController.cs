using Clash_Royale_Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Clash_Royale_Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            /*
                Проверяем наши куки, в случае если есть запись "PLAYER_NAME" попадём на страницу Index
                В противном случае - откроем страницу регистрации Register
            */

            if (Request.Cookies["PRAYER_Name"] != null)
            {
                //Создаём экземпляр класса AllPlayData и заполняем его всеми нужными данными для игрока
                AllPlayData initPrayerData = new AllPlayData();
                initPrayerData.PlayerName = Request.Cookies["PRAYER_Name"];



                /*
                  Проверяем наши куки, в случае если запись "PLAYER_LANGUAGE" отсутствует
                  установим язык по умолчанию - "UA"
                  В противном случае - установим значение языка из куки
              */
                if (Request.Cookies["PRAYER_LANGUAGE"] == null)
                {
                    initPrayerData.languagePlay = new Language("En");
                }
              //  return View("Index", languagePlayel);
              //если есть мова то мы присвоем ту котороя есть 
                else
                {
                    initPrayerData.languagePlay = new Language(Request.Cookies["PRAYER_LANGUAGE"]);
                   
                }

                //сущесвует ли PRAYER_MAP взяли в Seting


                /*
                    Проверяем наши куки, в случае если запись "PLAYER_MAP" отсутствует
                    установим карту случайным образом 
                    В противном случае - установим карту из куки
                */

                if (Request.Cookies["PRAYER_MAP"] == null)
                {
                    //за замовчування 0 если выбрали 1(карта)
                    initPrayerData.PlayerMap = "random";
                }
                //  return View("Index", languagePlayel);
                //если есть мова то мы присвоем ту котороя есть 
                else
                {
                    //присвоить данные которые были в Cookies ,таким образом мы сможем выбрать карты
                    initPrayerData.PlayerMap = Request.Cookies["PRAYER_MAP"];

                }
                //передаем данные
                // initPrayerData.AllEntite = new AllEntity("forest").AllCreatures;
                return View("Index", initPrayerData);
            }
           
            else
            {/*
                    Отобразим страницу Register и передадим в неё наш экземпляр ourlang,
                    с значением языка - UA
                */

                Language ourlang = new Language("En");
                return View("Register", ourlang);




            }

           
        }

        public IActionResult Privacy()
        {
            return View();
        }
        
        public IActionResult Seting()
        {
            //данные поменялись но мы не увидели
            AllPlayData initPrayerData = new AllPlayData();
            if (Request.Cookies["PRAYER_LANGUAGE"] == null)
            {
                initPrayerData.languagePlay = new Language("Ru");
            }
           // return View("Index", languagePlayel);
            //если есть мова то мы присвоем ту котороя есть
            else
            {
                initPrayerData.languagePlay = new Language(Request.Cookies["PRAYER_LANGUAGE"]);

            }

            if (Request.Cookies["PRAYER_MAP"] == null)
            {
                initPrayerData.PlayerMap = "random";
            }
            else
            {
                initPrayerData.PlayerMap = Request.Cookies["PRAYER_MAP"];
            }



            //Передаём наши данные на страницу Config и отображаем её


            //Передаём наши данные на страницу Config и отображаем её
            return View(initPrayerData);
        }
        public IActionResult Pla_y()
        {
            return View();
        }


      [HttpPost]
      //Метод обработки страницы Config с обработкой данных post запроса

        public IActionResult Register(IFormCollection formCollection)//обновление данных которые приходят
        {
            if (formCollection["nikName"].Count > 0)//если она не пустая
            {
                //то добовляем в Сooki
                Response.Cookies.Append("PRAYER_Name", formCollection["nikName"]);
            }
            //должнЫ вернуться
            return RedirectToAction("Index" , "Home");
        }
        //получаем данные
        //прогуглить   [HttpPost]
        [HttpPost]
        public IActionResult Seting(IFormCollection formСonfig)//обновление данных которые приходят
        {
            //  данные поменялись но мы не увидели
            //AllPlayData initPrayerData = new AllPlayData();
            //if (Request.Cookies["PRAYER_LANGUAGE"] == null)
            //{
            //    initPrayerData.languagePlay = new Language("En");


            //}
            ////  return View("Index", languagePlayel);
            ////если есть мова то мы присвоем ту котороя есть
            //else
            //{
            //    initPrayerData.languagePlay = new Language(Request.Cookies["PRAYER_LANGUAGE"]);

            //}
            //return View(initPrayerData);



            if (formСonfig["language"].Count > 0)//если она не пустая
            {
                //то добовляем в Сooki
                Response.Cookies.Append("PRAYER_LANGUAGE", formСonfig["language"]);

            }
            if (formСonfig["map"].Count > 0)//если она не пустая
            {
                //то добовляем в Сooki
                //игрок PRAYER_MAP что б получал нашве данные
                Response.Cookies.Append("PRAYER_MAP", formСonfig["map"]);
            }
            //   должнЫ вернуться
            return RedirectToAction("Seting", "Home");
        }




            [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
