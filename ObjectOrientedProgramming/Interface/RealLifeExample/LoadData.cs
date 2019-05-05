using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Interface
{
    public class LoadData
    {
        private readonly IPersonalInfoRepository _personalInfoRepository;
        public LoadData(IPersonalInfoRepository personalInfoRepository)
        {
            _personalInfoRepository = personalInfoRepository;
        }


        public async void Print()
        {
            IEnumerable<PersonalInfo> data = await _personalInfoRepository.GetAllPersonalInfosAsync();
            foreach (var item in data)
            {
                Console.WriteLine("User ID: " + item.ID + " User First Name: " + item.FirstName +
                    " User Last Name: " + item.LastName);
            }
        }

    }
}
