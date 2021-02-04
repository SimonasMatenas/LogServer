using System;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
// ReSharper disable TemplateIsNotCompileTimeConstantProblem

namespace LogServer.Controllers {
    [Route("{*url}")]
    [ApiController]
    public class AllController : ControllerBase {
        private readonly ILogger<AllController> _logger;

        public AllController(ILogger<AllController> logger) {
            _logger = logger;
        }

        [HttpGet]
        [HttpPost]
        public IActionResult All() {
            _logger.LogInformation($"{Request.Method} {Request.GetDisplayUrl()}");
            return Ok($"Response - {DateTime.Now}");
        }
    }
}

// curl https://10.190.114.219:3001/labas/cia/is/toli