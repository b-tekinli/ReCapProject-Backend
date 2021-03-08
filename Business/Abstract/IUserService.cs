using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IUserService
    {
        List<OperationClaim> GetClaims(User user);
        void Add(User user);
        User GetByMail(string email);

        //IDataResult<List<User>> GetAll();
        //IDataResult<User> GetById(int userId);
        //IResult Add(User user);
        //IResult Update(User user);
        //IResult Delete(User user);
    }
}
