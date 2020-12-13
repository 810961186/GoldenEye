﻿using System;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace GoldenEye.Shared.Core.Mappings
{
    public static class Registration
    {
        public static IServiceCollection AddAutoMapperForAllDependencies(
            this IServiceCollection services
        )
        {
            return services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }
    }
}
