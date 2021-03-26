using System;
using System.Collections.Generic;
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Profile;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Http;

namespace CommonRequestDemo
{
    class Class1
    {
        static void Main1(string[] args)
        {
            IClientProfile profile = DefaultProfile.GetProfile("cn-shanghai", "LTAI5tQewyNWV67aiSbyjiVV", "DuUFuq933u1CrhOajxFQaofYet049m");
            DefaultAcsClient client = new DefaultAcsClient(profile);
            CommonRequest request = new CommonRequest();
            request.Method = MethodType.POST;
            request.Domain = "facebody.cn-shanghai.aliyuncs.com";
            request.Version = "2019-12-30";
            request.Action = "DetectFace";
            // request.Protocol = ProtocolType.HTTP;
            //request.AddQueryParameters("ImageURL", "https://viapi-test.oss-cn-shanghai.aliyuncs.com/demo-center/facebody/DetectFace.jpg");
            request.AddQueryParameters("ImageURL", "https://demo-lly.oss-cn-shanghai.aliyuncs.com/p127383.png?versionId=CAEQFhiBgMC1rYPowhciIDNhMjM2ODE1YTdmNjRjMGFiOTRjZTM3ZmY2ZDE2MDQ3");
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