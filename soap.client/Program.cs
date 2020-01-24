using System;
using System.ServiceModel;

namespace soapclint
{
    class Program
    {
        static void Main(string[] args)
        {
            using (BatchChecker.CheckerClient service =
                            new BatchChecker.CheckerClient(
                            new BasicHttpBinding(BasicHttpSecurityMode.Transport),
                            new EndpointAddress("https://localhost:5001/Checker.asmx")))
            {
                string Result = "";
                try
                {
                    int RowCount = 49;
                    string Sdate = DateTime.Now.ToString();
                    string Fdate = DateTime.Now.ToString();
                    string Table = "ZClass";
                    var Response = service.SendBatchInfoAsync("OES", "Program", Table, "description", RowCount, Sdate, Fdate, 0).Result;
                    Result = "OK";
                }
                catch (Exception ex)
                {
                    Result = ex.Message;
                }
            }

        }
    }
}
