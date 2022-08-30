using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainWindow
{
    public class Student
    {
        private static int Counter;
        private int _ID;
        private int _OperationType;
        public Student(int OperationType)
        {
            _ID = ++Counter;
            _OperationType = (OperationType >= 0 && OperationType < OperationTypes.Types.Length) ? OperationType : 0;
        }
        public Student() : this(0) { }
        public override string ToString()
        {

            return "Студент " + _ID + " (" + OperationTypes.Types[_OperationType] + ")";
        }
        public int OperationType
        {
            get { return _OperationType; }
            set
            {
                if (value >= 0 && value < OperationTypes.Types.Length)
                    _OperationType = value;
            }
        }
    }
}
