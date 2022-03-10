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
				Console.WriteLine("Student  Management System");
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
						Console.WriteLine("Creating Student Record");

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
						Console.WriteLine("Displaying Student Records");
						List<Student> studentLst = CRUD_Operations.GetAllStudent();
						//Console.WriteLine("RollNumber" + "-" + "Student Name" + "Department" + "Mobile Number");
						foreach (Student stud in studentLst)
						{
							
							Console.WriteLine(stud.RollNumber.ToString() + "-" + stud.Name + stud.Department + stud.MobileNumber);
						}
						break;
					case 3:
						Console.WriteLine("Updating Student Record");
						List<Student> studentLstUpdate = CRUD_Operations.GetAllStudent();
						//Console.WriteLine("RollNumber" + "-" + "Student Name" + "Department" + "Mobile Number");
						foreach (Student stud in studentLstUpdate)
						{

							Console.WriteLine(stud.RollNumber.ToString() + "-" + stud.Name + stud.Department + stud.MobileNumber);
						}
						Console.WriteLine("Which Record want to update");
						
						Student student1 = new Student();
						student1.RollNumber = int.Parse(Console.ReadLine());
						Console.WriteLine("Enter Student Name");
						student1.Name = Console.ReadLine();

						Console.WriteLine("Enter Department Name");
						student1.Department = Console.ReadLine();

						Console.WriteLine("Enter Phone Number");
						student1.MobileNumber = Console.ReadLine();
						int RA = CRUD_Operations.SaveEmployee(student1);

						if (RA > 0)
							Console.WriteLine("Record Updated Successfully....");
						else
							Console.WriteLine("Record Updated not successfull");

						break;
					case 4:
						Console.WriteLine("Deleting Student Record");
						List<Student> studentLstDelete = CRUD_Operations.GetAllStudent();
						//Console.WriteLine("RollNumber" + "-" + "Student Name" + "Department" + "Mobile Number");
						foreach (Student stud in studentLstDelete)
						{

							Console.WriteLine(stud.RollNumber.ToString() + "-" + stud.Name + stud.Department + stud.MobileNumber);
						}
						Console.WriteLine("Enter Which student want to delete");
						int Roll = int.Parse(Console.ReadLine());
						int DeleteRA = CRUD_Operations.DeleteStudent(Roll);
						if (DeleteRA > 0)
							Console.WriteLine("Record Deleted Successfully....");
						else
							Console.WriteLine("Record Deleted not successfull");
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
