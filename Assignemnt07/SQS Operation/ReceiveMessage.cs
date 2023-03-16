using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Amazon.SQS;
using Amazon.SQS.Model;

namespace SQS_Operation
{
    public class ReceiveMessage
    {
        public static async Task Main(string[] args)
        {
            string queueUrl = "https://sqs.us-east-1.amazonaws.com/847888492411/aspnetb7-fahim";
            var attributeNames = new List<string>() { "All" };
            int maxNumberOfMessages = 10;
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
                DisplayMessages(response.Messages);
            }
        }

        /// <summary>
        /// Display message information for a list of Amazon SQS messages.
        /// </summary>
        /// <param name="messages">The list of Amazon SQS Message objects to display.</param>
        public static void DisplayMessages(List<Message> messages)
        {
            messages.ForEach(m =>
            {
                Console.WriteLine($"For message ID {m.MessageId}:");
                Console.WriteLine($"  Body: {m.Body}");
                Console.WriteLine($"  Receipt handle: {m.ReceiptHandle}");
                Console.WriteLine($"  MD5 of body: {m.MD5OfBody}");
                Console.WriteLine($"  MD5 of message attributes: {m.MD5OfMessageAttributes}");
                Console.WriteLine("  Attributes:");

                foreach (var attr in m.Attributes)
                {
                    Console.WriteLine($"\t {attr.Key}: {attr.Value}");
                }
            });
        }
    }
}
