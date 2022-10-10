using CreatioIntegration.Helpers;
using CreatioIntegration.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Data.Services.Client;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CreatioIntegration.Controllers
{
    [ApiController]
    public class InvoiceController : Controller
    {
        private CookieContainer _authCookie;
        private readonly string _appUrl;

        public InvoiceController()
        {
            _appUrl = "http://localhost/creation_learn";
        }

        /// <summary>
        /// Получение договора по имени
        /// </summary>
        /// <param name="agreementName">Номер договора</param>
        /// <returns></returns>
        private BaseCreatioResponse<Agreement> GetAgreementByName(string agreementName)
        {
            var responseData = new BaseCreatioResponse<Agreement>();
            try
            {
                var agreementUrl = $"{_appUrl}/0/odata/LrnAgreement?$filter=LrnName eq '{agreementName}'";
                var requestParams = new BaseCreatioRequest
                {
                    Url = agreementUrl
                };
                var request = CreateRequest(requestParams);
                request.CookieContainer = _authCookie;


                using (var response = (HttpWebResponse)request.GetResponse())
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        using (var reader = new StreamReader(response.GetResponseStream()))
                        {
                            var result = reader.ReadToEnd();
                            responseData = JsonConvert.DeserializeObject<BaseCreatioResponse<Agreement>>(result);
                            if(responseData.Value.Count > 1)
                            {
                                responseData.ErrorText = "Существует несколько договоров с таким названием!";
                            }
                        }
                    }
                }
            }
            catch(Exception exc)
            {
                responseData.ErrorText = exc.Message;
                throw;
            }
            return responseData;
        }

        /// <summary>
        /// Создание счета по номеру договора
        /// </summary>
        /// <param name="agreementName">Номер договора</param>
        /// <param name="invoiceAmount">Сумма счета</param>
        [HttpPost("/CreateInvoice")]
        public async Task<IActionResult> CreateInvoice(string agreementName, decimal invoiceAmount)
        {
            try
            {
                var invoiceUrl = $"{_appUrl}/0/odata/LrnInvoce";

                //проводим авторизацию
                var autorization = new AutorizationHelper("Supervisor", "Supervisor", "http://localhost/creation_learn/");
                autorization.TryLogin();
                _authCookie = autorization.AuthCookie;

                //ищем договор по имени
                var agreementData = GetAgreementByName(agreementName);
                if (string.IsNullOrEmpty(agreementData.ErrorText))
                {
                    var stringBuilder = new StringBuilder(agreementName, 100);

                    var invoice = new InvoiceCreate()
                    {
                        LrnName = stringBuilder.Insert(0, "Invoice_" + DateTime.Now.Date + "_").ToString(),
                        LrnDate = DateTime.Now,
                        LrnAgreementId = new Guid(agreementData.Value.Select(x => x.Id).FirstOrDefault().ToString()),
                        LrnPayDate = DateTime.Now,
                        LrnAmount = invoiceAmount
                    };
                    var response = await SendRequest(invoice, invoiceUrl);
                    response.EnsureSuccessStatusCode();
                }
                else
                {
                    return BadRequest(agreementData.ErrorText);
                }
            }
            catch
            {
                return BadRequest("Что-то пошло не так");
            }
            return Ok("Новый счет по вашему договору успешно создан!");
        }

        /// <summary>
        /// Отправка запроса через поток
        /// </summary>
        /// <param name="requestParams"></param>
        /// <returns></returns>
        private static HttpWebRequest CreateRequest(BaseCreatioRequest requestParams)//(string url, string method = "GET", string requestData = null)
        {
            var request = (HttpWebRequest)WebRequest.Create(requestParams.Url);
            request.ContentType = requestParams.ContentType;
            request.Method = requestParams.Method;
            request.KeepAlive = requestParams.KeepAlive;
            if (!string.IsNullOrEmpty(requestParams.Data))
            {
                using (var requestStream = request.GetRequestStream())
                {
                    using (var writer = new StreamWriter(requestStream))
                    {
                        writer.Write(requestParams.Data);
                    }
                }
            }
            return request;
        }


        /// <summary>
        /// Защита от CSRF-атак
        /// </summary>
        /// <param name="request"></param>
        private void AddCsrfToken(HttpRequestMessage request)
        {
            var cookie = _authCookie.GetCookies(new Uri(_appUrl))["BPMCSRF"];
            if (cookie != null)
            {
                request.Headers.Add("BPMCSRF", cookie.Value);
            }
        }


        /// <summary>
        /// Отправка запроса
        /// </summary>
        /// <param name="requestData">Данные запроса</param>
        /// <param name="destinationUri">Адрес сервиса для отправки запроса</param>
        /// <returns>HTTP ответ с результатом выполнения запроса</returns>
        private async Task<HttpResponseMessage> SendRequest(object requestData, string destinationUri)
        {
            //создаем хендлер для работы с куки
            var handler = new HttpClientHandler
            {
                UseDefaultCredentials = false,
                UseCookies = true,
                CookieContainer = _authCookie,
            };

            //игнорируем ошибки проверки SSL, если это необходимо
            //if (false)
            //{
            //    handler.ServerCertificateCustomValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            //}

            using (var httpClient = new HttpClient(handler))
            {
                //устанавливаем заголовок типа контента
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));



                //формируем запрос
                var request = new HttpRequestMessage(HttpMethod.Post, destinationUri)
                {
                    Content = new StringContent(JsonConvert.SerializeObject(requestData), Encoding.UTF8, "application/json")
                };

                AddCsrfToken(request);

                return await httpClient.SendAsync(request);
            }
        }

    }
}
