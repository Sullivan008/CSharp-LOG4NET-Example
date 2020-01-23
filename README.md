# C# - Logging Example with log4net Nuget Package [Year of Development: 2017]

About the application technologies and operation:

### Technologies:
- Programming Language: C#
- FrontEnd Side: Console Application
- BackEnd Side: .NET Framework 4.5.2.

### Installation/ Configuration:

1. Restore necessary Packages, run the following command in **PM Console**

   ```
   Update-Package -reinstall
   ```
 
2. Configure log4net using the .config file in **AssemblyInfo.cs** file

   ```C#
   [assembly: log4net.Config.XmlConfigurator(Watch = true)]
   ```
 
### About the application:

The Apache log4net library is a tool to help the programmer output log statements to a variety of output targets.

The application shows the following:
- How you can **Logging** in a **Console Application** with **Apache log4net** package.

### Configuration Helping:

1. How to show logging output in the console.

    ```XML
    <appender name="Console" type="log4net.Appender.ConsoleAppender">
        <layout type="log4net.Layout.PatternLayout">
            <conversionPattern value="[%level] - %date - %type.%method, row: %line - %message%n"/>
        </layout>
    </appender>
    ```

2. How to logging in one log file an **INFO**, **DEBUG**, **WARN**, **FATAL**, **ERROR**

   ```XML
    <appender name="Console" type="log4net.Appender.ConsoleAppender">
        <layout type="log4net.Layout.PatternLayout">
            <conversionPattern value="[%level] - %date - %type.%method, row: %line - %message%n"/>
        </layout>
      </appender>
   
    <appender name="LOGSRollingLogFileAppender" type="log4net.Appender.RollingFileAppender,log4net">
        <param name="File" value="logs\logs.log" />
        <param name="AppendToFile" value="true" />
        <param name="MaxSizeRollBackups" value="10" />
        <param name="MaximumFileSize" value="10240KB" />
        <param name="RollingStyle" value="Size" />
        <param name="StaticLogFileName" value="true" />
        <layout type="log4net.Layout.PatternLayout,log4net">
            <param name="ConversionPattern" value="[%level] - %date - %type.%method, row: %line - %message%n"/>
        </layout>
    </appender>

    <root>
        <level value="ALL" />
        <appender-ref ref="LOGSRollingLogFileAppender" />
    </root>
    ```

3. How to separate log files by **INFO**, **DEBUG**, **WARN**, **FATAL**, **ERROR**

    ```XML
    <appender name="InfoRollingLogFileAppender" type="log4net.Appender.RollingFileAppender,log4net">
        <param name="File" value="logs\info.log" />
        <param name="AppendToFile" value="true" />
        <param name="MaxSizeRollBackups" value="10" />
        <param name="MaximumFileSize" value="5120KB" />
        <param name="RollingStyle" value="Size" />
        <param name="StaticLogFileName" value="true" />
        <param name="Threshold" value="INFO"/>
        <layout type="log4net.Layout.PatternLayout,log4net">
            <param name="ConversionPattern" value="[%level] - %date - %type.%method, row: %line - %message%n"/>
        </layout>
        <filter type="log4net.Filter.LevelRangeFilter">
            <levelMin value="INFO"/>
            <levelMax value="INFO"/>
        </filter>
    </appender>
       
    <appender name="DebugRollingLogFileAppender" type="log4net.Appender.RollingFileAppender,log4net">
        <param name="File" value="logs\debug.log"/>
        <param name="AppendToFile" value="true" />
        <param name="MaxSizeRollBackups" value="10" />
        <param name="MaximumFileSize" value="5120KB" />
        <param name="RollingStyle" value="Size" />
        <param name="StaticLogFileName" value="true" />
        <param name="Threshold" value="DEBUG"/>
        <layout type="log4net.Layout.PatternLayout,log4net">
            <param name="ConversionPattern" value="[%level] - %date - %type.%method, row: %line - %message%n"/>
        </layout>
        <filter type="log4net.Filter.LevelRangeFilter">
            <levelMin value="DEBUG"/>
            <levelMax value="DEBUG"/>
        </filter>
    </appender>
      
    <appender name="ErrorRollingLogFileAppender" type="log4net.Appender.RollingFileAppender,log4net">
        <param name="File" value="logs\error.log"/>
        <param name="AppendToFile" value="true"/>
        <param name="MaxSizeRollBackups" value="10"/>
        <param name="MaximumFileSize" value="5120KB"/>
        <param name="RollingStyle" value="Size"/>
        <param name="StaticLogFileName" value="true"/>
        <param name="Threshold" value="ERROR"/>
        <layout type="log4net.Layout.PatternLayout,log4net">
            <param name="ConversionPattern" value="[%level] - %date - %type.%method, row: %line - %message%n"/>
        </layout>
        <filter type="log4net.Filter.LevelRangeFilter">
            <levelMin value="ERROR"/>
            <levelMax value="ERROR"/>
        </filter>
    </appender>
     
    <appender name="WarnRollingLogFileAppender" type="log4net.Appender.RollingFileAppender,log4net">
        <param name="File" value="logs\warn.log"/>
        <param name="AppendToFile" value="true"/>
        <param name="MaxSizeRollBackups" value="10"/>
        <param name="MaximumFileSize" value="5120KB"/>
        <param name="RollingStyle" value="Size"/>
        <param name="StaticLogFileName" value="true"/>
        <param name="Threshold" value="WARN"/>
        <layout type="log4net.Layout.PatternLayout,log4net">
            <param name="ConversionPattern" value="[%level] - %date - %type.%method, row: %line - %message%n"/>
        </layout>
        <filter type="log4net.Filter.LevelRangeFilter">
            <levelMin value="WARN"/>
            <levelMax value="WARN"/>
        </filter>
    </appender>
      
    <appender name="FatalRollingLogFileAppender" type="log4net.Appender.RollingFileAppender,log4net">
        <param name="File" value="logs\fatal.log" />
        <param name="AppendToFile" value="true"/>
        <param name="MaxSizeRollBackups" value="10"/>
        <param name="MaximumFileSize" value="5120KB"/>
        <param name="RollingStyle" value="Size"/>
        <param name="StaticLogFileName" value="true"/>
        <param name="Threshold" value="FATAL"/>
        <layout type="log4net.Layout.PatternLayout,log4net">
            <param name="ConversionPattern" value="[%level] - %date - %type.%method, row: %line - %message%n"/>
        </layout>
        <filter type="log4net.Filter.LevelRangeFilter">
            <levelMin value="FATAL"/>
            <levelMax value="FATAL"/>
        </filter>
    </appender>
    
    <root>
        <level value="debug" />
        <appender-ref ref="InfoRollingLogFileAppender" />
        <appender-ref ref="DebugRollingLogFileAppender" />
        <appender-ref ref="ErrorRollingLogFileAppender" />
        <appender-ref ref="WarnRollingLogFileAppender" />
        <appender-ref ref="FatalRollingLogFileAppender" />
    </root>
    ```
