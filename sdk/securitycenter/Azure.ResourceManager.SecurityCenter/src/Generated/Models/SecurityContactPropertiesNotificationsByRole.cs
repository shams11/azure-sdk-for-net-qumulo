// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> Defines whether to send email notifications from Microsoft Defender for Cloud to persons with specific RBAC roles on the subscription. </summary>
    public partial class SecurityContactPropertiesNotificationsByRole
    {
        /// <summary> Initializes a new instance of SecurityContactPropertiesNotificationsByRole. </summary>
        public SecurityContactPropertiesNotificationsByRole()
        {
            Roles = new ChangeTrackingList<SecurityAlertReceivingRole>();
        }

        /// <summary> Initializes a new instance of SecurityContactPropertiesNotificationsByRole. </summary>
        /// <param name="state"> Defines whether to send email notifications from AMicrosoft Defender for Cloud to persons with specific RBAC roles on the subscription. </param>
        /// <param name="roles"> Defines which RBAC roles will get email notifications from Microsoft Defender for Cloud. List of allowed RBAC roles:. </param>
        internal SecurityContactPropertiesNotificationsByRole(SecurityAlertNotificationByRoleState? state, IList<SecurityAlertReceivingRole> roles)
        {
            State = state;
            Roles = roles;
        }

        /// <summary> Defines whether to send email notifications from AMicrosoft Defender for Cloud to persons with specific RBAC roles on the subscription. </summary>
        public SecurityAlertNotificationByRoleState? State { get; set; }
        /// <summary> Defines which RBAC roles will get email notifications from Microsoft Defender for Cloud. List of allowed RBAC roles:. </summary>
        public IList<SecurityAlertReceivingRole> Roles { get; }
    }
}
