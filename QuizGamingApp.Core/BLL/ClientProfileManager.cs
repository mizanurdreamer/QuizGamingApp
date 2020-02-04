
using Microsoft.Azure.Documents;
using QuizGamingApp.Core.DAL;
using QuizGamingApp.Core.EnitityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGamingApp.Core.BLL
{
    public class ClientProfileManager
    {
        private ClientProfileRepository _clientProfileRepository;

        public ClientProfileManager()
        {
            _clientProfileRepository = new ClientProfileRepository();
        }
        public async Task<IEnumerable<ClientProfile>> IndexAsync()
        {
            var items = await _clientProfileRepository.GetItemsAsync(d => !d.IsDeleted);
            return items;
        }

        public async Task CreateAsync(ClientProfile clientProfile)
        {
            
            Document document = await _clientProfileRepository.CreateItemAsync(clientProfile);
        }

        public async Task EditAsync(ClientProfile clientProfile)
        {
            await _clientProfileRepository.UpdateItemAsync(clientProfile.Id, clientProfile);
        }

        public async Task DeleteConfirmedAsync(string id)
        {
            await _clientProfileRepository.DeleteItemAsync(id);
        }

        public async Task<ClientProfile> GetItemAsync(string id)
        {
            ClientProfile clientProfile = await _clientProfileRepository.GetItemAsync(id);
            return clientProfile;
        }
    }
}
