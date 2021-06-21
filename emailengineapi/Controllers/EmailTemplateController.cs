using emailengineapi.Model;
using emailengineapi.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace emailengineapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmailTemplateController:ControllerBase
    {
        [HttpPost]
        public async Task<EngineResponse> Engine(EngineRequest requestValue)
        {
            TemplateServices templateServices = new TemplateServices();
            var tabularHtml=await templateServices.BuildTemplate();
            var finalHtml = await templateServices.FinalHtml(tabularHtml);
            var response = await templateServices.SendEmail(finalHtml, requestValue.EmailId);
            return response ;
        }
    }
}
