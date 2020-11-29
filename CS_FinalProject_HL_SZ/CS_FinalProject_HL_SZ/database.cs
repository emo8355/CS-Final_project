using System;
using System.Linq;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;


namespace CS_FinalProject_HL_SZ
{
    public class Database
    {
        LibraryDbContext context = new LibraryDbContext();
        public Database()
        {
        }

        public bool LoginUser(string email,string password)
        {
            var query = context.admins.Where(admin => admin.email == email).Single();
            if (password == query.password)
                return true;
            else
                return false;
            
        }

        public void CreateUser(string firstname, string lastname, string email, string password)
        {
            try
            {
                admin newAdmin = new admin
                {
                    firstname = firstname,
                    lastname = lastname,
                    email = email,
                    password = password
                };
                context.admins.Add(newAdmin);
                context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                 throw new DbUpdateException("Admin already exist !");
                
            }
        }

        public void CreateCategory(string categoryname)
        {
            try
            {
                category newCategory = new category { name = categoryname };
                context.categories.Add(newCategory);
                context.SaveChanges();
            }
            catch(DbUpdateException ex)
            {
                MessageBox.Show("Can not duplicate data");
            }
            
        }

        public void UpdateCategory(string categoryname, int id)
        {
            try
            {
                var update = context.categories.Where(category => category.category_id == id).Single();
                update.name = categoryname;
                context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CreateAuthor( string firstname, string lastname)
        {
            try
            {
                author newAuthor = new author { firstname = firstname, lastname = lastname };
                context.authors.Add(newAuthor);
                context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show("Can not duplicate data");
            }
        }

        public void UpdateAuthor(string firstname, string lastname, int id)
        {
            try
            {
                var update = context.authors.Where(author => author.author_id == id).Single();
                update.firstname = firstname;
                update.lastname = lastname;
                context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show("something went wrong, try again later");
            }
        }

        public void CreateBook(string title, string language, int categoryId, int authorId, DateTime date)
        {
            try
            {
                book newBook = new book
                {
                    title = title,
                    language = language,
                    category_id = categoryId,
                    author_id = authorId,
                    published_date = date,
                    isBorrowed = false
            };
                context.books.Add(newBook);
                context.SaveChanges();

            }
            catch (DbUpdateException ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("something went wrong, try again later");
            }
        }

        public void UpdateBook(string title, string language, int categoryId, int authorId, DateTime date, int id )
        {
            try
            {
                var update = context.books.Where(book => book.book_id == id).Single();
                update.title = title;
                update.language = language;
                update.category_id = categoryId;
                update.author_id = authorId;
                update.published_date = date;
                context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show("something went wrong, try again later");
            }
        }

        public void UpdateBookStatus( bool status, int id)
        {
            try
            {
                var update = context.books.Where(book => book.book_id == id).Single();
                update.isBorrowed = status;
                context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show("something went wrong, try again later");
            }
        }

        public List<book> GetBooks()
        {
            List<book> query = (
                         from book in context.books
                         join author in context.authors on book.author_id equals author.author_id
                         join categories in context.categories on book.category_id equals categories.category_id
                         select book).ToList();
            return query;
        }

        public List<book> GetBooks(int id)
        {
            List<book> query = (
                         from book in context.books
                         join author in context.authors on book.author_id equals author.author_id
                         join categories in context.categories on book.category_id equals categories.category_id
                         where book.book_id == id
                         orderby book.book_id
                         select book).ToList();
            return query;
        }

        public List<category> GetCategories()
        {
            List<category> query = (from categories in context.categories orderby categories.category_id select categories).ToList();
            return query;
        }

        public List<category> GetCategories(int id)
        {
            List<category> query = (from categories in context.categories where categories.category_id == id orderby categories.category_id select categories).ToList();
            return query;
        }

        public List<AuthorInfoGetter> GetAuthors(bool fullname)
        {
            List<AuthorInfoGetter> query;
            if (fullname)
                query = context.authors
                               .ToList()
                               .Select(author => new AuthorInfoGetter(author.author_id, author.firstname+" "+author.lastname))
                               .ToList();
            else
                query = context.authors
                               .ToList()
                               .Select(author => new AuthorInfoGetter(author.author_id, author.firstname, author.lastname))
                               .ToList();
            return query;
        }

        public List<AuthorInfoGetter> GetAuthors(int id)
        {
            List<AuthorInfoGetter> query = context.authors
                                            .Where(author=>author.author_id == id)
                                            .ToList()
                                            .Select(author => new AuthorInfoGetter(author.author_id, author.firstname, author.lastname))
                                            .ToList();
            return query;
        }

        public List<BookInfoGetter> GetBookStatus(bool status)
        {
            List<BookInfoGetter> query = (from book in context.books
                                          join author in context.authors on book.author_id equals author.author_id
                                          join categories in context.categories on book.category_id equals categories.category_id
                                          where book.isBorrowed == status
                                          orderby book.book_id
                                          select new { book = book, bookType = categories.name, authorFullname = author.firstname + " " + author.lastname }
                                          )
                                          .ToList()
                                          .Select(x => new BookInfoGetter(x.book, x.bookType, x.authorFullname))
                                          .ToList();
            return query;
                                         
        }

        public void RemoveCategory(int id)
        {
            try
            {
                var query = context.categories.Where(category => category.category_id == id).Single();
                context.categories.Remove(query);
                context.SaveChanges();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Can't delete Category, please delete all the boos first");
            }
        }

        public void RemoveAuthor(int id)
        {
            try
            {
                var query = context.authors.Where(author => author.author_id == id).Single();
                context.authors.Remove(query);
                context.SaveChanges();
            }
            catch(InvalidOperationException ex)
            {
                MessageBox.Show("Can't delete Author, please delete the book first");
            }
            
        }

        public void RemoveBook (int id)
        {
            try
            {
                var query = context.books.Where(book => book.book_id == id).Single();
                context.books.Remove(query);
                context.SaveChanges();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Can't delete Book, please delete other relation first");
            }
        }

    }

}
