using System;
using DTD.Evaluate.Factory.FakeFactoryRepo;
using DTD.Evaluate.Factory.Interfaces;

namespace DTD.Evaluate.Factory
{
    public class FakeFactory:IFactory
    {
        public IUserContext UserContext =>new FakeFactoryUserContext();
    }
}
