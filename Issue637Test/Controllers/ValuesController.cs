
namespace Issue637Test.Controllers
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using MQTTnet.Client.Options;

    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            // Create TCP based options using the builder.
            var options = new MqttClientOptionsBuilder()
                .WithClientId("Client1")
                .WithTcpServer("broker.hivemq.com")
                .WithCredentials("bud", "%spencer%")
                .WithTls()
                .WithCleanSession()
                .Build();

            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
