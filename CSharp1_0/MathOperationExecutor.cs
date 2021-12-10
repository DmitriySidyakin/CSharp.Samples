using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1_0
{
    public class MathOperationExecutor
    {
        public MathOperation Execute;

        public event MathOperation MathSequence;

        public MathOperationExecutor()
        {
            Execute = Sum;
        }

        public MathOperationExecutor(MathOperation operation)
        {
            Execute = operation;
        }

        public void ExecuteMathSequence(int left, int right)
        {
            if(MathSequence != null)
                MathSequence.Invoke(left, right);
        }

        static public long Sum(int left, int right)
        {
            long result = left + right;
            Console.WriteLine(left + " + " + right + " = " + result);
            return result;
        }

        static public long Sub(int left, int right)
        {
            long result = left - right;
            Console.WriteLine(left + " - " + right + " = " + result);
            return result;
        }

        static public long Div(int left, int right)
        {
            long result = left / right;
            Console.WriteLine(left + " / " + right + " = " + result);
            return result;
        }

        static public long Rem(int left, int right)
        {
            long result = left % right;
            Console.WriteLine(left + " % " + right + " = " + result);
            return result;
        }

        static public long Mul(int left, int right)
        {
            long result = left * right;
            Console.WriteLine(left + " * " + right + " = " + result);
            return result;
        }
    }
}
