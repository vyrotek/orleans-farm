using System;
using System.Threading.Tasks;
using Orleans;

namespace Farm.Core
{
    public interface ICalcGrain : IGrainWithGuidKey
    {
        Task<int> GetCount();

        Task CalcValue(int input);
    }
}
