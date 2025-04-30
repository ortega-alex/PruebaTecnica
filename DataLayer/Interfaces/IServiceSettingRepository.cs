

using DataLayer.Models;

namespace DataLayer.Interfaces
{
    public interface IServiceSettingRepository
    {
        Task<List<ServiceSetting>> GetAll();
    }
}
