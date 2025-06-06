﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
using SimpleIdServer.IdServer.Domains;
using System;

namespace SimpleIdServer.IdServer.Authenticate.Validations;

public class PlainTextClientSecretValidator : IAlgClientSecretValidator
{
    public HashAlgs Alg => HashAlgs.PLAINTEXT;

    public bool IsValid(ClientSecret secret, string clientSecret)
    {
        return string.Compare(secret.Value, clientSecret, StringComparison.CurrentCultureIgnoreCase) == 0;
    }
}
