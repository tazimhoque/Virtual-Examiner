using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChildHaven
{
    class makeSolve
    {

        public static void makeSolveStatus()
        {


            try
            {

                // step 1: Create a connection

                var result = Path.GetFullPath("InformationDatabase.mdf");
                string strConnection = "Data Source=.\\sqlexpress;AttachDbFilename=" + result + ";User Instance=true;Integrated Security=True;Pooling=False;MultipleActiveResultSets=True";
                SqlConnection objConnection = new SqlConnection(strConnection);
                objConnection.Open();

                // step 2: fire a command
                string username = UserInformation.getUserName();
                int questionno = UserInformation.getQuestionNo();
               // MessageBox.Show("QSN: "+questionno.ToString());
                string strCommand = "select userID, QSN from Solve where userID=@UI and QSN=@QN";
                SqlCommand objCommand = new SqlCommand(strCommand, objConnection);

                objCommand.Parameters.Add(new SqlParameter("@UI", username));
                objCommand.Parameters.Add(new SqlParameter("@QN", questionno));


                // step 3: bind the result data with user interface

                SqlDataReader reader = objCommand.ExecuteReader();


                if (reader.Read())
                {
                    

                }
                else
                {
                    string strCommand1 = "insert into Solve values( @userID , @QSN, @Status)";
                    SqlCommand objCommand1 = new SqlCommand(strCommand1, objConnection);
                    objCommand1.Parameters.Add(new SqlParameter("@userID", username));
                    objCommand1.Parameters.Add(new SqlParameter("@QSN", questionno));
                    objCommand1.Parameters.Add(new SqlParameter("@Status", "Solved"));
                    objCommand1.ExecuteNonQuery();

                }



                reader.Close();
                objConnection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error in making Solved! Error: "+ex.Message);
            }





        }





    }
}
