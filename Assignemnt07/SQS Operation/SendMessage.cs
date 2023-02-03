using System;
using System.Threading.Tasks;
using Amazon.SQS;
using Amazon.SQS.Model;


namespace SQS_Operation
{
    class SendMessage
    {

        public static async Task Main1()
        {
            string messageBody = "This is a sample message to send to the example queue.";
            string queueUrl = "https://sqs.us-east-1.amazonaws.com/847888492411/aspnetb7-fahim";

            // Create an Amazon SQS client object using the
            // default user. If the AWS Region you want to use
            // is different, supply the AWS Region as a parameter.
            IAmazonSQS client = new AmazonSQSClient();

            var request = new SendMessageRequest
            {
                MessageBody = messageBody,
                QueueUrl = queueUrl,
            };

            var response = await client.SendMessageAsync(request);

            if (response.HttpStatusCode == System.Net.HttpStatusCode.OK)
            {
                Console.WriteLine($"Successfully sent message. Message ID: {response.MessageId}");
            }
            else
            {
                Console.WriteLine("Could not send message.");
            }
        }
        
    }
}