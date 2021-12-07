# Schule-EuroData

## Vorraussetzungen
- .NET Framework 4.8 ([Direkter Link](https://dotnet.microsoft.com/download/dotnet-framework/thank-you/net48-developer-pack-offline-installer) zum Download des Windows Developer Packs)
- MySql.Data (Ist als Nugget Package verfügbar, je nach IDE wird dies automatisch runtergeladen)

## MySQL-Server
Über ein Docker-Compose Script kann man ganz einfach einen MySQL Server starten und eine phpmyadmin Applikation dazu um die Datenbank zu bearbeiten.
Auf Windows braucht man nur [Docker Desktop](https://hub.docker.com/editions/community/docker-ce-desktop-windows).
Für Linux siehe [hier](https://docs.docker.com/compose/install/).

Wenn alles installiert und startbereit ist kann man über ein Terminal im Projekt mit folgendem Command die Datenbank starten.

`docker-compose up -d`

Wer es nicht über mein Docker-Compose Script machen möchte, kann sich selbst einen MySQL Server hosten (eigener Docker/XAMP/Whatever) kann diese [SQL-Datei](sql/setup.sql) nutzen um die bereitgestellte Datenbank zu installieren.


## Verbesserungen
Wer eine Optimierung in Sinn hat oder einfach eine bessere (best-practice) Methode hat für etwas im Code kann sich gerne melden und ein MR machen.
