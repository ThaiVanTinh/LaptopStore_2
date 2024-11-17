using LaptopStore_2.Shared.Settings;
using System.Threading.Tasks;
using LaptopStore_2.Shared.Wrapper;

namespace LaptopStore_2.Shared.Managers
{
    public interface IPreferenceManager
    {
        Task SetPreference(IPreference preference);

        Task<IPreference> GetPreference();

        Task<IResult> ChangeLanguageAsync(string languageCode);
    }
}