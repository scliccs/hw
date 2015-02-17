namespace Domain
{

    public class ShippingCostCalculatorService
    {
        private readonly IShippingStrategy _shippingStrategy;

        public ShippingCostCalculatorService(IShippingStrategy strategy)
        {
            _shippingStrategy = strategy;
        }
        public double CalculateShippingCost(Order order)
        {
            return _shippingStrategy.Calculate(order);
        }
    }
     
    //below is what it looked like before implementing strategy pattern. 

    //public class ShippingCostCalulatorService
    //{
    //    public double CalculateShippingCost(Order order)
    //    {
    //        switch (order.ShippingMethod)
    //        {
    //            case ShippingOptions.FedEx:
    //                return CalculateForFedEx(order);

    //            case ShippingOptions.UPS:
    //                return CalculateForUPS(order);

    //            case ShippingOptions.Schenker:
    //                return CalculateForSchenker(order);

    //            default:
    //                throw new Exception("Unknown carrier");

    //        }

    //    }

    //    double CalculateForSchenker(Order order)
    //    {
    //        return 3.00d;
    //    }

    //    double CalculateForUPS(Order order)
    //    {
    //        return 4.25d;
    //    }

    //    double CalculateForFedEx(Order order)
    //    {
    //        return 5.00d;
    //    }
    //}


}
