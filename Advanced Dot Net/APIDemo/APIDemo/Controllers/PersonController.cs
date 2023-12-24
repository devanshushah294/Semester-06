﻿using APIDemo.BAL;
using APIDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace APIDemo.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class PersonController : Controller
    {
        #region API_Person_SelectAll
        [HttpGet]
        public IActionResult API_Person_SelectAll()
        {
            try
            {

                Person_BALBase bal = new Person_BALBase();
                List<PersonModel> list = bal.API_Person_SelectAll();

                Dictionary<string, dynamic> response = new Dictionary<string, dynamic>();
                if (list.Count > 0 && list != null)
                {
                    response.Add("status", true);
                    response.Add("message", "Data Found. ");
                    response.Add("data", list);
                    return Ok(response);
                }
                else
                {
                    response.Add("status", false);
                    response.Add("message", "Data Not Found. ");
                    response.Add("data", null);
                    return NotFound(response);
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #endregion

        #region Api_Person_SelectByID
        [HttpGet("{id}")]
        public IActionResult Api_Person_SelectByID(int id)
        {
            try
            {
                Person_BALBase bal = new Person_BALBase();
                PersonModel person = bal.Api_Person_SelectByID(id);
                Dictionary<string, dynamic> response = new Dictionary<string, dynamic>();
                if (person != null)
                {
                    response.Add("status", true);
                    response.Add("message", "Data Found Successfully");
                    response.Add("data", person);
                    return Ok(response);
                }
                else
                {
                    response.Add("status", false);
                    response.Add("message", "Data Not found");
                    response.Add("data", null);
                    return NotFound(response);
                }

            }
            catch (Exception e)
            {
                return null;
            }
        }
        #endregion

        #region API_Person_DeleteByID
        [HttpDelete("{id}")]
        public IActionResult API_Person_DeleteByID(int id)
        {
            try
            {
                Person_BALBase bal = new Person_BALBase();
                bool res = bal.API_Person_DeleteByID(id);
                Dictionary<string, dynamic> response = new Dictionary<string, dynamic>();
                if (res)
                {
                    response.Add("status", true);
                    response.Add("message", "Data Deleted Successfully");
                    return Ok(response);
                }
                else
                {
                    response.Add("status", false);
                    response.Add("message", "Data Not Deleted");
                    return NotFound(response);
                }

            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #endregion

        #region API_Person_Add
        [HttpPost]
        public IActionResult API_AddStudent(PersonModel model)
        {
            if (!ModelState.IsValid)
            {
                Dictionary<string, dynamic> dict = new Dictionary<string, dynamic>();
                dict.Add("status", false);
                dict.Add("message", "Data Not Correct");
                return NotFound(dict);
            }
            try
            {
                Person_BALBase bal = new Person_BALBase();
                bool res = bal.API_Person_Add(model);
                if (res)
                {
                    Dictionary<string, dynamic> dict = new Dictionary<string, dynamic>();
                    dict.Add("status", true);
                    dict.Add("message", "Data Added successfully");
                    return Ok(dict);
                }
                else
                {
                    Dictionary<string, dynamic> dict = new Dictionary<string, dynamic>();
                    dict.Add("status", false);
                    dict.Add("message", "Data Not Added");
                    return NotFound(dict);
                }
            }
            catch (Exception ex)
            {
                Dictionary<string, dynamic> dict = new Dictionary<string, dynamic>();
                dict.Add("status", false);
                dict.Add("message", "Data Not Added");
                return NotFound();
            }
        }
        #endregion

        #region API_Person_UpdateByID
        [HttpPut]
        public IActionResult API_Person_UpdateByID(PersonModel model)
        {
            if (!ModelState.IsValid)
            {
                Dictionary<string, dynamic> dict = new Dictionary<string, dynamic>();
                dict.Add("status", false);
                dict.Add("message", "Data Not Correct");
                return NotFound(dict);
            }
            try
            {

                Person_BALBase bal = new Person_BALBase();
                bool res = bal.API_Person_UpdateByID(model);
                if (res)
                {
                    Dictionary<string, dynamic> dict = new Dictionary<string, dynamic>();
                    dict.Add("status", true);
                    dict.Add("message", "Data Added successfully");
                    return Ok(dict);
                }
                else
                {
                    Dictionary<string, dynamic> dict = new Dictionary<string, dynamic>();
                    dict.Add("status", false);
                    dict.Add("message", "Data Not Added");
                    return NotFound(dict);
                }

            }
            catch (Exception ex)
            {
                Dictionary<string, dynamic> dict = new Dictionary<string, dynamic>();
                dict.Add("status", false);
                dict.Add("message", "Data Not Added");
                return NotFound(dict);
            }
        }
        #endregion

    }

}
