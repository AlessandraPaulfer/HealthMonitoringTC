using Common;
using Repository.Entities;

namespace APIHM.Services.Interfaces
{
    public interface IExtraService
    {
        void AddExtra(ExtraModel model);
        void UpdateExtra(ExtraModel model);
        public void DeleteExtra(int id);
        List<ExtraEntity> GetFromPerson(int id);
    }
}
