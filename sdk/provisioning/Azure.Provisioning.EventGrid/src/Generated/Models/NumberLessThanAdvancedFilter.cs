// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.EventGrid;

/// <summary>
/// NumberLessThan Advanced Filter.
/// </summary>
public partial class NumberLessThanAdvancedFilter : AdvancedFilter
{
    /// <summary>
    /// The filter value.
    /// </summary>
    public BicepValue<double> Value 
    {
        get { Initialize(); return _value!; }
        set { Initialize(); _value!.Assign(value); }
    }
    private BicepValue<double>? _value;

    /// <summary>
    /// Creates a new NumberLessThanAdvancedFilter.
    /// </summary>
    public NumberLessThanAdvancedFilter() : base()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of NumberLessThanAdvancedFilter.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        DefineProperty<string>("operatorType", ["operatorType"], defaultValue: "NumberLessThan");
        _value = DefineProperty<double>("Value", ["value"]);
    }
}
