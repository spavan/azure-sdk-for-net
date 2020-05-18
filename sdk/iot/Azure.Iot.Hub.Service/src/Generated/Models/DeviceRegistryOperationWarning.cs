// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Iot.Hub.Service.Models
{
    /// <summary> Encapsulates device registry operation error details. </summary>
    public partial class DeviceRegistryOperationWarning
    {
        /// <summary> Initializes a new instance of DeviceRegistryOperationWarning. </summary>
        internal DeviceRegistryOperationWarning()
        {
            WarningCode = "DeviceRegisteredWithoutTwin";
        }

        /// <summary> Initializes a new instance of DeviceRegistryOperationWarning. </summary>
        /// <param name="deviceId"> Identifier of the device that indicated the warning. </param>
        /// <param name="warningCode"> The code associated with the warning. </param>
        /// <param name="warningStatus"> Additional details associated with the warning. </param>
        internal DeviceRegistryOperationWarning(string deviceId, string warningCode, string warningStatus)
        {
            DeviceId = deviceId;
            WarningCode = warningCode;
            WarningStatus = warningStatus;
        }

        /// <summary> Identifier of the device that indicated the warning. </summary>
        public string DeviceId { get; }
        /// <summary> The code associated with the warning. </summary>
        public string WarningCode { get; }
        /// <summary> Additional details associated with the warning. </summary>
        public string WarningStatus { get; }
    }
}
