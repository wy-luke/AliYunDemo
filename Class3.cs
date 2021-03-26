using System;
using System.Collections.Generic;
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Profile;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Http;

namespace CommonRequestDemo
{
    class Class3
    {
        static void Main3(string[] args)
        {
            IClientProfile profile = DefaultProfile.GetProfile("cn-shanghai", "LTAI5tQewyNWV67aiSbyjiVV", "DuUFuq933u1CrhOajxFQaofYet049m");
            DefaultAcsClient client = new DefaultAcsClient(profile);
            CommonRequest request = new CommonRequest();
            request.Method = MethodType.POST;
            request.Domain = "ocr.cn-shanghai.aliyuncs.com";
            request.Version = "2019-12-30";
            request.Action = "RecognizeIdentityCard";
            // request.Protocol = ProtocolType.HTTP;
            request.AddQueryParameters("Side", "face");
            request.AddQueryParameters("ImageURL", "http://viapi-test.oss-cn-shanghai.aliyuncs.com/viapi-3.0domepic/ocr/RecognizeIdentityCard/sfz1.jpg");
            try {
                CommonResponse response = client.GetCommonResponse(request);
                Console.WriteLine(System.Text.Encoding.Default.GetString(response.HttpResponse.Content));
            }
            catch (ServerException e)
            {
                Console.WriteLine(e);
            }
            catch (ClientException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
