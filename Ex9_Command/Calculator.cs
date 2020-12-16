using System;
using System.Collections.Generic;
using System.Text;

namespace Ex9_Command
{
    class Calculator
    {
        ArithmeticUnit arithmeticUnit;
        ControlUnit controlUnit;
        public Calculator()
        {
            arithmeticUnit = new ArithmeticUnit();
            controlUnit = new ControlUnit();
        }
        private double Run(Command command)
        {
            controlUnit.StoreCommand(command);
            controlUnit.ExecuteCommand();
            return arithmeticUnit.Register;
        }
        public double Add(double operand)
        {
            return Run(new Add(arithmeticUnit, operand));
        }
        public double Sub(double operand)
        {
            return Run(new Sub(arithmeticUnit, operand));
        }
        public double Multiply(double operand)
        {
            return Run(new Multiply(arithmeticUnit, operand));
        }
        public double Div(double operand)
        {
            return Run(new Div(arithmeticUnit, operand));
        }
        public double Redo()
        {
            controlUnit.Redo();
            return arithmeticUnit.Register;
        }
        public double Redo(int i)
        {
            controlUnit.Redo(i);
            return arithmeticUnit.Register;
        }

        public double Undo()
        {
            controlUnit.Undo();
            return arithmeticUnit.Register;
        }

        public double Undo(int i)
        {
            controlUnit.Undo(i);
            return arithmeticUnit.Register;
        }
    }
}
