﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace MovieAPI.Filters
{
    public class ParseBadRequest : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            var result = context.Result as IStatusCodeActionResult;
            if(result == null)
            {
                return;
            }
            var statusCode = result.StatusCode;
            if (statusCode == 400)
            {
                var response = new List<string>();
                var badRequestObjectResult = context.Result as BadRequestObjectResult;
                if(badRequestObjectResult.Value is string)
                {
                    response.Add(badRequestObjectResult.Value.ToString());
                }
                else
                {
                    foreach(var key in context.ModelState.Keys)
                    {
                        foreach(var err in context.ModelState[key].Errors)
                        {
                            response.Add($"{key} : {err.ErrorMessage}");
                        }
                    }
                }
            }
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
