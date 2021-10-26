using System;
using Contact.API.Entities;
using Contact.API.Services;

namespace Contact.API.Concrete
{
    public class ContactService:IContactService
    {
     
        public ContactDto GetContactDto(int Id)
        {
            return new ContactDto() { Id = Id ,FirstName="Yunus",LastName="Özdemir"};
        }
    }
}

