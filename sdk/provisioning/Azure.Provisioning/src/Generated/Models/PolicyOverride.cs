// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Resources;

/// <summary>
/// The policy property value override.
/// </summary>
public partial class PolicyOverride : ProvisionableConstruct
{
    /// <summary>
    /// The override kind.
    /// </summary>
    public BicepValue<PolicyOverrideKind> Kind 
    {
        get { Initialize(); return _kind!; }
        set { Initialize(); _kind!.Assign(value); }
    }
    private BicepValue<PolicyOverrideKind>? _kind;

    /// <summary>
    /// The value to override the policy property.
    /// </summary>
    public BicepValue<string> Value 
    {
        get { Initialize(); return _value!; }
        set { Initialize(); _value!.Assign(value); }
    }
    private BicepValue<string>? _value;

    /// <summary>
    /// The list of the selector expressions.
    /// </summary>
    public BicepList<ResourceSelectorExpression> Selectors 
    {
        get { Initialize(); return _selectors!; }
        set { Initialize(); _selectors!.Assign(value); }
    }
    private BicepList<ResourceSelectorExpression>? _selectors;

    /// <summary>
    /// Creates a new PolicyOverride.
    /// </summary>
    public PolicyOverride()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of PolicyOverride.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _kind = DefineProperty<PolicyOverrideKind>("Kind", ["kind"]);
        _value = DefineProperty<string>("Value", ["value"]);
        _selectors = DefineListProperty<ResourceSelectorExpression>("Selectors", ["selectors"]);
    }
}
