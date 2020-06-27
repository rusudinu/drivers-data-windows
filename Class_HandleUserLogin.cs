using Amazon.CognitoIdentityProvider;
using Amazon.Extensions.CognitoAuthentication;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DriversData_PC
{
    class Class_HandleUserLogin
    {
        private const string AppClientID = "5io11b2juq6rm4000rf56tup1";
        private const string PoolID = "eu-central-1_LZITFfCAz";
        private static Amazon.RegionEndpoint Region = Amazon.RegionEndpoint.EUCentral1;

        private byte[] retrievedEncodedPassword;
        private byte[] retrievedEncodedUsername;

        /*
         * 
         * Class_HandleUserLogin(byte[] password, byte[] username, bool save_credentials)
        {
            this.plainTextPassword = password;
            this.plainTextUsername = username;
            this.saveCredentials = save_credentials;
        }
         * 
         */


        public void AutenthicateTheUser()
        {
            if (CheckForSavedCredentials())
            {
                Console.WriteLine("saved credentials returned true");
                byte[] entropy = new byte[20];
                using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
                {
                    rng.GetBytes(entropy);
                }

                byte[] plaintextUsernameAfterDecode = ProtectedData.Unprotect(retrievedEncodedUsername, entropy, DataProtectionScope.CurrentUser);
                byte[] plaintextPasswordAfterDecode = ProtectedData.Unprotect(retrievedEncodedPassword, entropy, DataProtectionScope.CurrentUser);

                string plainTextUsernameAfterDecodeString = Encoding.Default.GetString(plaintextUsernameAfterDecode);
                string plainTextPasswordAfterDecodeString = Encoding.Default.GetString(plaintextPasswordAfterDecode);

                LoginUser(plainTextUsernameAfterDecodeString, plainTextPasswordAfterDecodeString).Wait();
            }
            else
            {
                Console.WriteLine("showing the login register form - the saved credentials returned false");
                ShowLoginRegisterForm();
            }
        }

        async Task LoginUser(string username, string password)
        {
            Console.WriteLine("atemtping to log the user in");
            AmazonCognitoIdentityProviderClient provider = new AmazonCognitoIdentityProviderClient(new Amazon.Runtime.AnonymousAWSCredentials(), Region);

            CognitoUserPool pool = new CognitoUserPool(PoolID, AppClientID, provider);

            CognitoUser user = new CognitoUser(username, AppClientID, pool, provider);

            InitiateSrpAuthRequest authRequest = new InitiateSrpAuthRequest() { Password = password };
            AuthFlowResponse authResponse = null;
            try
            {
                authResponse = await user.StartWithSrpAuthAsync(authRequest).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            if (authResponse.AuthenticationResult != null)
            {
                Console.WriteLine("auth response was not null");
                ShowDashboardForm();
            }
            else
            {
                Console.WriteLine("auth response was null");
                ShowLoginRegisterForm();
            }
        }

        private void ShowLoginRegisterForm()
        {
            Console.WriteLine("Showing login regsiter form");
            Form registerForm = new Form_Register();
            registerForm.Show();
        }

        private void ShowDashboardForm()
        {
            Console.WriteLine("Showing dashboard form");
            Form dashboardForm = new Form_Dashboard();
            dashboardForm.Show();
        }

        /*
         * 
         * checks if the user has saved credentials in the saved credentials file
         * if not, then prompts the user to autenthicate
         * 
         */
        bool CheckForSavedCredentials()
        {
            if (File.Exists(Class_AppFiles.savedCredentialsHiddenFile))
            {
                StreamReader file = new StreamReader(Class_AppFiles.savedCredentialsHiddenFile);
                byte[] retrievedEncryptedUsername = Encoding.UTF8.GetBytes(file.ReadLine());
                byte[] retrievedEncryptedPassword = Encoding.UTF8.GetBytes(file.ReadLine());
                file.Close();
                if (retrievedEncryptedPassword.Length > 0 && retrievedEncryptedUsername.Length > 0)
                {
                    retrievedEncodedUsername = retrievedEncryptedUsername;
                    retrievedEncodedPassword = retrievedEncryptedPassword;
                    return true;
                }
                else return false;
            }
            else return false;
        }

        static void SaveEncryptedCredentials(byte[] encryptedUsername, byte[] encryptedPassword)
        {
            DirectoryInfo di = Directory.CreateDirectory(Class_AppFiles.savedCredentialsHiddenFolder);
            di.Attributes = FileAttributes.Directory | FileAttributes.Hidden;

            if (!File.Exists(Class_AppFiles.savedCredentialsHiddenFile))
            {
                FileStream fileStream = File.Create(Class_AppFiles.savedCredentialsHiddenFile);
                fileStream.Close();
                using (StreamWriter file = new StreamWriter(Class_AppFiles.savedCredentialsHiddenFile, false))
                {
                    file.WriteLine(Encoding.Default.GetString(encryptedUsername));
                    file.WriteLine(Encoding.Default.GetString(encryptedPassword));
                    file.Close();
                }

            }
            else
            {
                using (StreamWriter file = new StreamWriter(Class_AppFiles.savedCredentialsHiddenFile, false))
                {
                    file.WriteLine(Encoding.Default.GetString(encryptedUsername));
                    file.WriteLine(Encoding.Default.GetString(encryptedPassword));
                    file.Close();
                }
            }

        }

        void Function()
        {
            // Data to protect. Convert a string to a byte[] using Encoding.UTF8.GetBytes(). byte[] plaintext = Encoding.UTF8.GetBytes(password);

            // Generate additional entropy (will be used as the Initialization vector)
            byte[] entropy = new byte[20];
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(entropy);
            }

            //encode
            //byte[] cipherTextUsername = ProtectedData.Protect(plainTextUsername, entropy, DataProtectionScope.CurrentUser);
            //byte[] cipherTextPassword = ProtectedData.Protect(plainTextPassword, entropy, DataProtectionScope.CurrentUser);

            //save cipherTextUsername and cipherTextPassword into a hidden file or smth
            //if (saveCredentials) SaveEncryptedCredentials(cipherTextUsername, cipherTextPassword);


            //decode
            //byte[] plaintextAfterDecode = ProtectedData.Unprotect(ciphertext, entropy, DataProtectionScope.CurrentUser);
        }


    }
}
