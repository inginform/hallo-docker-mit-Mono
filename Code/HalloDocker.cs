/// <summary>
/// Einfacher C#-Quellcode um zuzeigen wie das offizielle 
/// <see href="https://registry.hub.docker.com/u/library/mono/">Mono Docker Image</see>
/// verwendet werden kann um C# Anwendungen zu erstellen und auszuführen.
/// </summary>
/// <remarks>
/// Eine ausführliche Beschreibung zu diesem Beispiel kann in 
/// <see href="">diesem Artikel</see> gefunden werden.
/// </remarks>

using System; // -> brauchen wir für die Verwendung von Console

class HalloDocker
{
	static void Main(string[] args)
	{
		Console.WriteLine("ing.inform sagt Hallo aus einem Docker Container!");
	}
}
