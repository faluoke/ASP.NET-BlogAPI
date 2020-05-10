using BlogApi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BlogApi.Controllers
{
    public class BlogsController : ApiController
    {
        // GET api/blogs
        public IHttpActionResult Get()
        {
            try
            {
                using (MasterblogEntities entities = new MasterblogEntities())
                {
                    var entity = entities.Blogs;
                    if (entity == null)
                    {
                        return NotFound();
                    }
                    return Ok(entity.ToList());
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }


        }

        // GET api/values/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                using (MasterblogEntities entities = new MasterblogEntities())
                {
                    var entity = entities.Blogs.Find(id);
                    if (entity == null)
                    {
                        return NotFound();
                    }
                    return Ok(entity);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        // POST api/values
        public IHttpActionResult Post([FromBody]Blog blog)
        {
            try
            {
                using (MasterblogEntities entities = new MasterblogEntities())
                {
                    entities.Blogs.Add(blog);
                    entities.SaveChanges();
                    return Content(HttpStatusCode.Created, blog);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }

        // PUT api/values/5
        public IHttpActionResult Put(int id, [FromBody]Blog blog)
        {
            try
            {
                using (MasterblogEntities entities = new MasterblogEntities())
                {
                    var entity = entities.Blogs.Find(id);
                    if (entity == null)
                    {
                        return NotFound();
                    }
                    entity.Title = blog.Title;
                    entity.Author = blog.Author;
                    entity.ImageLink = blog.ImageLink;
                    entity.Body = blog.Body;
                    entities.SaveChanges();
                    return Ok(entity);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }

        // DELETE api/values/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                using (MasterblogEntities entities = new MasterblogEntities())
                {
                    var entity = entities.Blogs.Find(id);
                    if (entity == null)
                    {
                        return NotFound();
                    }
                    entities.Blogs.Remove(entity);
                    entities.SaveChanges();
                    return Ok($"Blog with id of {id} has been removed");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
