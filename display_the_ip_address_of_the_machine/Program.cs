/*
 * C# Program to Display the IP Address of the Machine
 */
using System;
using System.Net;

namespace display_the_ip_address_of_the_machine
{
    class Program
    {
        static void Main(string[] args)
        {
            String strHostName = string.Empty; //getting the Host Name.
            strHostName = Dns.GetHostName();
            Console.WriteLine("Local Machine's Host Name: " + strHostName);
            IPHostEntry ipEntry = Dns.GetHostEntry(strHostName);// Using Host Name,IP address is obtained.
            IPAddress[] addr = ipEntry.AddressList;

            for (int i = 0; i < addr.Length; i++)
            {
                Console.WriteLine("IP Address {1} : ", addr[i].ToString());
            }
            Console.ReadLine();
        }
    }
}
