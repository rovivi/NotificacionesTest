using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotificacionesTest.Models
{
    public class Mail
    {

        public string Title  { get; set; }
        public string Body  { get; set; }
        public string[] CC  { get; set; }
        public string[] CCC  { get; set; }

        public List<byte[]> Attatchments { get; set; }
    }
}
