using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using ObjectClass;
namespace ADOSamle
{
    internal class Program
    {
		static void Main(string[] args)
		{
			int choice;
			do
			{
				Console.WriteLine("Customer Management System");
				Console.WriteLine("1.Create Record"); ; //C-reate
				Console.WriteLine("2.Display Record");  //R-ead
				Console.WriteLine("3.Update Record");   //U-pdate
				Console.WriteLine("4.Delete Record");   //D-elete
				Console.WriteLine("5.Exit");
				Console.WriteLine("Enter your choice(1 / 2 / 3 / 4 /5)");
				choice = int.Parse(Console.ReadLine());

				switch (choice)
				{
					case 1:
						Console.WriteLine("Creating Customer Record");

						Student student = new Student();

						Console.WriteLine("Enter Student Name");
						student.Name = Console.ReadLine();

						Console.WriteLine("Enter Department Name");
						student.Department = Console.ReadLine();

						Console.WriteLine("Enter Phone Number");
						student.MobileNumber = Console.ReadLine();

						int RowsAffected = CRUD_Operations.SaveEmployee(student);

						if (RowsAffected > 0)
							Console.WriteLine("Record Inserted Successfully....");
						else
							Console.WriteLine("Record insertion not successfull");

						break;
					case 2:
						Console.WriteLine("Displaying Customer Records");
						List<Student> studentLst = CRUD_Operations.GetAllStudent();
						//Console.WriteLine("RollNumber" + "-" + "Student Name" + "Department" + "Mobile Number");
						foreach (Student stud in studentLst)
						{
							
							Console.WriteLine(stud.RollNumber.ToString() + "-" + stud.Name + stud.Department + stud.MobileNumber);
						}
						break;
					case 3:
						Console.WriteLine("Updating customer Record");
						break;
					case 4:
						Console.WriteLine("Deleting customer Record");
						break;
					case 5:
						Console.WriteLine("Thank you. Come Again");
						break;
					default:
						Console.WriteLine("Please give valid choice 1 to 5 only");
						break;
				}

				Console.ReadKey();  //Pause the execution upto keypress event..

			} while (choice >= 1 && choice < 5);
		}
	}
}
