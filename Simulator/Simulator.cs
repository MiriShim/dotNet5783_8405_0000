using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulatorLib
{
    public delegate void StateChangeDel(BO.ProductStatus prevState, DateTime startAt, BO.ProductStatus newState, int durationInMinuts);
    public delegate void ProductSelectedDel(BO.Product product,int willUpdatedAt);
    public class Simulator
    {
        public bool IsAlive { get; set; } = false;
        public static Simulator GetInstance(BlApi.IBL _bl)
        {
            bl = _bl;
            return Nested.simulatorInstance;
            //if (_simulator == null)
            //    _simulator = new();
            //return _simulator;
        }
         Simulator()
        {
        }
        class Nested
        {
            internal static readonly Simulator simulatorInstance = new Simulator ();
        }

       static  BlApi.IBL? bl;
        volatile bool stopRequest = false;
        
        event Action SimulatorStopedEvent;
        event StateChangeDel? StateChangedEvent;
        event ProductSelectedDel? ProductSelectedEvent;

        Random random = new Random();
        public void SetSimulatorOn()
        {
            //if simulator is off
            IsAlive= true;
            Thread thread = new Thread(simulatorDo);
            stopRequest = false;
            thread.Start();
        }

        public void SetSimulatorOff()
        {
            stopRequest = true;
            IsAlive = false;
        }

        private void simulatorDo(object? obj)
        {
            while (!stopRequest)
            {
                BO.Product? current = bl?.Product.SelectProductToState() ;
                 
                if (current == null)
                {
                    stopRequest = true;
                    break;
                    //Thread.Sleep(1000);
                    //continue;
                }
                if (stopRequest) break;//אם יש בקשת עצירה
 
                int treatTime = random.Next(2000, 10000);

                BO.ProductStatus  prevState = current.ProductStatus;

                DateTime startChangeAt = DateTime.Now; //שמירת זמן תחילת הפעולה
                 
                ProductSelectedEvent?.Invoke(current,treatTime/1000 );

                Thread.Sleep(treatTime);//המתנה של הזמן הנדרש לביצוע השינוי במצב (רנדומלי)

                current.ProductStatus++;
                current.LastUpdateAt = DateTime.Now;
                bl.Product.Update(current); //שמירת האוביקט עם המצב החדש

                StateChangedEvent?.Invoke ( prevState, startChangeAt, current.ProductStatus, treatTime/1000);
            }
            SimulatorStopedEvent?.Invoke ();
        }
        List<IObserveSimulator> observers = new List<IObserveSimulator>();

        public void RegisterSimulatorStoped(Action del)
        { SimulatorStopedEvent += del; }
        //אם רוצים לממש את הסימולטור  כאבזרבר מושלם
        public void RegisterSimulatorStoped(IObserveSimulator del)
        { observers.Add(del); }
        public void RegisterStateChanged(StateChangeDel del)
        { StateChangedEvent += del; }
        public void RegisterProductSelected(ProductSelectedDel del)
        { ProductSelectedEvent += del; }
    }
}
