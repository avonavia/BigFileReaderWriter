namespace BigFIleReaderWriter16042023
{
    class Program
    {
        static void Main()
        {
            const string path0 = @"..\test1.txt"; //2 mb | ~time: 0.27 sec 

            const string writingPath = @"C:\Users\nyanp\Desktop\test.txt";

            FileReaderWriter.ReadWriteFile(path0, writingPath);
        }
    }
}
