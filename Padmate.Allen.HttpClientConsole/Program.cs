using Padmate.Allen.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Padmate.Allen.HttpClientConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string requestUri = args[0];
            CallWebApi(requestUri);
            Console.ReadLine();
        }

        private async static void CallWebApi(string requestUri)
        {
            //获取所有数据
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage responseMeaasge = await httpClient.GetAsync(requestUri);
            string singerStr = await responseMeaasge.Content.ReadAsStringAsync();

            WriteResponse(singerStr);

            //添加
            string singerParam = @"{ ""Name"":""SweetBox"",""Sex"":""女""}";
            HttpContent httpContent = new StringContent(singerParam);
            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            Uri serviceReq = new Uri(requestUri);
            await httpClient.PostAsync(serviceReq, httpContent);

            Console.WriteLine("添加一条数据");

            responseMeaasge = await httpClient.GetAsync(requestUri);
            singerStr = await responseMeaasge.Content.ReadAsStringAsync();
            WriteResponse(singerStr);
        }

        public static void WriteResponse(string jsonStr)
        {
            List<Singer> singers = (List<Singer>)UnJson(jsonStr, typeof(List<Singer>));
            foreach (Singer singer in singers)
            {
                string str = "Name：" + singer.Name + " Sex：" + singer.Sex + " Albums" + singer.Albums;
                Console.WriteLine(str);
            }
        }

        public static object UnJson(string szJson, Type type)
        {
            object obj = null;
            using (MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(szJson)))
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(type);
                obj = serializer.ReadObject(ms);
            }
            return obj;
        }
    }
}
