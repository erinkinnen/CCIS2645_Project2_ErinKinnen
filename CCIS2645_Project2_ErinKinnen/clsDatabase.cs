using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace CCIS2645_Project2_ErinKinnen
{
    public class clsDatabase
    {
        //Acquire Connection()
        private static SqlConnection AcquireConnection()
        {
            SqlConnection cnSQL = null;
            Boolean blnErrorOccurred = false;

            if (ConfigurationManager.ConnectionStrings["ServiceCenter"] != null)
            {
                cnSQL = new SqlConnection();
                cnSQL.ConnectionString = ConfigurationManager.ConnectionStrings["ServiceCenter"].ToString();

                try
                {
                    cnSQL.Open();
                }
                catch (Exception ex)
                {
                    blnErrorOccurred = true;
                    cnSQL.Dispose();
                }
            }

            if (blnErrorOccurred)
            {
                return null;
            }
            else
            {
                return cnSQL;
            }
        }

        public static DataSet GetProductByID(string strProdID)
        {
            SqlConnection cnSQL;
            SqlCommand cmdSQL;
            SqlDataAdapter daSQL;
            DataSet dsSQL = null;
            Boolean blnErrorOccurred = false;
            Int32 intRetCode;

            if (strProdID.Trim().Length > 0)
            {
                cnSQL = AcquireConnection();
                if(cnSQL == null)
                {
                    blnErrorOccurred = true;
                }
                else
                {
                    cmdSQL = new SqlCommand();
                    cmdSQL.Connection = cnSQL;
                    cmdSQL.CommandType = CommandType.StoredProcedure;
                    cmdSQL.CommandText = "uspGetProductByID";

                    cmdSQL.Parameters.Add(new SqlParameter("@ProductID", SqlDbType.NVarChar, 10));
                    cmdSQL.Parameters["@ProductID"].Direction = ParameterDirection.Input;
                    cmdSQL.Parameters["@ProductID"].Value = strProdID;

                    cmdSQL.Parameters.Add(new SqlParameter("@ErrCode", SqlDbType.Int));
                    cmdSQL.Parameters["ErrCode"].Direction = ParameterDirection.ReturnValue;

                    dsSQL = new DataSet();
                    try
                    {
                        daSQL = new SqlDataAdapter(cmdSQL);
                        intRetCode = daSQL.Fill(dsSQL);
                        daSQL.Dispose();
                    }
                    catch (Exception ex)
                    {
                        blnErrorOccurred = true;
                        dsSQL.Dispose();
                    }
                    finally
                    {
                        cmdSQL.Parameters.Clear();
                        cmdSQL.Dispose();
                        cnSQL.Close();
                        cnSQL.Dispose();
                    }
                }
            }
        }
    }
}