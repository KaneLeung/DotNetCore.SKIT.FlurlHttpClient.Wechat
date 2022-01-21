﻿using System;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.UnitTests
{
    class TestClients
    {
        static TestClients()
        {
            var certificateManager = new Settings.InMemoryCertificateManager();
            Instance = new WechatTenpayClient(new WechatTenpayClientOptions()
            { 
                MerchantId = TestConfigs.WechatMerchantId,
                MerchantV3Secret = TestConfigs.WechatMerchantSecret,
                MerchantCertSerialNumber = TestConfigs.WechatMerchantCertSerialNumber,
                MerchantCertPrivateKey = TestConfigs.WechatMerchantCertPrivateKey,
                CertificateManager = certificateManager
            });
        }

        internal static async Task InitializeCertificateManagerAsync()
        {
            var request = new Models.QueryCertificatesRequest();
            var response = await Instance.ExecuteQueryCertificatesAsync(request);

            response = Instance.DecryptResponseSensitiveProperty(response);
            foreach (var certificateModel in response.CertificateList)
            {
                Instance.CertificateManager.AddEntry(new Settings.CertificateEntry(certificateModel));
            }
        }

        public static readonly WechatTenpayClient Instance;
    }
}
