// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> Azure ML WebService Input/Output file. </summary>
    public partial class AzureMLWebServiceFile
    {
        /// <summary> Initializes a new instance of AzureMLWebServiceFile. </summary>
        /// <param name="filePath"> The relative file path, including container name, in the Azure Blob Storage specified by the LinkedService. Type: string (or Expression with resultType string). </param>
        /// <param name="linkedServiceName"> Reference to an Azure Storage LinkedService, where Azure ML WebService Input/Output file located. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="filePath"/> or <paramref name="linkedServiceName"/> is null. </exception>
        public AzureMLWebServiceFile(DataFactoryElement<string> filePath, DataFactoryLinkedServiceReference linkedServiceName)
        {
            Argument.AssertNotNull(filePath, nameof(filePath));
            Argument.AssertNotNull(linkedServiceName, nameof(linkedServiceName));

            FilePath = filePath;
            LinkedServiceName = linkedServiceName;
        }

        /// <summary> The relative file path, including container name, in the Azure Blob Storage specified by the LinkedService. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> FilePath { get; set; }
        /// <summary> Reference to an Azure Storage LinkedService, where Azure ML WebService Input/Output file located. </summary>
        public DataFactoryLinkedServiceReference LinkedServiceName { get; set; }
    }
}