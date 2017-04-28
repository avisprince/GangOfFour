using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Logger
{
    public abstract class AbstractLogger
    {
        public const int INFO = 1;
        public const int DEBUG = 2;
        public const int ERROR = 3;

        protected int level;
        protected AbstractLogger nextLogger;

        public AbstractLogger(int level)
        {
            this.level = level;
        }

        public void SetNextLogger(AbstractLogger nextLogger)
        {
            this.nextLogger = nextLogger;
        }

        public void LogMessage(int level, string message)
        {
            if (this.level <= level)
            {
                Write(message);
            }

            if (nextLogger != null)
            {
                nextLogger.LogMessage(level, message);
            }
        }

        public abstract void Write(string message);
    }
}
