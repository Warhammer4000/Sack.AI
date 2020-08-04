using System;
using System.Collections.Generic;
using System.Text;

namespace DTD.Evaluate.Factory.Interfaces
{
    public interface IFactory
    {
         IUserContext UserContext { get; }
    }
}
