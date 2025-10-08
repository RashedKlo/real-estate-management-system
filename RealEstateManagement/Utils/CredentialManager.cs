using System;
using System.IO;
using RealEstateManagement.Global;


namespace RealEstateManagement
{
    public static class CredentialManager
    {
        public static readonly string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "credentials.txt");

        // Save username and password
        public static void Save(CredentialUser credential)
        {
            try
            {
                File.WriteAllText(filePath, $"{credential.userName}|{credential.password}|{credential.IsRememberMe}");
            }
            catch (Exception ex)
            {
                // Handle error if needed
                Console.WriteLine("Error saving credentials: " + ex.Message);
            }
        }

        // Load username and password, returns tuple
        public static CredentialUser Load()
        {
            if (!File.Exists(filePath))
                return new CredentialUser ();

            try
            {
                string[] parts = File.ReadAllText(filePath).Split('|');
                if (parts.Length>0)
                    return new CredentialUser(parts[0], parts[1],Convert.ToBoolean(parts[2]));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading credentials: " + ex.Message);
            }

            return new CredentialUser();
        }

        // Clear saved credentials
        public static void Clear()
        {
            try
            {
                if (File.Exists(filePath))
                    File.Delete(filePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error clearing credentials: " + ex.Message);
            }
        }
    }
}
