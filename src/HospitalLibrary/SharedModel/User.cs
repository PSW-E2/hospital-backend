using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using HospitalLibrary.Core.Model;
using Microsoft.EntityFrameworkCore;

namespace HospitalLibrary.SharedModel
{
    [Index(nameof(Email), IsUnique = true)]
    public class User : EntityObject
    {
        //public int UserId { get; set; }
        [Required, NotNull, EmailAddress]
        public string Email { get; set; }
        [Required, NotNull, MinLength(3, ErrorMessage = "Password needs to be atleast 3 characters or more")]
        public Password Password { get; set; }
        public UserRole Role { get; set; }

        public User() { 
        }
        public User(string email, string password)
        {
            Email = email;
            Password = new Password(password);
        }

        public User(string email, string password, UserRole userRole)
        {
            Email = email;
            Password = new Password(password);
            Role = userRole;
        }

        public override bool Equals(object obj)
        {
            return obj is User user &&
                   Email == user.Email &&
                   Password == user.Password;
        }

        public class DuplicateEMailException : Exception
        {
            public DuplicateEMailException(string message) : base(message) { }
        }
        public class BadPasswordException : Exception
        {
            public BadPasswordException(string message) : base(message) { }
        }

        
    }

    public enum UserRole
    {
        patient,
        doctor,
        manager
    }
}
