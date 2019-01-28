using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP.Interface
{

    public class PersonalInfoRepository : Repository<PersonalInfo>, IPersonalInfoRepository
    {
        public PersonalInfoRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public async Task<IEnumerable<PersonalInfo>> GetAllPersonalInfosAsync()
        {
            var owners = await FindAllAsync();
            return owners.OrderBy(x => x.FirstName);
        }

        public async Task<PersonalInfo> GetPersonalInfoByIdAsync(Guid ownerId)
        {
            var owner = await FindByConditionAync(o => o.ID.Equals(ownerId));
            return owner.DefaultIfEmpty(new PersonalInfo())
                    .FirstOrDefault();
        }

        public async Task<PersonalInfo> GetPersonalInfoWithDetailsAsync(Guid ownerId)
        {
            var personalInfo = await GetPersonalInfoByIdAsync(ownerId);

            return personalInfo;

        }

        public async Task CreatePersonalInfoAsync(PersonalInfo personalInfo)
        {
            Create(personalInfo);
            await SaveAsync();
        }

        public async Task UpdatePersonalInfoAsync(PersonalInfo dbpersonalInfo, PersonalInfo personalInfo)
        {
            Update(personalInfo);
            await SaveAsync();
        }

        public async Task DeletePersonalInfoAsync(PersonalInfo personalInfo)
        {
            Delete(personalInfo);
            await SaveAsync();
        }
    }
}
