using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace MockerUi
{
    internal class Common
    {
        private Random random = new Random();

        internal string event_GetCurrentDirectory()
        {
            return Path.GetDirectoryName(Application.ExecutablePath);
        }

        internal int event_GenerateRandomNumber(int startIndex, int endIndex) {

            int randomNumber = random.Next(startIndex, endIndex);
            return randomNumber;
        }

        internal void event_ExtractEmbeddedResource(string projectName, string fileName)
        {
            try {

                string currentDirectory = event_GetCurrentDirectory() + "\\";
                if (File.Exists(currentDirectory + "\\" + fileName)) { return; }

                string resourceFile = projectName +
                    ".Resources." +
                    fileName;

                Stream inputStream = Assembly
                    .GetExecutingAssembly()
                    .GetManifestResourceStream(resourceFile);

                Stream outputStream = File.Create(currentDirectory + fileName);

                byte[] buffer = new byte[8192];
                int bytesRead;

                while ((bytesRead = inputStream.Read(buffer, 0, buffer.Length)) > 0) {
                    outputStream.Write(buffer, 0, bytesRead);
                }

                inputStream.Close();
                outputStream.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        internal void event_ExtractEmbeddedResource(string projectName, string fileName, string filePath)
        {
            try {

                if (File.Exists(filePath)) { File.Delete(filePath); }
                string resourceFile = projectName + ".Resources." + fileName;

                Stream inputStream = Assembly
                    .GetExecutingAssembly()
                    .GetManifestResourceStream(resourceFile);

                Stream outputStream = File.Create(filePath);

                byte[] buffer = new byte[8192];
                int bytesRead;

                while ((bytesRead = inputStream.Read(buffer, 0, buffer.Length)) > 0) {
                    outputStream.Write(buffer, 0, bytesRead);
                }

                inputStream.Close();
                outputStream.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        internal ArrayList event_RetrieveFileContents(string filePath)
        {
            ArrayList fileContents = new ArrayList();

            try {

                StreamReader streamReader = new StreamReader(filePath);

                while (!streamReader.EndOfStream) {
                    fileContents.Add(streamReader.ReadLine());
                }

                streamReader.Close();
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }

            return fileContents;
        }

        internal void event_CreateDirectory(string directory)
        {
            try {
                Directory.CreateDirectory(directory);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        internal ArrayList event_GetDirectoryFileList(string directoryPath)
        {
            ArrayList fileList = new ArrayList();
            string[] fileEntries = Directory.GetFiles(directoryPath);

            foreach (string filePath in fileEntries) {

                string fileName = filePath.Substring(filePath.LastIndexOf("\\") + 1);
                fileName = fileName.Replace(".xml", "");
                fileList.Add(fileName);
            }

            return fileList;
        }

        internal void event_CreateCsvFile(string filePath, ArrayList headerList)
        {
            try {

                if (File.Exists(filePath)) { File.Delete(filePath); }
                TextWriter textWriter = File.CreateText(filePath);

                for (int headerIndex = 0; headerIndex < headerList.Count; headerIndex++) {

                    if (headerIndex > 0) { textWriter.Write(","); }
                    textWriter.Write((string)headerList[headerIndex]);
                }

                textWriter.Write(Environment.NewLine);
                textWriter.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
