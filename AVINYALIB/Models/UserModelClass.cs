using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace AVINYALIB.Models
{
    public class UserModelClass
    {
        public List<UserModel> GetAllUsers()

        {
            List<UserModel> LstUserModels = new List<UserModel>();

            //LOGIC

            string strConnectionstring = "Data Source=LENOVO;Initial Catalog=AVINYA;Integrated Security=True;Trust Server Certificate=True";
            SqlConnection objsqlConnection = new SqlConnection();
            objsqlConnection.ConnectionString = strConnectionstring;

            objsqlConnection.Open();


            string strCommand = "GetAllUsers";
            SqlCommand objsqlCommand = new SqlCommand(strCommand, objsqlConnection);
            objsqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

            SqlDataReader dataReader = objsqlCommand.ExecuteReader();

            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    UserModel objUserModel = new UserModel();

                    objUserModel.UserId = Convert.ToInt32(dataReader["UserId"]);
                    objUserModel.Name = Convert.ToString(dataReader["Name"]);
                    objUserModel.Email = Convert.ToString(dataReader["Email"]);
                    objUserModel.Password = Convert.ToString(dataReader["Password"]);
                    objUserModel.Role = Convert.ToString(dataReader["Role"]);

                    LstUserModels.Add(objUserModel);
                }
            }

            return LstUserModels;

        }
    }
}
