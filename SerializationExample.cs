using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace serialization
{

    [Serializable]
    public class Student
    {
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(Student));
        public int rollno;
        public string name;
        public Student(int rollno, string name)
        {
            log.Info("Creating constructor");
            this.rollno = rollno;
            this.name = name;
        }

    }


class SerializationExample
  {
    log4net.ILog log = log4net.LogManager.GetLogger(typeof(SerializationExample));


        public void WriteDataInToFile()
        {

        try
        {
            log.Info("We are writing Rollno and name into file system");
            FileStream stream = new FileStream("F:\\fileIO\\abc.txt", FileMode.OpenOrCreate);
            BinaryFormatter formated = new BinaryFormatter();
            Student s = new Student(101, "Ankit Chanrdra");
            formated.Serialize(stream, s);
            stream.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }


    public void ReadDataInToFile()
    {

        try
        {
            FileStream stream = new FileStream("F:\\fileIO\\abc.txt", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();

            Student s = (Student)formatter.Deserialize(stream);
            Console.WriteLine("Rollno: " + s.rollno);
            Console.WriteLine("Name: " + s.name);

            stream.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }


 static void Main(string[] args)
        {
            log4net.Config.BasicConfigurator.Configure();
            SerializationExample obj = new SerializationExample();
            obj.WriteDataInToFile();
            obj.ReadDataInToFile();
            Console.Read();
        }

    }
}
