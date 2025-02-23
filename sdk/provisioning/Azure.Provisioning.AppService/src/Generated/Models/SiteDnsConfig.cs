// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.AppService;

/// <summary>
/// The SiteDnsConfig.
/// </summary>
public partial class SiteDnsConfig : ProvisionableConstruct
{
    /// <summary>
    /// List of custom DNS servers to be used by an app for lookups. Maximum 5
    /// dns servers can be set.
    /// </summary>
    public BicepList<string> DnsServers 
    {
        get { Initialize(); return _dnsServers!; }
        set { Initialize(); _dnsServers!.Assign(value); }
    }
    private BicepList<string>? _dnsServers;

    /// <summary>
    /// Alternate DNS server to be used by apps. This property replicates the
    /// WEBSITE_DNS_ALT_SERVER app setting.
    /// </summary>
    public BicepValue<string> DnsAltServer 
    {
        get { Initialize(); return _dnsAltServer!; }
        set { Initialize(); _dnsAltServer!.Assign(value); }
    }
    private BicepValue<string>? _dnsAltServer;

    /// <summary>
    /// Timeout for a single dns lookup in seconds. Allowed range: 1-30.
    /// Default is 3.
    /// </summary>
    public BicepValue<int> DnsRetryAttemptTimeout 
    {
        get { Initialize(); return _dnsRetryAttemptTimeout!; }
        set { Initialize(); _dnsRetryAttemptTimeout!.Assign(value); }
    }
    private BicepValue<int>? _dnsRetryAttemptTimeout;

    /// <summary>
    /// Total number of retries for dns lookup. Allowed range: 1-5. Default is
    /// 3.
    /// </summary>
    public BicepValue<int> DnsRetryAttemptCount 
    {
        get { Initialize(); return _dnsRetryAttemptCount!; }
        set { Initialize(); _dnsRetryAttemptCount!.Assign(value); }
    }
    private BicepValue<int>? _dnsRetryAttemptCount;

    /// <summary>
    /// Custom time for DNS to be cached in seconds. Allowed range: 0-60.
    /// Default is 30 seconds. 0 means caching disabled.
    /// </summary>
    public BicepValue<int> DnsMaxCacheTimeout 
    {
        get { Initialize(); return _dnsMaxCacheTimeout!; }
        set { Initialize(); _dnsMaxCacheTimeout!.Assign(value); }
    }
    private BicepValue<int>? _dnsMaxCacheTimeout;

    /// <summary>
    /// Indicates that sites using Virtual network custom DNS servers are still
    /// sorting the list of DNS servers. Read-Only.
    /// </summary>
    public BicepValue<bool> DnsLegacySortOrder 
    {
        get { Initialize(); return _dnsLegacySortOrder!; }
    }
    private BicepValue<bool>? _dnsLegacySortOrder;

    /// <summary>
    /// Creates a new SiteDnsConfig.
    /// </summary>
    public SiteDnsConfig()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of SiteDnsConfig.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _dnsServers = DefineListProperty<string>("DnsServers", ["dnsServers"]);
        _dnsAltServer = DefineProperty<string>("DnsAltServer", ["dnsAltServer"]);
        _dnsRetryAttemptTimeout = DefineProperty<int>("DnsRetryAttemptTimeout", ["dnsRetryAttemptTimeout"]);
        _dnsRetryAttemptCount = DefineProperty<int>("DnsRetryAttemptCount", ["dnsRetryAttemptCount"]);
        _dnsMaxCacheTimeout = DefineProperty<int>("DnsMaxCacheTimeout", ["dnsMaxCacheTimeout"]);
        _dnsLegacySortOrder = DefineProperty<bool>("DnsLegacySortOrder", ["dnsLegacySortOrder"], isOutput: true);
    }
}
