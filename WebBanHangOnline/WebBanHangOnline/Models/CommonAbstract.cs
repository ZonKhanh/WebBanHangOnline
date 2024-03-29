using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebBanHangOnline.Models
{
    public abstract class CommonAbstract
    {
        public string CreateedBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string ModifiedBy { get; set;}
        public DateTime ModifiedDate { get; set;}
    }
}