using Azure;
using Microsoft.AspNetCore.Mvc;

namespace MovieAPI.APIBehaviour
{
    public class BadRequestBehaviour
    {
        public static void Parse(ApiBehaviorOptions options)
        {
            options.InvalidModelStateResponseFactory = context =>
            {
                var response = new List<string>();
                foreach (var key in context.ModelState.Keys)
                {
                    foreach (var err in context.ModelState[key].Errors)
                    {
                        response.Add($"{key} : {err.ErrorMessage}");
                    }
                }
                return new BadRequestObjectResult(response);
            };
        }
    }
}
