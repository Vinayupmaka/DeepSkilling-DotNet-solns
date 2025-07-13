using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.IO;

namespace MyFirstWebAPI.Filters
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            string errorMessage = context.Exception.Message;
            string log = $"[{DateTime.Now}] Error: {errorMessage}{Environment.NewLine}";
            File.AppendAllText("error_log.txt", log);
            context.Result = new ObjectResult("Something went wrong. Please try again later.")
            {
                StatusCode = 500
            };
            // mark exception as handled
            context.ExceptionHandled = true;
        }
    }
}
