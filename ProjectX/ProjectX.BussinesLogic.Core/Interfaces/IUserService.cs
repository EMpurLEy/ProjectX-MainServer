using ProjectX.BussinesLogic.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectX.BussinesLogic.Core.Interfaces
{
    public interface IUserService
    {
        Task<UserInformationBlo> RegisterWithPhone(int numberPrefix, int number, string password);
        Task<UserInformationBlo> AuthWithPhone(int numberPrefix, int number, string password);
        Task<UserInformationBlo> AuthWithEmail(string email, string password);
        Task<UserInformationBlo> AuthWihLogin(string login, string password);
        Task<UserInformationBlo> Get(int userId);
        Task<UserInformationBlo> Update(int numberPrefix, int number, string password, UserUpdateBlo userUpdateblo);
        Task<bool> DoesExist(int numberPrefix, int number);
    }
}
