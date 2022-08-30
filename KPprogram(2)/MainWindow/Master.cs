using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MainWindow
{
    public class Master
    {
        private List<StudentQueue> StudentQueues = new List<StudentQueue>();
        private List<Cabinet> Cabinets = new List<Cabinet>();
        private List<ServiceFact> LogList = new List<ServiceFact>();
        private Random Rnd = new Random();
        private TextBox _LogStudent_TB, _Stat_TB;
        private int _Chance = 2;
        private int _CountStudent = 1;
        public Master(TextBox LogStudent_TB, TextBox Stat_TB)
        {
            _LogStudent_TB = LogStudent_TB;
            _Stat_TB = Stat_TB;
        }
        public Master() : this(null, null) { }
        public int Chance
        { set { if (value >= 1 && value <= 5) _Chance = value; } }
        public int CountStudent
        { set { if (value >= 1 && value <= 3) _CountStudent = value; } }
        private event EventHandler<StudentArgs> NewStudentEvent;
        private void OnNewStudent()
        {
            StudentArgs E = new StudentArgs();            
            E.People = new Student(0);
            E.PrintResult = PrintResult;
            NewStudentEvent(this, E);

            if (E.People != null)
                PrintResult("не найдена подходящая очередь, <" + E.People + "> покинул дирекцию");
        }
        private event EventHandler<LogArgs> RunTimeEvent;

        private void OnRunTime()
        {
            if (RunTimeEvent != null)
            {
                LogArgs E = new LogArgs();
                E.PrintResult = PrintResult;
                E.PrintLog = PrintLog;
                RunTimeEvent(this, E);
            }
        }
        private void PrintResult(string s)
        {
            if (_LogStudent_TB != null)
                _LogStudent_TB.AppendText(s + Environment.NewLine);
        }
        private void PrintLog(ServiceFact Item)
        {
            LogList.Add(Item);
        }

        public void OnTimer()
        {
            _LogStudent_TB.Clear();
            OnRunTime();
            if (Rnd.Next(_Chance) == 0)
            {
                int Count = Rnd.Next(_CountStudent) + 1;
                for (int i = 1; i <= Count; i++)
                    OnNewStudent();
            }
        }

        public void SetStatCabinet()
        {
            _Stat_TB.Clear();
            
            var res = from ot in OperationTypes.Types
                      join elem in LogList on ot equals OperationTypes.Types[elem.OperationType]
                      into OT
                      orderby ot
                      select new
                          {
                              OperationTypes = ot,
                              Cabinet = from cs in Cabinets
                                        join cab in OT on cs.CabinetNum equals cab.CabinetNum into CS orderby cs.CabinetNum
                                        select new 
                                        {
                                            CabinetNum=cs.CabinetNum,
                                            Sum = OT.Count()
                                        }
                              
                          };            
            foreach (var elem in res)
            {
                _Stat_TB.AppendText(elem.OperationTypes + Environment.NewLine);
                foreach (var cab in elem.Cabinet)
                {

                    _Stat_TB.AppendText("    Кабинет №" + cab.CabinetNum + " : " + cab.Sum + Environment.NewLine);
                }
            }
        }

        public void AddQueue(StudentQueue Queue)
        {
            StudentQueues.Add(Queue);
            NewStudentEvent += Queue.NewStudent;
            Cabinets[0].IsReadyEvent += Queue.SetCabinet;
            Queue.SingleStudentEvent += Cabinets[0].WaitSingle;
            Cabinets[0].ReturnQueueEvent += Queue.NewStudent;

        }
        public void RemoveQueue(StudentQueue Queue)
        {
            StudentQueues.Remove(Queue);
            NewStudentEvent -= Queue.NewStudent;
            Cabinets[0].IsReadyEvent -= Queue.SetCabinet;
        }
        public void AddCabinet(Cabinet Cabinet)
        {
            Cabinets.Add(Cabinet);
            RunTimeEvent += Cabinet.RunTime;
            foreach (StudentQueue Queue in StudentQueues)
            {
                Queue.SingleStudentEvent += Cabinet.WaitSingle;
                Cabinet.IsReadyEvent += Queue.SetCabinet;
            }

        }
        public void RemoveCabinet(Cabinet Cabinet)
        {
            Cabinets.Remove(Cabinet);
            RunTimeEvent -= Cabinet.RunTime;
            foreach (StudentQueue Queue in StudentQueues)
            {
                Queue.SingleStudentEvent -= Cabinet.WaitSingle;                
            }
        }
    }
}
