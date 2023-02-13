using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proyecto_BackEnd.Model;
using Proyecto_BackEnd.Service;

namespace Proyecto_BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CallController : ControllerBase
    {
        public readonly CallService _call;
        public CallController(CallService callService)
        {
            _call = callService;
        }

        [HttpPost]
        public void insert([FromBody] CallModel c)
        {
            _call.Insert(c);
        }

        [HttpGet("GetAll")]
        public List<CallModel> GetAll()
        {
            return _call.GetAll();
        }

        [HttpPut("Update")]
        public void Update([FromBody] CallModel c)
        {
            _call.Update(c);
        }
    }
}
