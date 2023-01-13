using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibData;
using LibData.Entities;

namespace LibServices.Book
{
    public class BookServices
    {
        private readonly LibManageContext dbContext;
        public BookServices()
        {
            dbContext = new LibManageContext();
        }
        public List<BookDto> Search(bool getall,BookSearchDto searchbook)
        {
            var query = dbContext.Books.AsQueryable();
            if(getall)
            {
               
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(searchbook.Title)) query = query.Where(b => b.Title.Contains(searchbook.Title));
                if (searchbook.Isbn != null) query = query.Where(b => b.Isbn.ToString().Contains(searchbook.Isbn.ToString()));
                if (searchbook.PublisherId != null) query = query.Where(b => b.PublisherId == searchbook.PublisherId);
                if (searchbook.year_from != null) query = query.Where(b => b.Year >= searchbook.year_from);
                if (searchbook.year_to != null) query = query.Where(b => b.Year <= searchbook.year_to);
                if (searchbook.Id != 0) query = query.Where(b => b.Id == searchbook.Id);
                if (searchbook.CategoryId != null) query = query.Where(b => b.CategoryId == searchbook.CategoryId);
                if (searchbook.FirstAuthorId != null) query = query.Where(b => b.FirstAuthorId == searchbook.FirstAuthorId);
            }
            var results = query.ToList();
            List<BookDto> ResultsList= new();
            BookDto result;
            foreach (var item in results)
            {
                result = new() { PublisherId = item.PublisherId, Title = item.Title, Isbn = item.Isbn, Id = item.Id, Year = item.Year, FirstAuthorId = item.FirstAuthorId, CategoryId = item.CategoryId };
                ResultsList.Add(result);
            }
            return ResultsList;
        }
        //----------------------------------------------------------------------------------------------------------------------------------
        public int Insert(BookInsertionDto input, out string title)
        {
            if (string.IsNullOrWhiteSpace(input.Title)) throw new ExceptionServices("Enter Title!");
            else
            {
                LibData.Entities.Book newbook = new()
                {
                    Title = input.Title,
                    Year = input.Year,
                    Isbn = input.Isbn,
                    PublisherId = input.PublisherId,
                    CategoryId = input.CategoryId,
                    FirstAuthorId = input.FirstAuthorId,
                };
                dbContext.Books.Add(newbook);
                dbContext.SaveChanges();
                title = newbook.Title;
                return newbook.Id;
            }

        }
        //public int Update(BookDto BookBeingUpdated)
        //{
        //    var UpdatedBook = dbContext.Books.FirstOrDefault(b => b.Id == BookBeingUpdated.Id);
        //    if (UpdatedBook == null) throw new ExceptionServices("کتابی با این مشخصات یافت نشد!");
        //    else
        //    {
        //        //         UpdatedBook.Id = BookBeingUpdated.Id;
        //        //      UpdatedBook.Isbn = BookBeingUpdated.Isbn;
        //        UpdatedBook.Title = BookBeingUpdated.Title;
        //        UpdatedBook.Year = BookBeingUpdated.Year;
        //        UpdatedBook.PublisherId = BookBeingUpdated.PublisherId;
        //        dbContext.Books.Update(UpdatedBook);
        //        dbContext.SaveChanges();
        //        return UpdatedBook.Id;
        //    }

        //}
//------------------------------------------------------------------------------------------------------------------------------
        public string Delete(int id)
        {
            var DeletedBook = dbContext.Books.FirstOrDefault(b => b.Id == id);

            if (DeletedBook == null) throw new Exception("کتابی با این مشخصات یافت نشد!");
            else
            {
                dbContext.Books.Remove(DeletedBook);
                dbContext.SaveChanges();
                return DeletedBook.Title;
            }
        }
//--------------------------------------------------------------------------------------------------------------------------------------     
        //public BookDto Find(int id)
        //{
        //    var output = dbContext.Books.FirstOrDefault(b => b.Id == id);
        //    if (output == null) throw new ExceptionServices("کتابی با این مشخصات یافت نشد!");
        //    else
        //    {
        //        BookDto result = new()
        //        {
        //            Id = output.Id,
        //            Title = output.Title,
        //            Isbn = output.Isbn,
        //            PublisherId = output.PublisherId,
        //            Year = output.Year
        //        };
        //        return result;
        //    }
        //}
    }
}
