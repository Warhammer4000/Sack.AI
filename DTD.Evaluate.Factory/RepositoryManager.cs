using System;
using System.Collections.Generic;
using System.Text;
using DTD.Evaluate.Factory.Interfaces;

namespace DTD.Evaluate.Factory
{
    public class RepositoryManager
    {
        private static RepositoryManager _instance;

        public static RepositoryManager Instance => _instance ??= new RepositoryManager();
        private Dictionary<string, IFactory> Factoreis { get; set; }
        private RepositoryManager()
        {
            Factoreis = new Dictionary<string, IFactory> {{"fake", new FakeFactory()}};

        }

        
        public string selectedFactory = "fake";
        public IFactory GetFactory()
        {
            return Factoreis[selectedFactory];
        }
    }
}
