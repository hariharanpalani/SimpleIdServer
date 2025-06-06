﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System.Collections.Generic;

namespace SimpleIdServer.IdServer.Config;

public static class DefaultClients
{
    public static List<string> AllClientIds => new List<string>
    {
        SidAdminClientId
    };

    public static string SidAdminClientId => "SIDS-manager"; 
}
