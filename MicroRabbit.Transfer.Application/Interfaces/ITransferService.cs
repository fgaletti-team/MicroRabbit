
using MicroRabbit.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Transfer.Application.Interfaces
{
    // 59
    public interface ITransferService
    {
        IEnumerable<TransferLog> GetTransferLogs();
        
    }
}
