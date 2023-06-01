using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExamples.Console._01_Creational
{
    // abstract product
    public interface IShipping
    {
        void ShipOrder(int orderId);
    }
    // concrete product
    public class ChronoposteShipping : IShipping
    {
        public void ShipOrder(int orderId)
        {
            System.Console.WriteLine($"Shipping order {orderId} by Chrono poste");
        }
    }
    public class ColissimoShipping : IShipping
    {
        public void ShipOrder(int orderId)
        {
            System.Console.WriteLine($"Shipping order {orderId} by Colissimo");
        }
    }
    // abstract creator 
    public abstract class ShippingFactory
    {
        public abstract IShipping GetShippingProvider();

    }
    // concrete creator
    public class ChronopostShippingFactory : ShippingFactory
    {
        public override IShipping GetShippingProvider()
        {
            return new ChronoposteShipping();
        }
    }
    public class ColissimoShippingFactory : ShippingFactory
    {
        public override IShipping GetShippingProvider()
        {
            return new ColissimoShipping();
        }
    }
    // process 
    public class OrderService
    {
        private readonly ShippingFactory _factory;

        public OrderService(ShippingFactory factory)
        {
            _factory = factory;
        }

        public void SendOrder(int orderId)
        {
            var provider = _factory.GetShippingProvider();
            provider.ShipOrder(orderId);
            
        }
    }

}
