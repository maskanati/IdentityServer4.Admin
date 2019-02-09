﻿// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

// Original file: https://github.com/IdentityServer/IdentityServer4
// Modified by Jan Škoruba

namespace Skoruba.IdentityServer4.Admin.BusinessLogic.Events.Infrastructure
{
    public static class EventIds
    {
        private const int ClientAddedEvents = 1000;

        public const int ClientAdded = ClientAddedEvents + 1;        
    }
}