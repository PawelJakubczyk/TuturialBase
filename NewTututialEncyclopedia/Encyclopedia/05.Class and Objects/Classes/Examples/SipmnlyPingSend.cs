using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;

namespace NewTututialEncyklopedia.Classes;
internal class SipmnlyPingSend
{
    private readonly Ping _pingSender = new();
    private readonly PingOptions _options = new();
    public byte[] Bufer { get; set; }
    public string Body { get; set; }
    public int Timeout { get; set; }
    public string Adress { get; set; }
    public PingReply Reply { get; set; }

    public SipmnlyPingSend(string body, int timeout, string adress)
    {
        Body = body;
        Timeout = timeout;
        Adress = adress;
        Bufer = Encoding.ASCII.GetBytes(body);

        Reply = _pingSender.Send(adress, timeout, Bufer, _options);
    }

    public PingReply GetReply()
    {
        return Reply;
    }

    public void ReadReport()
    {
        if (Reply != null && Reply.Status == IPStatus.Success)
        { 
            Console.WriteLine($"Response: {Reply.Status}");
            Console.WriteLine($"RoundTrip: {Reply.RoundtripTime}");
            Console.WriteLine($"Time To live: {Reply.Options?.Ttl}");
            Console.WriteLine($"Bufer size: {Reply.Buffer.Length}");
        }

        else
        {
            Console.WriteLine("Ping failed.");
        }
    }
}






