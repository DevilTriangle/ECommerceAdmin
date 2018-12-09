using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace AdminECommerceAPI.BaseClass
{
    public class BaseResponse<T>
    {
        public HttpStatusCode ResultCode { get; set; }
        public bool Success { get; set; }
        public T Data { get; set; }
        public string Message { get; set; }

        public static BaseResponse<T> Get(bool success, HttpStatusCode resultCode, T data, string message)
        {
            return new BaseResponse<T>()
            {
                ResultCode = resultCode,
                Success = success,
                Data = data,
                Message = message,
            };
        }
    }
}