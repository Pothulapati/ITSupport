using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITSupportBot
{
    public class TicketEntity : TableEntity
    {
        public TicketEntity(int id,string Client)
        {
            this.RowKey = id.ToString();
            this.PartitionKey = Client;
        }
        public string Status { get; set; }
        public string Product { get; set; }
        public int Severity { get; set; }
        public string   DateCreated { get; set; }
        public string DateModified { get; set; }
        public string DateClosed { get; set; }
        public string Category { get; set; }
        public int TimeSpent { get; set; }
        public string CommentsBy { get; set; }
        public string Comments { get; set; }

    }
}