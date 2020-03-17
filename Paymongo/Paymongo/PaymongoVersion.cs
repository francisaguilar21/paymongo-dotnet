namespace Paymongo
{
    public enum PaymongoVersion
    {
        V1
    }

    public static class PaymongoVersionExtensions
    {
        public static string ToLowerString(this PaymongoVersion version)
        {
            return version.ToString().ToLower();
        }
    }
}
