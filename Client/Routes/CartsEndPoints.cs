namespace LaptopStore.Client.Infrastructure.Routes
{
    public static class CartsEndpoints
    {
        public static string ExportFiltered(string searchString)
        {
            return $"{Export}?searchString={searchString}";
        }

        public static string Export = "api/v1/carts/export";

        public static string GetAll = "api/v1/carts";
        public static string Delete = "api/v1/carts";
        public static string Save = "api/v1/carts";
        public static string GetCount = "api/v1/carts/count";
    }
}