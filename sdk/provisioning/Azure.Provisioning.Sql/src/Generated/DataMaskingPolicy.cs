// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.Sql;

/// <summary>
/// DataMaskingPolicy.
/// </summary>
public partial class DataMaskingPolicy : ProvisionableResource
{
    /// <summary>
    /// Gets the Name.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// The state of the data masking policy.
    /// </summary>
    public BicepValue<DataMaskingState> DataMaskingState 
    {
        get { Initialize(); return _dataMaskingState!; }
        set { Initialize(); _dataMaskingState!.Assign(value); }
    }
    private BicepValue<DataMaskingState>? _dataMaskingState;

    /// <summary>
    /// The list of the exempt principals. Specifies the semicolon-separated
    /// list of database users for which the data masking policy does not
    /// apply. The specified users receive data results without masking for
    /// all of the database queries.
    /// </summary>
    public BicepValue<string> ExemptPrincipals 
    {
        get { Initialize(); return _exemptPrincipals!; }
        set { Initialize(); _exemptPrincipals!.Assign(value); }
    }
    private BicepValue<string>? _exemptPrincipals;

    /// <summary>
    /// The list of the application principals. This is a legacy parameter and
    /// is no longer used.
    /// </summary>
    public BicepValue<string> ApplicationPrincipals 
    {
        get { Initialize(); return _applicationPrincipals!; }
    }
    private BicepValue<string>? _applicationPrincipals;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id 
    {
        get { Initialize(); return _id!; }
    }
    private BicepValue<ResourceIdentifier>? _id;

    /// <summary>
    /// The kind of data masking policy. Metadata, used for Azure portal.
    /// </summary>
    public BicepValue<string> Kind 
    {
        get { Initialize(); return _kind!; }
    }
    private BicepValue<string>? _kind;

    /// <summary>
    /// The location of the data masking policy.
    /// </summary>
    public BicepValue<AzureLocation> Location 
    {
        get { Initialize(); return _location!; }
    }
    private BicepValue<AzureLocation>? _location;

    /// <summary>
    /// The masking level. This is a legacy parameter and is no longer used.
    /// </summary>
    public BicepValue<string> MaskingLevel 
    {
        get { Initialize(); return _maskingLevel!; }
    }
    private BicepValue<string>? _maskingLevel;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public SystemData SystemData 
    {
        get { Initialize(); return _systemData!; }
    }
    private SystemData? _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent SqlDatabase.
    /// </summary>
    public SqlDatabase? Parent
    {
        get { Initialize(); return _parent!.Value; }
        set { Initialize(); _parent!.Value = value; }
    }
    private ResourceReference<SqlDatabase>? _parent;

    /// <summary>
    /// Creates a new DataMaskingPolicy.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the DataMaskingPolicy resource.  This
    /// can be used to refer to the resource in expressions, but is not the
    /// Azure name of the resource.  This value can contain letters, numbers,
    /// and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the DataMaskingPolicy.</param>
    public DataMaskingPolicy(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.Sql/servers/databases/dataMaskingPolicies", resourceVersion ?? "2021-11-01")
    {
    }

    /// <summary>
    /// Define all the provisionable properties of DataMaskingPolicy.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        _name = DefineProperty<string>("Name", ["name"], isOutput: true);
        _dataMaskingState = DefineProperty<DataMaskingState>("DataMaskingState", ["properties", "dataMaskingState"]);
        _exemptPrincipals = DefineProperty<string>("ExemptPrincipals", ["properties", "exemptPrincipals"]);
        _applicationPrincipals = DefineProperty<string>("ApplicationPrincipals", ["properties", "applicationPrincipals"], isOutput: true);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _kind = DefineProperty<string>("Kind", ["kind"], isOutput: true);
        _location = DefineProperty<AzureLocation>("Location", ["location"], isOutput: true);
        _maskingLevel = DefineProperty<string>("MaskingLevel", ["properties", "maskingLevel"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
        _parent = DefineResource<SqlDatabase>("Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported DataMaskingPolicy resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2021-11-01.
        /// </summary>
        public static readonly string V2021_11_01 = "2021-11-01";

        /// <summary>
        /// 2014-04-01.
        /// </summary>
        public static readonly string V2014_04_01 = "2014-04-01";

        /// <summary>
        /// 2014-01-01.
        /// </summary>
        public static readonly string V2014_01_01 = "2014-01-01";
    }

    /// <summary>
    /// Creates a reference to an existing DataMaskingPolicy.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the DataMaskingPolicy resource.  This
    /// can be used to refer to the resource in expressions, but is not the
    /// Azure name of the resource.  This value can contain letters, numbers,
    /// and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the DataMaskingPolicy.</param>
    /// <returns>The existing DataMaskingPolicy resource.</returns>
    public static DataMaskingPolicy FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
