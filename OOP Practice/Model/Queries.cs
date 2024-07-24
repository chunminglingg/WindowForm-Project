using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice.Model
{
    internal class Queries
    {
        // Queries 
        public string student_all = "SELECT " +
                                 "[student_code] as 'Student Code' ," +
                                 "[first_name] as 'First Name' ," +
                                 "[last_name] as 'Last Name' ," +
                                 "[dob] as 'Date of Birth' ," +
                                 "[groups] as ' Group' ," +
                                 "[promote] as 'Promote' ," +
                                 "[field] as 'Field' ," +
                                 "[year_study] as 'Year Study' ," +
                                 "[phone] as 'Phone' ," +
                                 "[email] as 'Email' ," +
                                 "[address] as 'Address' " +
                                 "FROM tbl_student";

        public string class_all = "SELECT " +
                                  "name as 'Class Name' ," +
                                  "floor as 'Floor' ," +
                                  "des as 'Description' " +
                                  "FROM tbl_class;";

        // db command
        public string db_command;
        public string db_execute;
    }
}
