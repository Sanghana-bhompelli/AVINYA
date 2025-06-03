using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace AVINYALIB.Models
{
    public class TransactionModelClass
    {
        public List<TransactionModel> GetAllTransactions()

        {
            List<TransactionModel> LstTransactionModels = new List<TransactionModel>();

            //LOGIC

            string strConnectionstring = "Data Source=LENOVO;Initial Catalog=AVINYA;Integrated Security=True;Trust Server Certificate=True";
            SqlConnection objsqlConnection = new SqlConnection();
            objsqlConnection.ConnectionString = strConnectionstring;

            objsqlConnection.Open();


            string strCommand = "GetAllTransactions";
            SqlCommand objsqlCommand = new SqlCommand(strCommand, objsqlConnection);
            objsqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

            SqlDataReader dataReader = objsqlCommand.ExecuteReader();

            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    TransactionModel objTransactionModel = new TransactionModel();

                    objTransactionModel.TransactionId = Convert.ToInt32(dataReader["TransactionId"]);
                    objTransactionModel.FromAccountId = Convert.ToString(dataReader["FromAccountId"]);
                    objTransactionModel.ToAccountId = Convert.ToString(dataReader["ToAccountId"]);
                    objTransactionModel.Amount = Convert.ToString(dataReader["Amount"]);
                    objTransactionModel.Date = Convert.ToString(dataReader["Date"]);
                    objTransactionModel.Status=Convert.ToString(dataReader["Status"]);

                    LstTransactionModels.Add(objTransactionModel);
                }
            }

            return LstTransactionModels;

        }
    }
}
