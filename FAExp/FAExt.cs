using FluentAssertions;
using FluentAssertions.Primitives;
using FluentAssertions.Numeric;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions.Execution;
using FluentAssertions.Common;

namespace FAExp
{
    public static class FAExt
    {

        public static AndConstraint<NumericAssertions<T>> Be2<T>(
            this NumericAssertions<T> numAssert, T expected, string fail = "", params object[] failArgs)  
            where T : struct, IComparable<T>
        {
            Execute.Assertion
                .ForCondition(numAssert.Subject.IsSameOrEqualTo(expected))
                //.BecauseOf(because, becauseArgs)
                .FailWith("{context:value} cippa lippa {0}",12);
                //.FailWith(fail, failArgs);
            
            return new AndConstraint<NumericAssertions<T>>((NumericAssertions<T>)numAssert);
        }
            //public (T expected, string because = "", params object[] becauseArgs)
    }
}
