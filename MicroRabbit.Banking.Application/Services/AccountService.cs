using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Application.Models;
using MicroRabbit.Banking.Domain.Commands;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Banking.Domain.Models;
using MicroRabbit.Domain.Core.Bus;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banking.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        private IEventBus _bus;   // 48 


        public AccountService(IAccountRepository accountRepository, IEventBus bus)
        {
            _accountRepository = accountRepository;
            _bus = bus;
        }
        public IEnumerable<Account> GetAccounts()
        {
            return _accountRepository.GetAccounts();
        }

        //45 implement
        public void Transfer(AccountTransfer accountTransfer)
        {

            // 48 
            var createTransferCommand = new CreateTransferCommand(
                    accountTransfer.FromAccount,
            accountTransfer.ToAccount,
            accountTransfer.TransferAmount
                );
            // 48 
            _bus.SendCommand(createTransferCommand);
        }
    }
}
