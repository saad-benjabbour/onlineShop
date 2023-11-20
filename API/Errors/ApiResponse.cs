﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Errors
{
    public class ApiResponse
    {

        public ApiResponse(int statusCode, string message = null)
        {
            Statuscode = statusCode;
            Message = message ?? GetDefaultMessageForStatusCode(statusCode);
        }

        public int Statuscode { get; set; }
        public string Message { get; set; }
        private string GetDefaultMessageForStatusCode(int statusCode)
        {
            return statusCode switch
            {
                400 => "A bad request, you have made",
                401 => "Authoriwed, you are not",
                404 => "Resource found, it was not",
                500 => "Internal Sever error",
                _ => null
            };
        }

    }
}
