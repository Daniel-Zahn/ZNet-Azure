using System;
using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using log4net;
using log4net.Config;
using log4net.Repository;

namespace ExcelFileContentExtractor.FunctionApp
{
    public class ExcelFileContentExtractorFuncApp
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        
        [FunctionName("excel-file-content-extractor-func-app")]
        public void Run([BlobTrigger("mis-test/{name}", Connection = "blobCon")]Stream myBlob, string name, ILogger log, Uri uri)
        {
            log.LogInformation($"C# Blob trigger function Processed blob\n Name:{name} \n Size: {myBlob.Length} Bytes \n Uri: {uri.AbsolutePath}");
        }
    }
}

// Azure.Storage.Blobs(12.14.1)
// log4net (2.0.9)
// NHibernate (5.2.7)
// NPOI (2.5.6)
// System.Data.SqlClient (4.8.3)
