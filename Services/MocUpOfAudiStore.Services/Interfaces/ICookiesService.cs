namespace MocUpOfAudiStore.Services.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using Microsoft.AspNetCore.Http;

    public interface ICookiesService
    {
        void SetCookieValue(
            IResponseCookies responseCookies,
            string key,
            string value);
        TEnumValue GetValueOrDefault<TEnumValue>(
            IRequestCookieCollection requestCookies,
            string sortTypeKey) where TEnumValue : struct, Enum;
    }
}
