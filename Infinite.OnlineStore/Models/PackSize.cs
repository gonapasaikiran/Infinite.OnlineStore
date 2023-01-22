using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infinite.OnlineStore.Models
{
    public class PackSize
    {
        public int Id { get; set; }
        public int Packsize { get; set; }
    }
}