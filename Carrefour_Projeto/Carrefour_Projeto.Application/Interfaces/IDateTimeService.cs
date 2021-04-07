using System;
using System.Collections.Generic;
using System.Text;

namespace Carrefour_Projeto.Application.Interfaces
{
    public interface IDateTimeService
    {
        DateTime NowUtc { get; }
    }
}
