namespace BigFIleReaderWriter16042023
{
    class Program
    {
        static void Main()
        {
            const string path0 = @"..\test1.txt"; //2 mb | ~time: 0.27 sec 
            const string path1 = @"C:\Program Files (x86)\Steam\steamapps\common\Super Auto Pets\UnityPlayer.dll"; //27~ mb | ~time: 0.909 sec
            const string path2 = @"C:\Games\BloonsTD6\TD6_batch-35.2-release.6313_release.zip"; //2~ gb | ~time: 50.503 sec
            const string path3 = @"C:\Users\nyanp\Downloads\Downlds\ru_windows_10_pro_64bit.iso"; //4~ gb | ~time: 2.52 min
            const string path4 = @"C:\Users\nyanp\VirtualBox VMs\Windows 10\Windows 10.vdi"; //10~ gb | ~time: 4.47 min

            const string writingPath = @"C:\Users\nyanp\Desktop\test.txt";

            FileReaderWriter.ReadWriteFile(path1, writingPath);
        }
    }
}
