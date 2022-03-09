using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectClass;
using System.Data.SqlClient;
namespace DataAccessLayer
{
    public class CRUD_Operations
    {
        //"x=10;y=20;z=30"
        static string ConnectionStringInformation = @"Data Source=DESKTOP-7QINIDU\SQLEXPRESS;Initial Catalog=StudentADO;Integrated Security=True;";

        public static int SaveEmployee(Student student)
        {
            //Step1
            SqlConnection con;
            con = new SqlConnection(ConnectionStringInformation);
            con.Open();

            //Step2
            SqlCommand cmd;
            cmd = new SqlCommand("insert into  Student values(@Name,@Department,@MobileNumber)", con);
            cmd.Parameters.AddWithValue("@Name", student.Name);
            cmd.Parameters.AddWithValue("@Department", student.Department);
            cmd.Parameters.AddWithValue("@MobileNumber", student.MobileNumber);

            //Step3
            int rowsAffected = cmd.ExecuteNonQuery();

            //step4
            cmd.Dispose();
            con.Close();

            //Step5
            return rowsAffected;
        }

        public static List<Student> GetAllStudent()
        {

            using (SqlConnection con = new SqlConnection(ConnectionStringInformation))
            {
                //Step1
                con.Open();

                //Step2
                SqlCommand cmd;
                cmd = new SqlCommand("select * from Student order by Name", con);

                //Step3
                SqlDataReader dr = cmd.ExecuteReader();

                //x = 1;
                //while(x<=10) //if cond satisfies returns true otherwise false
                //{             //Relations expressions are returning boolean value
                //    x++;      
                //}

                //Step4
                //List<int> marks = new List<int>();
                //List<string> studentnames = new List<string>();
                List<Student> student = new List<Student>();

                while (dr.Read()) //1.Moves the pointer first record very first time. Moves the pointer to next record in following iterations
                {                 //2.Returns true if record exists or returns fales if no record
                    Student stud = new Student()
                    {
                        RollNumber = Convert.ToInt32(dr["RollNumber"]),
                        Name = dr["Name"].ToString(),
                        Department = dr["Department"].ToString(),
                        MobileNumber = dr["MobileNumber"].ToString()
                    };

                    student.Add(stud); //Sivabala obj, suriyaa obj, vikash object

                } //while

                //Step5
                return student;

            } //using

        } //GetAllCustomers
    }
}
