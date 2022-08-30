using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MainWindow
{
    public delegate void CalcBack(string s);
    public class OnlyPrintArgs : EventArgs
    {
        public CalcBack PrintResult;
    }
    public class StudentArgs : OnlyPrintArgs
    {
        public Student People;
    }
    public delegate bool CabinetCalcBack(StudentArgs e);
    public class CabinetArgs : OnlyPrintArgs
    {
        public CabinetCalcBack SetCabinet;
        public bool IsReady;
    }
    public delegate void LogCalcBack(ServiceFact e);
    public class LogArgs : OnlyPrintArgs
    {
        public LogCalcBack PrintLog;
    }
    public class Cabinet
    {
        private static int Counter;
        private int _ID;
        private TextBox _TB;
        private string _Name = "Кабинет";
        private Student _Current;
        public Cabinet(TextBox TB)
        {
            _ID = ++Counter;
            _Name = "Кабинет "+_ID;
            _TB = TB;
            if (_TB != null)
                TB.Clear();
        }
        public Cabinet() : this(null) { }
        public override string ToString()
        {
            return _Name;
        }
        public int CabinetNum
        {
            get { return _ID; }
        }
        private bool SetStudent(StudentArgs E)
        {
            if (E.People != null)
                if (_Current == null)
                {
                    _Current = E.People;
                    if (_TB != null)
                        _TB.Text = E.People.ToString();
                    if (E.PrintResult != null)
                        E.PrintResult(this + ": зашел в кабинет <" + E.People + ">");
                }
                else
                {
                    if (E.PrintResult != null)
                        E.PrintResult(this + ": <" + E.People + "> не смог зайти в кабинет, так как он занят");
                }
            return _Current == null;
        }
        public event EventHandler<CabinetArgs> IsReadyEvent;
        public void OnIsReady(CalcBack PrintResult)
        {
            if (IsReadyEvent != null && _Current == null)
            {
                CabinetArgs E = new CabinetArgs();
                E.PrintResult = PrintResult;
                E.SetCabinet = SetStudent;
                E.IsReady = true;
                IsReadyEvent(this, E);
            }
        }        

        public void RunTime(object sender, LogArgs e)
        {
            if (_Current != null)
            {
                if (e.PrintResult != null)
                    e.PrintResult(this + ": <" + _Current + "> выполнено");
                if (e.PrintResult != null)
                    e.PrintLog(new ServiceFact(_ID, _Current.OperationType));
                if (_TB != null)
                    _TB.Clear();

                if (e.PrintResult != null)
                {
                    e.PrintResult(this + ": <" + _Current + "> вышел из кабинета");
                    
                }

                ReturnQueue(e.PrintResult);
                OnIsReady(e.PrintResult);
            }
        }

        public event EventHandler<StudentArgs> ReturnQueueEvent;
        
        public void ReturnQueue(CalcBack PrintResult)
        {

            if (ReturnQueueEvent != null)
            {
                StudentArgs E = new StudentArgs();

                E.People = _Current;

                Random rnd = new Random();
                if (E.People != null)
                {
                    switch (E.People.OperationType)
                    {
                        case 0:
                            E.People.OperationType = rnd.Next(1, 3);                            
                            break;
                        case 1:
                            E.People = null;
                            break;
                        case 2:
                            E.People.OperationType = 4;
                            break;
                        case 3:
                            E.People.OperationType = rnd.Next(1, 3);
                            break;
                        case 4:
                            E.People.OperationType = 3;
                            break;
                    }
                }

                E.PrintResult = PrintResult;
                _Current = null;

                if (E.People != null)
                    ReturnQueueEvent(this, E);
            }
        }

        public void WaitSingle(object sender, OnlyPrintArgs e)
        {
            OnIsReady(e.PrintResult);
        }
    }
}
