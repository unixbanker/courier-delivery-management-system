using System;
using System.Collections.Generic;
using System.Text;

namespace courier_delivery_management_system
{
    public class FragileShipment : Shipment
    {
        public string HandlingNotes { get; set; }
        public bool RequiredDoubleBox { get; set; }
        public FragileShipment (string shipmentID, string senderName, string recipientName, double baseCost, string status, string dateTime, string handlingNotes, bool requiredDoubleBox) : base(shipmentID, senderName, recipientName, baseCost, status, dateTime)
        {
            HandlingNotes = handlingNotes;
            RequiredDoubleBox = requiredDoubleBox;
        }
        public override double CalculateCost()
        {
            return BaseCost * 1.25;
        }
        public override void PrintDetails()
        {
            base.PrintDetails();
            Console.WriteLine("HandlingNotes: " + HandlingNotes);
            Console.WriteLine("RequiredDoubleBox: " + RequiredDoubleBox);
        }
    }
}
