# Picoage Logger

## Purpose 
This package can be used to log structure logs to application insight.

## Steps: 

(a)	Create application insight in Azure portal. 

(b)	Install this package. 

(c)	In Startup.cs file add services.AddApplicationInsightLogger();

(d)	In appsetting.json add instrumentation key. 
        "ApplicationInsights": {
           "InstrumentationKey": ""
  }

(e)	Inject the IPicoageLogger <T\> into the constructor and start using the logs. E.g. IPicoageLogger<Helloworld\>
