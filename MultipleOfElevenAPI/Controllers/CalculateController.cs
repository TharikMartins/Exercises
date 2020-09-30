using MultipleOfElevenAPI.Models;
using MultipleOfElevenAPI.Services;
using System.Web.Http;

namespace MultipleOfElevenAPI.Controllers
{
    [RoutePrefix("api/calculate")]
    public class CalculateController : ApiController
    {

        [HttpPost]
        [Route("Result")]
        public Response Result(Request data)
        {
            var response = new Response();

            data.Numbers.ForEach(n =>
            {
                response.Results.Add(new Result
                {
                    isMultiple = CalculateService.IsMultipleNumber(n),
                    number = n
                });
            });

            return response;
        }
    }
}
