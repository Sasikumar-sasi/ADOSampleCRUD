using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectClass;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DataAccessLayer
{
    public class CRUD_Operations
    {
        //"x=10;y=20;z=30"
        //static string ConnectionStringInformation = @"Data Source=DESKTOP-7QINIDU\SQLEXPRESS;Initial Catalog=StudentADO;Integrated Security=True;";
        static string ConnectionStringInformation
           = ConfigurationManager.ConnectionStrings["StudentDBString"].ConnectionString;
        public static int SaveEmployee(Student student)
        {
            //Step1
            SqlConnection con;
            con = new SqlConnection(ConnectionStringInformation);
            con.Open();

            //Step2
            SqlCommand cmd;
            cmd = new SqlCommand("spSaveEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd = new SqlCommand("insert into  Student values(@Name,@Department,@MobileNumber)", con);
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
                
                con.Open();

                SqlCommand cmd;
                //cmd = new SqlCommand("select * from Student order by Name", con);
                cmd = new SqlCommand("spGetAllStudent", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //Step3
                SqlDataReader dr = cmd.ExecuteReader();

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

        public static int UpdateStudent(Student student)
        {
            using (SqlConnection con = new SqlConnection(ConnectionStringInformation))
            {
                con.Open();
                SqlCommand com;
                //com = new SqlCommand("update student set Name=@Name , Department = @Department,MobileNumber = @MobileNumber where RollNumber =@RollNumber");
                com = new SqlCommand("spUpdateStudent", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Name", student.Name);
                com.Parameters.AddWithValue("@Department", student.Department);
                com.Parameters.AddWithValue("@MobileNumber", student.MobileNumber);
                com.Parameters.AddWithValue("@RollNumber", student.RollNumber);
                int RowAffected = com.ExecuteNonQuery();
                return RowAffected;
            }
        }

        public static Student GetBasedOnRollNumber(int RollNumber)
        {
            using (SqlConnection con = new SqlConnection(ConnectionStringInformation))
            {
                con.Open();
                SqlCommand com;
                //com = new SqlCommand("select * from student where RollNumber=@Roll");
                com = new SqlCommand("spGetBasedOnRollNumber", con);
                com.CommandType = CommandType.StoredProcedure; 
                com.Parameters.AddWithValue("@RollNumber", RollNumber);
                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read()) //1.Moves the pointer first record very first time. Moves the pointer to next record in following iterations
                {                 //2.Returns true if record exists or returns fales if no record
                    return new Student()
                    {
                        RollNumber = Convert.ToInt32(dr["RollNumber"]),
                        Name = dr["Name"].ToString(),
                        Department = dr["Department"].ToString(),
                        MobileNumber = dr["MobileNumber"].ToString()
                    };
                }
                return null;
            }
        }
        public static int DeleteStudent(int Roll)
        {
            using (SqlConnection con = new SqlConnection(ConnectionStringInformation))
            {
                con.Open();
                SqlCommand com;
                //com = new SqlCommand("delete student where RollNumber=@RollNumber",con);
                com = new SqlCommand("spDeleteStudent", con);
                com.CommandType = CommandType.StoredProcedure;

                com.Parameters.AddWithValue("@RollNumber", Roll);
                int RowAffected = com.ExecuteNonQuery();
                return RowAffected;
            }
        }

        public static int CountStudent()
        {
            using (SqlConnection con = new SqlConnection(ConnectionStringInformation))
            {
                con.Open();
                SqlCommand cmd;
                cmd = new SqlCommand("select count(RollNumber) from student", con);
                Object c = cmd.ExecuteScalar();
                int count = Convert.ToInt32(c);
                return count;
            }
        }
    }
}
