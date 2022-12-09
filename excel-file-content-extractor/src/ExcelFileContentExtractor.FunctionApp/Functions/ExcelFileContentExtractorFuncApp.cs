using System;
using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace ExcelFileContentExtractor.FunctionApp
{
    public class ExcelFileContentExtractorFuncApp
    {
        
        [FunctionName("excel-file-content-extractor-func-app")]
        public void Run([BlobTrigger("mis-test/{name}", Connection = "blobCon")]Stream myBlob, string name, ILogger log, Uri uri)
        {
            log.LogInformation($"C# Blob trigger function Processed blob\n Name:{name} \n Size: {myBlob.Length} Bytes \n Uri: {uri.AbsolutePath}");
        }
    }
}
