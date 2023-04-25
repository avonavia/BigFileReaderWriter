using System.IO;
using System;

namespace BigFIleReaderWriter16042023
{
    public class FileReaderWriter
    {
        public static void ReadWriteFile(string readFilePath, string writeFilePath)
        {
            try
            {
                var startTime = System.Diagnostics.Stopwatch.StartNew();
                StreamReader reader = new StreamReader(File.OpenRead(readFilePath));
                StreamWriter writer = new StreamWriter(File.OpenWrite(writeFilePath));
                long bytesTotal = 0;

                while (reader.Peek() >= 0)
                {
                    char[] readBuffer = new char[4096];
                    bytesTotal += reader.ReadBlock(readBuffer, 0, readBuffer.Length);
                    writer.Write(readBuffer);
                }
                startTime.Stop();
                var resultTime = startTime.Elapsed;
                string elapsedTime = string.Format("{0:00}:{1:00}:{2:00}", resultTime.Minutes, resultTime.Seconds, resultTime.Milliseconds);
                reader.Close();

                Console.WriteLine($"Finished in {elapsedTime}");
                Console.WriteLine($"Read {bytesTotal} bytes from file: {readFilePath}");
                Console.WriteLine($"Wrote {new FileInfo(writeFilePath).Length} bytes to file: {writeFilePath}");
            }
            catch(Exception Error)
            {
                Console.WriteLine($"Error: {Error.Message}");
            }
        }
    }
}

