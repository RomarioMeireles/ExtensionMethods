using System;

namespace ExtensionMethods
{
    public static class DataExtension
    {
        public static string PrimeiroFormato(this DateTime data)
        {
            return data.ToString("dd/MM/yyyy");
        }
        public static string SegundoFormato(this DateTime data)
        {
            return data.ToString("dd-MM-yyyy");
        }
        public static string TerceiroFormato(this DateTime data)
        {
            return data.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
    public static class StringExtension
    {
        public static string BoasVindas(this string texto)
        {
            return "Seja bem-vindo ao meu canal";
        }
    }
}
