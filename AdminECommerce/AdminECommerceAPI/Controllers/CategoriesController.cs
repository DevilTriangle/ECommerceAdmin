using AdminECommerceAPI.Repository;
using AdminECommerceModel.Models;
using AutoMapper;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;

namespace AdminECommerceAPI.Controllers
{
    public class CategoriesController : ApiController
    {
        private MStoreContext db = new MStoreContext();

        private CategoryRepository categoryRepository;
        public CategoriesController()
        {
            categoryRepository = new CategoryRepository(db);
        }

        // GET: api/Categories
        public IEnumerable<Category> GetAll()
        {
            return categoryRepository.GetMany();
        }

        // GET: api/Categories/5
        [ResponseType(typeof(Category))]
        public IHttpActionResult GetCategory(int id)
        {
            Category category = categoryRepository.GetByID(id);
            if (category == null)
            {
                return NotFound();
            }

            return Ok(category);
            
        }

        // PUT: api/Categories/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCategory(int id, Category category)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != category.Id)
            {
                return BadRequest();
            }
            categoryRepository.Update(category);
            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CategoryExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Categories
        [ResponseType(typeof(Category))]
        public IHttpActionResult PostCategory(Category category)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            categoryRepository.Add(category);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = category.Id }, category);
        }

        // DELETE: api/Categories/5
        [ResponseType(typeof(Category))]
        public IHttpActionResult DeleteCategory(int id)
        {
            Category category = categoryRepository.GetByID(id);
            if (category == null)
            {
                return NotFound();
            }

            categoryRepository.Delete(category);
            db.SaveChanges();

            return Ok(category);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CategoryExists(int id)
        {
            //return db.Categories.Count(e => e.Id == id) > 0;
            return categoryRepository.GetByID(id) != null;
        }
    }
}