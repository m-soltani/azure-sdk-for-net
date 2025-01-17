// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of common properties of all FhirResource events. </summary>
    public partial class HealthcareFhirResourceEventBaseProperties
    {
        /// <summary> Initializes a new instance of HealthcareFhirResourceEventBaseProperties. </summary>
        internal HealthcareFhirResourceEventBaseProperties()
        {
        }

        /// <summary> Initializes a new instance of HealthcareFhirResourceEventBaseProperties. </summary>
        /// <param name="resourceType"> Type of HL7 FHIR resource. </param>
        /// <param name="resourceFhirAccount"> Domain name of FHIR account for this resource. </param>
        /// <param name="resourceFhirId"> Id of HL7 FHIR resource. </param>
        /// <param name="resourceVersionId"> VersionId of HL7 FHIR resource. It changes when the resource is created, updated, or deleted(soft-deletion). </param>
        internal HealthcareFhirResourceEventBaseProperties(HealthcareFhirResourceType? resourceType, string resourceFhirAccount, string resourceFhirId, long? resourceVersionId)
        {
            ResourceType = resourceType;
            ResourceFhirAccount = resourceFhirAccount;
            ResourceFhirId = resourceFhirId;
            ResourceVersionId = resourceVersionId;
        }

        /// <summary> Type of HL7 FHIR resource. </summary>
        public HealthcareFhirResourceType? ResourceType { get; }
        /// <summary> Domain name of FHIR account for this resource. </summary>
        public string ResourceFhirAccount { get; }
        /// <summary> Id of HL7 FHIR resource. </summary>
        public string ResourceFhirId { get; }
        /// <summary> VersionId of HL7 FHIR resource. It changes when the resource is created, updated, or deleted(soft-deletion). </summary>
        public long? ResourceVersionId { get; }
    }
}
