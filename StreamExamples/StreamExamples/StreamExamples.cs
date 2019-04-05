using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamExamples
{
    public class StreamExamples
    {

        public static void FileExample()
        {
            const string testPath01 = "d:\\test.txt";
            if (!File.Exists(testPath01))
            {

                FileStream test1 = File.Create(testPath01);
            }
            const string testPath02 = "d:\\testWithBuffer.txt";
            if (!File.Exists(testPath02))
            {
                FileStream test2 = File.Create(testPath02, sizeof(int) * 100, FileOptions.Encrypted | FileOptions.Asynchronous);
                test2.Flush();
                try
                {
                    StreamWriter sw = File.CreateText(testPath02);
                    //using (StreamWriter sw = File.CreateText(testPath02))
                    {

                        try
                        {
                            sw.Write("test text");
                            throw new ArgumentException();
                        }
                        catch (IndexOutOfRangeException e)
                        {

                        }
                    }
                }catch(Exception e)
                {

                }
                using (StreamWriter sw = File.CreateText(testPath02))
                {

                }


            }
            FileInfo fileInfoTest1 = new FileInfo(testPath01);
            if (fileInfoTest1.Exists) 
            {
                var sw = fileInfoTest1.Create();
                sw.Close();
            }

            DriveInfo di = new DriveInfo("C");
            var freeSpace = di.TotalFreeSpace;

        }

    }
}
