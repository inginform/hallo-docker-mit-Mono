#Software im Container, oder wie Du in unter 30 Minuten ein Programm schreibst (ohne Vorkenntnisse)

Sicher hast Du schon mal gehört, dass Softwareentwicklung eigentlich ganz einfach ist. Wenn Du Dich vielleicht auch schon mal etwas näher mit dem Thema beschäftigt hast, dann hast Du gemerkt, sooo einfach ist das gar nicht. Insbesondere die Einstiegshürde ist nicht eben niedrig.

Egal ob Du nun unter Windows, Linux oder Mac OS X arbeitest, Du brauchst eine Entwicklungsumgebung. Diese muß erstmal installiert werden. Wobei das der einfachste Schritt ist (wenn er auch durch aus schon mal länger dauern kann). Nun kannst Du diese Entwicklungsumgebung öffnen und stehst vor einer unendlichen Auswahl an Möglichkeiten.

Wahrscheinlich weist Du nicht so recht wie Du überhaupt eine Software entwickelst. Du wirst die Programmiersprache vielleicht nicht so gut oder gar nicht kennen. Mit der Entwicklungsumgebung hast Du ein sehr komplexes Programm zu bedienen. Viele sagen spätestens an diesem Punkt: "Kein Bock mehr!".

Ich zeige Dir in diesem Artikel einen Weg, wie Du in weniger als 30 Minuten, alles was Du brauchst zum Software entwickeln, installierst und Dein erstes Programm erstellst. Du hast somit die Chance die Einstiegshürde schnell zu überwinden. Denn wenn Du erstmal Erfolge siehst, macht es Dir sicher gleich mehr Spaß.

Ich sage nicht, dass es einfach wird. Du wirst Deine Komfortzone verlassen müssen und auch etwas Vorstellungskraft mitbringen müssen. Ich werde Dir nämlich zeigen wie Du Deinem Computer Befehle mitteilst ohne die Maus zu verwenden. Es geht also ans Eingemachte. Dafür wirst Du in wenigen Minuten Dein erstes Programm erstellt haben. 

##Was denn nun für ein Container?

Du fragst Dich vielleicht was das mit den Containern immer soll. Schließlich sind wir ja nicht am Hafen, oder doch? Nein. Wir verwenden eine Technologie namens Docker.

Um eine Software entwickeln zu können, brauchen wir einige Programme. Diese könntest Du nun alle auf Deinem Computer installieren, aber ich möchte es Dir ja einfach machen. Also habe ich alles was Du benötigst in einen Container gepackt. Vom Konzept her ist es tatsächglich ähnlich wie so ein Frachtcontainer.

Das einzige was Du nun auf Deinem Rechner brauchst ist ein Programm welches den Container aufnehmen kann. Dieses Programm ist die [Docker Engine](https://www.docker.com). Damit machst Du Deinen Rechner "quasi" zu einem Containerschiff, oder Containerzug, wenn Dir das besser gefällt.

Sicher fragst Du Dich wie Du nun an diesen Container kommst. Das ist zum Glück auch ganz einfach. Dafür gibt es den [Docker Hub](https://registry.hub.docker.com). Dabei handelt es sich um eine Art Containerumschlagplatz. Es ist also eine zentrale Anlaufstelle, wenn Du auf der Suche nach bestimmten Containern bist, oder besser gesagt, wenn Du einen Container mit einem bestimmten Inhalt suchst.

Das ist wirklich ziemlich cool. Auf dem *Docker Hub* gibt es Container mit verschiedenen Datenbanken, mit Webservern, mit Entwicklungsumgebungen und so weiter. Du kannst also innerhalb weniger Minuten Entwicklungsumgebungen für verschiedene Programmiersprachen auf Deinem Rechner haben. Dabei kann ein Container genau so schnell wieder entfernt werden ohne irgendwelche Rückstände zu hinterlassen.

##Containerschiff für Dich

Nachdem Du nun etwas Theorie gehört hast, werden wir einfach anfangen. Es ist nicht wichtig, dass Du bis hier hin alles verstanden hast. Offene Punkte sollten sich im folgenden klären. Wenn nicht, dann melde Dich einfach bei mir. [Kontakt]() [Kommentare]()

Keine Angst. Die *Docker Engine* ist nicht sonderlich groß (z.B. Downloadgröße: 130MB für Mac OS X) und verbraucht auch nicht viel Ressourcen. Dein Computer wird sich nach der Installation nicht anfühlen wie ein Containerschiff. Das passiert nur, wenn Du wirklich sehr viele Container geladen hast.

Die Installation der *Docker Engine* ist recht einfach. Installationspakete bekommst Du für [Mac OS X hier](https://github.com/boot2docker/osx-installer/releases/latest)(ab Mac OS X 10.6) und [Microsoft Windows hier](https://github.com/boot2docker/windows-installer/releases/latest). Wenn Du Linux benutzt, kannst Du [hier](https://docs.docker.com/installation/#installation) schauen. Je nach Distribution und Version gibt es etwas unterschiedliche Anweisungen.

Unter Microsoft Windows und Mac OS X hast Du nach der Installation ein *Boot2Docker* Icon auf Deinem Desktop oder bei den Programmen. Dieses klickst Du nun an und es öffnet sich ein Fenster. Nicht erschrecken! Das geöffnete Fenster ist die Kommandozeile. Also eine Möglichkeit dem Computer zu sagen was er tun soll, ohne das Du die Maus benutzen musst. Unter Linux endet die Installation direkt in der Kommandozeile.

Je nach Betriebssystem hat die Kommandozeile unterschiedliche Namen. Es gibt die Eingabeaufforderung, das Terminal, das Shell-Fenster, die Bash, und so weiter. Es dreht sich aber immer um das gleiche. Du gibst Befehle über die Tastatur ein, der Computer führt sie aus und gibt Dir dann vielleicht ein Resultat oder eine Meldung in Textform aus.

Nun kannst Du noch überprüfen, ob die *Docker Engine* auch richtig funktioniert. Dazu gibst Du in der (bereits geöffneten) Kommandozeile einfach folgenden Befehl ein und drückst Enter:
`docker run hello-world`

Als Resultat für den eingegebenen Befehl, wird Dir einiges an Text angezeigt. Darunter auch `Hello from Docker.`. Der Rest des Textes besagt, dass alles richtig funktioniert und erklärt Dir im Detail was alles passiert ist.

Weitere Informationen zur *Docker Engine* findest Du [hier](https://docs.docker.com/installation/#about). Dort ist allerdings alles in Englisch. In den kommenden Artikel hier auf Ing.InForm werde ich immer mal wieder Docker verwenden. Damit lernst Du dann die Basics auf Deutsch und anhand praktischer Beispiele.

##Ich packe meinen Container

Glückwunsch! Den schwierigsten Schritt hast Du geschaft. Du bist aus Deiner Komfortzone gekommen, hast ein Programm installiert und einen Befehl über die Kommandozeile eingegeben. Lass uns gleich weiter machen. Denn nun beginnt der interessante Teil.

Ich habe für Dich ein kleines Programm in C# geschrieben. Es macht nicht mehr als eine Ausgabe in der Kommandozeile. Vielleicht noch etwas langweilig, aber für den Anfang soll es reichen. Schließlich geht es hier darum, dass Du die Einstiegshürde bezüglich Entwicklungsumgebung überwindest.

Dieses C#-Programm ist zusammen mit der Entwicklungsumgebung in einem Container verpackt. Eine genauere Beschreibung des Containers findest Du im [Ing.InForm Bereich auf Docker Hub](https://registry.hub.docker.com/u/inginform/hallo-docker-mit-mono/). Den Quellcode für das C#-Programm findest im [Ing-InForm Bereich auf Github](https://github.com/inginform/hallo-docker-mit-Mono).

Um nun den Container vom *Docker Hub* auf Deinen Computer zu holen und ihn dort zu starten, musst Du wieder einen Befehl in der Kommandozeile eingeben. Gehe also wieder zu dem noch geöffneten Fenster mit der Kommandozeile, oder starte *Boot2Docker* bzw. die *Docker Engine*, und gebe folgenden Befehl ein:
`docker run --rm inginform/hallo-docker-mit-mono`

Das einzige was Du als Ausgabe sehen solltest ist:
`ing.inform sagt Hallo aus einem Docker Container!`

Somit bist Du schon wieder einen Schritt weiter. Du hast nun eine Entwicklungs- und Ausführungsumgebung für C#-Programme auf Deinem Computer. Ausserdem hast Du bereits ein C#-Programm auf Deinem Computer gestartet und das Resultat gesehen.

**graue Box**
Wie Du vielleicht schon vorher bemerkt hast, wird mit `docker run` die *Docker Engine* angewiesen einen Container zu starten. In unserem Fall ist das `inginform/hallo-docker-mit-mono`. Sofern der angegebene Container nicht auf Deinem Computer existiert, sucht die *Docker Engine* automatisch auf *Docker Hub* nach dem Container. Du brauchst also eine Internetverbindung wenn Du diesen Befehl ausführst.

Jetzt habe ich Dir alle Bestandteile des Befehls den Du eben eingegeben hast erklärt, ausser dem Parameter `--rm`. Mit diesem Parameter sagst Du der *Docker Engine*, dass Dein Container gelöscht werden kann, wenn er beendet wird. 
**/graue Box**

##Dein erstes Programm

Nun ist das bisher erreichte schon nicht schlecht, aber es geht darum, dass Du ein eigenes Programm erstellst. Dazu brauchst Du als erstes Quellcode auf Deinem Computer. Genau den erstellst Du jetzt.

Am besten Du legst Dir auf Deinem Computer ein eigenes Verzeichnis für Softwareentwicklung an und in diesem ein Unterverzeichnis für dein C#-Programm. Die Verzeichnisse kannst Du anlegen wie und wo Du willst und natürlich auch benennen wie Du willst. Mein Standardvorgehen ist, dass ich in meinem Benutzerverzeichnis ein Unterverzeichnis mit dem Namen `Entwicklung` erstelle. Für dieses Beispiel habe ich darin das Unterverzeichnis `HalloDocker`erstellt.

Nun brauchen wir im Verzeichnis `HalloDocker` noch eine Datei mit Quellcode. Dazu legst Du eine Datei mit der Endung `.cs` an. Ich habe sie `HalloDocker.cs` genannt. In diese Datei kannst Du nun ein Hauptprogramm in C# schreiben, oder Du kopierst Dir einfach den Quellcode von [hier](https://github.com/inginform/hallo-docker-mit-Mono/blob/master/Code/HalloDocker.cs).

Um den Quellcode in die Datei zu kopieren öffnest Du die Datei mit einem Texteditor (z.B. Notepad in Microsoft Windows oder TextEdit in Mac OS X). 
Wenn Du den Quellcode kopiert hast, dann solltest Du ihn noch überarbeiten, damit es auch wirklich DEIN eigenes Programm ist. Eine Möglichkeit was Du machen kannst ist im Quellcode beschrieben.

Nachdem Du den Quellcode fertig hast, muss er in ein ausführbares Programm übersetzt werden. Alles was Du dazu benötigst ist im Container enthalten. Als erstes musst Du jedoch im Fenster mit der Kommandozeile in das Verzeichnis wechseln indem Dein Quellcode ist. In der grauen Box an der Seite sind die Befehle beschrieben die Du benötigst.

**graue Box** -> Hinweis: Besser als separaten Artikel oder Tabelle mit direkter Unterscheidung zwischen Windows und OS X / Linux
Folgende Befehle kannst Du in der Kommandozeile verwenden um zwischen Verzeichnissen zu navigieren:
- `pwd` - Zeigt den kompletten Pfad des aktuellen Verzeichnisses an. (Befehl gibt es nicht in Microsoft Windows. `echo %cd%` solle hier verwendet werden.)
- `cd` - Wechselt in ein Verzeichnis dessen Namen dem Befehl als Parameter folgt. Dabei gilt, dass `cd ..` in das übergeordnete Verzeichnis wechselt. Um vom aktuellen Verzeichnis in das Unterverzeichnis *Entwicklung* zu wechseln, kannst Du `cd Entwicklung` eingeben.
- `ls` - Zeigt den Inhalt des aktuellen Verzeichnisses an. (Unter Microsoft Windows heißt der Befehl `dir`.)
**/graue Box**

Wenn Du in der Eingabeaufforderung dein Verzeichnis erreicht hast, dann kannst Du wieder den Container starten. Diesmal geht das etwas anders. Beim vorherigen `docker run ...` wurde einfach der Container gestartet, das enthaltene Programm ausgeführt und anschließend der Container wieder beendet. Ausser dem starten hast Du nicht mit dem Container interagiert. Da alle nötigen Werkzeuge zum übersetzen des Quellcodes jedoch im Container sind, werden wir jetzt den Container starten und dann dadrin arbeiten.

Gebe also bitte folgenden Befehl in der Kommandozeile ein:
`docker run --rm -it -v $(pwd):/usr/src/project -w /usr/src/project inginform/hallo-docker-mit-mono /bin/bash`

Wie Du siehst hat sich der Kommandoprompt (der Teil in der Kommandozeile der vor dem Cursor steht) ein wenig verändert. Er sollte mit `root@` anfangen. Dies ist das Zeichen, dass Du Dich nun im Container befindest. Über die vielen Parameter die Du bei `docker run` mit angegeben hast, ist Dein Quellcode im Container verfügbar.

Nun brauchst Du nur noch Deinen Quellcode zu übersetzen und auszuführen. Dazu brauchen wir als erstes einen C#-Compiler. Dieser macht aus Deinem Quellcode ein ausführbares Programm. Dieser Compiler ist natürlich im Container enthalten. Gib also folgenden Befehl in der Kommandozeile ein:
`mcs HalloDocker.cs`. Wenn Du einen anderen Dateinamen als ich verwendet hast, musst Du das `HalloDocker.cs` mit diesem Dateinamen ersetzen.

Wenn Du Dir nun den Inhalt des Verzeichnisses in dem Dein Quellcode liegt anschaust, dann wirst Du sehen, dass es eine neue Datei gibt. In meinem Fall ist es die Datei `HalloDocker.exe`. Dieses ist das aus Deinem Quellcode erstellte ausführbare Programm. Nun brauchst Du dieses nur noch starten:
`mono HalloDocker.exe`.

Und? Bekommst Du die Ausgabe, die Du erwartet hast? Wenn nicht, dann solltest Du den Quellcode anschauen und unter Umständen entsprechend überarbeiten. Dies machst Du wieder mit Deinem Texteditor. Nachdem Du den Quellcode verändert hast, must Du ihn wieder mit dem Compiler übersetzen und dann ausführen. Dazu gibst Du die letzten beiden Befehle wieder in der Kommandozeile ein.

Wenn Du mit dem Ergebnis zufrieden bist, kannst Du den Container verlassen. Dazu gibst Du einfach folgenden Befehl ein:
`exit`. Damit hat sich wieder der Kommandoprompt verändert und Du hast den Container verlassen. 

##GESCHAFFT! 

Herzlichen Glückwunsch! Du hast es geschafft. Du kannst nun nach belieben den Quellcode verändern


Fang einfach direkt an etwas zu entwickeln und bis zum nächsten Artikel
Jan
