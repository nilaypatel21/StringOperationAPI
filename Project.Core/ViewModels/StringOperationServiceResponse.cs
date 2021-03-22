namespace Project.Core.ViewModels
{
    public class StringOperationServiceResponse
    {
        public bool IsValidationFailed { get; set; }

        public string ValidationMessage { get; set; }

        public bool Response { get; set; }
    }
}
