using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IwLauncher_Builder
{
    /// <summary>
    /// Stores values temporarilly in the current user's session
    /// </summary>
    public static class IwMemoryVariables
    {
        /// <summary>
        /// The e-mail that holds the licence
        /// </summary>
        public static string Usermail = "";

        /// <summary>
        /// User's current project name
        /// </summary>
        public static string ProjectName = "IWLAUNCHER PROJECT";
        /// <summary>
        /// The current developer of the project
        /// Can be changed only with Professional licence
        /// </summary>
        public static string ProjectBuilder = "";
        public enum lType
        {
            Professional,
            Basic
        }
        /// <summary>
        /// The user licence type (Basic is default)
        /// </summary>
        public static lType LicenceType = lType.Basic;

        /// <summary>
        /// Verify if the user opts to use Ironiawn servers for update checking
        /// </summary>
        public static bool UseIWSVRKey = false;
        /// <summary>
        /// If the user wants to use IWSVR key, store it here
        /// </summary>
        public static string IWSVRKey;

        /// <summary>
        /// Verify if the provided IwSVR key is valid
        /// </summary>
        public static bool ValidIwSVRKey = false;

        /// <summary>
        /// The game updates setup local
        /// </summary>
        public static class GameUpdates
        {
            /// <summary>
            /// Verify if the user wants to update your game automatically
            /// </summary>
            public static bool AllowGameUpdates;
            /// <summary>
            /// Game's server URL
            /// </summary>
            public static string ServerURL;
            /// <summary>
            /// Game's current version
            /// </summary>
            public static string GameCurrentVersion;
        }

        /// <summary>
        /// The game licensing options
        /// </summary>
        public static class GameLicensing
        {
            /// <summary>
            /// Verify if the user wants to use license management
            /// </summary>
            public static bool UseLicenseChecking = false;
            /// <summary>
            /// The cached game keys [it will be not saved on project's file]
            /// </summary>
            public static string[] GameKeys;
            /// <summary>
            /// Verify if the user wants to use an Account Product Activation method
            /// </summary>
            public static bool UseACPKey = false;
            /// <summary>
            /// Sets the provided Account Product Activation key 
            /// </summary>
            public static string ProvidedACPKey = "";
            /// <summary>
            /// The provided server will set the launcher to get the key file to verify the authenticity of the key
            /// </summary>
            public static string ServerURLKey = "";
        }
    }
}
