using HotelListing.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.IRepository
{
    /// <summary>
    /// The repository and unit of work patterns are intended to create an abstraction layer 
    /// between the data access layer and the business logic layer of an application. 
    /// Implementing these patterns can help insulate your application from changes in the data store 
    /// and can facilitate automated unit testing or test-driven development (TDD)
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Country> Countries { get; }
        IGenericRepository<Hotel> Hotels { get; }
        Task Save();
    }
}
