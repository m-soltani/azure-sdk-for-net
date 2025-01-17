// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> An activity log alert object for the body of patch operations. </summary>
    public partial class PatchableActivityLogAlertData
    {
        /// <summary> Initializes a new instance of PatchableActivityLogAlertData. </summary>
        public PatchableActivityLogAlertData()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Indicates whether this activity log alert is enabled. If an activity log alert is not enabled, then none of its actions will be activated. </summary>
        public bool? Enabled { get; set; }
    }
}
