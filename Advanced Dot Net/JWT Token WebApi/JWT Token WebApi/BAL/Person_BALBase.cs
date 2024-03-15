using JWT_Token_WebApi.DAL;
using JWT_Token_WebApi.Models;

namespace JWT_Token_WebApi.BAL
{
    public class Person_BALBase
    {
        #region API_Person_SelectAll
        public List<PersonModel> API_Person_SelectAll()
        {
            try
            {
                Person_DALBase dal = new Person_DALBase();
                List<PersonModel> list = dal.API_Person_SelectAll();
                return list;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #endregion

        #region Api_Person_SelectByID
        public PersonModel Api_Person_SelectByID(int id)
        {
            try
            {
                Person_DALBase dal = new Person_DALBase();
                PersonModel list = dal.Api_Person_SelectByID(id);
                return list;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #endregion

        #region API_Person_DeleteByID
        public bool API_Person_DeleteByID(int id)
        {
            try
            {
                Person_DALBase dal = new Person_DALBase();
                bool res = dal.API_Person_DeleteByID(id);
                return res;
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
                Person_DALBase dal = new Person_DALBase();
                bool res = dal.API_Person_Add(model);
                return res;
            }
            catch (Exception ex) { return false; }
        }
        #endregion

        #region API_Person_UpdateByID
        public bool API_Person_UpdateByID(PersonModel model)
        {
            try
            {
                Person_DALBase dal = new Person_DALBase();
                bool res = dal.API_Person_UpdateByID(model);
                return res;
            }
            catch
            (Exception ex)
            { return false; }
        }
        #endregion
    }
}
