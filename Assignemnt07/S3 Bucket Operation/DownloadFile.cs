using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using Microsoft.Extensions.Configuration;

namespace S3_Bucket_Operation
{
    public class DownloadFile
    {
        public static async Task Main()
        {
            IAmazonS3 client = new AmazonS3Client();
            string bucketName = "aspnetb7-fahim";
            string keyName = "key.txt";
            string filePath = $"source\\{keyName}";

            bool success = await S3Bucket.DownloadObjectFromBucketAsync(client, bucketName, keyName, filePath);
            
            if(success)
            {
                Console.WriteLine($"Successfully downloaded {keyName}.\n");
            }
            else
            {
                Console.WriteLine($"Sorry, could not download {keyName}.\n");
            }
        }
    }
}
