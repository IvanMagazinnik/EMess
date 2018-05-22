using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace EMess
{
    class RequestArgs
    {
        private Dictionary<String, String> args;

        public RequestArgs()
        {
            this.args = new Dictionary<String, String>();
        }
    }
    class RequestResponse
    {
        private string data;
        private int status;

        public RequestResponse(string data, int status)
        {
            this.data = data;
            this.status = status;
        }

        public int Status { get => status; set => status = value; }
        public string Data { get => data; set => data = value; }
    };

    class Request
    {
        public static readonly RequestResponse ErrorResponse = new RequestResponse("", 1);  // TODO enum of errors
        public RequestResponse sendRequest(RequestArgs args)
        {
            return ErrorResponse;
        }
    };
}
