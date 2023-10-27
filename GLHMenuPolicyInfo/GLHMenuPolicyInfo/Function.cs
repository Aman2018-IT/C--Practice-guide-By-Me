using Amazon.Lambda.Core;
using Amazon.SecretsManager.Model;
using Amazon.SecretsManager;
using System.Net;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace GLHMenuPolicyInfo;

public class Function
{
    
    /// <summary>
    /// A simple function that takes a string and does a ToUpper
    /// </summary>
    /// <param name="input"></param>
    /// <param name="context"></param>
    /// <returns></returns>
    public string FunctionHandler(PolicyInput policyInput, ILambdaContext context)
    {
        LambdaLogger.Log($"GLHMenuPolicyInfo function Started..{JsonConvert.SerializeObject(policyInput)}");
        PolicyOutput policyOutput = await GetPolicyInfo(policyInput);
        return policyOutput;
    }

    public async Task<PolicyOutput> GetPolicyInfo(PolicyInput policyInput)
    {
        try
        {
            PolicyOutput policyOutput = new PolicyOutput();
            LambdaLogger.Log($"GLHMenuPolicyInfo Lambda- GetPolicyInfo started");

            LambdaLogger.Log($"GLHMenuPolicyInfo Lambda- GetPolicyInfo - GetAccessToken started");
            var sFResponse = await GetAccessToken();
            LambdaLogger.Log($"GLHMenuPolicyInfo Lambda- GetPolicyInfo - GetAccessToken end");


            if (sFResponse != null && !string.IsNullOrEmpty(sFResponse.access_token))
            {
                LambdaLogger.Log($"GLHMenuPolicyInfo Lambda- GetPolicyInfo - Access Token {sFResponse.access_token}");
                LambdaLogger.Log($"GLHMenuPolicyInfo Lambda- GetPolicyInfo - Api URL Token {sFResponse.api_url}");
                var apiEndPoint = Environment.GetEnvironmentVariable("ApiEndpoint");
                apiEndPoint = string.Join("", sFResponse.api_url, apiEndPoint);
                LambdaLogger.Log($"GLHMenuPolicyInfo Lambda- GetPolicyInfo - get the apiEndPoint {apiEndPoint}");

                if (string.IsNullOrEmpty(apiEndPoint))
                {
                    LambdaLogger.Log($"GLHMenuPolicyInfo Lambda- GetPolicyInfo - apiEndPoint is not configured");
                    return policyOutput;
                }

                LambdaLogger.Log($"GLHMenuPolicyInfo Lambda- GetPolicyInfo - Initialize the RestClient");
                using (var restClient = new RestClient())
                {
                    RestRequest requestUpdate = new RestRequest(apiEndPoint, Method.Post);
                    requestUpdate.AddParameter("Authorization", "Bearer " + sFResponse.access_token, ParameterType.HttpHeader);
                    requestUpdate.RequestFormat = DataFormat.Json;
                    string jsonObject = JsonConvert.SerializeObject(policyInput);
                    requestUpdate.AddJsonBody(jsonObject);
                    LambdaLogger.Log($"GLHMenuPolicyInfo Lambda- GetPolicyInfo - RestRequest Object {Newtonsoft.Json.JsonConvert.SerializeObject(requestUpdate)}");
                    var responseS = await restClient.ExecuteAsync(requestUpdate);

                    LambdaLogger.Log($"GLHMenuPolicyInfo Lambda- GetPolicyInfo - Response Object {Newtonsoft.Json.JsonConvert.SerializeObject(responseS)}");
                    if (responseS.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        policyOutput = JsonConvert.DeserializeObject<PolicyOutput>(responseS.Content);
                        LambdaLogger.Log($"GLHMenuPolicyInfo Lambda- GetPolicyInfo - PolicyOutput {Newtonsoft.Json.JsonConvert.SerializeObject(policyOutput)}");
                    }
                    else
                    {
                        LambdaLogger.Log("GLHMenuPolicyInfo Lambda- GetPolicyInfo  not working");
                        LambdaLogger.Log($"GLHMenuPolicyInfo Lambda- GetPolicyInfo - Errormessage: {responseS.ErrorMessage} StatusCode: {responseS.StatusCode}");
                        LambdaLogger.Log($"GLHMenuPolicyInfo Lambda- GetPolicyInfo - Content:{responseS.Content}");
                    }
                }
            }
            return policyOutput;
        }
        catch (Exception ex)
        {
            LambdaLogger.Log($"GLHMenuPolicyInfo Lambda- GetPolicyInfo - Error : {ex.Message} {ex}");
            throw;
        }
    }

    public async Task<SFResponse> GetAccessToken()
    {
        SFResponse sFResponse = new SFResponse();
        try
        {
            LambdaLogger.Log($"GLHMenuPolicyInfo Lambda- GetAccessToken started");
                        var LoginEndpoint = Environment.GetEnvironmentVariable("LoginEndpoint");
            LambdaLogger.Log($"GLHMenuPolicyInfo Lambda-GetAccessToken- get the LoginEndPoint {LoginEndpoint}");

            string AWSRegion = Environment.GetEnvironmentVariable("AWSRegion");
            LambdaLogger.Log($"GLHMenuPolicyInfo Lambda-GetAccessToken- get the AWSRegion {AWSRegion}");

            string SF_Secret_Name = Environment.GetEnvironmentVariable("API_Secret");
            LambdaLogger.Log($"GLHMenuPolicyInfo Lambda-GetAccessToken- get the API_Secret {SF_Secret_Name}");

            if (string.IsNullOrEmpty(AWSRegion) || string.IsNullOrEmpty(SF_Secret_Name) || string.IsNullOrEmpty(LoginEndpoint))
            {
                LambdaLogger.Log($"GLHMenuPolicyInfo Lambda-GetAccessToken- Error: Environment Variables not configured properly");
                return sFResponse;
            }

            LambdaLogger.Log($"GLHMenuPolicyInfo Lambda-GetAccessToken- Initialize GetSecretValueRequest ");
            GetSecretValueRequest request = new GetSecretValueRequest();
            request.SecretId = SF_Secret_Name;
            request.VersionStage = "AWSCURRENT";

            LambdaLogger.Log($"GLHMenuPolicyInfo Lambda-GetAccessToken- Get the IAmazonSecretsManager ");
            IAmazonSecretsManager clients = new AmazonSecretsManagerClient(RegionEndpoint.GetBySystemName(AWSRegion));
            LambdaLogger.Log($"GLHMenuPolicyInfo Lambda-GetAccessToken- Get the getSecret object ");
            GetSecretValueResponse getSecret = await clients.GetSecretValueAsync(request);
            LambdaLogger.Log($"GLHMenuPolicyInfo Lambda-GetAccessToken- getSecret object ..{Newtonsoft.Json.JsonConvert.SerializeObject(getSecret)}");
            if (getSecret.SecretString != null)
            {
                LambdaLogger.Log($"GLHMenuPolicyInfo Lambda-GetAccessToken- Successfully retrived the secret values. Secret string: {getSecret.SecretString}");
                var get = Newtonsoft.Json.Linq.JObject.Parse(getSecret.SecretString);
                using (var restClient = new RestClient())
                {
                    var restRequest = new RestRequest(LoginEndpoint, Method.Post);
                    restRequest.AddParameter("grant_type", "client_credentials");
                    restRequest.AddParameter("client_id", get["client_id"].ToObject<string>());
                    restRequest.AddParameter("scope", get["scope"].ToObject<string>());
                    restRequest.AddParameter("client_secret", get["client_secret"].ToObject<string>());

                    var response = await restClient.ExecuteAsync<SFResponse>(restRequest);
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        LambdaLogger.Log($"GLHMenuPolicyInfo Lambda- GetAccessToken Successfully retrived the token.");
                        sFResponse = JsonConvert.DeserializeObject<SFResponse>(response.Content);
                        sFResponse.api_url = get["api_url"].ToObject<string>();
                    }
                    else
                    {
                        LambdaLogger.Log($"GLHMenuPolicyInfo Lambda- GetAccessToken  SFStatusCode: {response.StatusCode} Error Message: {response.ErrorMessage}");
                    }
                }
            }
            else
            {
                LambdaLogger.Log($"GLHMenuPolicyInfo Lambda- GetAccessToken Error: Couldn't retrive the secret string");
            }
        }
        catch (Exception ex)
        {
            LambdaLogger.Log($"GLHMenuPolicyInfo Lambda- GetAccessToken  Exception: {ex.Message} InnerException: {ex.InnerException}");
        }
        return sFResponse;
    }


}
