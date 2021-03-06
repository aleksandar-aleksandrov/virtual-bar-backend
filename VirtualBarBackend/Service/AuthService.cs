﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using VirtualBarBackend.Config;
using VirtualBarBackend.DTOS;
using VirtualBarBackend.DTOS.Auth;
using VirtualBarBackend.Models;

namespace VirtualBarBackend.Service
{
    public class AuthService
    {
        private readonly IMongoCollection<User> _users;

        public AuthService(IDatabaseConnection databaseConnection)
        {
            var client = new MongoClient(databaseConnection.ConnectionString);
            var database = client.GetDatabase(databaseConnection.DatabaseName);

            _users = database.GetCollection<User>(databaseConnection.UsersCollectionName);
        }

        public User RegisterUser(RegisterUserDTO registerUserDTO)
        {
            var userEntity = new User(registerUserDTO.firstName, registerUserDTO.lastName, registerUserDTO.eMail, registerUserDTO.plainPassword);

             _users.InsertOne(userEntity);
            return userEntity;
        }
    }
}
