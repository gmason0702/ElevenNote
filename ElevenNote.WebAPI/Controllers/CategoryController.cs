﻿using ElevenNote.Models;
using ElevenNotes.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ElevenNote.WebAPI.Controllers
{
    public class CategoryController : ApiController
    {
        public IHttpActionResult Get()
        {
            CategoryService categoryService = CreateCategoryService();
            var category = categoryService.GetCategory();
            return Ok(category);
        }
        public IHttpActionResult Get(int id)
        {
            CategoryService categoryService = CreateCategoryService();
            var category = categoryService.GetCategoryById(id);
            return Ok(category);
        }

        public IHttpActionResult Post(CategoryCreate category)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateCategoryService();

            if (!service.CreateCategory(category))
                return InternalServerError();

            return Ok();
        }

        public IHttpActionResult Put(CategoryEdit category)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateCategoryService();

            if (!service.UpdateCategory(category))
                return InternalServerError();

            return Ok();

        }
        public IHttpActionResult Delete(int id)
        {
            var service = CreateCategoryService();
            if (!service.DeleteCategory(id))
                return InternalServerError();

            return Ok();

        }



        private CategoryService CreateCategoryService()
        {
            var categoryService = new CategoryService();
            return categoryService;
        }
    }
}
