using Project.Core.ViewModels;
using System.Linq;

namespace Project.Core.BusinessServices.Implementation
{
    public class StringOperationService : IStringOperationService
    {
        /// <summary>
        /// Check if input string has atleast one of each letter of the alphabet
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns>Return response of type StringOperationServiceResponse. 
        /// If string is empty will return error message with IsValidationFailed to true 
        /// otherwise ValidationMessage will be empty but Response will be set to true/false
        /// </returns>
        public StringOperationServiceResponse HasAllLettersOfAlphabet(string inputString)
        {
            var response = new StringOperationServiceResponse();

            if (string.IsNullOrEmpty(inputString))
            {
                response.IsValidationFailed = true;
                response.ValidationMessage = "String is empty";

                return response;
            }

            var alphabateCount = inputString.ToLower()
                .Where(c => System.Char.IsLetter(c))
                .GroupBy(c => c)
                .Count();

            response.Response = alphabateCount == 26;

            return response;
        }
    }
}
