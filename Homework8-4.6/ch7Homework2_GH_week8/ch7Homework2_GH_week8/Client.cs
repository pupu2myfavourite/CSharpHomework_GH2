using System;
namespace OrderManagement
{
    public class Client
    {
        public int ClientID { get; set; }
        public string ClientName { get; set; }

        public Client()
        {
        }
        public Client(int ID, string name)
        {
            ClientID = ID;
            ClientName = name;
        }

        public override string ToString()
        {
            return "-ClientID:" + ClientID + " -ClientName:" + ClientName;
        }
    }
}
