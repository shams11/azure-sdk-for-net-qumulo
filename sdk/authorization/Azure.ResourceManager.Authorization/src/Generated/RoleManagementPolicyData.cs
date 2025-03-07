// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Authorization.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Authorization
{
    /// <summary> A class representing the RoleManagementPolicy data model. </summary>
    public partial class RoleManagementPolicyData : ResourceData
    {
        /// <summary> Initializes a new instance of RoleManagementPolicyData. </summary>
        public RoleManagementPolicyData()
        {
            Rules = new ChangeTrackingList<RoleManagementPolicyRule>();
            EffectiveRules = new ChangeTrackingList<RoleManagementPolicyRule>();
        }

        /// <summary> Initializes a new instance of RoleManagementPolicyData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="scope"> The role management policy scope. </param>
        /// <param name="displayName"> The role management policy display name. </param>
        /// <param name="description"> The role management policy description. </param>
        /// <param name="isOrganizationDefault"> The role management policy is default policy. </param>
        /// <param name="lastModifiedBy"> The name of the entity last modified it. </param>
        /// <param name="lastModifiedOn"> The last modified date time. </param>
        /// <param name="rules">
        /// The rule applied to the policy.
        /// Please note <see cref="RoleManagementPolicyRule"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="RoleManagementPolicyApprovalRule"/>, <see cref="RoleManagementPolicyAuthenticationContextRule"/>, <see cref="RoleManagementPolicyEnablementRule"/>, <see cref="RoleManagementPolicyExpirationRule"/> and <see cref="RoleManagementPolicyNotificationRule"/>.
        /// </param>
        /// <param name="effectiveRules">
        /// The readonly computed rule applied to the policy.
        /// Please note <see cref="RoleManagementPolicyRule"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="RoleManagementPolicyApprovalRule"/>, <see cref="RoleManagementPolicyAuthenticationContextRule"/>, <see cref="RoleManagementPolicyEnablementRule"/>, <see cref="RoleManagementPolicyExpirationRule"/> and <see cref="RoleManagementPolicyNotificationRule"/>.
        /// </param>
        /// <param name="policyProperties"> Additional properties of scope. </param>
        internal RoleManagementPolicyData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string scope, string displayName, string description, bool? isOrganizationDefault, RoleManagementPrincipal lastModifiedBy, DateTimeOffset? lastModifiedOn, IList<RoleManagementPolicyRule> rules, IReadOnlyList<RoleManagementPolicyRule> effectiveRules, RoleManagementPolicyProperties policyProperties) : base(id, name, resourceType, systemData)
        {
            Scope = scope;
            DisplayName = displayName;
            Description = description;
            IsOrganizationDefault = isOrganizationDefault;
            LastModifiedBy = lastModifiedBy;
            LastModifiedOn = lastModifiedOn;
            Rules = rules;
            EffectiveRules = effectiveRules;
            PolicyProperties = policyProperties;
        }

        /// <summary> The role management policy scope. </summary>
        public string Scope { get; set; }
        /// <summary> The role management policy display name. </summary>
        public string DisplayName { get; set; }
        /// <summary> The role management policy description. </summary>
        public string Description { get; set; }
        /// <summary> The role management policy is default policy. </summary>
        public bool? IsOrganizationDefault { get; set; }
        /// <summary> The name of the entity last modified it. </summary>
        public RoleManagementPrincipal LastModifiedBy { get; }
        /// <summary> The last modified date time. </summary>
        public DateTimeOffset? LastModifiedOn { get; }
        /// <summary>
        /// The rule applied to the policy.
        /// Please note <see cref="RoleManagementPolicyRule"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="RoleManagementPolicyApprovalRule"/>, <see cref="RoleManagementPolicyAuthenticationContextRule"/>, <see cref="RoleManagementPolicyEnablementRule"/>, <see cref="RoleManagementPolicyExpirationRule"/> and <see cref="RoleManagementPolicyNotificationRule"/>.
        /// </summary>
        public IList<RoleManagementPolicyRule> Rules { get; }
        /// <summary>
        /// The readonly computed rule applied to the policy.
        /// Please note <see cref="RoleManagementPolicyRule"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="RoleManagementPolicyApprovalRule"/>, <see cref="RoleManagementPolicyAuthenticationContextRule"/>, <see cref="RoleManagementPolicyEnablementRule"/>, <see cref="RoleManagementPolicyExpirationRule"/> and <see cref="RoleManagementPolicyNotificationRule"/>.
        /// </summary>
        public IReadOnlyList<RoleManagementPolicyRule> EffectiveRules { get; }
        /// <summary> Additional properties of scope. </summary>
        public RoleManagementPolicyProperties PolicyProperties { get; }
    }
}
