using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("123 Elm St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Oak St", "Chicago", "IL", "USA");
        Address address3 = new Address("789 Pine St", "Los Angeles", "CA", "USA");

        // Create events
        Event lecture = new Lecture("The Future of AI", "A discussion on AI trends", new DateTime(2024, 5, 20, 18, 0, 0), address1, "Dr. Alice Smith", 100);
        Event reception = new Reception("Networking Evening", "An evening of networking and fun", new DateTime(2024, 6, 15, 17, 30, 0), address2, "rsvp@company.com");
        Event outdoorGathering = new OutdoorGathering("Summer Picnic", "Join us for a fun-filled day outdoors", new DateTime(2024, 7, 10, 12, 0, 0), address3, "Sunny with a chance of clouds");

        // Display event details
        DisplayEventDetails(lecture);
        Console.WriteLine(new string('=', 40));
        DisplayEventDetails(reception);
        Console.WriteLine(new string('=', 40));
        DisplayEventDetails(outdoorGathering);
    }

    static void DisplayEventDetails(Event eventObj)
    {
        Console.WriteLine(eventObj.GetStandardDetails());
        Console.WriteLine(eventObj.GetFullDetails());
        Console.WriteLine(eventObj.GetShortDescription());
    }
}