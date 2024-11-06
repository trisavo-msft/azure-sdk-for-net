using System;
using Azure.Core;
using Azure.Core.TestFramework;
using Azure.ResourceManager.NetworkCloud.Models;
using Azure.ResourceManager.Resources;
using NUnit.Framework;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Azure.ResourceManager.NetworkCloud.Tests.ScenarioTests
{
    public class NetworkCloudClustersTests : NetworkCloudManagementTestBase
    {
        public NetworkCloudClustersTests(bool isAsync, RecordedTestMode mode) : base(isAsync, mode) {}
        public NetworkCloudClustersTests(bool isAsync) : base(isAsync) {}

        [Test]
        [RecordedTest]
        public async Task NetworkCloudClusters()
        {
            var clusterName = Recording.GenerateAssetName("cluster");
            NetworkCloudClusterCollection clusterCollection = ResourceGroupResource.GetNetworkCloudClusters();

            // Create
            var createCreds = new AdministrativeCredentials("password","username", null);
            NetworkCloudClusterData data = new NetworkCloudClusterData
            (
                new AzureLocation(TestEnvironment.Location),
                new ExtendedLocation(TestEnvironment.ManagerExtendedLocation, "CustomLocation"),
                new NetworkCloudRackDefinition(new ResourceIdentifier(TestEnvironment.SubnetId), "aa1234", new ResourceIdentifier("/subscriptions/a3eeb848-665a-4dbf-80a4-eb460930fb23/providers/Microsoft.NetworkCloud/rackSkus/VLab1_4_Aggregator_sim"))
                {
                    RackLocation = "Foo Datacenter, Floor 3, Aisle 9, Rack 2",
                    AvailabilityZone = "A"
                },
                ClusterType.MultiRack,
                TestEnvironment.ClusterVersion,
                new ResourceIdentifier(TestEnvironment.SubnetId)
            )
            {
                AnalyticsWorkspaceId = new ResourceIdentifier(TestEnvironment.LawId),
                ClusterServicePrincipal = new ServicePrincipalInformation("12345678-1234-1234-1234-123456789012", "00000008-0004-0004-0004-000000000012", "80000000-4000-4000-4000-120000000000"){
                    Password = "password"
                },
                ComputeDeploymentThreshold = new ValidationThreshold(ValidationThresholdGrouping.PerCluster, ValidationThresholdType.PercentSuccess, 90),
                ComputeRackDefinitions =
                {
                 new NetworkCloudRackDefinition(new ResourceIdentifier(TestEnvironment.SubnetId), "b37m15r1", new ResourceIdentifier("/subscriptions/fca2e8ee-1179-48b8-9532-428ed0873a2e/providers/Microsoft.NetworkCloud/rackSkus/VLab1_4_Compute_DellR750_2C2M_sim"))
                    {
                        BareMetalMachineConfigurationData =
                        {
                            new BareMetalMachineConfiguration(createCreds,"AA:BB:CC:DD:EE:FF","00:BB:CC:DD:EE:FF",1,"BM1219XXX")
                            {
                                MachineDetails = "extraDetails",
                                MachineName = "compute1",
                            },
                            new BareMetalMachineConfiguration(createCreds,"AA:BB:CC:DD:EE:00","00:BB:CC:DD:EE:00",2,"BM1219YYY")
                            {
                                MachineDetails = "extraDetails",
                                MachineName = "compute2",
                            },
                            new BareMetalMachineConfiguration(createCreds,"AA:BB:CC:DD:EE:01","00:BB:CC:DD:EE:01",3,"BM1219YY1")
                            {
                                MachineDetails = "extraDetails",
                                MachineName = "control1",
                            },
                            new BareMetalMachineConfiguration(createCreds,"AA:BB:CC:DD:EE:F1","00:BB:CC:DD:EE:F1",4,"BM1219XX1")
                            {
                                MachineDetails = "extraDetails",
                                MachineName = "control2",
                            },
                        },
                    },
                },
                Tags =
                {
                    ["key1"] = "myvalue1",
                },
            };
            var createResult = await clusterCollection.CreateOrUpdateAsync(WaitUntil.Completed, clusterName, data);
            Assert.AreEqual(clusterName, createResult.Value.Data.Name);

            // Get
            var getResult = await clusterCollection.GetAsync(clusterName);
            Assert.AreEqual(clusterName, getResult.Value.Data.Name);
            NetworkCloudClusterResource clusterResource = Client.GetNetworkCloudClusterResource(getResult.Value.Data.Id);

            // Update cluster location
            NetworkCloudClusterPatch patch = new NetworkCloudClusterPatch()
            {
                ClusterLocation = "Foo floor",
                Tags =
                {
                    ["key1"] = "myvalue1",
                    ["key2"] = "myvalue2",
                },
            };
            var patchResult = await clusterResource.UpdateAsync(WaitUntil.Completed, patch);
            Assert.AreEqual(patch.Tags, patchResult.Value.Data.Tags);
            Assert.AreEqual("Foo floor", patchResult.Value.Data.ClusterLocation);

            // List by Resource Group
            var listByResourceGroup = new List<NetworkCloudClusterResource>();
            await foreach (NetworkCloudClusterResource item in clusterCollection.GetAllAsync())
            {
                listByResourceGroup.Add(item);
            }
            Assert.IsNotEmpty(listByResourceGroup);

            // List by Subscription
            var listBySubscription = new List<NetworkCloudClusterResource>();
            await foreach (NetworkCloudClusterResource item in SubscriptionResource.GetNetworkCloudClustersAsync())
            {
                listBySubscription.Add(item);
            }
            Assert.IsNotEmpty(listBySubscription);

            // Patch Upgrade Strategy
             NetworkCloudClusterPatch patch2 = new NetworkCloudClusterPatch()
            {
                Tags =
                {
                    ["key1"] = "myvalue1",
                    ["key2"] = "myvalue2",
                },
                UpdateStrategy = new ClusterUpdateStrategy(ClusterUpdateStrategyType.PauseAfterRack, ValidationThresholdType.PercentSuccess, 100)
                {
                    MaxUnavailable = 2,
                    WaitTimeMinutes = 0,
                },
            };
            var strategyResult = await clusterResource.UpdateAsync(WaitUntil.Completed, patch2);
            Assert.AreEqual(patch2.Tags, strategyResult.Value.Data.Tags);

            // Cluster Update Version
            try
            {
                ClusterUpdateVersionContent update = new ClusterUpdateVersionContent("3.15.0");
                var updatedClusterResult = await clusterResource.UpdateVersionAsync(WaitUntil.Completed, update);
            }
            catch (Exception ex)
            {
                StringAssert.Contains("cluster conditions do not pass validation", ex.Message);
            }

            // Continue Update Version
            try
            {
                ClusterContinueUpdateVersionContent continueUpdate = new ClusterContinueUpdateVersionContent()
                {
                    MachineGroupTargetingMode = ClusterContinueUpdateVersionMachineGroupTargetingMode.AlphaByRack,
                };
                var continueUpdateClusterResult = await clusterResource.ContinueUpdateVersionAsync(WaitUntil.Completed, continueUpdate);
            }
            // catch (RequestFailedException ex)
            // {
            //     var response = ex.GetRawResponse();
            //     Assert.Fail($"Response: {response.Content.ToString()}");
            // }
            catch (RequestFailedException ex)
            {
                if (ex.InnerException != null)
                {
                    Console.WriteLine($"Inner Exception: {ex.InnerException.Message}");
                }
                Assert.Fail($"Response: {ex.InnerException.Message}");
            }

            // Delete
            var deleteResult = await clusterResource.DeleteAsync(WaitUntil.Completed);
            Assert.IsTrue(deleteResult.HasCompleted);
        }
    }
}

