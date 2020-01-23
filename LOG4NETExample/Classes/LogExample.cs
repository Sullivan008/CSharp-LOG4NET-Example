using log4net;
using System;
using System.Threading;

namespace LOG4NETExample.Classes
{
    public class LogExample
    {
        private readonly ILog _log;

        public LogExample()
        {
            _log = LogManager.GetLogger(typeof(LogExample));
        }

        /// <summary>
        ///     Elindítja a Logolási példát
        /// </summary>
        public void RunLogExample()
        {
            ImplementLoggingFunciton();
        }

        /// <summary>
        ///     Meghívja a LOG-olási példákat
        /// </summary>
        private void ImplementLoggingFunciton()
        {
            const int sec = 3;

            Console.WriteLine("Logging start...");

            InfoExample();
            Wait(sec);

            DebugExample();
            Wait(sec);

            ErrorExample();
            Wait(sec);

            WarnExample();
            Wait(sec);

            FatalExample();
            Wait(sec);

            Console.WriteLine("\nLogging Success!");
        }

        /// <summary>
        ///     Prezentálja egy INFO sor beszúrását a config által meghatározott log fájlba
        /// </summary>
        private void InfoExample()
        {
            Console.WriteLine("\nINFO típusú sor beszúrása az info.log fájlba!\n");
            _log.Info("INFO típusú sor beszúrása az info.log fájlba!");
        }

        /// <summary>
        ///     Prezentálja egy DEBUG sor beszúrását a config által meghatározott log fájlba
        /// </summary>
        private void DebugExample()
        {
            Console.WriteLine("\nDEBUG típusú sor beszúrása az debug.log fájlba!\n");
            _log.Debug("DEBUG típusú sor beszúrása az debug.log fájlba!");
        }

        /// <summary>
        ///     Prezentálja egy ERROR sor beszúrását a config által meghatározott log fájlba
        /// </summary>
        private void ErrorExample()
        {
            Console.WriteLine("\nERROR típusú sor beszúrása az error.log fájlba!\n");
            _log.Error("ERROR típusú sor beszúrása az error.log fájlba!");
        }

        /// <summary>
        ///     Prezentálja egy WARN sor beszúrását a config által meghatározott log fájlba
        /// </summary>
        private void WarnExample()
        {
            Console.WriteLine("\nWARN típusú sor beszúrása az info.log fájlba!\n");
            _log.Warn("WARN típusú sor beszúrása az info.log fájlba!");
        }

        /// <summary>
        ///     Prezentálja egy FATAL sor beszúrását a config által meghatározott log fájlba
        /// </summary>
        private void FatalExample()
        {
            Console.WriteLine("\nFATAL típusú sor beszúrása az info.log fájlba!\n");
            _log.Fatal("FATAL típusú sor beszúrása az info.log fájlba!");
        }

        /// <summary>
        ///     Felfüggeszti, várakoztatja a szálat, a paraméterben kapott időmennyiségik
        /// </summary>
        /// <param name="sec">A várakoztatandó időmennyiség</param>
        private void Wait(int sec)
        {
            Thread.Sleep(TimeSpan.FromSeconds(sec));
        }
    }
}
