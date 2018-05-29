using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace EMess
{
    /*
    class RequestArgs
    {
        private List<String> args;

        public RequestArgs()
        {
            this.args = new List<String>();
        }
        public abstract getSerialise();
    }*/
    public class RequestResponse
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

    public abstract class Request
    {
        protected System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient();
        public static readonly RequestResponse ErrorResponse = new RequestResponse("", 1);  // TODO enum of errors\
        public static readonly RequestResponse NetworkErrorResponse = new RequestResponse("", 404);
        public static readonly RequestResponse SuccessResponse = new RequestResponse("", 0);
        public abstract RequestResponse SendRequest(List<String> args);
    };
    public class LoginRequest : Request
    {
        Int32 id = 1;
        UInt32 loginLen;
        byte[] login;
        UInt32 passLen;
        byte[] pass;
        UInt32 emailLen;
        byte[] email;
        public override RequestResponse SendRequest(List<String> args)
        {
            try
            {
                clientSocket.Connect("127.0.0.1", 12345);
                loginLen = Convert.ToUInt32(args[0].Length);
                login = Encoding.UTF8.GetBytes(args[0]);
                passLen = Convert.ToUInt32(args[1].Length);
                pass = Encoding.UTF8.GetBytes(args[1]);
                emailLen = Convert.ToUInt32(args[2].Length);
                email = Encoding.UTF8.GetBytes(args[2]);
            }
            catch
            {
                return NetworkErrorResponse;
            }
            finally
            {
                clientSocket.Close();
            }

            return ErrorResponse;
        }
    }

    public class SendMessageRequest : Request
    {
        Int32 id = 2;
        UInt32 msgLen;
        byte[] msg;
        public override RequestResponse SendRequest(List<String> args)
        {
            try
            {
                clientSocket.Connect("127.0.0.1", 12345);
                msgLen = Convert.ToUInt32(args[0].Length);
                msg = Encoding.UTF8.GetBytes(args[0]);
            }
            catch
            {
                return NetworkErrorResponse;
            }
            finally
            {
                clientSocket.Close();
            }

            return ErrorResponse;
        }
    }
    public class GetMessageRequest : Request
    {
        Int32 id = 2;
        UInt32 msgLen;
        byte[] msg;
        public override RequestResponse SendRequest(List<String> args)
        {
            try
            {
                clientSocket.Connect("127.0.0.1", 12345);
                msgLen = Convert.ToUInt32(args[0].Length);
                msg = Encoding.UTF8.GetBytes(args[0]);
            }
            catch
            {
                return NetworkErrorResponse;
            }
            finally
            {
                clientSocket.Close();
            }

            return ErrorResponse;
        }
    }
}
