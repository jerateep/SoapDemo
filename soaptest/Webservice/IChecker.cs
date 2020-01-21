using System;
using System.ServiceModel;

namespace soaptest.Webservice
{
    [ServiceContract]
    public interface IChecker
    {
        [OperationContract]
        string SendBatchInfo(string System, string Programname, string Table,
        string Description, int RowCount,string start, string stop, int addHour);
    }
}