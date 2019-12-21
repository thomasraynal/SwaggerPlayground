using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ComplexApp.Complex
{
    public interface IComplexService
    {

Task PostComplexA(PostComplexARequest request);


Task PostComplexB(PostComplexBRequest request);


Task PostComplexC(PostComplexCRequest request);


Task PostComplexD(PostComplexDRequest request);


Task PostComplexE(PostComplexERequest request);

    }
}
