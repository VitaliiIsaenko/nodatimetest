using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using NodaTime;

namespace NodaTimeTest.WebApi.Controllers
{
    [ApiController]
    [Route("/")]
    public class Controller : ControllerBase
    {

        public Controller()
        {
        }

        [HttpGet]
        public ClassWithOffsetDateTime Get()
        {
            var objWithOffsetDateTime = new ClassWithOffsetDateTime();
            // objWithOffsetDateTime.Start = new OffsetDateTime().WithOffset(Offset.FromHours(5));
            var serialized = JsonConvert.SerializeObject(objWithOffsetDateTime);
            return JsonConvert.DeserializeObject<ClassWithOffsetDateTime>(serialized);
        }
    }
}