using Project.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Core.BusinessServices
{
    public interface IStringOperationService
    {
        StringOperationServiceResponse HasAlphabets(string inputString);
    }
}
