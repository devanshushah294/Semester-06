using APIDemo.Models;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data;
using System.Data.Common;

namespace APIDemo.DAL
{
    public class Person_DALBase : DAL_Helper
    {
        #region API_Person_SelectAll
        public List<PersonModel> API_Person_SelectAll()
        {
            try
            {
                List<PersonModel> list = new List<PersonModel>();
                SqlDatabase db = new SqlDatabase(connStr);
                DbCommand cmd = db.GetStoredProcCommand("API_Person_SelectAll");
                using (IDataReader reader = db.ExecuteReader(cmd))
                {
                    while (reader.Read())
                    {
                        PersonModel model = new PersonModel();
                        model.PersonID = Convert.ToInt32(reader["PersonID"].ToString());
                        model.Name = reader["Name"].ToString();
                        model.Email = reader["Email"].ToString();
                        model.Contact = reader["Contact"].ToString();
                        list.Add(model);
                    }
                }
                return list;

            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region Api_Person_SelectByID
        public PersonModel Api_Person_SelectByID(int PersonID)
        {
            try
            {
                SqlDatabase db = new SqlDatabase(connStr);
                PersonModel model = new PersonModel();
                DbCommand cmd = db.GetStoredProcCommand("API_Person_SelectByID");
                db.AddInParameter(cmd, "@PersonID", SqlDbType.Int, PersonID);
                using (IDataReader reader = db.ExecuteReader(cmd))
                {
                    if (reader.Read())
                    {
                        model.PersonID = Convert.ToInt32(reader["PersonID"]);
                        model.Name = reader["Name"].ToString();
                        model.Email = reader["Email"].ToString();
                        model.Contact = reader["Contact"].ToString();
                        reader.Close();
                    }
                    else { return null; }
                }
                    return model;
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region API_Person_DeleteByID
        public bool API_Person_DeleteByID(int PersonID)
        {
            try
            {
                SqlDatabase db = new SqlDatabase(connStr);
                DbCommand cmd = db.GetStoredProcCommand("API_Person_DeleteByID");
                db.AddInParameter(cmd, "@PersonID", SqlDbType.Int, PersonID);
                int noOfRows = db.ExecuteNonQuery(cmd);
                if (noOfRows > 0)
                {
                    return true;
                }
                else { return false; }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        #endregion

        #region API_Person_Add
        public bool API_Person_Add(PersonModel model)
        {
            try
            {
                SqlDatabase sql = new SqlDatabase(connStr);
                DbCommand cmd = sql.GetStoredProcCommand("API_Person_Add");
                sql.AddInParameter(cmd, "@Name", SqlDbType.VarChar, model.Name);
                sql.AddInParameter(cmd, "@Email", SqlDbType.VarChar, model.Email);
                sql.AddInParameter(cmd, "@Contact", SqlDbType.VarChar, model.Contact);
                int noOfRows = sql.ExecuteNonQuery(cmd);
                if (noOfRows > 0)
                {
                    return true;
                }
                else { return false; }
            }
            catch (Exception ex) { return false; }
        }
        #endregion

        #region API_Person_UpdateByID
        public bool API_Person_UpdateByID(PersonModel model)
        {
            try
            {
                SqlDatabase db = new SqlDatabase(connStr);
                DbCommand cmd = db.GetStoredProcCommand("API_Person_UpdateByID");
                db.AddInParameter(cmd, "@PersonID", SqlDbType.Int, model.PersonID);
                db.AddInParameter(cmd, "@Name", SqlDbType.VarChar, model.Name);
                db.AddInParameter(cmd, "@Email", SqlDbType.VarChar, model.Email);
                db.AddInParameter(cmd, "@Contact", SqlDbType.VarChar, model.Contact);
                int noOfRows = db.ExecuteNonQuery(cmd);
                if (noOfRows > 0) {  return true; } else { return false; }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        #endregion
    }
}
