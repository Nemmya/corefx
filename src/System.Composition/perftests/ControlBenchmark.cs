// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositionThroughput
{
    internal class ControlBenchmark : Benchmark
    {
        public override Action GetOperation()
        {
            return () => { };
        }

        public override string Description
        {
            get { return "Control (Empty)"; }
        }

        public override bool SelfTest()
        {
            return true;
        }
    }
}
