﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutionsTest
{
    public class FactorialTest
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData(1)
                                .Returns(true)
                                .SetDescription("1 is narcissitic");
                yield return new TestCaseData(371)
                                .Returns(true)
                                .SetDescription("371 is narcissitic");

            }
        }

        [Test, TestCaseSource("testCases")]
        public bool Test(int n) => Factorial.Narcissistic(n);
    }
}
