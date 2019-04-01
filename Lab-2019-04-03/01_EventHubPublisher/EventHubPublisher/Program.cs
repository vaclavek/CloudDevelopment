namespace EventHubPublisher
{
    using System;
    using System.Text;
    using System.Threading.Tasks;
    using Microsoft.Azure.EventHubs;

    // Source: https://docs.microsoft.com/en-us/azure/event-hubs/event-hubs-dotnet-standard-getstarted-send
    public class Program
    {
        private static EventHubClient eventHubClient;
        private const string EventHubConnectionString = "<INSERT YOUR CONNECTION STRING>"; // ie Endpoint=sb://XXX.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=XXX
        private const string EventHubName = "<INSERT YOUR EVENT HUB NAME>"; // ie myeventhub1

        public static void Main(string[] args)
        {
            MainAsync(args).GetAwaiter().GetResult();
        }

        private static async Task MainAsync(string[] args)
        {
            // Creates an EventHubsConnectionStringBuilder object from the connection string, and sets the EntityPath.
            // Typically, the connection string should have the entity path in it, but for the sake of this simple scenario
            // we are using the connection string from the namespace.
            var connectionStringBuilder = new EventHubsConnectionStringBuilder(EventHubConnectionString)
            {
                EntityPath = EventHubName
            };

            eventHubClient = EventHubClient.CreateFromConnectionString(connectionStringBuilder.ToString());

            await SendMessagesToEventHub(10);

            await eventHubClient.CloseAsync();

            Console.WriteLine("Press ENTER to exit.");
            Console.ReadLine();
        }

        // Creates an event hub client and sends X messages to the event hub.
        private static async Task SendMessagesToEventHub(int numMessagesToSend)
        {
            for (var i = 0; i < numMessagesToSend; i++)
            {
                try
                {
                    var message = $"Message {i}";
                    Console.WriteLine($"Sending message: {message}");
                    await eventHubClient.SendAsync(new EventData(Encoding.UTF8.GetBytes(message)));
                }
                catch (Exception exception)
                {
                    Console.WriteLine($"{DateTime.Now} > Exception: {exception.Message}");
                }

                await Task.Delay(10);
            }

            Console.WriteLine($"{numMessagesToSend} messages sent.");
        }
    }
}