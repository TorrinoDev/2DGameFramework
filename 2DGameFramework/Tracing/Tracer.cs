using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DGameFramework.Tracing
{
    public class Tracer
    {

        public Tracer(TraceSource ts)
        {
            ts.Switch = new SourceSwitch("Game Log", "All");

            TraceListener consoleLog = new ConsoleTraceListener();
            consoleLog.Filter = new EventTypeFilter(SourceLevels.Information);
            ts.Listeners.Add(consoleLog);

            TraceListener fileLog = new TextWriterTraceListener(new StreamWriter("Tracing.txt"));
            ts.Listeners.Add(fileLog);
        }
    }
}
