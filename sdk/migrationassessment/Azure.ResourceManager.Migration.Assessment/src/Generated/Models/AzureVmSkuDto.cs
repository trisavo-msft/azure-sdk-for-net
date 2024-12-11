// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Migration.Assessment.Models
{
    /// <summary> Azure Virtual Machine SKU. </summary>
    public partial class AzureVmSkuDto
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AzureVmSkuDto"/>. </summary>
        internal AzureVmSkuDto()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AzureVmSkuDto"/>. </summary>
        /// <param name="azureVmFamily"> Gets the Virtual Machine Family, for example : standardMSFamily. </param>
        /// <param name="cores"> Gets the Compute Size in vCores. </param>
        /// <param name="azureSkuName"> Gets the Virtual Machine SKU name,: E.g. : Standard_F16s. </param>
        /// <param name="availableCores">
        /// Gets the Available vCores. This can be less than the vCores in the Constrained
        /// vCPU VM Sizes.
        /// </param>
        /// <param name="maxNetworkInterfaces"> Gets the Max network interfaces. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AzureVmSkuDto(AzureVmFamily? azureVmFamily, int? cores, AzureVmSize? azureSkuName, int? availableCores, int? maxNetworkInterfaces, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AzureVmFamily = azureVmFamily;
            Cores = cores;
            AzureSkuName = azureSkuName;
            AvailableCores = availableCores;
            MaxNetworkInterfaces = maxNetworkInterfaces;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the Virtual Machine Family, for example : standardMSFamily. </summary>
        public AzureVmFamily? AzureVmFamily { get; }
        /// <summary> Gets the Compute Size in vCores. </summary>
        public int? Cores { get; }
        /// <summary> Gets the Virtual Machine SKU name,: E.g. : Standard_F16s. </summary>
        public AzureVmSize? AzureSkuName { get; }
        /// <summary>
        /// Gets the Available vCores. This can be less than the vCores in the Constrained
        /// vCPU VM Sizes.
        /// </summary>
        public int? AvailableCores { get; }
        /// <summary> Gets the Max network interfaces. </summary>
        public int? MaxNetworkInterfaces { get; }
    }
}
