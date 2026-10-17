using System;
using System.Collections.Generic;
using System.Text;

namespace courier_delivery_management_system
{
    public abstract class ShipmentSystem
    {
        public string ShipmentID { get; set; }
        public string SenderName { get; set; }
        public string RecipientName { get; set; }
        public double BaseCost { get; set; }
        public string Status { get; set; }
        public string DateTime { get; set; }
        public ShipmentSystem(string shipmentID, string senderName, string recipientName, double baseCost, string status, string dateTime)
        {
            ShipmentID = shipmentID;
            SenderName = senderName;
            RecipientName = recipientName;
            BaseCost = baseCost;
            Status = status;
            DateTime = dateTime;
        }
        public abstract void CalculateCost();
        public virtual void PrintDetails()
        {
            Console.WriteLine("ShipmentID: " + ShipmentID);
            Console.WriteLine("SenderName: " + SenderName);
            Console.WriteLine("ShipmentID: " + RecipientName);
            Console.WriteLine("ShipmentID: " + BaseCost);
            Console.WriteLine("ShipmentID: " + Status);
            Console.WriteLine("ShipmentID: " + DateTime);
        }
    }
}
