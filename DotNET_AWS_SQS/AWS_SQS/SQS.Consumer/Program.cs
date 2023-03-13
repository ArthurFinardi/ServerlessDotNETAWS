using Amazon;
using Amazon.SQS;
using Amazon.SQS.Model;

namespace SQS.Consumer
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World");

            var client = new AmazonSQSClient(RegionEndpoint.SAEast1); // SP Region 
            var request = new ReceiveMessageRequest
            {
                QueueUrl = "https://sqs.sa-east-1.amazonaws.com/367945316125/teste1"
            };
            var response = await client.ReceiveMessageAsync(request);
            while(true)
            {
                foreach (var message in response.Messages)
                {
                    Console.WriteLine(message.Body);
                    client.DeleteMessageAsync("https://sqs.sa-east-1.amazonaws.com/367945316125/teste1", message.ReceiptHandle);
                }
            }
        }
    }
}