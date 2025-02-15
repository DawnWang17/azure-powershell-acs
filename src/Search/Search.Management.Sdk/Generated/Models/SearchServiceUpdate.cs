// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Search.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The parameters used to update an Azure Cognitive Search service.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class SearchServiceUpdate : Resource
    {
        /// <summary>
        /// Initializes a new instance of the SearchServiceUpdate class.
        /// </summary>
        public SearchServiceUpdate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SearchServiceUpdate class.
        /// </summary>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="replicaCount">The number of replicas in the search
        /// service. If specified, it must be a value between 1 and 12
        /// inclusive for standard SKUs or between 1 and 3 inclusive for basic
        /// SKU.</param>
        /// <param name="partitionCount">The number of partitions in the search
        /// service; if specified, it can be 1, 2, 3, 4, 6, or 12. Values
        /// greater than 1 are only valid for standard SKUs. For 'standard3'
        /// services with hostingMode set to 'highDensity', the allowed values
        /// are between 1 and 3.</param>
        /// <param name="hostingMode">Applicable only for the standard3 SKU.
        /// You can set this property to enable up to 3 high density partitions
        /// that allow up to 1000 indexes, which is much higher than the
        /// maximum indexes allowed for any other SKU. For the standard3 SKU,
        /// the value is either 'default' or 'highDensity'. For all other SKUs,
        /// this value must be 'default'. Possible values include: 'Default',
        /// 'HighDensity'</param>
        /// <param name="publicNetworkAccess">This value can be set to
        /// 'enabled' to avoid breaking changes on existing customer resources
        /// and templates. If set to 'disabled', traffic over public interface
        /// is not allowed, and private endpoint connections would be the
        /// exclusive access method. Possible values include: 'enabled',
        /// 'disabled'</param>
        /// <param name="status">The status of the search service. Possible
        /// values include: 'running': The search service is running and no
        /// provisioning operations are underway. 'provisioning': The search
        /// service is being provisioned or scaled up or down. 'deleting': The
        /// search service is being deleted. 'degraded': The search service is
        /// degraded. This can occur when the underlying search units are not
        /// healthy. The search service is most likely operational, but
        /// performance might be slow and some requests might be dropped.
        /// 'disabled': The search service is disabled. In this state, the
        /// service will reject all API requests. 'error': The search service
        /// is in an error state. If your service is in the degraded, disabled,
        /// or error states, it means the Azure Cognitive Search team is
        /// actively investigating the underlying issue. Dedicated services in
        /// these states are still chargeable based on the number of search
        /// units provisioned. Possible values include: 'Running',
        /// 'Provisioning', 'Deleting', 'Degraded', 'Disabled', 'Error',
        /// 'Stopped'</param>
        /// <param name="statusDetails">The details of the search service
        /// status.</param>
        /// <param name="provisioningState">The state of the last provisioning
        /// operation performed on the search service. Provisioning is an
        /// intermediate state that occurs while service capacity is being
        /// established. After capacity is set up, provisioningState changes to
        /// either 'succeeded' or 'failed'. Client applications can poll
        /// provisioning status (the recommended polling interval is from 30
        /// seconds to one minute) by using the Get Search Service operation to
        /// see when an operation is completed. If you are using the free
        /// service, this value tends to come back as 'succeeded' directly in
        /// the call to Create search service. This is because the free service
        /// uses capacity that is already set up. Possible values include:
        /// 'Succeeded', 'Provisioning', 'Failed'</param>
        /// <param name="networkRuleSet">Network specific rules that determine
        /// how the Azure Cognitive Search service may be reached.</param>
        /// <param name="encryptionWithCmk">Specifies any policy regarding
        /// encryption of resources (such as indexes) using customer manager
        /// keys within a search service.</param>
        /// <param name="disableLocalAuth">When set to true, calls to the
        /// search service will not be permitted to utilize API keys for
        /// authentication. This cannot be set to true if
        /// 'dataPlaneAuthOptions' are defined.</param>
        /// <param name="authOptions">Defines the options for how the data
        /// plane API of a search service authenticates requests. This cannot
        /// be set if 'disableLocalAuth' is set to true.</param>
        /// <param name="privateEndpointConnections">The list of private
        /// endpoint connections to the Azure Cognitive Search service.</param>
        /// <param name="sharedPrivateLinkResources">The list of shared private
        /// link resources managed by the Azure Cognitive Search
        /// service.</param>
        /// <param name="sku">The SKU of the Search Service, which determines
        /// price tier and capacity limits. This property is required when
        /// creating a new Search Service.</param>
        /// <param name="location">The geographic location of the resource.
        /// This must be one of the supported and registered Azure Geo Regions
        /// (for example, West US, East US, Southeast Asia, and so forth). This
        /// property is required when creating a new resource.</param>
        /// <param name="tags">Tags to help categorize the resource in the
        /// Azure portal.</param>
        /// <param name="identity">The identity of the resource.</param>
        public SearchServiceUpdate(string id = default(string), string name = default(string), string type = default(string), int? replicaCount = default(int?), int? partitionCount = default(int?), HostingMode? hostingMode = default(HostingMode?), PublicNetworkAccess? publicNetworkAccess = default(PublicNetworkAccess?), SearchServiceStatus? status = default(SearchServiceStatus?), string statusDetails = default(string), ProvisioningState? provisioningState = default(ProvisioningState?), NetworkRuleSet networkRuleSet = default(NetworkRuleSet), EncryptionWithCmk encryptionWithCmk = default(EncryptionWithCmk), bool? disableLocalAuth = default(bool?), DataPlaneAuthOptions authOptions = default(DataPlaneAuthOptions), IList<PrivateEndpointConnection> privateEndpointConnections = default(IList<PrivateEndpointConnection>), IList<SharedPrivateLinkResource> sharedPrivateLinkResources = default(IList<SharedPrivateLinkResource>), Sku sku = default(Sku), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), Identity identity = default(Identity))
            : base(id, name, type)
        {
            ReplicaCount = replicaCount;
            PartitionCount = partitionCount;
            HostingMode = hostingMode;
            PublicNetworkAccess = publicNetworkAccess;
            Status = status;
            StatusDetails = statusDetails;
            ProvisioningState = provisioningState;
            NetworkRuleSet = networkRuleSet;
            EncryptionWithCmk = encryptionWithCmk;
            DisableLocalAuth = disableLocalAuth;
            AuthOptions = authOptions;
            PrivateEndpointConnections = privateEndpointConnections;
            SharedPrivateLinkResources = sharedPrivateLinkResources;
            Sku = sku;
            Location = location;
            Tags = tags;
            Identity = identity;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the number of replicas in the search service. If
        /// specified, it must be a value between 1 and 12 inclusive for
        /// standard SKUs or between 1 and 3 inclusive for basic SKU.
        /// </summary>
        [JsonProperty(PropertyName = "properties.replicaCount")]
        public int? ReplicaCount { get; set; }

        /// <summary>
        /// Gets or sets the number of partitions in the search service; if
        /// specified, it can be 1, 2, 3, 4, 6, or 12. Values greater than 1
        /// are only valid for standard SKUs. For 'standard3' services with
        /// hostingMode set to 'highDensity', the allowed values are between 1
        /// and 3.
        /// </summary>
        [JsonProperty(PropertyName = "properties.partitionCount")]
        public int? PartitionCount { get; set; }

        /// <summary>
        /// Gets or sets applicable only for the standard3 SKU. You can set
        /// this property to enable up to 3 high density partitions that allow
        /// up to 1000 indexes, which is much higher than the maximum indexes
        /// allowed for any other SKU. For the standard3 SKU, the value is
        /// either 'default' or 'highDensity'. For all other SKUs, this value
        /// must be 'default'. Possible values include: 'Default',
        /// 'HighDensity'
        /// </summary>
        [JsonProperty(PropertyName = "properties.hostingMode")]
        public HostingMode? HostingMode { get; set; }

        /// <summary>
        /// Gets or sets this value can be set to 'enabled' to avoid breaking
        /// changes on existing customer resources and templates. If set to
        /// 'disabled', traffic over public interface is not allowed, and
        /// private endpoint connections would be the exclusive access method.
        /// Possible values include: 'enabled', 'disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicNetworkAccess")]
        public PublicNetworkAccess? PublicNetworkAccess { get; set; }

        /// <summary>
        /// Gets the status of the search service. Possible values include:
        /// 'running': The search service is running and no provisioning
        /// operations are underway. 'provisioning': The search service is
        /// being provisioned or scaled up or down. 'deleting': The search
        /// service is being deleted. 'degraded': The search service is
        /// degraded. This can occur when the underlying search units are not
        /// healthy. The search service is most likely operational, but
        /// performance might be slow and some requests might be dropped.
        /// 'disabled': The search service is disabled. In this state, the
        /// service will reject all API requests. 'error': The search service
        /// is in an error state. If your service is in the degraded, disabled,
        /// or error states, it means the Azure Cognitive Search team is
        /// actively investigating the underlying issue. Dedicated services in
        /// these states are still chargeable based on the number of search
        /// units provisioned. Possible values include: 'Running',
        /// 'Provisioning', 'Deleting', 'Degraded', 'Disabled', 'Error',
        /// 'Stopped'
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public SearchServiceStatus? Status { get; private set; }

        /// <summary>
        /// Gets the details of the search service status.
        /// </summary>
        [JsonProperty(PropertyName = "properties.statusDetails")]
        public string StatusDetails { get; private set; }

        /// <summary>
        /// Gets the state of the last provisioning operation performed on the
        /// search service. Provisioning is an intermediate state that occurs
        /// while service capacity is being established. After capacity is set
        /// up, provisioningState changes to either 'succeeded' or 'failed'.
        /// Client applications can poll provisioning status (the recommended
        /// polling interval is from 30 seconds to one minute) by using the Get
        /// Search Service operation to see when an operation is completed. If
        /// you are using the free service, this value tends to come back as
        /// 'succeeded' directly in the call to Create search service. This is
        /// because the free service uses capacity that is already set up.
        /// Possible values include: 'Succeeded', 'Provisioning', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public ProvisioningState? ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets network specific rules that determine how the Azure
        /// Cognitive Search service may be reached.
        /// </summary>
        [JsonProperty(PropertyName = "properties.networkRuleSet")]
        public NetworkRuleSet NetworkRuleSet { get; set; }

        /// <summary>
        /// Gets or sets specifies any policy regarding encryption of resources
        /// (such as indexes) using customer manager keys within a search
        /// service.
        /// </summary>
        [JsonProperty(PropertyName = "properties.encryptionWithCmk")]
        public EncryptionWithCmk EncryptionWithCmk { get; set; }

        /// <summary>
        /// Gets or sets when set to true, calls to the search service will not
        /// be permitted to utilize API keys for authentication. This cannot be
        /// set to true if 'dataPlaneAuthOptions' are defined.
        /// </summary>
        [JsonProperty(PropertyName = "properties.disableLocalAuth")]
        public bool? DisableLocalAuth { get; set; }

        /// <summary>
        /// Gets or sets defines the options for how the data plane API of a
        /// search service authenticates requests. This cannot be set if
        /// 'disableLocalAuth' is set to true.
        /// </summary>
        [JsonProperty(PropertyName = "properties.authOptions")]
        public DataPlaneAuthOptions AuthOptions { get; set; }

        /// <summary>
        /// Gets the list of private endpoint connections to the Azure
        /// Cognitive Search service.
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateEndpointConnections")]
        public IList<PrivateEndpointConnection> PrivateEndpointConnections { get; private set; }

        /// <summary>
        /// Gets the list of shared private link resources managed by the Azure
        /// Cognitive Search service.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sharedPrivateLinkResources")]
        public IList<SharedPrivateLinkResource> SharedPrivateLinkResources { get; private set; }

        /// <summary>
        /// Gets or sets the SKU of the Search Service, which determines price
        /// tier and capacity limits. This property is required when creating a
        /// new Search Service.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// Gets or sets the geographic location of the resource. This must be
        /// one of the supported and registered Azure Geo Regions (for example,
        /// West US, East US, Southeast Asia, and so forth). This property is
        /// required when creating a new resource.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets tags to help categorize the resource in the Azure
        /// portal.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets the identity of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public Identity Identity { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ReplicaCount != null)
            {
                if (ReplicaCount > 12)
                {
                    throw new ValidationException(ValidationRules.InclusiveMaximum, "ReplicaCount", 12);
                }
                if (ReplicaCount < 1)
                {
                    throw new ValidationException(ValidationRules.InclusiveMinimum, "ReplicaCount", 1);
                }
            }
            if (PartitionCount != null)
            {
                if (PartitionCount > 12)
                {
                    throw new ValidationException(ValidationRules.InclusiveMaximum, "PartitionCount", 12);
                }
                if (PartitionCount < 1)
                {
                    throw new ValidationException(ValidationRules.InclusiveMinimum, "PartitionCount", 1);
                }
            }
            if (Identity != null)
            {
                Identity.Validate();
            }
        }
    }
}
