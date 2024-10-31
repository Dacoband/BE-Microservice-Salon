﻿namespace UserService.Constants
{
    public static class ApiRoutes
    {
        public const string Base = "api/users";
        public const string GetAll = Base;
        public const string GetById = Base + "/{id}";
        public const string Create = Base;
        public const string Update = Base + "/{id}";
        public const string Delete = Base + "/{id}";
    }
}
