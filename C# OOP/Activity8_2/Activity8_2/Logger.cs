using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Threading;
//using System.Threading.Tasks;

namespace Activity8_2
{
    class Logger
    {
        public static string LogWrite(string logPath, string logInfo)
        {

            try
            {
                using (FileStream oFileStream = new FileStream(logPath, FileMode.Open, FileAccess.Write))
                {
                    using (StreamWriter oStreamWriter = new StreamWriter(oFileStream))
                    {
                        oFileStream.Seek(0, SeekOrigin.End);
                        oStreamWriter.WriteLine(DateTime.Now);
                        oStreamWriter.WriteLine(logInfo);
                        oStreamWriter.WriteLine();
                    }
                }
                return "Info Logged";
            }
            catch (FileNotFoundException ex)
            {
                return "FileNotFoundException: " + ex.Message;
            }
            catch (IOException ex)
            {
                return ex.Message;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static string LogRead(string filePath)
        {
            StreamReader oStreamReader;
            string fileText;

            try
            {
                oStreamReader = File.OpenText(filePath);
                fileText = oStreamReader.ReadToEnd();
                oStreamReader.Close();
                Thread.Sleep(5000);
                return fileText;
            }
            catch (FileNotFoundException ex)
            {
                return "FNFE: " + ex.Message;
            }
            catch (IOException ex)
            {
                return "IOE: " + ex.Message;
            }
            catch
            {
                return "Logging failed";
            }
        }

        public static async Task<string> LogReadAsync(string filePath)
        {
            string fileText;
            try
            {
                using (StreamReader oStreamReader = new StreamReader(filePath))
                {
                    fileText = await oStreamReader.ReadToEndAsync();
                }
                await Task.Delay(10000);
                return fileText;
            }
            catch (FileNotFoundException ex)
            {
                return "FNFE: " + ex.Message;
            }
            catch (IOException ex)
            {
                return "IOE: " + ex.Message;
            }
            catch
            {
                return "Logging failed";
            }

        }


    }
}
