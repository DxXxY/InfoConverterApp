namespace InfoConverterApp.Messange
{
    public class Messange
    {
        public class ServerStatus
        {
            public string Status { get; set; }
            public DateTime DateTime { get; set; }

            public string HostName { get; set; }

            public ServerStatus(string status, DateTime dateTime, string hostname)
            {
                Status = status;
                DateTime = dateTime;
                HostName = hostname;

            }
        }
    }
}
