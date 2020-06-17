using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NotificacionesTest.Models;

namespace NotificacionesTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MailController : ControllerBase
    {


        private readonly ILogger<MailController> _logger;

        public MailController(ILogger<MailController> logger)
        {
            _logger = logger;
        }




        /// <summary>
        /// Nos devuelve una notificación 
        /// </summary>
        /// Sample request:
        ///
        ///     POST /Mail
        ///    {
        ///    "title": String,
        ///    "body":  String,
        ///    "cc":  String,
        ///    "ccc":   String,
        ///    "attatchments": Byte[]
        ///     }
        /// </remarks>        
        /// <response code="200">Todo ha pasado correctamente</response>
        /// <response code="400">Product has missing/invalid values</response>
        /// <response code="409">Se ha producido un conflicto</response>
        /// <response code="500">Error inesperado</response>
        /// 
        [HttpPost]
        [ProducesResponseType(typeof(Mail), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]


        public IActionResult Post(Mail mail)
        {
            if (mail.Title == null || mail.CC == null || mail.CCC == null || mail.Body == null)
                return BadRequest();

            try
            {
                MailService.SendMail(mail);
            }
            catch (Exception ex) {
                return Conflict();
            }


            return Ok(mail);
        }





    }
}
