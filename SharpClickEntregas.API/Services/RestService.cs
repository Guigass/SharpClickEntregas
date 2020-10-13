using Newtonsoft.Json;
using SharpClickEntregas.API.Helpers;
using SharpClickEntregas.API.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SharpClickEntregas.API.Services
{
    public class RestService
    {
        private HttpClient client;
        private string _apiUrl;
        private string _apiToken;

        public RestService(string apiToken, string apiUrl)
        {
            if (String.IsNullOrEmpty(apiToken) || String.IsNullOrEmpty(apiUrl))
                throw new Exception("Erro ao criar o RestService, Verifique se as informações estão corretas");

            _apiToken = apiToken;
            _apiUrl = apiUrl;

            CreateClient();
        }

        public async Task<ApiResponse<T>> Post<T>(string action, object objeto) where T : class
        {
            var apiResponse = new ApiResponse<T>();
            try
            {
                var mediaType = "application/json";
                var jsonContent = new StringContent(JsonConvert.SerializeObject(objeto), Encoding.UTF8, mediaType);

                var result = await client.PostAsync($"{_apiUrl}/{action}", jsonContent);

                apiResponse.Status = result.StatusCode.ToString();
                apiResponse.IsSuccess = result.IsSuccessStatusCode;

                var jsonResult = await result.Content.ReadAsStringAsync().ConfigureAwait(false);

                apiResponse.Message = jsonResult;

                try { apiResponse.Object = JsonConvert.DeserializeObject<T>(jsonResult); }
                catch (Exception ex) { apiResponse.Exception = ex; }
            }
            catch (Exception ex) { apiResponse.Exception = ex; }

            return apiResponse;
        }

        public async Task<ApiResponse<T>> Put<T>(string action, object objeto) where T : class
        {
            var apiResponse = new ApiResponse<T>();

            try
            {
                var mediaType = "application/json";
                var jsonContent = new StringContent(JsonConvert.SerializeObject(objeto), Encoding.UTF8, mediaType);

                var result = await client.PutAsync($"{_apiUrl}/{action}", jsonContent);

                apiResponse.Status = result.StatusCode.ToString();
                apiResponse.IsSuccess = result.IsSuccessStatusCode;

                var jsonResult = await result.Content.ReadAsStringAsync().ConfigureAwait(false);

                apiResponse.Message = jsonResult;

                try { apiResponse.Object = JsonConvert.DeserializeObject<T>(jsonResult); }
                catch (Exception ex) { apiResponse.Exception = ex; }
            }
            catch (Exception ex) { apiResponse.Exception = ex; }

            return apiResponse;
        }

        public async Task<ApiResponse<T>> Get<T>(string action, string query = "") where T : class
        {
            var apiResponse = new ApiResponse<T>();

            try
            {
                var result = await client.GetAsync($"{_apiUrl}/{action}?{query}");

                apiResponse.Status = result.StatusCode.ToString();
                apiResponse.IsSuccess = result.IsSuccessStatusCode;

                var jsonResult = await result.Content.ReadAsStringAsync().ConfigureAwait(false);

                apiResponse.Message = jsonResult;

                try { apiResponse.Object = JsonConvert.DeserializeObject<T>(jsonResult); }
                catch (Exception ex) { apiResponse.Exception = ex; }
            }
            catch (Exception ex) { apiResponse.Exception = ex; }

            return apiResponse;
        }

        public async Task<ApiResponse<string>> Delete(string action)
        {
            var apiResponse = new ApiResponse<string>();

            try
            {
                var result = await client.DeleteAsync($"{_apiUrl}/{action}");

                apiResponse.Status = result.StatusCode.ToString();
                apiResponse.IsSuccess = result.IsSuccessStatusCode;

                var jsonResult = await result.Content.ReadAsStringAsync().ConfigureAwait(false);

                apiResponse.Object = apiResponse.Message = jsonResult;
            }
            catch (Exception ex) { apiResponse.Exception = ex; }

            return apiResponse;
        }

        public async Task<ApiResponse<string>> Delete(string action, object objeto)
        {
            var apiResponse = new ApiResponse<string>();

            try
            {
                var result = await client.DeleteAsJsonAsync($"{_apiUrl}/{action}", objeto);

                apiResponse.Status = result.StatusCode.ToString();
                apiResponse.IsSuccess = result.IsSuccessStatusCode;

                var jsonResult = await result.Content.ReadAsStringAsync().ConfigureAwait(false);

                apiResponse.Object = apiResponse.Message = jsonResult;
            }
            catch (Exception ex) { apiResponse.Exception = ex; }

            return apiResponse;
        }

        private void CreateClient()
        {
            client = new HttpClient();

            client.MaxResponseContentBufferSize = 256000;

            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("X-DV-Auth-Token", _apiToken);
        }

        public void Dispose()
        {
            client.Dispose();
        }
    }
}
