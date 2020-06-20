using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NotificacionesTest.Models
{
    public class Mail
    {
        [Required]
        public string Title  { get; set; }
        [Required]
        public string Body  { get; set; }
        [Required]
        public string To { get; set; }
        
        public string[] CC  { get; set; }
        public string[] BCC  { get; set; }

        public List<byte[]> Attatchments { get; set; }


        public String? Host { get; set; }
        public String? From { get; set; }
        public int? Port { get; set; }
        public bool? DefaultCredentiasl { get; set; }
        public bool? UseSSL { get; set; }




    }
}
