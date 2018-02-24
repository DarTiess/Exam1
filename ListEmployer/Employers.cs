using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ListEmployer
{
    [Serializable]
   public class Employers
    {
        /* 3.Список всех сотрудников, должен находиться в отдельном XML файле и содержать следующие поля:
     - ID сотрудника
     - ФИО
     - Должность
     - и прочие основные поля, на выбор, но не более 6 полей*/
       static int IDem = 0;
     public int ID { get; set; }
     public string Name { get; set; }
     public string Proffession { get; set; }
    
        public int Salaire { get; set; }
        public Employers(string Name, string Proffession,  int Salaire)
        {
           
            this.Name = Name;
            this.Proffession = Proffession;
            this.Salaire = Salaire;
        }

        public Employers()
        {
        }

     
       
       
        public Employers CreateNew()
        {
          
            Employers obj = new Employers();
           
            IDem++;
            obj.ID = IDem;
            Console.WriteLine("Name ");
            
            obj.Name = Console.ReadLine();
            
            Console.WriteLine("Proffession");
            obj.Proffession = Console.ReadLine();
            Console.WriteLine("Salaire ");
            obj.Salaire = Int32.Parse(Console.ReadLine());

            XmlSerializer formatter = new XmlSerializer(typeof(Employers));
            using (FileStream fs = new FileStream("Empolyers_" +obj.ID+".xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, obj);
                Console.WriteLine("Done empo");
            }

            return obj;
        }
      

        public Employers UpdateOne()
        {
            Employers em = new Employers();
            XmlSerializer formatter = new XmlSerializer(typeof(Employers));



            Console.WriteLine("New Name ");

            em.Name = Console.ReadLine();

            Console.WriteLine("Proffession");
            em.Proffession = Console.ReadLine();
            Console.WriteLine("Salaire ");
            em.Salaire = Int32.Parse(Console.ReadLine());

           
            using (FileStream fs = new FileStream("Empolyers_" + em.ID + ".xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, em);
                Console.WriteLine("Done empo");
            }

            return em;

        }

        public void FindeInfo(int num)
        {
            

        }

    }
}
