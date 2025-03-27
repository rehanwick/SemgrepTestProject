using System;
using System.IO;

namespace SemgrepTestProject
{
    public class VulnerableApp
    {
        private string filename = "user_data.html";

        public void InjectUserInput(string userInput)
        {
            // Directly inject user input into HTML without sanitization (insecure)
            string htmlContent = $@"
                <html>
                    <head><title>User Data</title></head>
                    <body>
                        <h1>User Input</h1>
                        <p>{userInput}</p> <!-- Insecure user input injection -->
                    </body>
                </html>
                ";

            // Save the HTML content to a file
            File.WriteAllText(filename, htmlContent);
            Console.WriteLine($"User input has been written to {filename}");
        }

        public void ReadHtmlFile()
        {
            // Read the generated HTML file
            string content = File.ReadAllText(filename);
            Console.WriteLine("Generated HTML content:");
            Console.WriteLine(content);
        }
    }

    public class Testxss
    {
        // 🚨 Cross site scripting Vulnerability
        public static void Test()
        {
            var app = new VulnerableApp();

            // Simulate user input
            Console.WriteLine("Enter some data: ");
            string userInput = Console.ReadLine();  // User input (potentially dangerous)

            app.InjectUserInput(userInput);

            // Display the contents of the generated HTML file
            app.ReadHtmlFile();
        }

    }
}
