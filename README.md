# SharpClickEntregas

Essa biblioteca serve para fazer solicita��es junto a Click Entregas.
Existem 3 metodos aplicados Calcula Pre�o, Solicitar Corrida e Consultar Corrida.

############################ WORK IN PROGRESS #####################################

Exemplos:
            
            using (var client = new ClickEntregasClient("SEU TOKEN", false))
            {
                ############## Calcula pre�o da rota

                var points = new List<PointRequest>();

                points.Add(new PointRequest
                {
                    Address = "R. Guamiranga, 1140 - Vila Independencia, S�o Paulo - SP, 04220-020",
                    ContactPerson = new ContactPerson
                    {
                        Name = "Fulano",
                        Phone = "11999999999"
                    }
                });

                points.Add(new PointRequest
                {
                    Address = "Av. Paulista, 1439 - 12 - Bela Vista, S�o Paulo - SP, 01310-100",
                    ContactPerson = new ContactPerson
                    {
                        Name = "Ciclano",
                        Phone = "11999999999"
                    }
                });

                var reqCalc = new CalculateOrderRequest
                {
                    Matter = "Compras",
                    Points = points
                };

                var calc = client.CalculateOrder(reqCalc).Result;

                ############## Cria uma Solicita��o

                var reqCreate = new CreateOrderRequest
                {
                    Matter = "Compras",
                    IsRouteOptimizerEnabled = true,
                    IsClientNotificationEnabled = true,
                    IsContactPersonNotificationEnabled = true,
                    InsuranceAmount = 0,
                    Points = points
                };

                var create = client.CreateOrder(reqCreate).Result;

                ############## Consulta Pedidos

                var orders = client.GetOrders().Result;

                var order = client.GetOrder(1327).Result;
            }




Caso queira contribuir para a biblioteca, fique livre para fazer um pull request.

Espero estar ajudando.