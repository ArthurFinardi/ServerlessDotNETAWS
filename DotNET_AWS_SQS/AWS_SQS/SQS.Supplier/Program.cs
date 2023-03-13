using Amazon;
using Amazon.SQS;
using Amazon.SQS.Model;

namespace SQS.Supplier
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World");

            var client = new AmazonSQSClient(RegionEndpoint.SAEast1); // SP Region 
            var request = new SendMessageRequest
            {
                QueueUrl = "https://sqs.sa-east-1.amazonaws.com/367945316125/teste1",
                MessageBody = "teste 123"
            };
            await client.SendMessageAsync(request);
        }
    }
}