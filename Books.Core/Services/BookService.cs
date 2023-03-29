using Books.Core.Interfaces;
using Books.Data.Exceptions;
using Books.Data.Entities;
using Books.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Books.Core.Services
{
    public class BookService : IBookService
    {
        private IRepository<Book> _repository;
        private readonly IUnitOfWork _unitOfWork;

        public BookService(IRepository<Book> repository,
            IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Book>> GetBooksAsync()
        {
            return await _repository.All.OrderBy(x => x.Title).ToListAsync();
        }

        public async Task<Book> GetBookByIdAsync(int id)
        {
            return await _repository.All.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Book> CreateBookAsync(Book Book)
        {
            if (Book == null)
            {
                throw new InvalidEntityException();
            }

            var isRepeated = await _repository.All.AnyAsync(x => x.Title == Book.Title);

            if (isRepeated)
            {
                throw new EntryExistsException();
            }

            _repository.Insert(Book);
            await _unitOfWork.CommitAsync();
            return Book;
        }

        public async Task<Book> UpdateBookAsync(Book Book)
        {
            if (Book == null)
            {
                throw new InvalidEntityException();
            }

            if (Book.Id == default)
            {
                throw new InvalidOperationException();
            }

            var BookFound = await _repository.All.FirstOrDefaultAsync(x => x.Id == Book.Id);

            if (BookFound == null)
            {
                throw new EntryExistsException();
            }

            BookFound.Title = Book.Title;
            BookFound.FirstName = Book.FirstName;
            BookFound.LastName = Book.LastName;
            BookFound.Isbn = Book.Isbn;
            BookFound.Category = Book.Category;
            BookFound.TotalCopies = Book.TotalCopies;
            BookFound.CopiesInUse = Book.CopiesInUse;

            _repository.Update(BookFound);
            await _unitOfWork.CommitAsync();

            return BookFound;
        }

        public async Task DeleteBookAsync(int id)
        {
            var item = await _repository.All.FirstOrDefaultAsync(x => x.Id == id);

            if (item == null)
            {
                throw new EntryExistsException();
            }

            _repository.Delete(id);
            await _unitOfWork.CommitAsync();
        }
    }

}
