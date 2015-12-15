using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace DendrobiiWine.Mobile.Repository.Api
{
    public abstract class ApiRepositoryBase
    {
        /// <summary>
        /// 控制器名称
        /// </summary>
        public abstract string ControllerName { get; }

        /// <summary>
        /// 主机地址
        /// </summary>
        public Uri Host { get; set; }
        
        /// <summary>
        /// 安全密钥
        /// </summary>
        public string SecurityKey { get; set; }

        /// <summary>
        /// 获取数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="uri"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public async Task<T> GetAsync<T>(string uri, Dictionary<string, string> parameters = null)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", new[] { SecurityKey });

                var urlWithParas = GenerateUrl<T>(uri, parameters);
                var reponseMessage = await client.GetAsync(new Uri(Host, urlWithParas), HttpCompletionOption.ResponseContentRead);
                if (reponseMessage.IsSuccessStatusCode)
                {
                    var result = await reponseMessage.Content.ReadAsAsync<T>();
                    return result;
                }
                else
                {
                    var details = await reponseMessage.Content.ReadAsStringAsync();
                    throw new Exception(details);
                }
            }
        }

        /// <summary>
        /// 提交数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TR"></typeparam>
        /// <param name="uri"></param>
        /// <param name="obj"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public async Task<TR> PostAsJsonAsync<T, TR>(string uri, T obj, Dictionary<string, string> parameters = null)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", new[] { SecurityKey });
                var urlWithParas = GenerateUrl<T>(uri, parameters);
                var reponseMessage = await client.PostAsJsonAsync(new Uri(Host, urlWithParas), obj);
                var result = await reponseMessage.Content.ReadAsAsync<TR>();
                return result;
            }
        }

        /// <summary>
        /// 生成URL
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="uri"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        private static string GenerateUrl<T>(string uri, Dictionary<string, string> parameters)
        {
            var urlWithParas = uri;
            if (parameters != null && parameters.Count > 0)
            {
                if (urlWithParas.Contains("?"))
                {
                    urlWithParas += "&";
                }
                else
                {
                    urlWithParas += "?";
                }
                urlWithParas += string.Join("&", parameters.Select(p => $"{p.Key}={p.Value}"));
            }
            return urlWithParas;
        }
    }
}
