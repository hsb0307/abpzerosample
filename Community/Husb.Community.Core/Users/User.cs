using System;
using Abp.Authorization.Users;
using Abp.Extensions;
using Husb.Community.MultiTenancy;

namespace Husb.Community.Users
{
    public class User : AbpUser<Tenant, User>
    {
        public static string CreateRandomPassword()
        {
            return Guid.NewGuid().ToString("N").Truncate(16);
        }
    }
}