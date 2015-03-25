#Mit Containern frei von Abhängigkeiten, oder Hallo Docker

Hast Du Dich schon mal geärgert, dass die von Dir entwickelte Anwendung auf Deinem Rechner läuft, aber auf anderen nicht? Hast Du vielleicht häufiger die Anforderung, dass Deine Anwendung auch auf einem anderen Betriebssystem laufen soll? Dann stelle ich Dir jetzt eine Technologie vor, die Dich vielleicht weiter bringt.

##Wo genau liegt das Problem?

Bevor ich Dir Docker im Detail vorstelle möchte ich Dir erst zeigen welches Problem diese Technologie für Dich lösen kann. 
Stell Dir vor Du hast ein Steuergerät. Dies könnte zum Beispiel den Motor einer Tür ansteuern. Nun willst Du eine kleine Anwendung schreiben welche auf einem Rechner läuft und das über eine USB-Verbindung angeschlossene Steuergerät anweist in periodischen Abständen die verbundene Tür zu öffnen. So etwas brauchst Du bestimmt häufiger, wenn Du Dein Steuergerät oder das ganze System testen möchtest (z.B.  für eine Dauerlaufprüfung).

Die Lösung scheint erstmal recht einfach. Du nimmst die Entwicklungsumgebung Deiner Wahl, zum Beispiel Visual Studio mit .Net 4.5 und C#, und fängst an die Anwendung zu erstellen. Natürlich brauchst Du auch noch einen Treiber, damit Du eine Kommunikationsverbindung mit dem Steuergerät herstellen kannst. Nicht lange und alles läuft auf Deinem Entwicklungsrechner wie es soll.

Nun willst Du diese Anwendung aber nicht auf Deinem Entwicklungsrechner laufen lassen, sondern an zwei unterschiedlichen Versuchsaufbauten. Ausserdem haben Dich gerade die Qualitätssicherung und ein externes Prüflabor gebeten Ihnen eine ähnliche Anwendung für ihre Prüfung bereit zu stellen. Du hast also Deine Anwendung und insgesamt 4 unterschiedliche Rechner auf denen Du sie laufen lassen willst.

Wie immer ist es leider nicht so, dass die Rechner die gleiche Version des Betriebssystems verwenden, sondern sie sind unterschiedlich. Du musst also auf allen Rechnern feststellen ob die passende .Net Version installiert ist und diese gegebenenfalls nach installieren. Du musst den passenden Treiber installieren und hast dabei Konflikte mit anderen bereits installierten Treibern und so weiter. Letztlich hast Du mehr Zeit damit verbracht die Anwendung auf allen Rechnern zu installieren, als die Anwendung zu entwickeln.

Wahrscheinlich wäre es einfacher gewesen Deinen Entwicklungsrechner zu klonen und überall dahin zu stellen wo Deine Anwendung benötigt wird. Offensichtlich hätte dies andere Probleme, aber Du könntest Dir sicher sein, dass es in jeder Umgebung einfach laufen wird.

##Dafür gibt es Docker!

Genau an diesem Punkt setzt Docker an. Docker ist eine Technologie und in ihrem Mittelpunkt steht ein Gebilde welches Container genannt wird. Du kannst Dir einen Container als eine Art kleinen Computer vorstellen. Ein Container bietet genügend Platz um eine Anwendung und alles was diese zum laufen braucht auf zu nehmen. 

Wenn Du Deine Anwendung und alle Ihre Abhängigkeiten in diesen Container gepackt hast, kannst Du ihn klonen und auf jeden Rechner kopieren. Da ein Container eine Art kleiner Computer ist, kannst Du ihn starten und es wird automatisch Deine Anwendung ausgeführt. Wenn Du Deine Anwendung also in einen Container gepackt hast und dieser auf Deinem Entwicklungsrechner läuft, dann wird er auch auf allen anderen Rechnern laufen.

Somit bietet Dir Docker nicht nur die Möglichkeit Deine Anwendung einfach auf unterschiedlichen Rechnern laufen zu lassen, sondern es bietet Deiner Anwendung einen eigenen Sandkasten. Für den Inhalt Deines Containers bist Du verantwortlich. Wenn Deine Anwendung also einen Treiber braucht, dann kannst Du diesen in Deinem Container installieren. Du hast aber keine Konflikte mit anderen Treibern, weil Du eben nur diesen einen Treiber installierst. Entsprechend ist es (fast) egal was sonst noch so auf dem Rechner läuft oder installiert ist.

In einem Container wird Deine Anwendung also wirklich Portable. Somit wird auch die Entwicklung Deiner Anwendung in den meisten Fällen wesentlich vereinfacht. Denn nun brauchst Du Dir nicht mehr die Gedanken machen was die Unterschiede der Umgebungen sind in denen Deine Anwendung einmal laufen soll. Du definierst einfach Deine Wunschumgebung und realisierst diese dann in dem Container. Dadurch wird schon mal ein großer Teil von Variablen eliminiert und Du kannst Dich wieder ein bisschen mehr darauf konzentrieren was wirklichen Nutzen für Dich und/oder Deine Anwender bringt.

##Wie ist Docker aufgebaut?

Wie bereits erwähnt, ist der Container die zentrale Einheit bei Docker. In den meisten Fällen läuft in einem Container genau eine Instantz einer Anwendung. Nun ist es möglich mehrere Instanzen einer Anwendung auf dem selben oder auch auf unterschiedlichen Rechnern laufen zu lassen. Entsprechend hat ein Container eine eindeutige Identifikationsnummer und einen Namen. 

Wenn wir bei unserem Beispiel von oben bleiben und annehmen, dass wir Steuergeräte von Türen testen wollen, dann könnte es sein, das wir mehrere Steuergeräte an einen Rechner angeschlossen haben. Nun müssen wir unsere Anwendung einmal für jedes Steuergerät ausführen. Wir starten also pro Steuergerät einen Container. Jeden dieser Container können wir eindeutig identifizieren über seine Id oder seinen Namen.

Damit Du nun nicht für jeden Container immer wieder definieren musst was genau alles da rein soll, gibt es in Docker Images. Ein Image ist quasi die Blaupause für eine bestimmte Art von Container. Für ein Image kannst Du definieren welche Basisfunktionen es haben soll, welche Anwendung darin laufen soll und so weiter. Solch ein Image ist aber nicht nur eine Beschreibung, sondern es ist ein Binärpaket welches von einer Docker-Installation ausgeführt werden kann.

Für das Beispiel von oben müssten wir also ein Image erstellen, dass einen Treiber, für die Kommunikation mit dem Steuergerät enthält, dass das .NET 4.5 Framework enthält, und natürlich die erstellte Anwendung. Für jedes Image wird weiterhin angegeben auf welcher Basis es laufen soll. In diesem Beispiel könntest Du Windows 8 angeben. Leider ist dies momentan noch nicht möglich, weil Microsoft noch an der Integration von Docker arbeitet.

Wenn Du einen Container starten willst, dann brauchst Du lediglich sagen welches Image die Basis sein soll und unter Umständen musst Du noch ein paar Konfigurationsinformationen angeben. Dann aber kannst Du so viele Container von diesem Image starten wie Du willst. Mit Docker Hub gibt es sogar eine Möglichkeit Images mit anderen Leuten zu teilen. Du brauchst beim erstellen Deiner Images also nicht immer von vorne anfangen, sondern kannst Dich einer breiten Basis von Images bedienen.

##GENUG (langweilige) Theorie, lass uns endlich was machen

Bei mir hat es recht lange gedauert, bis ich das volle Potential, die Funktionsweise und den allgemeinen Aufbau von Docker erkannt habe. Dabei musste ich immer wieder feststellen, dass mir Beispiele und das erstellen von eigenen Images und Containern am besten geholfen haben. 

Du hast vielleicht schon mal etwas von [Mono](http://www.mono-project.com) gehört. Das ist ein Projekt welches Teile des .NET Frameworks von Microsoft unter Unix, Linux, Mac OS X, usw. bereitstellt. Damit lassen sich Anwendungen in C#, F#, ... auch auf anderen Plattformen als Microsoft Windows entwickeln. Dies brauchst Du aktuell vielleicht nicht, aber ich möchte Dir zeigen wie einfach es ist ein (sehr) einfache C#-Anwendung zu kompilieren und auszuführen.

Natürlich verwenden wir dafür Docker! Der erste Schritt für Dich ist also die Docker Engine zu installieren. Da es je nach verwendetem Betriebssystem unterschiedliche Installationsanweisungen gibt, solltest Du einfach [hier](https://docs.docker.com/installation/#installation) nach Deinem Betriebssystem suchen und dann die entsprechenden Schritte ausführen. 

Sobald Du eine lauffähige Docker Installation hast (am besten mit `docker version` überprüfen wie in dem jeweiligen Installationsanweisungen beschrieben), kann es auch schon los gehen. Ich habe für Dich eine kleine C#-Anwendung geschrieben und [hier](https://github.com/inginform/hallo-docker-mit-Mono/blob/master/Code/HalloDocker.cs) auf Github abgelegt. Wie Du sehen kannst ist die Anwendung sehr einfach. Sie gibt lediglich einen Text auf der Kommandozeile aus, wenn sie ausgeführt wird.

Nun geht es ja aber nicht um die Anwendung, sondern darum, diese in einem Docker-Container auszuführen. Dafür habe ich ein Image erstellt und [hier](https://registry.hub.docker.com/u/inginform/hallo-docker-mit-mono/) auf Docker Hub abgelegt.

Du brauchst also nur noch Deiner bereits installierten Docker Engine mit zu teilen, dass Du einen Container basierend auf diesem Image starten möchtest. Dafür gibst Du im Terminal/Kommandozeile/Shell oder wie das bei Deinem Betriebssystem auch immer heißt folgendes ein:
`docker run --rm inginform/hallo-docker-mit-mono`

Das einzige was Du dann als Ausgabe sehen wirst ist:
`ing.inform sagt Hallo aus einem Docker Container!`

Vielleicht bekommst Du auch eine Fehlermeldung wie zum Beispiele diese: 
`FATA[0000] Post http:///var/run/docker.sock/v1.17/containers/create: dial unix /var/run/docker.sock: no such file or directory. Are you trying to connect to a TLS-enabled daemon without TLS?`

Dann solltest Du sicherstellen, dass Du das `docker run` Kommando in dem gleichen Terminal eingegeben hast in dem Du auch Docker gestartet hast bzw. welches sich geöffnet hat als Du Boot2Docker gestartet hast.

##Was sagt Dir das nun?

Was ist passiert und was genau bedeuten die Befehle? Einer der wichtigsten Docker Befehle ist `docker run`. Damit sagst Du, dass Du einen Container basierend auf einem Image starten möchtest. Sofern Docker das angegebene Image nicht lokal bei Dir finden kann, versucht die Docker Engine das entsprechende Image im Docker Hub zu finden und dann auf Deinen Rechner zu laden. Im Docker Hub setzt sich der Name eines Images meistens aus dem Namen des Erstellers und dem Namen des Verzeichnisses zusammen. Entsprechend ist `inginform/hallo-docker-mit-mono` in unserem Beispiel der Name des Images.

Damit bleibt nur noch der Parameter `--rm` übrig. Dieser sagt Docker, dass er den Container nach der Ausführung direkt wieder löschen kann.

Nachdem Du nun eine erste Idee hast was Docker ist und was Du damit anfangen kannst, bekommst Du in den nächsten Artikeln mehr Details und vor allem viel mehr Beispiele. Damit kannst Du hoffentlich die Thematik schnell verstehen. Es würde mich sehr freuen, wenn Du mir sagst ob Dir der Artikel gefallen hat und ob Dich das Thema interessiert. Schreib doch einfach einen Kommentar unter diesen Artikel.

Fang einfach direkt an etwas zu entwickeln und bis zum nächsten Artikel
Jan
