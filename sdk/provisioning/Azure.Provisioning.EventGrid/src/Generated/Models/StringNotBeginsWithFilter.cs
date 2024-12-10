// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.EventGrid;

/// <summary>
/// StringNotBeginsWith Filter.
/// </summary>
public partial class StringNotBeginsWithFilter : EventGridFilter
{
    /// <summary>
    /// The set of filter values.
    /// </summary>
    public BicepList<string> Values 
    {
        get { Initialize(); return _values!; }
        set { Initialize(); _values!.Assign(value); }
    }
    private BicepList<string>? _values;

    /// <summary>
    /// Creates a new StringNotBeginsWithFilter.
    /// </summary>
    public StringNotBeginsWithFilter() : base()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of StringNotBeginsWithFilter.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        DefineProperty<string>("operatorType", ["operatorType"], defaultValue: "StringNotBeginsWith");
        _values = DefineListProperty<string>("Values", ["values"]);
    }
}
