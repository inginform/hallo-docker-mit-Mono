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

Ich habe oben geschrieben, dass ein Container eine Art kleiner Computer ist. Damit liegt natürlich der Verdacht nahe, dass es sich um eine virtuelle Maschine handelt. Dies ist allerdings nicht der Fall. Eine virtuelle Maschine bildet tatsächlich einen ganzen Computer in Software ab. Dies hat Vorteile aber auch Nachteile. Mit einer virtuellen Maschine ist es möglich ein komplett anderes Betriebssystem laufen zu lassen (z.B. eine Version von Windows auf einem Mac). Allerdings wird sich dies erkauft mit dem Einsatz vieler Ressourcen. So benutzt eine virtuelle Maschine üblicherweise wenigstens 2GB Arbeitsspeicher, 1 CPU-Kern, einige GB Festplattenplatz und so weiter. Eine virtuelle Maschine ist also ein ziemlich großer Sandkasten oder schwarze Kiste die wir auf einem Computer laufen lassen können. Je nach Performance von diesem Computer ist es möglich einige dieser Sandkästen parallel laufen zu lassen.
Docker ist auch eine Virtualisierungstechnologie, aber der Umfang ist ein anderer. Wo eine virtuelle Maschine einen ganzen Computer abbildet, ist es bei Docker üblich lediglich einen Prozess abzubilden. Somit ist der Sandkasten den Docker Dir bietet wesentlich kleiner als der den Dir eine virtuelle Maschine bietet. Du verbrauchst somit wesentlich weniger Platz, aber hast auch nicht alle Möglichkeiten die Du mit einer virtuellen Maschine hättest. 
Wie aber genau macht Docker das nun? Ich habe bereits darauf hingewiesen, dass es sich bei Docker um Container dreht. Im Gegenteil zu einer virtuellen Maschine ist
