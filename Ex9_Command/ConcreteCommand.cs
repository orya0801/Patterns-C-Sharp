using System;
using System.Collections.Generic;
using System.Text;

namespace Ex9_Command
{
    class Add : Command
    {
        public Add(ArithmeticUnit unit, double operand)
        {
            this.unit = unit;
            this.operand = operand;
        }
        public override void Execute()
        {
            unit.Run('+', operand);
        }
        public override void UnExecute()
        {
            unit.Run('-', operand);
        }
    }

    class Sub : Command
    {
        public Sub(ArithmeticUnit unit, double operand)
        {
            this.unit = unit;
            this.operand = operand;
        }
        public override void Execute()
        {
            unit.Run('-', operand);
        }
        public override void UnExecute()
        {
            unit.Run('+', operand);
        }
    }

    class Multiply : Command
    {
        public Multiply(ArithmeticUnit unit, double operand)
        {
            this.unit = unit;
            this.operand = operand;
        }
        public override void Execute()
        {
            unit.Run('*', operand);
        }
        public override void UnExecute()
        {
            unit.Run('/', operand);
        }
    }

    class Div : Command
    {
        public Div(ArithmeticUnit unit, double operand)
        {
            this.unit = unit;
            this.operand = operand;
        }

        public override void Execute()
        {
            unit.Run('/', operand);
        }
        public override void UnExecute()
        {
            unit.Run('*', operand);
        }
    }
}
