using ComplexApp.Complex;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Complex.Complex
{
    public class ComplexService : IComplexService
    {
        public Task PostComplexA(PostComplexARequest request)
        {
            return Task.CompletedTask;
        }

        public Task PostComplexB(PostComplexBRequest request)
        {
            throw new NotImplementedException();
        }

        public Task PostComplexC(PostComplexCRequest request)
        {
            throw new NotImplementedException();
        }

        public Task PostComplexD(PostComplexDRequest request)
        {
            throw new NotImplementedException();
        }

        public Task PostComplexE(PostComplexERequest request)
        {
            throw new NotImplementedException();
        }
    }
}
