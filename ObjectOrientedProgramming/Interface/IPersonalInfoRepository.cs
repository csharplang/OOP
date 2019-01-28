using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OOP.Interface
{
    public interface IPersonalInfoRepository
    {
        Task<IEnumerable<PersonalInfo>> GetAllPersonalInfosAsync();
        Task<PersonalInfo> GetPersonalInfoByIdAsync(Guid personalInfoId);
        Task<PersonalInfo> GetPersonalInfoWithDetailsAsync(Guid personalInfoId);
        Task CreatePersonalInfoAsync(PersonalInfo personalInfo);
        Task UpdatePersonalInfoAsync(PersonalInfo dbPersonalInfo, PersonalInfo personalInfo);
        Task DeletePersonalInfoAsync(PersonalInfo personalInfo);
    }
}
