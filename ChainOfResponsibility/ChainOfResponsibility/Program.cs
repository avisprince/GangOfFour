using ChainOfResponsibility.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AbstractLogger loggerChain = GetChainOfLoggers();

            loggerChain.LogMessage(AbstractLogger.INFO, "Info message");
            loggerChain.LogMessage(AbstractLogger.DEBUG, "Debug message");
            loggerChain.LogMessage(AbstractLogger.ERROR, "Error message");
        }

        private static AbstractLogger GetChainOfLoggers()
        {
            AbstractLogger errorLogger = new ErrorLogger(AbstractLogger.ERROR);
            AbstractLogger fileLogger = new FileLogger(AbstractLogger.DEBUG);
            AbstractLogger consoleLogger = new ConsoleLogger(AbstractLogger.INFO);

            errorLogger.SetNextLogger(fileLogger);
            fileLogger.SetNextLogger(consoleLogger);

            return errorLogger;
        }
    }
}
