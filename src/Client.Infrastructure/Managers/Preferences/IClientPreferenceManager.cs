using LaptopStore_2.Shared.Managers;
using MudBlazor;
using System.Threading.Tasks;

namespace LaptopStore_2.Client.Infrastructure.Managers.Preferences
{
    public interface IClientPreferenceManager : IPreferenceManager
    {
        Task<MudTheme> GetCurrentThemeAsync();

        Task<bool> ToggleDarkModeAsync();
    }
}