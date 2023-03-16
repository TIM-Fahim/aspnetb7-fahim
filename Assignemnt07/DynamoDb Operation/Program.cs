using System.Collections.Generic;
using System.Threading.Tasks;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;
using Amazon.DAX;
using Amazon.Runtime;
public class Program
{
    public static async Task Main(string[] args)
    {
        string endpointUri = args[0];
        Console.WriteLine($"Using DAX client - endpointUri={endpointUri}");

        var clientConfig = new DaxClientConfig(endpointUri)
        {
            AwsCredentials = FallbackCredentialsFactory.GetCredentials()
        };
        var client = new ClusterDaxClient(clientConfig);

        var tableName = "aspnetb7-fahim";

        var pk = 1;
        var sk = 10;
        var iterations = 5;

        var startTime = System.DateTime.Now;

        for (var i = 0; i < iterations; i++)
        {
            for (var ipk = 1; ipk <= pk; ipk++)
            {
                for (var isk = 1; isk <= sk; isk++)
                {
                    var request = new GetItemRequest()
                    {
                        TableName = tableName,
                        Key = new Dictionary<string, AttributeValue>() {
                            {"pk", new AttributeValue {N = ipk.ToString()} },
                            {"sk", new AttributeValue {N = isk.ToString() } }
                        }
                    };
                    var response = await client.GetItemAsync(request);
                    Console.WriteLine($"GetItem succeeded for pk: {ipk},sk: {isk}");
                }
            }
        }

        var endTime = DateTime.Now;
        TimeSpan timeSpan = endTime - startTime;
        Console.WriteLine($"Total time: {timeSpan.TotalMilliseconds} milliseconds");

        Console.WriteLine("Hit <enter> to continue...");
        Console.ReadLine();
    }
public static async Task AddRowAsync(IAmazonDynamoDB client, string tableName, Dictionary<string, AttributeValue> item)
    {
        var request = new PutItemRequest
        {
            TableName = tableName,
            Item = item
        };

        await client.PutItemAsync(request);
    }
}

