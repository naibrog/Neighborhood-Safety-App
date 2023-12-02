using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class User
    {
        public string  userName;
        public string password;
        public string firstName;
        public string lastName;
        public string email;
        public string phone;
        public string streetAddress;
        public string city;
        public string state;    
        public string zipCode;
      

        public string UserName { get { return userName; }set { userName = value; } }
        public string Password { get { return password; } set { password = value; } }
        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Phone { get { return phone; } set { phone = value; } }
        public string StreetAddress { get {  return streetAddress; } set {  streetAddress = value; } }
        public string City { get { return city; } set { city = value; } }
        public string State { get { return state; } set { state = value; } }
        public string ZipCode { get {  return zipCode; } set {  zipCode = value; } }
     



    }
}
