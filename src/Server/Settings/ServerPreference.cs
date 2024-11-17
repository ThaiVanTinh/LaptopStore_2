using System.Linq;
using LaptopStore_2.Shared.Constants.Localization;
using LaptopStore_2.Shared.Settings;

namespace LaptopStore_2.Server.Settings
{
    public record ServerPreference : IPreference
    {
        public string LanguageCode { get; set; } = LocalizationConstants.SupportedLanguages.FirstOrDefault()?.Code ?? "en-US";

        //TODO - add server preferences
    }
}