namespace SemgrepTestProject.VulnerableCode
{
    public class HardcodedSecrets
    {
        // 🚨 Hardcoded API Key
        private string apiKey = "sk_test_51H6zY7EwQKjXn5Ys";

        public string GetApiKey()
        {
            return apiKey;
        }
    }
}
