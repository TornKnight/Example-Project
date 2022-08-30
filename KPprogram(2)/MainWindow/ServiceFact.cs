using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainWindow
{
    public class ServiceFact
    {
        private static int Counter;
        private int _ID;
        private int _OperationType;
        private int _CabinetNum;
        public ServiceFact(int CabinetNum, int OperationType)
        {
            if (CabinetNum>0 && OperationType >= 0 && OperationType < OperationTypes.Types.Length)
            {
                _ID = ++Counter;
                _OperationType = OperationType;
                _CabinetNum = CabinetNum;
            }
            else throw new Exception("Параметры записи Log-файла заданы неправильно");
        }
        public override string ToString()
        {
            return _ID + ": Кабинет, " + _CabinetNum+ ", " + OperationTypes.Types[_OperationType];
        }
        public int ID
        {
            get { return _ID; }
        }
        public int CabinetNum
        {
            get { return _CabinetNum; }
            set
            {
                if (value > 0)
                    _CabinetNum = value;
            }
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
