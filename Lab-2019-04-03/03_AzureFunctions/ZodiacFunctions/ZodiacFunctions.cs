using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace ZodiacFunctions
{
    // DOC: https://docs.microsoft.com/en-us/azure/azure-functions/functions-create-your-first-function-visual-studio
    public static class ZodiacFunctions
    {
        [FunctionName("GetSign")]
        public static IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req, ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            if (!DateTime.TryParse(req.Query["dateOfBirth"], out DateTime dateOfBirth))
            {
                return new BadRequestObjectResult("Please pass a dateOfBirth in the query string.");
            }

            ZodiacSign sign = GetSign(dateOfBirth);

            return new OkObjectResult($"Hello, your sign is {sign}");
        }

        private static ZodiacSign GetSign(DateTime dateOfBirth)
        {
            if (dateOfBirth.Day <= 20 && dateOfBirth.Month <= 1)
            {
                return ZodiacSign.Capricornus;
            }
            if (dateOfBirth.Day <= 20 && dateOfBirth.Month <= 2)
            {
                return ZodiacSign.Aquarius;
            }
            if (dateOfBirth.Day <= 20 && dateOfBirth.Month <= 3)
            {
                return ZodiacSign.Pisces;
            }
            if (dateOfBirth.Day <= 20 && dateOfBirth.Month <= 4)
            {
                return ZodiacSign.Aries;
            }
            if (dateOfBirth.Day <= 20 && dateOfBirth.Month <= 5)
            {
                return ZodiacSign.Taurus;
            }
            if (dateOfBirth.Day <= 21 && dateOfBirth.Month <= 6)
            {
                return ZodiacSign.Gemini;
            }
            if (dateOfBirth.Day <= 22 && dateOfBirth.Month <= 7)
            {
                return ZodiacSign.Cancer;
            }
            if (dateOfBirth.Day <= 22 && dateOfBirth.Month <= 8)
            {
                return ZodiacSign.Leo;
            }
            if (dateOfBirth.Day <= 22 && dateOfBirth.Month <= 9)
            {
                return ZodiacSign.Virgo;
            }
            if (dateOfBirth.Day <= 23 && dateOfBirth.Month <= 10)
            {
                return ZodiacSign.Libra;
            }
            if (dateOfBirth.Day <= 22 && dateOfBirth.Month <= 11)
            {
                return ZodiacSign.Scorpius;
            }
            if (dateOfBirth.Day <= 21 && dateOfBirth.Month <= 12)
            {
                return ZodiacSign.Sagittarius;
            }

            return ZodiacSign.Capricornus;
        }

        private enum ZodiacSign
        {
            Aries,
            Taurus,
            Gemini,
            Cancer,
            Leo,
            Virgo,
            Libra,
            Scorpius,
            Sagittarius,
            Capricornus,
            Aquarius,
            Pisces
        }
    }
}
