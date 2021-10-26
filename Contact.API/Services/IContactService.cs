using System;
using Contact.API.Entities;

namespace Contact.API.Services
{
    public interface IContactService
    {
        public ContactDto GetContactDto(int Id);
    }
}

