using Farm.Core;
using NCalc;
using Orleans;
using System;
using System.Threading.Tasks;

namespace Farm.Silo
{
    public class CalcGrain : Grain, ICalcGrain
    {
        private int count = 0;

        public Task<int> GetCount()
        {
            return Task.FromResult(this.count);
        }

        public Task CalcValue(int input)
        {
            // Build expression
            var expr = new Expression("input + 10 >= 100");

            // Added parameter values
            expr.Parameters.Add("input", input);

            // Create executable Func
            var f = expr.ToLambda<bool>();

            // Run Func and get result
            var result = f();

            Console.WriteLine(result);

            // Increment count when result is true
            if(result == true)
                count++;

            return Task.CompletedTask;
        }
    }
}