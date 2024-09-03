using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SchoolManagementSystem
{
    class AddTeachersData
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sudes\OneDrive\Documents\school.mdf;Integrated Security=True;Connect Timeout=30");
        public int ID { set; get; }
        public string teacherID { set; get; }
        public string teacherName { set; get; }
        public string teacherGender { set; get; }
        public string teacherAddress { set; get; }
        public string teacherImage { set; get; }
        public string status { set; get; }
        public string DateInsert { set; get; }

        public List<AddTeachersData> teachersData()
        {
            List<AddTeachersData> listData = new List<AddTeachersData>();
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string sql = "SELECT * FROM teachers WHERE date_delete IS NULL";

                    using(SqlCommand cmd = new SqlCommand(sql, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            AddTeachersData addTD = new AddTeachersData();
                            addTD.ID = (int)reader["id"];
                            addTD.teacherID = reader["teacher_id"].ToString();
                            addTD.teacherName = reader["teacher_name"].ToString();
                            addTD.teacherGender = reader["teacher_gender"].ToString();
                            addTD. teacherAddress = reader["teacher_address"].ToString();
                            addTD.teacherImage = reader["teacher_image"].ToString();
                            addTD.status = reader["teacher_status"].ToString();
                            addTD.DateInsert = reader["date_insert"].ToString();

                            listData.Add(addTD);

                        }
                        reader.Close();
                    }
                    
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Error connecting Database: " + ex);
                   
                }
                finally
                {
                    connect.Close();
                }

            }

            return listData;
        }
       
    }
}
