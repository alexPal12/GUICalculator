using Avalonia.Markup.Xaml.Templates;
using Avalonia.Metadata;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System;
using System.Data;
using Avalonia.Controls;

namespace InClassCalculator
{
    public class Solver : ISolve
    {
        public static int count;
        //string to accumulate
        private string accumulateNumbers = "";

        public void Accumulate(string s)
        {
            accumulateNumbers += s;
            count++;
        }

        public void Clear()
        {
            accumulateNumbers = "";
        }

        public double solve()
        {
            try
            {
                DataTable table = new DataTable();
                var result = Convert.ToDouble(table.Compute(accumulateNumbers, ""));
                accumulateNumbers = ""; // Clear accumulated expression after evaluation
                return result;
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error evaluating expression", e);
            }
        }

        //private double EvaluateExpression(string expression)
        //{
        //    return Convert.ToDouble(new System.Data.DataTable().Compute(expression, ""));
        //}

        public Solver()
        {

        }
    }
}
