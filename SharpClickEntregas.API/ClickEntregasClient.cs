using SharpClickEntregas.API.Models;
using SharpClickEntregas.API.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SharpClickEntregas.API
{
    public class ClickEntregasClient : IDisposable
    {
        private RestService _restClient;

        private string _apiToken;
        public ClickEntregasClient(string apiToken, bool production = true)
        {
            string url = "https://robotapitest.clickentregas.com/api/business/1.1";

            if (production)
                url = "https://robot.clickentregas.com/api/business/1.1";

            _restClient = new RestService(apiToken, url);

            _apiToken = apiToken;
        }

        public async Task<ApiResponse<CalculateOrderResponse>> CalculateOrder(CalculateOrderRequest calculateOrderRequest)
        {
            var action = "calculate-order";

            var response = await _restClient.Post<CalculateOrderResponse>(action, calculateOrderRequest);

            return response;
        }

        public async Task<ApiResponse<CreateOrderResponse>> CreateOrder(CreateOrderRequest createOrderRequest)
        {
            var action = "create-order";

            var response = await _restClient.Post<CreateOrderResponse>(action, createOrderRequest);

            return response;
        }

        public async Task<ApiResponse<GetOrdersResponse>> GetOrders()
        {
            var action = "orders";

            var response = await _restClient.Get<GetOrdersResponse>(action);

            return response;
        }

        public async Task<ApiResponse<GetOrdersResponse>> GetOrder(int order_id)
        {
            var action = "orders";

            var response = await _restClient.Get<GetOrdersResponse>(action, $"order_id={order_id}");

            return response;
        }

        public void Dispose()
        {
            _restClient.Dispose();
        }
    }
}
