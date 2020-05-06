using System;
using System.ComponentModel.DataAnnotations;

namespace ch11Homework_GH
{
    public class Client
    {
        [Key]
        public int ClientID { get; set; }
        [Required]
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
