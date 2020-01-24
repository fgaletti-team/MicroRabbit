
using MediatR;
using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Application.Services;
using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Banking.Data.Repository;
using MicroRabbit.Banking.Domain.CommandHandlers;
using MicroRabbit.Banking.Domain.Commands;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Infra.Bus;
using MicroRabbit.Transfer.Application.Interfaces;
using MicroRabbit.Transfer.Application.Services;
using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Data.Repository;
using MicroRabbit.Transfer.Domain.EventHandlers;
using MicroRabbit.Transfer.Domain.Events;
using MicroRabbit.Transfer.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Infra.IoC
{
    public  class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain Bus
           services.AddTransient<IEventBus, RabbitMQBus>();

            //Domains Events
            // 63
            services.AddTransient<IEventHandler<TransferCreatedEvent>, TransferEventHandler>();

            //Domains Banking Command
            // 50
            services.AddTransient<IRequestHandler<CreateTransferCommand,bool>, TransferCommandHandler>();
            //Application Services
           services.AddTransient<IAccountService, AccountService>();

            //60
            services.AddTransient<ITransferService, TransferService>();

            //Data
            services.AddTransient<IAccountRepository, AccountRepository>();
            // 60
            services.AddTransient<ITransferRepository, TransferRepository>();

            services.AddTransient<BankingDbContext>();
            services.AddTransient<TransferDbContext>();

        }
    }
}
