using Project.Core.ViewModels;
using System.Linq;
using System.Text.RegularExpressions;

namespace Project.Core.BusinessServices.Implementation
{
    public class StringOperationService : IStringOperationService
    {
        public StringOperationServiceResponse HasAlphabets(string inputString)
        {
            var response = new StringOperationServiceResponse();

            if (string.IsNullOrEmpty(inputString))
            {
                response.IsValidationFailed = true;
                response.ValidationMessage = "String is empty";

                return response;
            }

            var alphabateCount = Regex.Matches(inputString, @"[a-zA-Z]").Count();

            response.Response =  alphabateCount > 0;

            return response;
        }
    }
}
