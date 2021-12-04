using AutoMapper;
using ProjectX.BussinesLogic.Core.Interfaces;
using ProjectX.BussinesLogic.Core.Models;
using ProjectX.DataAccess.Core.Interfaces.DbContext;
using ProjectX.DataAccess.Core.Models;
using Sharedd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectX.BussinesLogic.Services
{
    public class UserServices : IUserService
    {

        private readonly IMapper _mapper;
        private readonly IProjectConetext _context;

        public UserServices(IMapper mapper, IProjectConetext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public Task<UserInformationBlo> AuthWihLogin(string login, string password)
        {
            throw new NotImplementedException();
        }

        public Task<UserInformationBlo> AuthWithEmail(string email, string password)
        {
            UserRto user = _context.Users.FirstOrDefault(p => p.Email == email && p.Password == password);

            if (user == null)
                throw new NotFoundException($"Пользователь с почтой {email} не найден");
            return ConvertToUserInformation(user);
        }

        public Task<UserInformationBlo> AuthWithPhone(int numberPrefix, int number, string password)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DoesExist(int numberPrefix, int number)
        {
            throw new NotImplementedException();
        }

        public Task<UserInformationBlo> Get(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<UserInformationBlo> RegisterWithPhone(int numberPrefix, int number, string password)
        {
            throw new NotImplementedException();
        }

        public Task<UserInformationBlo> Update(int numberPrefix, int number, string password, UserUpdateBlo userUpdateblo)
        {
            throw new NotImplementedException();
        }

        private async Task<UserInformationBlo> ConvertToUserInformation(UserRto userRto)
        {
            if (userRto == null) throw new ArgumentException(nameof(userRto));

            var userInformationBlo = _mapper.Map<UserInformationBlo>(userRto);

                return userInformationBlo;
        }

    }
}
