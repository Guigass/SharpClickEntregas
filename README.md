# SharpClickEntregas

Essa biblioteca serve para fazer solicitações junto a Click Entregas.
Existem 3 metodos aplicados Calcula Preço, Solicitar Corrida e Consultar Corrida.

############################ WORK IN PROGRESS #####################################

Exemplos:
            
            using (var client = new ClickEntregasClient("SEU TOKEN", false))
            {
                ############## Calcula preço da rota

                var points = new List<PointRequest>();

                points.Add(new PointRequest
                {
                    Address = "Rua Belem, 234 - Belenzinho, São Paulo - SP, Brasil",
                    ContactPerson = new ContactPerson
                    {
                        Name = "Guilherme",
                        Phone = "11999960923"
                    }
                });

                points.Add(new PointRequest
                {
                    Address = "Rua Jacirendi, 91 - Tatuapé, São Paulo - SP, Brasil",
                    ContactPerson = new ContactPerson
                    {
                        Name = "Guilherme",
                        Phone = "11999960923"
                    }
                });

                var reqCalc = new CalculateOrderRequest
                {
                    Matter = "Compras",
                    Points = points
                };

                var calc = client.CalculateOrder(reqCalc).Result;

                ############## Cria uma Solicitação

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