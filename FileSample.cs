using System.Text;

namespace FileSample
{
    class FileSample
    {



        void testFile()
        {
            string filePath = @"D:\TestDir\TestFile.txt";
            //use File class
            Console.WriteLine(File.GetAttributes(filePath));
            File.SetAttributes(filePath, FileAttributes.Hidden | FileAttributes.ReadOnly);
            Console.WriteLine(File.GetAttributes(filePath));

            //user FilInfo class
            FileInfo fi = new FileInfo(filePath);
            Console.WriteLine(fi.Attributes.ToString());
            fi.Attributes = FileAttributes.Hidden | FileAttributes.ReadOnly; //隐藏与只读
            Console.WriteLine(fi.Attributes.ToString());

            //只读与系统属性，删除时会提示拒绝访问
            fi.Attributes = FileAttributes.Archive;
            Console.WriteLine(fi.Attributes.ToString());


            string dirPath = @"D:\TestDir";

            Console.WriteLine("<<<<<<<<<<<{0}>>>>>>>>>>", "文件路径");
            //获得当前路径
            Console.WriteLine(Environment.CurrentDirectory);
            //文件或文件夹所在目录
            Console.WriteLine(Path.GetDirectoryName(filePath));     //D:\TestDir
            Console.WriteLine(Path.GetDirectoryName(dirPath));      //D:\
            //文件扩展名.txt
            Console.WriteLine(Path.GetExtension(filePath));         
            //文件名
            Console.WriteLine(Path.GetFileName(filePath));          //TestFile.txt
            Console.WriteLine(Path.GetFileName(dirPath));           //TestDir
            Console.WriteLine(Path.GetFileNameWithoutExtension(filePath)); //TestFile
            //绝对路径
            Console.WriteLine(Path.GetFullPath(filePath));          //D:\TestDir\TestFile.txt
            Console.WriteLine(Path.GetFullPath(dirPath));           //D:\TestDir  
            //更改扩展名
            Console.WriteLine(Path.ChangeExtension(filePath, ".jpg"));//D:\TestDir\TestFile.jpg
            //根目录
            Console.WriteLine(Path.GetPathRoot(dirPath));//D:\      
            //生成路径  //D:\BaseDir\SubDir\TestFile.txt
            Console.WriteLine(Path.Combine(new string[] { @"D:\", "BaseDir", "SubDir", "TestFile.txt" })); 
            //生成随即文件夹名或文件名
            Console.WriteLine(Path.GetRandomFileName());
            //创建磁盘上唯一命名的零字节的临时文件并返回该文件的完整路径
            Console.WriteLine(Path.GetTempFileName());
            //返回当前系统的临时文件夹的路径
            Console.WriteLine(Path.GetTempPath());
            //文件名中无效字符
            Console.WriteLine(Path.GetInvalidFileNameChars());
            //路径中无效字符
            Console.WriteLine(Path.GetInvalidPathChars());


        }
        void readFile()
        {
            try
            {
                // 创建一个 StreamReader 的实例来读取文件 
                // using 语句也能关闭 StreamReader
                using (StreamReader sr = new StreamReader("c:/jamaica.txt", Encoding.UTF8))
                {
                    string line;
                    // 从文件读取并显示行，直到文件的末尾 
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                // 向用户显示出错消息
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }


        void writeFile()
        {
            string[] names = new string[] { "Zara Ali", "Nuha Ali" };
            using (StreamWriter sw = new StreamWriter("names.txt"))
            {
                foreach (string s in names)
                {
                    sw.WriteLine(s);

                }
            }

            // 从文件中读取并显示每行
            string line = "";
            using (StreamReader sr = new StreamReader("names.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            Console.ReadKey();
        }
    }
}
