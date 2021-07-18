# Programmierprojekt: <Random Meeting>

* Teammitglieder:
	1. Vinh Thong Trinh
	2. Christopher Schwarz
	3. Meriem Rekik
* Team: 7
* Semester: SS21

Das Programm ist in der Lage, Gruppen je nach Themenanzahl(Gruppengröße), aus einer Teilnehmer Liste zu erstellen. Anschließend jedem Teilnehmer eine individuelle E-Mail zu versenden. Die E-Mail beinhaltet dementsprechend den gegebenen Termin, Meeting-Link, die Gruppennummer und das Gruppenthema.


## Installationshinweise

- git clone https://gitlab.rz.htw-berlin.de/programmierprojekt/sose2021/grp07.git
- Ordner> grp07
- Ordner> program
- Ordner> RandomMeeting
- Öffne> RandomMeeting.sln


## Eigennutzung

Für die Eigennutzung:

> https://marketplace.zoom.us/

1. Über die Zoom-Webseite Account erstellen oder den über den genutzten Zoom Account einloggen.
	1. Falls noch kein Account - Vollständig Registrieren und E-Mail verifizieren
2. Nach dem Login - oben rechts auf 'Develop' klicken und dann 'Build App'
3. Bei JWT App Type auf 'Create' drücken
4. App beliebig benennen
5. Unter App Credentials API Key + API Secret entnehmen.
6. RandomMeeting.sln starten
7. LinkGenerator.cs öffnen und anschließend den API Secret und API key ersetzen.


## Verwendung der Software

#### 1. .CSV-Datei erstellen:
	
Die Datei kann mit Excel erstellt werden oder in einer einfachen .txt Datei. Dabei sollte die linke Spalte den Namen beinhalten und in der rechten die E-Mail.

Die .CSV-Datei sollte so aussehen: 

Name;E-Mail <br>
Name2;E-Mail2 <br>
	

#### 2. Programm starten und .CSV-Datei einfügen.

Hier sollten die Namen angezeigt in der linken Spalte sein und in der rechten die jeweiligen E-Mails dazu.

#### 3.  Themen eingeben

Bedenke das die Themenanzahl gleich die Gruppenanzahl ist. <br>
Themenanzahl = Gruppenanzahl <br>
	
#### 4. Gruppen generieren > 'Generate Groups'-Button drücken

Hier werden die Teilnehmer in verschiedenen Gruppen aufgeteilt.

#### 5. Datum + Länge des Meetings angeben

Über 'Date:' Datum für Meeting - Wann es stattfindet soll. <br>
Über 'Duration' Länge des Meetings - Wie lange es stattfinden soll. <br>

#### 6. E-Mail und Passwort eingeben

Beachte - E-Mail muss mit der Domain '@htw-berlin.de' enden.
- E-Mail und Password müssen richtig sein.
- E-Mail sollte mit dem Benutzer Namen starten <br>
Bsp.: s0571062@htw-berlin.de <br>

#### 7. Betreff + Nachricht eingeben

Subject = Betreff <br>
Message = Die Nachricht die an jeden gehen soll. <br>

#### 8. Send Mail-Button drücken und zurücklehnen.

Hiermit wird an jeden Teilnehmer eine E-Mail gesendet.



## Links, Hinweise etc.

1. Zoom Marketplace: https://marketplace.zoom.us/
2. CSV-Datei: Linke Spalte Name und rechte E-Mail
	2. E-Mails der Teilnehmer sollten richtig sein.
	2. Der Code der CSV-Datei sollte wie folgt aussehen: <br>
		Name;E-Mail <br>
		Vinh;s0571062@htw-berlin.de <br>
3. Sollten unbekannte Fehler auftreten bitte an die jeweiligen Teammitglieder eine E-Mail.