using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using InfluxDB.Collector;

public class InfluxService
{
    public InfluxService()
    {

    }

    public void WriteCpuTime()
    {

        Metrics.Collector = new CollectorConfiguration()
    .Tag.With("host", Environment.GetEnvironmentVariable("COMPUTERNAME"))
    .Batch.AtInterval(TimeSpan.FromSeconds(2))
    .WriteTo.InfluxDB("http://localhost:8086", "data")
    .CreateCollector();

        Metrics.Increment("iterations");

        Metrics.Write("cpu_time",
            new Dictionary<string, object>
            {
        { "value", 1 },
        { "user", 2 }
            });

        Metrics.Measure("working_set", new { });

    }
}
