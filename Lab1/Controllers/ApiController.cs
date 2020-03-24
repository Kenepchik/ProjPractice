using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Linq;

namespace Lab1.Controllers
{
    [Route("api")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        [HttpGet("num/{n}")]
        public ActionResult<string> Func1(int n)
        {
            return JsonConvert.SerializeObject(RusNumber.Str(n));
        }

        [HttpGet("equation")]
        public ActionResult<string> Func2(int a, int b, int c)
        {
            double disc = b * b - 4 * a * c;
            if (disc > 0)
            {
                double ansOne = (-b + Math.Sqrt(disc)) / 2 * a;
                double ansTwo = (-b - Math.Sqrt(disc)) / 2 * a;

                return JsonConvert.SerializeObject(new double[] { ansOne, ansTwo });
            }

            if (disc == 0)
            {
                double ansOne = -b / 2 / a;
                return JsonConvert.SerializeObject(ansOne);
            }

            return JsonConvert.SerializeObject("");
        }

        //private Dictionary<DayOfWeek, string> keyValues = new Dictionary<DayOfWeek, string>
        //{
        //    {DayOfWeek.Monday, "Понедельник" },
        //    {DayOfWeek.Tuesday, "Вторник" },
        //    {DayOfWeek.Wednesday, "Среда" },
        //    {DayOfWeek.Thursday, "Четверг" },
        //    {DayOfWeek.Friday, "Пятница" },
        //    {DayOfWeek.Saturday, "Суббота" },
        //    {DayOfWeek.Sunday, "Воскресенье" },
        //};

        [HttpGet("dow")]
        public ActionResult<string> Func3(string n)
        {
            var date = n.Split('.').Select(int.Parse).ToArray();
            return JsonConvert.SerializeObject(new DateTime(date[2], date[1], date[0]).DayOfWeek.ToString());
        }

        [HttpGet("fib/{n}")]
        public ActionResult<string> Func4(int n)
        {
            double expOne = Math.Pow((1 + Math.Sqrt(5)) / 2, n);
            double expTwo = Math.Pow((1 - Math.Sqrt(5)) / 2, n);
            double formulaBine = Math.Round(expOne - expTwo) / Math.Sqrt(5);

            return JsonConvert.SerializeObject(formulaBine);
        }

        [HttpGet("region/{n}")]
        public ActionResult<string> Func5(int n)
        {
            string[] regions = new string[] {
                "",
                "Республика Адыгея (Адыгея)",
                "Республика Башкортостан",
                "Республика Бурятия",
                "Республика Алтай",
                "Республика Дагестан",
                "Республика Ингушетия",
                "Кабардино-Балкарская Республика",
                "Республика Калмыкия",
                "Карачаево-Черкесская Республика",
                "Республика Карелия",
                "Республика Коми",
                "Республика Марий Эл",
                "Республика Мордовия",
                "Республика Саха (Якутия)",
                "Республика Северная Осетия - Алания",
                "Республика Татарстан (Татарстан)",
                "Республика Тыва",
                "Удмуртская Республика",
                "Республика Хакасия",
                "Чеченская Республика",
                "Чувашская Республика - Чувашия",
                "Алтайский край",
                "Краснодарский край",
                "Красноярский край",
                "Приморский край",
                "Ставропольский край",
                "Хабаровский край",
                "Амурская область",
                "Архангельская область",
                "Астраханская область",
                "Белгородская область",
                "Брянская область",
                "Владимирская область",
                "Волгоградская область",
                "Вологодская область",
                "Воронежская область",
                "Ивановская область",
                "Иркутская область",
                "Калининградская область",
                "Калужская область",
                "Камчатский край",
                "Кемеровская область",
                "Кировская область",
                "Костромская область",
                "Курганская область",
                "Курская область",
                "Ленинградская область",
                "Липецкая область",
                "Магаданская область",
                "Московская область",
                "Мурманская область",
                "Нижегородская область",
                "Новгородская область",
                "Новосибирская область",
                "Омская область",
                "Оренбургская область",
                "Орловская область",
                "Пензенская область",
                "Пермский край",
                "Псковская область",
                "Ростовская область",
                "Рязанская область",
                "Самарская область",
                "Саратовская область",
                "Сахалинская область",
                "Свердловская область",
                "Смоленская область",
                "Тамбовская область",
                "Тверская область",
                "Томская область",
                "Тульская область",
                "Тюменская область",
                "Ульяновская область",
                "Челябинская область",
                "Забайкальский край",
                "Ярославская область",
                "г. Москва",
                "Санкт-Петербург",
                "Еврейская автономная область",
                "Ненецкий автономный округ",
                "Ханты-Мансийский автономный округ - Югра",
                "Чукотский автономный округ",
                "Ямало-Ненецкий автономный округ",
                "Иные территории, включая город и космодром Байконур" };

            string NumofRegion = regions[n];
            return JsonConvert.SerializeObject(NumofRegion);
        }
    }
}