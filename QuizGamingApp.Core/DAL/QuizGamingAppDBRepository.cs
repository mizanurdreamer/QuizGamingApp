using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGamingApp.Core.DAL
{
    public class QuizGamingAppDBRepository
    {
        private static readonly string DatabaseId = ConfigurationManager.AppSettings["database"];
        private static DocumentClient QuizGamingAppClient;
        private static void Initialize()
        {
            QuizGamingAppClient = new DocumentClient(new Uri(ConfigurationManager.AppSettings["endpoint"]), ConfigurationManager.AppSettings["authKey"]);
            CreateDatabaseIfNotExistsAsync().Wait();
        }
        public static DocumentClient GetDocumentClient()
        {
            if (QuizGamingAppClient == null)
                Initialize();
            return QuizGamingAppClient;
        }
        public static void CreateDocumentClient()
        {
            if (QuizGamingAppClient == null)
                Initialize();
        }
        public static string GetDatabaseId()
        {
            return DatabaseId;
        }
        private static async Task CreateDatabaseIfNotExistsAsync()
        {
            try
            {
                await QuizGamingAppClient.ReadDatabaseAsync(UriFactory.CreateDatabaseUri(DatabaseId));
            }
            catch (DocumentClientException e)
            {
                if (e.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    await QuizGamingAppClient.CreateDatabaseAsync(new Database { Id = DatabaseId });
                }
                else
                {
                    throw;
                }
            }
        }
    }
}
