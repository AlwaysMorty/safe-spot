# 🧙‍‍♂️ Verpflegung für Helden – MVP

Willkommen im Projekt **„Verpflegung für Helden“**, einem 2D-Mobile-Spiel in Unity, bei dem die Spieler:innen einen Verpflegungsstand für RPG-Held:innen betreiben. Ziel ist es, ein süchtig machendes, skalierbares Spiel mit niedrigem Pflegeaufwand zu entwickeln – mit KI- und Agentenunterstützung.

---

## 🎯 Ziel des Projekts (für Codex und Entwickler)

> Erstelle ein Unity-2D-Mobile-Spiel mit Fokus auf:
> - einfachen Spielmechaniken (Drag-and-Drop, Tap to Serve)
> - wachsender Komplexität durch Upgrades, Heldentypen und Ressourcen
> - klarer Dopamin-Kurve durch Belohnungsschleifen
> - guter Agentenunterstützung zur Automatisierung von Entwicklung, Tests und Erweiterung



---

## 🔧 Features im MVP

- [ ] Helden erscheinen zufällig mit Bedürfnis (z. B. Hunger, Durst, Müdigkeit)
- [ ] Spieler:in kann Bedürfnisse befriedigen (einfaches UI + Interaktion)
- [ ] Belohnungssystem mit Gold
- [ ] 2–3 Upgrades (z. B. schneller kochen, mehr Lagerkapazität)
- [ ] einfache Loop mit Spawn → Bedienung → Belohnung

---

## 💻 Build-Instruktionen (Unity)

> Voraussetzungen:
- Unity 2022.3 LTS oder neuer (2D Mobile Template)
- Mobile Build Target: Android (min. API Level 21)
- Optional: Unity Ads SDK installiert über Unity Package Manager

> Build:
1. Projekt öffnen
2. In `Scenes/` die Szene `Game.unity` öffnen
3. In den Build Settings „Android“ wählen → „Switch Platform“
4. Build und Run starten

---

## 🤖 Hinweise für Codex-Agent

- Bitte implementiere neue Features immer **modular** (Ein Script pro Klasse/Funktionseinheit)
- Erstelle **Testdaten und Platzhalter-Assets**, falls keine vorhanden sind
- Nutze `PlayerPrefs` zur einfachen Persistenz
- Nach jedem Feature: **Commit mit sprechender Nachricht**
- Nutze bei Unsicherheit kommentierten Beispielcode

---

## 📌 Nächste Schritte

> Für Codex: Bitte beginne mit folgenden Aufgaben – jeweils als eigene Commits:

1. [ ] Erstelle die Verzeichnisstruktur
2. [ ] Lege ein Unity-Projekt mit 2D Mobile Template an
3. [ ] Erzeuge eine Szene mit Hintergrund und HeroSpawnPoint
4. [ ] Erstelle ein Script `HeroSpawner.cs`, das alle 15 Sekunden zufällig einen Helden mit Bedürfnis spawnt

---

## 🛠️ Technisches Ziel

> Das Projekt soll langfristig:
> - leicht erweiterbar sein
> - balancierbare Tabellen enthalten
> - In-App-Käufe + Werbung ermöglichen
> - möglichst automatisiert gepflegt werden (neue Events, neue Items, Helden etc.)

---

## ✍️ Lizenz & Credits

> Dieses Spiel dient experimentellen Zwecken. Assets sind Platzhalter oder Open Source. Lizenzierung erfolgt nach MVP-Abschluss.

---
