// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.Terraform.Models;

namespace Azure.ResourceManager.Terraform
{
    internal class TerraformOperationStatusOperationSource : IOperationSource<TerraformOperationStatus>
    {
        TerraformOperationStatus IOperationSource<TerraformOperationStatus>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return TerraformOperationStatus.DeserializeTerraformOperationStatus(document.RootElement);
        }

        async ValueTask<TerraformOperationStatus> IOperationSource<TerraformOperationStatus>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return TerraformOperationStatus.DeserializeTerraformOperationStatus(document.RootElement);
        }
    }
}
