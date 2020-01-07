using System;
using System.Collections.Generic;
using System.Text;
using Business.Domain;
using RabbitMQ.Client;



using Newtonsoft.Json;

namespace Business.Service
{
    public interface IPublishService
    {
        // IEnumerable<Products> GetProducts();
        public void SendMessage(ConnectionFactory factory, Model model);
        
    }
}
