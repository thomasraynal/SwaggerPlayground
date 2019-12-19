﻿using Nancy.Authentication.Stateless;
using Nancy.Security;
using SwaggerPlayground.Common;
using SwaggerPlayground.Modules.PetStore;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace SwaggerPlayground.Tests
{
    public class PetStoreModule : PetStoreModuleBase
    {
        public PetStoreModule(IPetStoreService petStoreService) : base(petStoreService)
        {
            var configuration =
              new StatelessAuthenticationConfiguration(context =>
              {

                  var token = context.Request.Headers.Authorization;

                  if (null == token) return null;

                  return new ClaimsPrincipal(new ClaimsIdentity(new Claim[] { new Claim("token", token) }));
              });

            StatelessAuthentication.Enable(this, configuration);
        }

        protected override void ConfigureDeletePetRequestRoute()
        {
            this.RequiresAuthentication();
        }
    }
}