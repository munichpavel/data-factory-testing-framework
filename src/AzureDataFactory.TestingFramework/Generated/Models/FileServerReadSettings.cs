// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> File server read settings. </summary>
    public partial class FileServerReadSettings : StoreReadSettings
    {
        /// <summary> Initializes a new instance of FileServerReadSettings. </summary>
        public FileServerReadSettings()
        {
            StoreReadSettingsType = "FileServerReadSettings";
        }

        /// <summary> Initializes a new instance of FileServerReadSettings. </summary>
        /// <param name="storeReadSettingsType"> The read setting type. </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="disableMetricsCollection"> If true, disable data store metrics collection. Default is false. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="recursive"> If true, files under the folder path will be read recursively. Default is true. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="wildcardFolderPath"> FileServer wildcardFolderPath. Type: string (or Expression with resultType string). </param>
        /// <param name="wildcardFileName"> FileServer wildcardFileName. Type: string (or Expression with resultType string). </param>
        /// <param name="fileListPath"> Point to a text file that lists each file (relative path to the path configured in the dataset) that you want to copy. Type: string (or Expression with resultType string). </param>
        /// <param name="enablePartitionDiscovery"> Indicates whether to enable partition discovery. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="partitionRootPath"> Specify the root path where partition discovery starts from. Type: string (or Expression with resultType string). </param>
        /// <param name="deleteFilesAfterCompletion"> Indicates whether the source files need to be deleted after copy completion. Default is false. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="modifiedDatetimeStart"> The start of file's modified datetime. Type: string (or Expression with resultType string). </param>
        /// <param name="modifiedDatetimeEnd"> The end of file's modified datetime. Type: string (or Expression with resultType string). </param>
        /// <param name="fileFilter"> Specify a filter to be used to select a subset of files in the folderPath rather than all files. Type: string (or Expression with resultType string). </param>
        internal FileServerReadSettings(string storeReadSettingsType, DataFactoryElement<int> maxConcurrentConnections, DataFactoryElement<bool> disableMetricsCollection, IDictionary<string, DataFactoryElement<string>> additionalProperties, DataFactoryElement<bool> recursive, DataFactoryElement<string> wildcardFolderPath, DataFactoryElement<string> wildcardFileName, DataFactoryElement<string> fileListPath, DataFactoryElement<bool> enablePartitionDiscovery, DataFactoryElement<string> partitionRootPath, DataFactoryElement<bool> deleteFilesAfterCompletion, DataFactoryElement<string> modifiedDatetimeStart, DataFactoryElement<string> modifiedDatetimeEnd, DataFactoryElement<string> fileFilter) : base(storeReadSettingsType, maxConcurrentConnections, disableMetricsCollection, additionalProperties)
        {
            Recursive = recursive;
            WildcardFolderPath = wildcardFolderPath;
            WildcardFileName = wildcardFileName;
            FileListPath = fileListPath;
            EnablePartitionDiscovery = enablePartitionDiscovery;
            PartitionRootPath = partitionRootPath;
            DeleteFilesAfterCompletion = deleteFilesAfterCompletion;
            ModifiedDatetimeStart = modifiedDatetimeStart;
            ModifiedDatetimeEnd = modifiedDatetimeEnd;
            FileFilter = fileFilter;
            StoreReadSettingsType = storeReadSettingsType ?? "FileServerReadSettings";
        }

        /// <summary> If true, files under the folder path will be read recursively. Default is true. Type: boolean (or Expression with resultType boolean). </summary>
        public DataFactoryElement<bool> Recursive { get; set; }
        /// <summary> FileServer wildcardFolderPath. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> WildcardFolderPath { get; set; }
        /// <summary> FileServer wildcardFileName. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> WildcardFileName { get; set; }
        /// <summary> Point to a text file that lists each file (relative path to the path configured in the dataset) that you want to copy. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> FileListPath { get; set; }
        /// <summary> Indicates whether to enable partition discovery. Type: boolean (or Expression with resultType boolean). </summary>
        public DataFactoryElement<bool> EnablePartitionDiscovery { get; set; }
        /// <summary> Specify the root path where partition discovery starts from. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> PartitionRootPath { get; set; }
        /// <summary> Indicates whether the source files need to be deleted after copy completion. Default is false. Type: boolean (or Expression with resultType boolean). </summary>
        public DataFactoryElement<bool> DeleteFilesAfterCompletion { get; set; }
        /// <summary> The start of file's modified datetime. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> ModifiedDatetimeStart { get; set; }
        /// <summary> The end of file's modified datetime. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> ModifiedDatetimeEnd { get; set; }
        /// <summary> Specify a filter to be used to select a subset of files in the folderPath rather than all files. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> FileFilter { get; set; }
    }
}