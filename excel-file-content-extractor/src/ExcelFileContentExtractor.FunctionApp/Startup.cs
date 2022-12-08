using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;


[assembly: FunctionsStartup(typeof(ExcelFileContentExtractor.FunctionApp.Startup))]
namespace ExcelFileContentExtractor.FunctionApp
{
    internal class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            //throw new NotImplementedException();
        }
    }
}
