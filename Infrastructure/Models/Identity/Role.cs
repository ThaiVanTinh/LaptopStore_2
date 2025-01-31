﻿using System;
using System.Collections.Generic;
using LaptopStore.Domain.Contracts;
using Microsoft.AspNetCore.Identity;
using static LaptopStore.Shared.Constants.Permission.Permissions;

namespace LaptopStore.Infrastructure.Models.Identity
{
    public class Role : IdentityRole, IAuditableEntity<string>
    {
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public virtual ICollection<RoleClaim> RoleClaims { get; set; }

        public Role() : base()
        {
            RoleClaims = new HashSet<RoleClaim>();
        }

        public Role(string roleName, string roleDescription = null) : base(roleName)
        {
            RoleClaims = new HashSet<RoleClaim>();
            Description = roleDescription;
        }
    }
}