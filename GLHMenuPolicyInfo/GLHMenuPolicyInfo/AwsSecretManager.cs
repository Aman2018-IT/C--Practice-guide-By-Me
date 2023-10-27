using Amazon.SecretsManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLHMenuPolicyInfo
{
    public class AwsSecretManager
    {
        private readonly IAmazonSecretsManager secretsManager;
        private readonly SecretsManagerCache cache;



        public AWSSecretsManager()
        {
            this.secretsManager = new AmazonSecretsManagerClient(Amazon.RegionEndpoint.APNortheast1);
            this.cache = new SecretsManagerCache(this.secretsManager);
        }

        public void Dispose()
        {
            this.secretsManager.Dispose();
            this.cache.Dispose();
        }





        public async Task<string> GetUrlAccessKey(string secretId)
        {
            try
            {
                var sec = await this.cache.GetSecretString(secretId);
                var jo = Newtonsoft.Json.Linq.JObject.Parse(sec);
                return jo["jwtkey"].ToObject<string>();
            }
            catch (Exception ex)
            {
                throw;
            }
        }




    
    }
}
