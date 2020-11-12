using System.IO;
using log4net.Config;
using UnityEngine;

public static class LoggingConfiguration
{
    // Mit RuntimeInitializeLoadType.BeforeSceneLoad stellen wir sicher,
    // dass wir Log4Net konfigurieren, bevor die Szene geladen wird.
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void ConfigureLogging()
    {
        XmlConfigurator.Configure(new FileInfo($"{Application.dataPath}/log4net.xml"));
    }
}
