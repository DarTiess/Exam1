using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using ListEmployer;
using System.Xml.Serialization;
using System.IO;

namespace EmployeesList
{
    class Program
    {
        static void Main(string[] args)

        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Employers>));
            
            Console.WriteLine("To Create List Empoyers Enter 1\n To Update List Enter 2");
            int tempnum = Int32.Parse(Console.ReadLine());
            List<Employers> emplor = new List<Employers>();
            Employers emp = new Employers();


            switch (tempnum) {
               
                    case 1:
            for (int i = 0; i < 4; i++)
            {
                emplor.Add(emp.CreateNew());
            }

                       
                        using (FileStream fs = new FileStream("EmpolyersList.xml", FileMode.OpenOrCreate))
                        {
                            formatter.Serialize(fs, emplor);
                            Console.WriteLine("Done List");
                        }

                        using (FileStream fs = new FileStream("EmpolyersList.xml", FileMode.OpenOrCreate))
                        {
                            List<Employers> employers = (List<Employers>)formatter.Deserialize(fs);
                            foreach (Employers em in employers)
                            {
                                Console.WriteLine(" ID - {0}, Name - {1}, Prof- {2}, Salaire - {3}", em.ID, em.Name, em.Proffession, em.Salaire);
                            }
                        }

                    break;
                case 2:
                    Console.WriteLine("Make choise");

                    int choise = Int32.Parse(Console.ReadLine()) - 1;

                    emp.UpdateOne();
                    break;
               
                    

          

            }
            }
}
          
          
               

            }




  
/*Необходимо разработать программу для учета сотрудников с использованием средств ООП.
Программа должна содержать следующую логику.
1. Все данные о сотруднике должны лежать в отдеьном XML файле.

2. При изменении сотрудника, необходимо создавать XML файл с Уникальным ID данного сотрудника
2.2. При редактировании карточкисотрудника, должен открываться XML файл и производиться редактирование текущего файла.

3.Список всех сотрудников, должен находиться в отдельном XML файле и содержать следующие поля:
	- ID сотрудника
	- ФИО
	- Должность
	- и прочие основные поля, на выбор, но не более 6 полей

4. Все данные в карточке сотрудника, которые беруться со справочников, должны быть связанны по их уникальному ID

5. Список всех справочников, так же должен храниться в XML файлах, у каждого знаения в справочнике должно быть уникальное ID.

Программа должна реализовать следующие функции:
1. отображение списка всех сотрудников;
2. прием на работу нового сотрудника;
3. увольнение сотрудника;
4. поиск сотрудника по имени;
5. отображение статистики (кол-во сотрудников, средняя зарплата и т.д.)

Справочники. Необходимо создать следующие справочники:

1. Должностей
2. Филиалов
3. Список доступы
4. Доступы у пользователей

По справочникам необходимо реализовать следующие функции:
1.Создание значения в справочнике

2. Редактировании значения справочника

3. Удаление значения в справочнике.
Доступ. Для того что бы пользователь мог производить редактирование/добавление/удаление, у пользователей системы должны быть соответствующие права. Необходимо создать механизм авторизации пользователя с указанием login и password пользователя.
История. Так же при любом изменении в карточке сотрудника необходимо предусмотреть систему легирования всех действий текущего пользователя, что изменил, у кого изменил, на что изменил.

    Общие требования к проекту:
1.	В качестве БД использовать XML файлы. 

2.	Каждый модуль должен быть отдельной библиотекой, ничем не связанной между собой.

3.	В случае создания машины/останова/пользователя и т.д. должно происходить редактирование XML файла, в случае отсутствия данного файла создание.

4.	В проекте должны быть использованы следующий функционал ООП:

a.	Наследование
b.	Интерфейсы
c.	Свойства
d.	Возможно Делегаты
e.	Коллекции
f.	Выбрать где использовать структуры где классы
g.	Обработка исключений
*/
