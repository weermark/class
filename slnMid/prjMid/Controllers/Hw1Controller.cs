using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using prjMid.Models;
namespace prjMid.Controllers
{
    public class Hw1Controller : Controller
    {
        // GET: Hw1
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Prog1()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Prog1(Count count)
        {
            double res = 0;
            string str = "";
            ViewBag.Start = count.Start;
            ViewBag.End = count.End;
            ViewBag.Interval = count.Interval;
            int time = 1;
            for(double i = Convert.ToDouble(count.Start); i < Convert.ToDouble(count.End);time++, i += Convert.ToDouble(count.Interval))
            {
                if(time == 1)
                {
                    res += Convert.ToDouble(1 / i);
                    str += $"1/{i}";
                }
                else if(time % 2 == 1)
                {
                    res += Convert.ToDouble(1 / i);
                    str += $"+1/{i}";
                }
                else
                {
                    res -= Convert.ToDouble(1 / i);
                    str += $"-1/{i}";

                }
            }
            str += $"={res.ToString()}";
            ViewBag.Res = res;
            ViewBag.Str = str;
            return View();
        }
        public ActionResult Prog2()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Prog2(Custom custom, string[] products)
        {
            int sum = 0;
            custom.Meal = string.Join("<br>", products);
            custom.Price = (Convert.ToInt32(custom.Quantity) * 150).ToString();
            sum += Convert.ToInt32(custom.Quantity) * 150;
            for(int i = 0; i < products.Length; i++)
            {
                sum += Convert.ToInt32(products[i].Substring(products[i].IndexOf("$")+1, 2));
            }
            custom.Sum = sum.ToString();
            return View(custom);
        }

        public ActionResult Prog3()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Prog3(Table table)
        {
            ViewBag.Row = table.Row;
            ViewBag.Col = table.Col;
            return View(table);
        }

        public ActionResult Prog4()
        {
            List<Book> books = new List<Book>
            {
                new Book { Path="407 台中市西屯區文華路", Name="逢甲夜市", Url="A01"},
                new Book { Path="404 台中市北區一中街", Name="一中街商圈", Url="A02"},
                new Book { Path= "400 台中市中區公園路", Name= "中華路夜市", Url="A03"},
                new Book { Path= "402 台中市南區忠孝路", Name= "忠孝路夜市", Url="A04"},
                new Book { Path= "420 台中市豐原區中正路 167 巷", Name= "豐原廟東夜市", Url="A05"},
                new Book { Path= "433 台中市龍井區新興路", Name= "東海夜市", Url="A06"}
            };
            /*List<Book> books = new List<Book>();
            books.Add(new Book { Path="407 台中市西屯區文華路", Name="逢甲夜市", Url="A01"});
            books.Add(new Book { Path="404 台中市北區一中街", Name="一中街商圈", Url="A02"});
            books.Add(new Book { Path= "400 台中市中區公園路", Name= "中華路夜市", Url="A03"});
            books.Add(new Book { Path= "402 台中市南區忠孝路", Name= "忠孝路夜市", Url="A04"});
            books.Add(new Book { Path= "420 台中市豐原區中正路 167 巷", Name= "豐原廟東夜市", Url="A05"});
            books.Add(new Book { Path= "433 台中市龍井區新興路", Name= "東海夜市", Url="A06"});*/
            return View(books);
        }
    }
}