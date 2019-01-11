// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Azure.Devices.ProtocolGateway.IotHubClient
{
    using DotNetty.Buffers;
    using Microsoft.Azure.Devices.Client;
    using System;

    public sealed class IotHubTransformedClientMessage : IotHubClientMessage
    {
        string identifier;
        DateTime createdTimeInUtc;

        public IotHubTransformedClientMessage(Message message, IByteBuffer payload, string identifier, DateTime createdTimeInUtc)
           : base(message, payload)
        {
            this.identifier = identifier;
            this.createdTimeInUtc = createdTimeInUtc;
        }

        public override string Id
        {
            get { return this.identifier; }
        }

        public override DateTime CreatedTimeUtc
        {
            get { return this.createdTimeInUtc; }
        }
    }
}
