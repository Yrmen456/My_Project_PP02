using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Project_PP02.Data
{
    class Data
    {
    }

    public class ServiceArray
    {
        public List<Service> Service { get; set; }
    }

    public class Service
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public decimal Cost { get; set; }
        public int DurationInSeconds { get; set; }
        public string Description { get; set; }
        public decimal Discount { get; set; }
        public string MainImagePath { get; set; }
    }

    public class ClientArray
    {
        public List<Client> Client { get; set; }
    }
    public class Client : Service
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int GenderCode { get; set; }
        public string PhotoPath { get; set; } 
        public string FIO { get; set; }
    }


    public class ClientServiceArray
    {
        public List<ClientService> ClientService { get; set; }
    }

    public class ClientService : Client  
    {
        public int ID { get; set; }
        public int ClientID { get; set; }
        public int ServiceID { get; set; }
        public DateTime StartTime { get; set; }
        public string Comment { get; set; }
        public DateTime EndDate { get; set; }
    }
}
