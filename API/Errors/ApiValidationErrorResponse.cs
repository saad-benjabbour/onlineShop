﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Errors
{
    public class ApiValidationErrorResponse : ApiResponse
    {
        public ApiValidationErrorResponse()
            :base(400)
        {

        }
        // looping through the errors of the validation
        public IEnumerable<string> Errors { get; set; }
    }
}
