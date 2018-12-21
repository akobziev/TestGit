using Ninject;
using Solid.IoC;
using System;

namespace Solid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //kernel.Bind<IWeapon>().To<Sward>();
            var kernel = new StandardKernel();
            kernel.Bind<ISchedule>().To<ScheduleManager>();
            var scheduleViewer = kernel.Get<ScheduleViewer>();
            Console.WriteLine(scheduleViewer.RenderSchedule());

            //var warior = kernel.Get<Warior>();
            //warior.Kill();


        }
    }

    class ScheduleManager : ISchedule
    {
        public String GetSchedule()
        {
            return "1,2,3";
        }
    }

    class ScheduleViewer
    {
        ISchedule _scheduleManager;

        public ScheduleViewer(ISchedule scheduleManager)
        {
            _scheduleManager = scheduleManager;
        }

        public string RenderSchedule()
        {
            return "<" + _scheduleManager.GetSchedule() + ">";
        }
    }
}
