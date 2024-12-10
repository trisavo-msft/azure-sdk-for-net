// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers
{
    internal class VirtualEndpointResourceOperationSource : IOperationSource<VirtualEndpointResource>
    {
        private readonly ArmClient _client;

        internal VirtualEndpointResourceOperationSource(ArmClient client)
        {
            _client = client;
        }

        VirtualEndpointResource IOperationSource<VirtualEndpointResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = VirtualEndpointResourceData.DeserializeVirtualEndpointResourceData(document.RootElement);
            return new VirtualEndpointResource(_client, data);
        }

        async ValueTask<VirtualEndpointResource> IOperationSource<VirtualEndpointResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = VirtualEndpointResourceData.DeserializeVirtualEndpointResourceData(document.RootElement);
            return new VirtualEndpointResource(_client, data);
        }
    }
}
