using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using BCrypt.Net;



namespace VirtualBarBackend.Models
{
    public class User
    {

        [BsonId]
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PashwordHash { get; set; }

        public User(string firstName, string lastName, string eMail, string plainPassword)
        {
            this.Id = System.Guid
                .NewGuid()
                .ToString();
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = eMail;
            this.hashPasword(plainPassword);
        }

        private void hashPasword(string plainPassword)
        {
            this.PashwordHash = BCrypt.Net.BCrypt.HashPassword(plainPassword);
        }
    }
}
