namespace soaptest.Webservice
{
    public class Checker : IChecker
    {
        public string SendBatchInfo(string System, string Programname, string Table, string Description, int RowCount, string start, string stop, int addHour)
        {
            return "Send OK";
        }
    }
}