using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentalCarDbContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (RentalCarDbContext context = new RentalCarDbContext())
            {
                var result = from rental in context.Rentals
                             join ca in context.Cars
                             on rental.CarId equals ca.CarId
                             join cu in context.Customers
                             on rental.CustomerId equals cu.Id
                             join u in context.Users
                             on cu.UserId equals u.Id
                             join b in context.Brands
                             on ca.BrandId equals b.BrandId
                             join co in context.Colors
                             on ca.ColorId equals co.ColorId
                             select new RentalDetailDto
                             {
                                 Id = rental.Id,
                                 CarId = ca.CarId,
                                 BrandName = b.BrandName,
                                 ColorName = co.ColorName,
                                 CustomerId = cu.Id,
                                 CustomerFirstName = u.FirstName,
                                 CustomerLastName = u.LastName,
                                 RentDate = rental.RentDate,
                                 ReturnDate = rental.ReturnDate
                             };

                return result.ToList();
            }
        }
    }
}
