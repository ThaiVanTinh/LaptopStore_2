using System.Text.Json;
using LaptopStore_2.Application.Interfaces.Serialization.Options;

namespace LaptopStore_2.Application.Serialization.Options
{
    public class SystemTextJsonOptions : IJsonSerializerOptions
    {
        public JsonSerializerOptions JsonSerializerOptions { get; } = new();
    }
}