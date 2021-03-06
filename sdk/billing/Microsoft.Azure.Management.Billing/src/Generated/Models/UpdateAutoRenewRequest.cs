// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Billing.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Request parameters to update auto renew for support product.
    /// </summary>
    public partial class UpdateAutoRenewRequest
    {
        /// <summary>
        /// Initializes a new instance of the UpdateAutoRenewRequest class.
        /// </summary>
        public UpdateAutoRenewRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UpdateAutoRenewRequest class.
        /// </summary>
        /// <param name="autoRenew">Request parameters to update auto renew
        /// policy a product. Possible values include: 'true', 'false'</param>
        public UpdateAutoRenewRequest(string autoRenew = default(string))
        {
            AutoRenew = autoRenew;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets request parameters to update auto renew policy a
        /// product. Possible values include: 'true', 'false'
        /// </summary>
        [JsonProperty(PropertyName = "autoRenew")]
        public string AutoRenew { get; set; }

    }
}
