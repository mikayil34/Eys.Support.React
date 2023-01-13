using Eys.Support.Debugging;

namespace Eys.Support
{
    public class SupportConsts
    {
        public const string LocalizationSourceName = "Support";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "47fa4c22ef854e9283e57e12aaab3e73";
    }
}
