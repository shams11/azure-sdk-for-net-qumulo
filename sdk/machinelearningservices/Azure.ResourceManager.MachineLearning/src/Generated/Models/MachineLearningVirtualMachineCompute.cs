// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// A Machine Learning compute based on Azure Virtual Machines.
    /// Serialized Name: VirtualMachine
    /// </summary>
    public partial class MachineLearningVirtualMachineCompute : MachineLearningComputeProperties
    {
        /// <summary> Initializes a new instance of MachineLearningVirtualMachineCompute. </summary>
        public MachineLearningVirtualMachineCompute()
        {
            ComputeType = ComputeType.VirtualMachine;
        }

        /// <summary> Initializes a new instance of MachineLearningVirtualMachineCompute. </summary>
        /// <param name="computeType">
        /// The type of compute
        /// Serialized Name: Compute.computeType
        /// </param>
        /// <param name="computeLocation">
        /// Location for the underlying compute
        /// Serialized Name: Compute.computeLocation
        /// </param>
        /// <param name="provisioningState">
        /// The provision state of the cluster. Valid values are Unknown, Updating, Provisioning, Succeeded, and Failed.
        /// Serialized Name: Compute.provisioningState
        /// </param>
        /// <param name="description">
        /// The description of the Machine Learning compute.
        /// Serialized Name: Compute.description
        /// </param>
        /// <param name="createdOn">
        /// The time at which the compute was created.
        /// Serialized Name: Compute.createdOn
        /// </param>
        /// <param name="modifiedOn">
        /// The time at which the compute was last modified.
        /// Serialized Name: Compute.modifiedOn
        /// </param>
        /// <param name="resourceId">
        /// ARM resource id of the underlying compute
        /// Serialized Name: Compute.resourceId
        /// </param>
        /// <param name="provisioningErrors">
        /// Errors during provisioning
        /// Serialized Name: Compute.provisioningErrors
        /// </param>
        /// <param name="isAttachedCompute">
        /// Indicating whether the compute was provisioned by user and brought from outside if true, or machine learning service provisioned it if false.
        /// Serialized Name: Compute.isAttachedCompute
        /// </param>
        /// <param name="disableLocalAuth">
        /// Opt-out of local authentication and ensure customers can use only MSI and AAD exclusively for authentication.
        /// Serialized Name: Compute.disableLocalAuth
        /// </param>
        /// <param name="properties"> Serialized Name: VirtualMachineSchema.properties. </param>
        internal MachineLearningVirtualMachineCompute(ComputeType computeType, string computeLocation, MachineLearningProvisioningState? provisioningState, string description, DateTimeOffset? createdOn, DateTimeOffset? modifiedOn, ResourceIdentifier resourceId, IReadOnlyList<MachineLearningError> provisioningErrors, bool? isAttachedCompute, bool? disableLocalAuth, MachineLearningVirtualMachineProperties properties) : base(computeType, computeLocation, provisioningState, description, createdOn, modifiedOn, resourceId, provisioningErrors, isAttachedCompute, disableLocalAuth)
        {
            Properties = properties;
            ComputeType = computeType;
        }

        /// <summary> Serialized Name: VirtualMachineSchema.properties. </summary>
        public MachineLearningVirtualMachineProperties Properties { get; set; }
    }
}
