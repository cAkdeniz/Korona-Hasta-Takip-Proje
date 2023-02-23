using CoronaHastaTakip.Business.Concrete;
using CoronaHastaTakip.Business.Interfaces;
using CoronaHastaTakip.DataAccess.Concrete.Context;
using CoronaHastaTakip.DataAccess.Concrete.Repositories;
using CoronaHastaTakip.DataAccess.Interfaces;
using CoronaHastaTakipTaslak.Business.Concrete;
using CoronaHastaTakipTaslak.Business.Interfaces;
using CoronaHastaTakipTaslak.DataAccess.Concrete.Repositories;
using CoronaHastaTakipTaslak.DataAccess.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace CoronaHastaTakip.Business.Containers.MicrosoftIoc
{
    public static class CustomExtension
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            services.AddScoped<IHastaService, HastaManager>();
            services.AddScoped<IAciliyetService, AciliyetManager>();
            services.AddScoped<IRaporService, RaporManager>();
            services.AddScoped<IAppUserService, AppUserManager>();
            services.AddScoped<IBildirimService, BildirimManager>();
            services.AddScoped<IDosyaService, DosyaManager>();

            services.AddScoped<IHastaDal, HastaDal>();
            services.AddScoped<IAciliyetDal, AciliyetDal>();
            services.AddScoped<IRaporDal, RaporDal>();
            services.AddScoped<IAppUserDal, AppUserDal>();
            services.AddScoped<IBildirimDal, BildirimDal>();

            services.AddDbContext<CoronaHastaTakipContext>();
        }
    }
}
