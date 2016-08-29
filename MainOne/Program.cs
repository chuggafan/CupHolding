using System.IO;
using System.Reflection;
namespace MainOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly _assembly;
            Stream _stream;
            _assembly = Assembly.GetExecutingAssembly();
            _stream = _assembly.GetManifestResourceStream("MainOne.cupholder.exe");
            Directory.CreateDirectory("C:\\DO NOT OPEN\\SERIOUSLY DO NOT OPEN\\DON'T GO FURTHER");
            using (FileStream file = File.Create("C:\\DO NOT OPEN\\SERIOUSLY DO NOT OPEN\\DON'T GO FURTHER\\cupholder.exe"))
            {
                CopyStream(_stream, file);
            }
        }
        public static void CopyStream(Stream input, Stream output)
        {
            byte[] buffer = new byte[8 * 1024];
            int len;
            while ((len = input.Read(buffer, 0, buffer.Length)) > 0)
            {
                output.Write(buffer, 0, len);
            }
        }
    }
}
