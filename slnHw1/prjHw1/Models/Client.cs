using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prjHw1.Models
{
    public class Client
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string IsMember { get; set; }
        public string PickWay { get; set; }
        public string PayWay { get; set; }
        public string Order { get; set; }
        public string Time { get; set; }
        public string Remark { get; set; }
    }
}