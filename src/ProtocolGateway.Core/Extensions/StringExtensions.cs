// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Azure.Devices.ProtocolGateway.Extensions
{
    public static class StringExtensions
    {
        public static bool IsGatewayGenerated(this string messageId)
        {
            return messageId != null && messageId.StartsWith(Constants.PgGeneratedMessageIdPrefix);
        }
    }
}
