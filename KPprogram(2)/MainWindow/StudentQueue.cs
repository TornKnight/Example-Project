using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MainWindow
{
    public class StudentQueue
    {
        private static int Counter;
        private int _ID;
        private int _OperationType;
        private Queue<Student> _Queue = new Queue<Student>();
        private ListBox _LB;
        public string _Name;
        public StudentQueue(int OperationType, ListBox LB)
        {
            _ID = ++Counter;
            _OperationType = OperationType;
            _LB = LB;
            _Name = "Очередь";
        }
        public StudentQueue()
            : this(0, null)
        {
        }
        public override string ToString()
        {
            return _Name;
        }
        public int QueueNumber
        {
            get { return _ID; }
        }
        public int OpetrionType
        {
            get { return _OperationType; }
        }
        public event EventHandler<OnlyPrintArgs> SingleStudentEvent;
        private void OnSingleStudent(CalcBack PrintResult)
        {
            if (SingleStudentEvent != null && _Queue.Count == 1)
            {
                OnlyPrintArgs E = new OnlyPrintArgs();
                E.PrintResult = PrintResult;
                SingleStudentEvent(this, E);
            }
        }
        public void NewStudent(object sender, StudentArgs e)
        {
            if (e.People != null && e.People.OperationType == _OperationType)
            {
                _Queue.Enqueue(e.People);
                if (_LB != null)
                    _LB.Items.Add(e.People);
                if (e.PrintResult != null)
                    e.PrintResult(this + ": добавлен <" + e.People + ">");
                e.People = null;
                OnSingleStudent(e.PrintResult);
            }

        }



        public void SetCabinet(object sender, CabinetArgs e)
        {
            if (_Queue.Count > 0 && e.IsReady)
            {
                StudentArgs E = new StudentArgs();
                E.People = _Queue.Dequeue();
                _LB.Items.Remove(E.People);                
                E.PrintResult = e.PrintResult;
                e.IsReady = e.SetCabinet(E);

            }
        }
    }
}
