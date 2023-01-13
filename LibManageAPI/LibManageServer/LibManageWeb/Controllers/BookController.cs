
//using LibManageData.Entities;
//using LibManageServices.BookFolder;
//using LibManageServices;
//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace LibManageWeb.Controllers
//{
//    [ApiController]
//    public class BookController : ControllerBase
//    {
//        private readonly BookServices bookservice;
//        public BookController()
//        {
//            this.bookservice = new BookServices();
//        }
//        [HttpPost]
//        [Route("api/book")]
//        public ActionResult Insert([FromBody] BookDto BookToBeAdded)
//        {
//            try { return Ok(bookservice.Insert(BookToBeAdded)); }
//            catch (ExceptionServices e) { return BadRequest(e.Message); }
//            catch (Exception e)
//            {
//                return BadRequest(e.Message);
//            }
//        }
//        [HttpPut]
//        [Route("api/book")]
//        public ActionResult Update([FromBody] BookDto BookToBeUpdated)
//        {
//            try { return Ok(bookservice.Update(BookToBeUpdated)); }
//            catch (ExceptionServices e) { return BadRequest(e.Message); }
//            catch (Exception) { return BadRequest("Unknown Error!"); }
//        }
//        [HttpDelete]
//        [Route("api/book")]
//        public ActionResult Delete([FromQuery] int BookToBeDeletedID)
//        {
//            try { return Ok(bookservice.Delete(BookToBeDeletedID)); }
//            catch (ExceptionServices e) { return BadRequest(e.Message); }
//            catch (Exception) { return BadRequest("Unknown Error!"); }
//        }
//        [HttpGet]
//        [Route("api/book")]
//        public ActionResult Search([FromQuery] string title, [FromQuery] int? isbn, [FromQuery] int? publisherid, [FromQuery] int? year_from, [FromQuery] int? year_to)
//        {
//            //try { return Ok(bookservice.Search()); }
//            //catch (ExceptionServices e) { return BadRequest(e.Message); }
//            //catch (Exception e) { return BadRequest(e.Message); }
//            return Ok();
//        }
//        [HttpGet]
//        [Route("api/bookfind")]
//        public ActionResult Find([FromQuery] int id)
//        {
//            try { return Ok(bookservice.Find(id)); }
//            catch (ExceptionServices e) { return BadRequest(e.Message); }
//            catch (Exception) { return BadRequest("Unknown Error!"); }
//        }
//    }
//}
