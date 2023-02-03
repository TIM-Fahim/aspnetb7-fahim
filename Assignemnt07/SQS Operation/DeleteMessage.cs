using Amazon.SQS.Model;
using Amazon.SQS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQS_Operation
{
    public class DeleteMessage
    {
        public static async Task Main()
        {
            string queueUrl = "https://sqs.us-east-1.amazonaws.com/847888492411/aspnetb7-fahim";
            var attributeNames = new List<string>() { "All" };
            int maxNumberOfMessages = 1;
            var visibilityTimeout = (int)TimeSpan.FromMinutes(1).TotalSeconds;
            var waitTimeSeconds = (int)TimeSpan.FromSeconds(5).TotalSeconds;

            // If the Amazon SQS message queue is not in the same AWS Region as your
            // default user, you need to provide the AWS Region as a parameter to the
            // client constructor.
            var client = new AmazonSQSClient();

            var request = new ReceiveMessageRequest
            {
                QueueUrl = queueUrl,
                AttributeNames = attributeNames,
                MaxNumberOfMessages = maxNumberOfMessages,
                VisibilityTimeout = visibilityTimeout,
                WaitTimeSeconds = waitTimeSeconds,
            };

            var response = await client.ReceiveMessageAsync(request);

            if (response.Messages.Count > 0)
            {
                response.Messages.ForEach(async m =>
                {
                    Console.Write($"Message ID: '{m.MessageId}'");

                    var delRequest = new DeleteMessageRequest
                    {
                        QueueUrl = "https://sqs.us-east-1.amazonaws.com/847888492411/aspnetb7-fahim",
                        ReceiptHandle = m.ReceiptHandle,
                    };

                    var delResponse = await client.DeleteMessageAsync(delRequest);
                });
            }
            else
            {
                Console.WriteLine("No messages to delete.");
            }
        }
    }
}
