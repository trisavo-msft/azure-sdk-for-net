// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.ContainerService;

/// <summary>
/// AgentPoolSnapshot.
/// </summary>
public partial class AgentPoolSnapshot : ProvisionableResource
{
    /// <summary>
    /// The name of the managed cluster resource.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
        set { Initialize(); _name!.Assign(value); }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// Gets or sets the Location.
    /// </summary>
    public BicepValue<AzureLocation> Location 
    {
        get { Initialize(); return _location!; }
        set { Initialize(); _location!.Assign(value); }
    }
    private BicepValue<AzureLocation>? _location;

    /// <summary>
    /// This is the ARM ID of the source object to be used to create the target
    /// object.
    /// </summary>
    public BicepValue<ResourceIdentifier> CreationDataSourceResourceId 
    {
        get { Initialize(); return _creationDataSourceResourceId!; }
        set { Initialize(); _creationDataSourceResourceId!.Assign(value); }
    }
    private BicepValue<ResourceIdentifier>? _creationDataSourceResourceId;

    /// <summary>
    /// The type of a snapshot. The default is NodePool.
    /// </summary>
    public BicepValue<SnapshotType> SnapshotType 
    {
        get { Initialize(); return _snapshotType!; }
        set { Initialize(); _snapshotType!.Assign(value); }
    }
    private BicepValue<SnapshotType>? _snapshotType;

    /// <summary>
    /// Gets or sets the Tags.
    /// </summary>
    public BicepDictionary<string> Tags 
    {
        get { Initialize(); return _tags!; }
        set { Initialize(); _tags!.Assign(value); }
    }
    private BicepDictionary<string>? _tags;

    /// <summary>
    /// Whether to use a FIPS-enabled OS.
    /// </summary>
    public BicepValue<bool> EnableFips 
    {
        get { Initialize(); return _enableFips!; }
    }
    private BicepValue<bool>? _enableFips;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id 
    {
        get { Initialize(); return _id!; }
    }
    private BicepValue<ResourceIdentifier>? _id;

    /// <summary>
    /// The version of Kubernetes.
    /// </summary>
    public BicepValue<string> KubernetesVersion 
    {
        get { Initialize(); return _kubernetesVersion!; }
    }
    private BicepValue<string>? _kubernetesVersion;

    /// <summary>
    /// The version of node image.
    /// </summary>
    public BicepValue<string> NodeImageVersion 
    {
        get { Initialize(); return _nodeImageVersion!; }
    }
    private BicepValue<string>? _nodeImageVersion;

    /// <summary>
    /// Specifies the OS SKU used by the agent pool. The default is Ubuntu if
    /// OSType is Linux. The default is Windows2019 when Kubernetes &lt;= 1.24
    /// or Windows2022 when Kubernetes &gt;= 1.25 if OSType is Windows.
    /// </summary>
    public BicepValue<ContainerServiceOSSku> OSSku 
    {
        get { Initialize(); return _oSSku!; }
    }
    private BicepValue<ContainerServiceOSSku>? _oSSku;

    /// <summary>
    /// The operating system type. The default is Linux.
    /// </summary>
    public BicepValue<ContainerServiceOSType> OSType 
    {
        get { Initialize(); return _oSType!; }
    }
    private BicepValue<ContainerServiceOSType>? _oSType;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public SystemData SystemData 
    {
        get { Initialize(); return _systemData!; }
    }
    private SystemData? _systemData;

    /// <summary>
    /// The size of the VM.
    /// </summary>
    public BicepValue<string> VmSize 
    {
        get { Initialize(); return _vmSize!; }
    }
    private BicepValue<string>? _vmSize;

    /// <summary>
    /// Creates a new AgentPoolSnapshot.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the AgentPoolSnapshot resource.  This
    /// can be used to refer to the resource in expressions, but is not the
    /// Azure name of the resource.  This value can contain letters, numbers,
    /// and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the AgentPoolSnapshot.</param>
    public AgentPoolSnapshot(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.ContainerService/snapshots", resourceVersion ?? "2024-08-01")
    {
    }

    /// <summary>
    /// Define all the provisionable properties of AgentPoolSnapshot.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        _name = DefineProperty<string>("Name", ["name"], isRequired: true);
        _location = DefineProperty<AzureLocation>("Location", ["location"], isRequired: true);
        _creationDataSourceResourceId = DefineProperty<ResourceIdentifier>("CreationDataSourceResourceId", ["properties", "creationData", "sourceResourceId"]);
        _snapshotType = DefineProperty<SnapshotType>("SnapshotType", ["properties", "snapshotType"]);
        _tags = DefineDictionaryProperty<string>("Tags", ["tags"]);
        _enableFips = DefineProperty<bool>("EnableFips", ["properties", "enableFIPS"], isOutput: true);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _kubernetesVersion = DefineProperty<string>("KubernetesVersion", ["properties", "kubernetesVersion"], isOutput: true);
        _nodeImageVersion = DefineProperty<string>("NodeImageVersion", ["properties", "nodeImageVersion"], isOutput: true);
        _oSSku = DefineProperty<ContainerServiceOSSku>("OSSku", ["properties", "osSku"], isOutput: true);
        _oSType = DefineProperty<ContainerServiceOSType>("OSType", ["properties", "osType"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
        _vmSize = DefineProperty<string>("VmSize", ["properties", "vmSize"], isOutput: true);
    }

    /// <summary>
    /// Supported AgentPoolSnapshot resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-08-01.
        /// </summary>
        public static readonly string V2024_08_01 = "2024-08-01";

        /// <summary>
        /// 2024-07-01.
        /// </summary>
        public static readonly string V2024_07_01 = "2024-07-01";

        /// <summary>
        /// 2024-06-01.
        /// </summary>
        public static readonly string V2024_06_01 = "2024-06-01";

        /// <summary>
        /// 2024-05-01.
        /// </summary>
        public static readonly string V2024_05_01 = "2024-05-01";

        /// <summary>
        /// 2024-02-01.
        /// </summary>
        public static readonly string V2024_02_01 = "2024-02-01";

        /// <summary>
        /// 2024-01-01.
        /// </summary>
        public static readonly string V2024_01_01 = "2024-01-01";

        /// <summary>
        /// 2023-11-01.
        /// </summary>
        public static readonly string V2023_11_01 = "2023-11-01";

        /// <summary>
        /// 2023-10-01.
        /// </summary>
        public static readonly string V2023_10_01 = "2023-10-01";

        /// <summary>
        /// 2023-09-01.
        /// </summary>
        public static readonly string V2023_09_01 = "2023-09-01";

        /// <summary>
        /// 2023-08-01.
        /// </summary>
        public static readonly string V2023_08_01 = "2023-08-01";

        /// <summary>
        /// 2023-07-01.
        /// </summary>
        public static readonly string V2023_07_01 = "2023-07-01";

        /// <summary>
        /// 2023-06-01.
        /// </summary>
        public static readonly string V2023_06_01 = "2023-06-01";

        /// <summary>
        /// 2023-05-01.
        /// </summary>
        public static readonly string V2023_05_01 = "2023-05-01";

        /// <summary>
        /// 2023-04-01.
        /// </summary>
        public static readonly string V2023_04_01 = "2023-04-01";

        /// <summary>
        /// 2023-03-01.
        /// </summary>
        public static readonly string V2023_03_01 = "2023-03-01";

        /// <summary>
        /// 2023-02-01.
        /// </summary>
        public static readonly string V2023_02_01 = "2023-02-01";

        /// <summary>
        /// 2023-01-01.
        /// </summary>
        public static readonly string V2023_01_01 = "2023-01-01";

        /// <summary>
        /// 2022-11-01.
        /// </summary>
        public static readonly string V2022_11_01 = "2022-11-01";

        /// <summary>
        /// 2022-09-01.
        /// </summary>
        public static readonly string V2022_09_01 = "2022-09-01";

        /// <summary>
        /// 2022-08-01.
        /// </summary>
        public static readonly string V2022_08_01 = "2022-08-01";

        /// <summary>
        /// 2022-07-01.
        /// </summary>
        public static readonly string V2022_07_01 = "2022-07-01";

        /// <summary>
        /// 2022-06-01.
        /// </summary>
        public static readonly string V2022_06_01 = "2022-06-01";

        /// <summary>
        /// 2022-04-01.
        /// </summary>
        public static readonly string V2022_04_01 = "2022-04-01";

        /// <summary>
        /// 2022-03-01.
        /// </summary>
        public static readonly string V2022_03_01 = "2022-03-01";

        /// <summary>
        /// 2022-02-01.
        /// </summary>
        public static readonly string V2022_02_01 = "2022-02-01";

        /// <summary>
        /// 2022-01-01.
        /// </summary>
        public static readonly string V2022_01_01 = "2022-01-01";

        /// <summary>
        /// 2021-10-01.
        /// </summary>
        public static readonly string V2021_10_01 = "2021-10-01";

        /// <summary>
        /// 2021-09-01.
        /// </summary>
        public static readonly string V2021_09_01 = "2021-09-01";

        /// <summary>
        /// 2021-08-01.
        /// </summary>
        public static readonly string V2021_08_01 = "2021-08-01";
    }

    /// <summary>
    /// Creates a reference to an existing AgentPoolSnapshot.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the AgentPoolSnapshot resource.  This
    /// can be used to refer to the resource in expressions, but is not the
    /// Azure name of the resource.  This value can contain letters, numbers,
    /// and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the AgentPoolSnapshot.</param>
    /// <returns>The existing AgentPoolSnapshot resource.</returns>
    public static AgentPoolSnapshot FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
