// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.RecoveryServices;
    using Microsoft.Azure.Management.RecoveryServices.SiteRecovery;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Recovery plan HVR Azure failback input.
    /// </summary>
    [Newtonsoft.Json.JsonObject("HyperVReplicaAzureFailback")]
    public partial class RecoveryPlanHyperVReplicaAzureFailbackInput : RecoveryPlanProviderSpecificFailoverInput
    {
        /// <summary>
        /// Initializes a new instance of the
        /// RecoveryPlanHyperVReplicaAzureFailbackInput class.
        /// </summary>
        public RecoveryPlanHyperVReplicaAzureFailbackInput()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// RecoveryPlanHyperVReplicaAzureFailbackInput class.
        /// </summary>
        /// <param name="dataSyncOption">The data sync option. Possible values
        /// include: 'ForDownTime', 'ForSynchronization'</param>
        /// <param name="recoveryVmCreationOption">The ALR option. Possible
        /// values include: 'CreateVmIfNotFound', 'NoAction'</param>
        public RecoveryPlanHyperVReplicaAzureFailbackInput(DataSyncStatus dataSyncOption, AlternateLocationRecoveryOption recoveryVmCreationOption)
        {
            DataSyncOption = dataSyncOption;
            RecoveryVmCreationOption = recoveryVmCreationOption;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the data sync option. Possible values include:
        /// 'ForDownTime', 'ForSynchronization'
        /// </summary>
        [JsonProperty(PropertyName = "dataSyncOption")]
        public DataSyncStatus DataSyncOption { get; set; }

        /// <summary>
        /// Gets or sets the ALR option. Possible values include:
        /// 'CreateVmIfNotFound', 'NoAction'
        /// </summary>
        [JsonProperty(PropertyName = "recoveryVmCreationOption")]
        public AlternateLocationRecoveryOption RecoveryVmCreationOption { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}