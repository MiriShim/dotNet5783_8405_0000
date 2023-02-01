using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulatorLib
{
    public delegate void StateChangeDel(DO.ProductStatus prevState, DateTime startAt, DO.ProductStatus newState, DateTime endAt);
    public delegate void ProductSelectedDel(BO.Product product);
    public class Simulator
    {        
        public static Simulator GetInstance(BlApi.IBL _bl)
        {
            bl = _bl;
            return nested.simulatorInstance;
            //if (_simulator == null)
            //    _simulator = new();
            //return _simulator;
        }
         Simulator()
        {
                
        }
        class nested
        {
            internal static readonly Simulator simulatorInstance = new Simulator ();
           }
       static  BlApi.IBL? bl;
        volatile bool stopRequest = false;
        event Action? simulatorStopedEvent;
        event StateChangeDel? stateChangedEvent;
        event ProductSelectedDel? productSelectedEvent;

        Random random = new Random();
        public void SetSimulatorOn()
        {
            Thread thread = new Thread(simulatorDo);
            stopRequest = false;
            thread.Start();
        }

        public void SetSimulatorOff()
        {
            stopRequest = true;
        }

        private void simulatorDo(object? obj)
        {
            while (!stopRequest)
            {
                BO.Product current = bl.Product.SelectProductToState();
                productSelectedEvent?.Invoke (current);

                if (current == null)
                {
                    Thread.Sleep(1000);
                    continue;
                }
                if (stopRequest) break;//אם יש בקשת עצירה
                int treatTime = random.Next(3000, 10000);
                DO.ProductStatus  prevState = current.ProductStatus;

                DateTime startChangeAt = DateTime.Now; //שמירת זמן תחילת הפעולה
                Thread.Sleep(treatTime);//המתנה של הזמן הנדרש לביצוע השינוי במצב (רנדומלי)
                current.ProductStatus++;
                bl.Product.Update(current); //שמירת האוביקט עם המצב החדש

                stateChangedEvent?.Invoke ((DO.ProductStatus)prevState, startChangeAt, current.ProductStatus, DateTime.Now);
            }
            simulatorStopedEvent?.Invoke ();
        }

        public void RegisterSimulatorStoped(Action del)
        { simulatorStopedEvent += del; }
        public void RegisterStateChanged(StateChangeDel del)
        { stateChangedEvent += del; }
        public void RegisterProductSelected(ProductSelectedDel del)
        { productSelectedEvent += del; }
    }
}
