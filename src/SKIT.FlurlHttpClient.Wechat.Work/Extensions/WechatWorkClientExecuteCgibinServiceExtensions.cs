﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Work
{
    public static class WechatWorkClientExecuteCgibinServiceExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/service/get_provider_token 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/91200 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinServiceGetProviderTokenResponse> ExecuteCgibinServiceGetProviderTokenAsync(this WechatWorkClient client, Models.CgibinServiceGetProviderTokenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "service", "get_provider_token")
                .SetOptions(request);

            var requestData = new { corpid = client.CorpId, provider_secret = client.AgentSecret };
            return await client.SendRequestWithJsonAsync<Models.CgibinServiceGetProviderTokenResponse>(flurlReq, data: requestData, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/service/get_suite_token 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/90600 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinServiceGetSuiteTokenResponse> ExecuteCgibinServiceGetSuiteTokenAsync(this WechatWorkClient client, Models.CgibinServiceGetSuiteTokenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (string.IsNullOrEmpty(request.SuiteId))
                request.SuiteId = client.SuiteId;

            if (string.IsNullOrEmpty(request.SuiteSecret))
                request.SuiteSecret = client.SuiteSecret;

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "service", "get_suite_token")
                .SetOptions(request);

            return await client.SendRequestWithJsonAsync<Models.CgibinServiceGetSuiteTokenResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/service/get_pre_auth_code 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/90601 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinServiceGetPreAuthCodeResponse> ExecuteCgibinServiceGetPreAuthCodeAsync(this WechatWorkClient client, Models.CgibinServiceGetPreAuthCodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Get, "cgi-bin", "service", "get_pre_auth_code")
                .SetOptions(request)
                .SetQueryParam("suite_access_token", request.AccessToken);

            return await client.SendRequestAsync<Models.CgibinServiceGetPreAuthCodeResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/service/set_session_info 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/90602 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinServiceSetSessionInfoResponse> ExecuteCgibinServiceSetSessionInfoAsync(this WechatWorkClient client, Models.CgibinServiceSetSessionInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "service", "get_pre_auth_code")
                .SetOptions(request)
                .SetQueryParam("suite_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinServiceSetSessionInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/service/get_permanent_code 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/90603 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinServiceGetPermanentCodeResponse> ExecuteCgibinServiceGetPermanentCodeAsync(this WechatWorkClient client, Models.CgibinServiceGetPermanentCodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "service", "get_permanent_code")
                .SetOptions(request)
                .SetQueryParam("suite_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinServiceGetPermanentCodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/service/get_auth_info 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/90604 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinServiceGetAuthInfoResponse> ExecuteCgibinServiceGetAuthInfoAsync(this WechatWorkClient client, Models.CgibinServiceGetAuthInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "service", "get_auth_info")
                .SetOptions(request)
                .SetQueryParam("suite_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinServiceGetAuthInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/service/get_corp_token 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/90605 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinServiceGetCorpTokenResponse> ExecuteCgibinServiceGetCorpTokenAsync(this WechatWorkClient client, Models.CgibinServiceGetCorpTokenRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "service", "get_corp_token")
                .SetOptions(request)
                .SetQueryParam("suite_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinServiceGetCorpTokenResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/service/get_admin_list 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/90605 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinServiceGetAdminListResponse> ExecuteCgibinServiceGetAdminListAsync(this WechatWorkClient client, Models.CgibinServiceGetAdminListRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "service", "get_admin_list")
                .SetOptions(request)
                .SetQueryParam("suite_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinServiceGetAdminListResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/service/getuserinfo3rd 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/91121 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinServiceUserInfo3rdResponse> ExecuteCgibinServiceUserInfo3rdAsync(this WechatWorkClient client, Models.CgibinServiceUserInfo3rdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Get, "cgi-bin", "service", "getuserinfo3rd")
                .SetOptions(request)
                .SetQueryParam("suite_access_token", request.AccessToken)
                .SetQueryParam("code", request.Code);

            return await client.SendRequestAsync<Models.CgibinServiceUserInfo3rdResponse>(flurlReq, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/service/getuserdetail3rd 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/91122 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinServiceUserDetail3rdResponse> ExecuteCgibinServiceUserDetail3rdAsync(this WechatWorkClient client, Models.CgibinServiceUserDetail3rdRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "service", "getuserdetail3rd")
                .SetOptions(request)
                .SetQueryParam("suite_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinServiceUserDetail3rdResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/service/get_login_info 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/91125 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinServiceGetLoginInfoResponse> ExecuteCgibinServiceGetLoginInfoAsync(this WechatWorkClient client, Models.CgibinServiceGetLoginInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Get, "cgi-bin", "service", "get_login_info")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinServiceGetLoginInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region Register
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/service/get_register_code 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/90581 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinServiceGetRegisterCodeResponse> ExecuteCgibinServiceGetRegisterCodeAsync(this WechatWorkClient client, Models.CgibinServiceGetRegisterCodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "service", "get_register_code")
                .SetOptions(request)
                .SetQueryParam("provider_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinServiceGetRegisterCodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/service/get_register_info 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/90582 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinServiceGetRegisterInfoResponse> ExecuteCgibinServiceGetRegisterInfoAsync(this WechatWorkClient client, Models.CgibinServiceGetRegisterInfoRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "service", "get_register_info")
                .SetOptions(request)
                .SetQueryParam("provider_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinServiceGetRegisterInfoResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Media
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/service/media/upload 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/91883 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinServiceMediaUploadResponse> ExecuteCgibinServiceMediaUploadAsync(this WechatWorkClient client, Models.CgibinServiceMediaUploadRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            if (string.IsNullOrEmpty(request.FileName))
            {
                string ext = "";
                if ("image".Equals(request.Type))
                    ext = ".png";
                else if ("voice".Equals(request.Type))
                    ext = ".mp3";
                else if ("video".Equals(request.Type))
                    ext = ".mp4";

                request.FileName = Guid.NewGuid().ToString("N").ToLower() + ext;
            }

            if (string.IsNullOrEmpty(request.FileContentType))
            {
                if (request.FileName!.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase))
                    request.FileContentType = "image/jpeg";
                else if (request.FileName!.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase))
                    request.FileContentType = "image/jpeg";
                else if (request.FileName!.EndsWith(".png", StringComparison.OrdinalIgnoreCase))
                    request.FileContentType = "image/png";
                else if (request.FileName!.EndsWith(".gif", StringComparison.OrdinalIgnoreCase))
                    request.FileContentType = "image/gif";
                else if (request.FileName!.EndsWith(".mp3", StringComparison.OrdinalIgnoreCase))
                    request.FileContentType = "audio/mpeg";
                else if (request.FileName!.EndsWith(".amr", StringComparison.OrdinalIgnoreCase))
                    request.FileContentType = "audio/amr";
                else if (request.FileName!.EndsWith(".mp4", StringComparison.OrdinalIgnoreCase))
                    request.FileContentType = "video/mp4";
                else
                    request.FileContentType = "application/octet-stream";
            }

            string boundary = "--BOUNDARY--" + DateTimeOffset.Now.Ticks.ToString("x");
            using var fileContent = new ByteArrayContent(request.FileBytes ?? new byte[0]);
            using var httpContent = new MultipartFormDataContent(boundary);
            httpContent.Add(fileContent, "\"media\"", "\"" + request.FileName + "\"");
            httpContent.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data; boundary=" + boundary);
            fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse(request.FileContentType);
            fileContent.Headers.ContentLength = request.FileBytes?.Length;
            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "service", "media", "upload")
                .SetOptions(request)
                .SetQueryParam("provider_access_token", request.AccessToken)
                .SetQueryParam("type", request.Type);

            return await client.SendRequestAsync<Models.CgibinServiceMediaUploadResponse>(flurlReq, content: httpContent, cancellationToken: cancellationToken);
        }
        #endregion

        #region Contact
        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/service/contact/id_translate 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/91846 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinServiceContactIdTranslateResponse> ExecuteCgibinServiceContactIdTranslateAsync(this WechatWorkClient client, Models.CgibinServiceContactIdTranslateRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "service", "contact", "id_translate")
                .SetOptions(request)
                .SetQueryParam("provider_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinServiceContactIdTranslateResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cgi-bin/service/contact/sort 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/92093 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinServiceContactSortResponse> ExecuteCgibinServiceContactSortAsync(this WechatWorkClient client, Models.CgibinServiceContactSortRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cgi-bin", "service", "contact", "sort")
                .SetOptions(request)
                .SetQueryParam("provider_access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.CgibinServiceContactSortResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Batch
        /// <summary>
        /// <para>异步调用 [GET] /cgi-bin/service/batch/getresult 接口。</para>
        /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/91882 </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CgibinServiceBatchGetResultResponse> ExecuteCgibinServiceBatchGetResultAsync(this WechatWorkClient client, Models.CgibinServiceBatchGetResultRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Get, "cgi-bin", "service", "batch", "getresult")
                .SetOptions(request)
                .SetQueryParam("provider_access_token", request.AccessToken)
                .SetQueryParam("jobid", request.JobId);

            return await client.SendRequestAsync<Models.CgibinServiceBatchGetResultResponse>(flurlReq, cancellationToken: cancellationToken);
        }
        #endregion
    }
}