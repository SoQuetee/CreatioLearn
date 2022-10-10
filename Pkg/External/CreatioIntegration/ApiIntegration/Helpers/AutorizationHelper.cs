using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace CreatioIntegration.Helpers
{
    public class AutorizationHelper
    {
        private readonly string _userName;
        private readonly string _userPassword;
        private readonly string _authServiceUrl;
        private readonly string _appUrl;
        public CookieContainer AuthCookie;

        public AutorizationHelper(string userName, string userPassword, string appUrl)
        {
            _userName = userName;
            _userPassword = userPassword;
            _authServiceUrl = appUrl + @"/ServiceModel/AuthService.svc/Login";
            _appUrl = appUrl;
        }

        /// <summary>
        /// Авторизация
        /// </summary>
        public void TryLogin()
        {
            var authData = @"{
                ""UserName"":""" + _userName + @""",
                ""UserPassword"":""" + _userPassword + @"""
            }";
            var request = CreateRequest(_authServiceUrl, authData);
            AuthCookie = new CookieContainer();
            request.CookieContainer = AuthCookie;
            // При успешной аутентификации сохраняем аутентификационные куки для
            // дальнейшего использования в запросах к Creatio. В случае неудачной 
            // аутентификации в консоль приложения выводится сообщение о причине
            // ошибки.
            using (var response = (HttpWebResponse)request.GetResponse())
            {
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    using (var reader = new StreamReader(response.GetResponseStream()))
                    {
                        var responseMessage = reader.ReadToEnd();
                        //Console.WriteLine(responseMessage);
                        if (responseMessage.Contains("\"Code\":1"))
                        {
                            throw new UnauthorizedAccessException($"Пользователь {_userName} неавтозирован в {_appUrl}");
                        }
                    }
                    string authName = ".ASPXAUTH";
                    string authCookieValue = response.Cookies[authName].Value;
                    AuthCookie.Add(new Uri(_appUrl), new Cookie(authName, authCookieValue));
                }
            }
        }
        /// <summary>
        /// Отправка запроса через поток
        /// </summary>
        /// <param name="url">Url запроса</param>
        /// <param name="requestData">Тело запроса</param>
        /// <returns></returns>
        private static HttpWebRequest CreateRequest(string url, string requestData = null)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.ContentType = "application/json";
            request.Method = "POST";
            request.KeepAlive = true;
            if (!string.IsNullOrEmpty(requestData))
            {
                using (var requestStream = request.GetRequestStream())
                {
                    using (var writer = new StreamWriter(requestStream))
                    {
                        writer.Write(requestData);
                    }
                }
            }
            return request;
        }
    }
}
