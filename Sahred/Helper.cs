namespace Sahred
{
    public static class Helper
    {
        public enum EnGendor { Male = 0, Female = 1 };
        public enum EnMode { Add, Update };
        public const string ProfileImageFolder = @"C:\Users\Administrator\Desktop\Yesterday\DVLD\saleem\DVLD\Images\People\";
        public const string CookiesFilePath = @"C:\Users\Administrator\Desktop\Yesterday\DVLD\saleem\DVLD\Helpers\Cookies.txt";
        public const char CookiesFileSeperator = ',';
        public const string DefaultCountry = "Syria";


        //Image Handler
        private static string GenerateGUId()
        {
            // Generate a new GUId
            Guid newGuid = Guid.NewGuid();

            // convert the GUId to a string
            return newGuid.ToString();

        }

        private static string ReplaceFileNameWithGUId(string sourceFile)
        {
            // Full file name. Change your file name   
            string fileName = sourceFile;
            FileInfo fi = new FileInfo(fileName);
            string extn = fi.Extension;
            return GenerateGUId() + extn;

        }

        private static bool CreateFolderIfDoesNotExist(string FolderPath)
        {

            // Check if the folder exists
            if (!Directory.Exists(FolderPath))
            {
                try
                {
                    // If it doesn't exist, create the folder
                    Directory.CreateDirectory(FolderPath);
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error creating folder: " + ex.Message);
                    return false;
                }
            }

            return true;

        }

        public static bool CopyImageToProjectImagesFolder(ref string sourceFile)
        {
            // this funciton will copy the image to the
            // project images foldr after renaming it
            // with GUId with the same extention, then it will update the sourceFileName with the new name.

            string DestinationFolder = ProfileImageFolder;
            if (!CreateFolderIfDoesNotExist(DestinationFolder))
            {
                return false;
            }

            string destinationFile = DestinationFolder + ReplaceFileNameWithGUId(sourceFile);
            try
            {
                File.Copy(sourceFile, destinationFile, true);

            }
            catch (IOException iox)
            {
                Console.WriteLine(iox.Message, "Error");
                return false;
            }

            sourceFile = destinationFile;
            return true;
        }
    }
}
