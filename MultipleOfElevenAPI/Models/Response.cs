using System.Collections.Generic;

namespace MultipleOfElevenAPI.Models
{
    public class Response
    {
        public Response()
        {
            Results = new List<Result>();
        }

        public List<Result> Results { get; set; }
    }
}