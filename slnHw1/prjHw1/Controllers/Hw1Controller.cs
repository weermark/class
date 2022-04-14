using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using prjHw1.Models;    // important

namespace prjHw1.Controllers
{
    public class Hw1Controller : Controller
    {
        // GET: Hw1
        public ActionResult Prog1()
        {
            //client.Order.Add("黑森林蛋糕");
            //client.Order.Add("森林蛋糕");
            //client.Order.Add("林蛋糕");
            //client.Order.Add("蛋糕");
            //ViewBag.Client = client;
            return View();
        }

        [HttpPost]
        public ActionResult Prog1(Client client, string[] products)
        {
            ViewData["title"] = "訂單基本資料";
            ViewBag.Name = client.Name;
            ViewBag.Id = client.Id;
            ViewBag.IsMember = client.IsMember;
            ViewBag.PickWay = client.PickWay;
            ViewBag.PayWay = client.PayWay;
            ViewBag.Order = string.Join(" ", products);
            ViewBag.Time = client.Time;
            ViewBag.Remark = "";
            foreach (var c in client.Remark)
            {
                if (c == '\r')
                {
                    ViewBag.Remark += "<br>";
                }
                else
                {
                    ViewBag.Remark += c;
                }
                // System.Diagnostics.Debug.WriteLine(c);
            }
//             ViewBag.Remark = client.Remark;
            return View();
        }

        // prog2
        public ActionResult Prog2()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Prog2(Table table)
        {
            ViewBag.Row = table.Row;
            ViewBag.Col = table.Col;
            ViewBag.Fir = table.Fir;
            ViewBag.Sec = table.Sec;
            return View();
        }

        // Prog3
        public ActionResult Prog3()
        {
            List<Dice> dices = new List<Dice>();
            dices.Add(new Dice { Id = "dice1", Name = "1" });
            dices.Add(new Dice { Id = "dice2", Name = "2" });
            dices.Add(new Dice { Id = "dice3", Name = "3" });
            dices.Add(new Dice { Id = "dice4", Name = "4" });
            dices.Add(new Dice { Id = "dice5", Name = "5" });
            dices.Add(new Dice { Id = "dice6", Name = "6" });
            return View(dices);
        }

        [HttpPost]
        public ActionResult Prog3(Dice dice)
        {
            ViewBag.Time1 = dice.Time1;
            ViewBag.Time2 = dice.Time2;
            ViewBag.Time3 = dice.Time3;
            ViewBag.Time4 = dice.Time4;
            Console.WriteLine(dice.Time1);
            return View();
        }
    }
}