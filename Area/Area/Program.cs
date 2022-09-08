using System;
[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace Area
{
    public class Program
    {
        public static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(String[] args)
        {
            Triangle T = new Triangle();
            Rectangle R = new Rectangle();

            double AreaOfT = T.ShapeArea();

            double AreaOfR = R.ShapeArea();

            log.Info($"Area of Triangle is : {AreaOfT}");
            log.Info($"Area of Rectangle is : {AreaOfR}");

            Console.ReadLine();
        }
    }
}
