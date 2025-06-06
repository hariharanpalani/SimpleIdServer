﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.IdentityModel.Tokens;
using SimpleIdServer.IdServer.Api.Token.PKCECodeChallengeMethods;
using SimpleIdServer.IdServer.Api.Token.TokenProfiles;
using SimpleIdServer.IdServer.Authenticate.Handlers;
using SimpleIdServer.IdServer.ClaimTokenFormats;
using SimpleIdServer.IdServer.SubjectTypeBuilders;
using System;
using System.Collections.Generic;
using System.Text.Json;

namespace SimpleIdServer.IdServer.Options;

public class IdServerHostOptions
{
    /// <summary>
    /// Base URL of the identity server.
    /// </summary>
    public string Authority { get; set; } = "https://localhost:5000";
    /// <summary>
    /// Default OTP issuer.
    /// </summary>
    public string OtpIssuer { get; set; } = "SimpleIdServer";
    /// <summary>
    /// Enable force https.
    /// </summary>
    public bool ForceHttpsEnabled { get; set; } = false;
    /// <summary>
    /// Enable or disable realm.
    /// </summary>
    public bool RealmEnabled { get; set; } = false;
    /// <summary>
    /// Enable or disable UMA.
    /// </summary>
    public bool IsUMAEnabled { get; set; } = true;
    /// <summary>
    /// Use the email during the authentication.
    /// </summary>
    public bool IsEmailUsedDuringAuthentication { get; set; } = false;
    /// <summary>
    ///  If true, all authorization requests must specify a grant_management_action.
    ///  Default value is false.
    /// </summary>
    public bool GrantManagementActionRequired { get; set; } = false;
    /// <summary>
    /// Mututal TLS is enabled.
    /// </summary>
    public bool MtlsEnabled { get; internal set; } = false;
    /// <summary>
    /// Enable or disable Back Channel Authentication.
    /// </summary>
    public bool BCEnabled { get; set; }
    /// <summary>
    /// Indicating whether the authorization server accepts authorization request data only via PAR.
    /// </summary>
    public bool RequiredPushedAuthorizationRequest { get; set; } = false;
    /// <summary>
    /// OAUTH2.0 client's default scopes.
    /// </summary>
    public List<string> DefaultScopes { get; set; } = new List<string>();
    /// <summary>
    /// Default Token Expiration Time in seconds.
    /// </summary>
    public double DefaultTokenExpirationTimeInSeconds { get; set; } = 60 * 30;
    /// <summary>
    /// Default expiration time of the user cookie.
    /// </summary>
    public double DefaultUserCookieExpirationTimeInSeconds { get; set; } = 60 * 30;
    /// <summary>
    /// Default Refresh Token Expiration Time in seconds.
    /// </summary>
    public double DefaultRefreshTokenExpirationTimeInSeconds { get; set; } = 60 * 30;
    /// <summary>
    /// Default expiration time of the authorization request callback.
    /// </summary>
    public double DefaultAuthorizationRequestCallbackExpirationTimeInSeconds { get; set; } = 60 * 30;
    /// <summary>
    /// Default authentication method used by the client.
    /// </summary>
    public string DefaultTokenEndPointAuthMethod { get; set; } = OAuthClientSecretPostAuthenticationHandler.AUTH_METHOD;
    /// <summary>
    /// Default token signed response algorithm.
    /// </summary>
    public string DefaultTokenSignedResponseAlg { get; set; } = SecurityAlgorithms.RsaSha256;
    /// <summary>
    /// OAUTH2.0 client's default token profile.
    /// </summary>
    public string DefaultTokenProfile { get; set; } = BearerTokenProfile.DEFAULT_NAME;
    /// <summary>
    /// Default encryption alg (JWE).
    /// </summary>
    public string DefaultTokenEncrypteAlg { get; set; } = SecurityAlgorithms.RsaPKCS1;
    /// <summary>
    /// Default encryption enc (JWE).
    /// </summary>
    public string DefaultTokenEncryptedEnc { get; set; } = SecurityAlgorithms.Aes128CbcHmacSha256;
    /// <summary>
    /// Default subject type.
    /// </summary>
    public string DefaultSubjectType { get; set; } = PublicSubjectTypeBuilder.SUBJECT_TYPE;
    /// <summary>
    /// Default code challenge method.
    /// </summary>
    public string DefaultCodeChallengeMethod { get; set; } = PlainCodeChallengeMethodHandler.DEFAULT_NAME;
    /// <summary>
    /// Default max_age.
    /// </summary>
    public double? DefaultMaxAge { get; set; } = null;
    /// <summary>
    /// Default acr value.
    /// </summary>
    public string DefaultAcrValue { get; set; } = Config.DefaultAcrs.FirstLevelAssurance.Name;
    /// <summary>
    /// Get the default token claim format.
    /// </summary>
    public string DefaultClaimTokenFormat { get; set; } = OpenIDClaimTokenFormat.NAME;
    /// <summary>
    /// Algorithm used to hash the password.
    /// </summary>
    public PasswordHashAlgs DefaultPwdHashAlg { get; set; } = PasswordHashAlgs.Default;
    /// <summary>
    /// If true then "scope" claim is expressed as a list of space-delimited case sensistive strings"
    /// If false then "scope" claim is expressed as an array of string.
    /// </summary>
    public bool IsScopeClaimConcatenationEnabled { get; set; } = false;
    /// <summary>
    /// Customizable parameters.
    /// </summary>
    public Dictionary<string, string> Parameters { get; set; } = new Dictionary<string, string>();
    /// <summary>
    /// NAME of the cookie used to store the session id.
    /// </summary>
    public string SessionCookieName { get; set; } = CookieAuthenticationDefaults.CookiePrefix + "Session";
    /// <summary>
    /// NAME of the cookie used to store the state of the registration.
    /// </summary>
    public string RegistrationCookieName { get; set; } = CookieAuthenticationDefaults.CookiePrefix + "Registration";
    /// <summary>
    /// Client secret expiration time in seconds.
    /// </summary>
    public int? ClientSecretExpirationInSeconds { get; set; } = null;
    /// <summary>
    /// Number of seconds the external authentication providers will be stored.
    /// </summary>
    public int? CacheExternalAuthProvidersInSeconds { get; set; }
    /// <summary>
    /// Validity of permission ticket in seconds.
    /// </summary>
    public double UmaValidityPeriodPermissionTicketInSeconds { get; set; } = 5 * 60;
    /// <summary>
    /// The minimum amount of time in seconds that the client SHOULD wait between polling requests to the token endpoint. 
    /// </summary>
    public int RequestSubmittedInterval { get; set; } = 5;
    /// <summary>
    /// Defint the time in MS to end the user's session.
    /// </summary>
    public int EndSessionRedirectionTimeInMS { get; set; } = 3 * 1000;
    /// <summary>
    /// Maximum number of active sessions.
    /// </summary>
    public int MaxNbActiveSessions { get; set; } = 4;

    public ScimClientOptions ScimClientOptions { get; set; }

    public int GetIntParameter(string name) => int.Parse(Parameters[name]);

    public string GetStringParameter(string name) => Parameters[name];

    public IEnumerable<string> GetStringArrayParameter(string name) => Parameters[name].Split(',');

    public IEnumerable<T> GetObjectArrayParameter<T>(string name) => JsonSerializer.Deserialize<IEnumerable<T>>(Parameters[name]);

    public string GetSessionCookieName(string realm, string userName)
    {
        userName = userName.SanitizeNameIdentifier();
        if (!string.IsNullOrWhiteSpace(realm))
            return $"{SessionCookieName}.{realm}-{userName}";
        return $"{SessionCookieName}-{userName}";
    }

    public string GetRegistrationCookieName(string realm)
    {
        if (!string.IsNullOrWhiteSpace(realm))
            return $"{RegistrationCookieName}.{realm}";
        return RegistrationCookieName;
    }
}

public class UICulture
{
    public string Name { get; set; }
    public string DisplayName { get; set; }
}