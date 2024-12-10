// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.ContainerRegistry;

/// <summary>
/// The ContainerRegistryKeyVaultProperties.
/// </summary>
public partial class ContainerRegistryKeyVaultProperties : ProvisionableConstruct
{
    /// <summary>
    /// Key vault uri to access the encryption key.
    /// </summary>
    public BicepValue<string> KeyIdentifier 
    {
        get { Initialize(); return _keyIdentifier!; }
        set { Initialize(); _keyIdentifier!.Assign(value); }
    }
    private BicepValue<string>? _keyIdentifier;

    /// <summary>
    /// The fully qualified key identifier that includes the version of the key
    /// that is actually used for encryption.
    /// </summary>
    public BicepValue<string> VersionedKeyIdentifier 
    {
        get { Initialize(); return _versionedKeyIdentifier!; }
    }
    private BicepValue<string>? _versionedKeyIdentifier;

    /// <summary>
    /// The client id of the identity which will be used to access key vault.
    /// </summary>
    public BicepValue<string> Identity 
    {
        get { Initialize(); return _identity!; }
        set { Initialize(); _identity!.Assign(value); }
    }
    private BicepValue<string>? _identity;

    /// <summary>
    /// Auto key rotation status for a CMK enabled registry.
    /// </summary>
    public BicepValue<bool> IsKeyRotationEnabled 
    {
        get { Initialize(); return _isKeyRotationEnabled!; }
    }
    private BicepValue<bool>? _isKeyRotationEnabled;

    /// <summary>
    /// Timestamp of the last successful key rotation.
    /// </summary>
    public BicepValue<DateTimeOffset> LastKeyRotationTimestamp 
    {
        get { Initialize(); return _lastKeyRotationTimestamp!; }
    }
    private BicepValue<DateTimeOffset>? _lastKeyRotationTimestamp;

    /// <summary>
    /// Creates a new ContainerRegistryKeyVaultProperties.
    /// </summary>
    public ContainerRegistryKeyVaultProperties()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// ContainerRegistryKeyVaultProperties.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _keyIdentifier = DefineProperty<string>("KeyIdentifier", ["keyIdentifier"]);
        _versionedKeyIdentifier = DefineProperty<string>("VersionedKeyIdentifier", ["versionedKeyIdentifier"], isOutput: true);
        _identity = DefineProperty<string>("Identity", ["identity"]);
        _isKeyRotationEnabled = DefineProperty<bool>("IsKeyRotationEnabled", ["keyRotationEnabled"], isOutput: true);
        _lastKeyRotationTimestamp = DefineProperty<DateTimeOffset>("LastKeyRotationTimestamp", ["lastKeyRotationTimestamp"], isOutput: true);
    }
}
