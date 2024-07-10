// See https://aka.ms/new-console-template for more information
using Classes.ConstructorPerson;
using NewTututial.Classes;

using System.Text;
using System.Net.NetworkInformation;
using static System.Runtime.InteropServices.JavaScript.JSType;

Ping pingSender = new();
PingOptions options = new PingOptions();
options.DontFragment = true;

string body = "send to google";
byte[] bufer = Encoding.ASCII.GetBytes(body);
int timeout = 120;
string adress = "4.2.2.2";
PingReply reply = pingSender.Send(adress, timeout, bufer, options);

if (reply.Status == IPStatus.Success)
{
    Console.WriteLine($"Response: {reply.Status.ToString()}");
    Console.WriteLine($"RoundTrip: {reply.RoundtripTime}");
    Console.WriteLine($"Time To live: {reply.Options.Ttl}");
    Console.WriteLine($"Bufer size: {reply.Buffer.Length}");
}

internal class SipmnlyPingSend
{
    Ping pingSender = new();
    PingOptions options = new PingOptions();
    private byte[] bufer { get; set; }
    private string body { get; set; }
    private int timeout { get; set; }
    private string adress { get; set; }
    private PingReply reply;

    public SipmnlyPingSend(string body, int timeout, string adress)
    {
        this.body = body;
        this.timeout = timeout;
        this.adress = adress;
        this.bufer = Encoding.ASCII.GetBytes(body);

        reply = pingSender.Send(adress, timeout, bufer, options);
    }

    public PingReply GetReply()
    {
        return reply;
    }

    public void ReadReport()
    {
        if (reply != null && reply.Status == IPStatus.Success)
        {
            Console.WriteLine($"Response: {reply.Status.ToString()}");
            Console.WriteLine($"RoundTrip: {reply.RoundtripTime}");
            Console.WriteLine($"Time To live: {reply.Options.Ttl}");
            Console.WriteLine($"Bufer size: {reply.Buffer.Length}");
        else
            {
                Console.WriteLine("Ping failed.");
            }
        }
    }
}











//Console.WriteLine("Hello, World!");

//var rogal = new PlayerToExpand()
//{
//    Age = 35,
//    Level = 2,
//    Name = "Michal"
//;

//Console.WriteLine($"True Rogl power is: {rogal.ToBetterPlayer(10)}");


//var costam = ConstructorPerson.CreatePerson();

