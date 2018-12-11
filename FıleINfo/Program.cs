using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FıleInfo
{
    class FıleInfoTest
    {
        static void Main()
        {
            FileInfo NewFile = new FileInfo(@"C:\Test\HedefDizini\NewFile.txt");
            if (NewFile.Exists)
            {
                //dosya silme islemi
                NewFile.Delete();// file sınıfı:File.CreateText(@"C:\Test\NewFile.txt")
            }
            //dosya oluşturma
            NewFile.CreateText();  //file sınıfı:File.CreateText(@"C:\Test\NewFile.txt")
            Console.WriteLine("olusturulma tarihi : " + NewFile.CreationTime);
            Console.WriteLine("son erisim tarihi : " + NewFile.LastAccessTime);
            Console.WriteLine("son degistirme tarihi : " + NewFile.LastWriteTime);
            Console.WriteLine("bulundugu dizinin adı : " + NewFile.DirectoryName);
            Console.WriteLine("dosyanın adı : " + NewFile.Name);
            Console.WriteLine("dosyanın tam  adı : " + NewFile.FullName);
            Console.WriteLine("dosyanın uzantısı : " + NewFile.Extension);
            NewFile.CopyTo(@"C:\Test\nt.txt");
            Console.ReadKey();
        }


    }
}
