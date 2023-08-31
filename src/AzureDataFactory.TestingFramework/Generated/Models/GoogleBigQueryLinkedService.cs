// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> Google BigQuery service linked service. </summary>
    public partial class GoogleBigQueryLinkedService : DataFactoryLinkedServiceProperties
    {
        /// <summary> Initializes a new instance of GoogleBigQueryLinkedService. </summary>
        /// <param name="project"> The default BigQuery project to query against. Type: string (or Expression with resultType string). </param>
        /// <param name="authenticationType"> The OAuth 2.0 authentication mechanism used for authentication. ServiceAuthentication can only be used on self-hosted IR. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="project"/> is null. </exception>
        public GoogleBigQueryLinkedService(DataFactoryElement<string> project, GoogleBigQueryAuthenticationType authenticationType)
        {
            Argument.AssertNotNull(project, nameof(project));

            Project = project;
            AuthenticationType = authenticationType;
            LinkedServiceType = "GoogleBigQuery";
        }

        /// <summary> Initializes a new instance of GoogleBigQueryLinkedService. </summary>
        /// <param name="linkedServiceType"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="project"> The default BigQuery project to query against. Type: string (or Expression with resultType string). </param>
        /// <param name="additionalProjects"> A comma-separated list of public BigQuery projects to access. Type: string (or Expression with resultType string). </param>
        /// <param name="requestGoogleDriveScope"> Whether to request access to Google Drive. Allowing Google Drive access enables support for federated tables that combine BigQuery data with data from Google Drive. The default value is false. Type: string (or Expression with resultType string). </param>
        /// <param name="authenticationType"> The OAuth 2.0 authentication mechanism used for authentication. ServiceAuthentication can only be used on self-hosted IR. </param>
        /// <param name="refreshToken"> The refresh token obtained from Google for authorizing access to BigQuery for UserAuthentication. </param>
        /// <param name="clientId"> The client id of the google application used to acquire the refresh token. Type: string (or Expression with resultType string). </param>
        /// <param name="clientSecret"> The client secret of the google application used to acquire the refresh token. </param>
        /// <param name="email"> The service account email ID that is used for ServiceAuthentication and can only be used on self-hosted IR. Type: string (or Expression with resultType string). </param>
        /// <param name="keyFilePath"> The full path to the .p12 key file that is used to authenticate the service account email address and can only be used on self-hosted IR. Type: string (or Expression with resultType string). </param>
        /// <param name="trustedCertPath"> The full path of the .pem file containing trusted CA certificates for verifying the server when connecting over SSL. This property can only be set when using SSL on self-hosted IR. The default value is the cacerts.pem file installed with the IR. Type: string (or Expression with resultType string). </param>
        /// <param name="useSystemTrustStore"> Specifies whether to use a CA certificate from the system trust store or from a specified PEM file. The default value is false.Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </param>
        internal GoogleBigQueryLinkedService(string linkedServiceType, IntegrationRuntimeReference connectVia, string description, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, DataFactoryElement<string>> additionalProperties, DataFactoryElement<string> project, DataFactoryElement<string> additionalProjects, DataFactoryElement<string> requestGoogleDriveScope, GoogleBigQueryAuthenticationType authenticationType, DataFactorySecretBaseDefinition refreshToken, DataFactoryElement<string> clientId, DataFactorySecretBaseDefinition clientSecret, DataFactoryElement<string> email, DataFactoryElement<string> keyFilePath, DataFactoryElement<string> trustedCertPath, DataFactoryElement<bool> useSystemTrustStore, string encryptedCredential) : base(linkedServiceType, connectVia, description, parameters, annotations, additionalProperties)
        {
            Project = project;
            AdditionalProjects = additionalProjects;
            RequestGoogleDriveScope = requestGoogleDriveScope;
            AuthenticationType = authenticationType;
            RefreshToken = refreshToken;
            ClientId = clientId;
            ClientSecret = clientSecret;
            Email = email;
            KeyFilePath = keyFilePath;
            TrustedCertPath = trustedCertPath;
            UseSystemTrustStore = useSystemTrustStore;
            EncryptedCredential = encryptedCredential;
            LinkedServiceType = linkedServiceType ?? "GoogleBigQuery";
        }

        /// <summary> The default BigQuery project to query against. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Project { get; set; }
        /// <summary> A comma-separated list of public BigQuery projects to access. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> AdditionalProjects { get; set; }
        /// <summary> Whether to request access to Google Drive. Allowing Google Drive access enables support for federated tables that combine BigQuery data with data from Google Drive. The default value is false. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> RequestGoogleDriveScope { get; set; }
        /// <summary> The OAuth 2.0 authentication mechanism used for authentication. ServiceAuthentication can only be used on self-hosted IR. </summary>
        public GoogleBigQueryAuthenticationType AuthenticationType { get; set; }
        /// <summary> The refresh token obtained from Google for authorizing access to BigQuery for UserAuthentication. </summary>
        public DataFactorySecretBaseDefinition RefreshToken { get; set; }
        /// <summary> The client id of the google application used to acquire the refresh token. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> ClientId { get; set; }
        /// <summary> The client secret of the google application used to acquire the refresh token. </summary>
        public DataFactorySecretBaseDefinition ClientSecret { get; set; }
        /// <summary> The service account email ID that is used for ServiceAuthentication and can only be used on self-hosted IR. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Email { get; set; }
        /// <summary> The full path to the .p12 key file that is used to authenticate the service account email address and can only be used on self-hosted IR. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> KeyFilePath { get; set; }
        /// <summary> The full path of the .pem file containing trusted CA certificates for verifying the server when connecting over SSL. This property can only be set when using SSL on self-hosted IR. The default value is the cacerts.pem file installed with the IR. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> TrustedCertPath { get; set; }
        /// <summary> Specifies whether to use a CA certificate from the system trust store or from a specified PEM file. The default value is false.Type: boolean (or Expression with resultType boolean). </summary>
        public DataFactoryElement<bool> UseSystemTrustStore { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </summary>
        public string EncryptedCredential { get; set; }
    }
}