# Development Plan

This plan outlines five features on the critical path for the "Verpflegung fuer Helden" MVP.

1. **Bootstrap Scene Setup**
   - Script creates camera, background and hero spawn point at runtime.
   - Ensures the game runs even with an empty scene.
2. **Hero Entity**
   - Hero can have a random need (food or drink) shown with an icon.
   - Clicking a hero serves them and grants gold.
3. **Hero Spawner**
   - Spawns a hero every 15 seconds at the spawn point.
4. **Gold Manager & UI**
   - Tracks player gold using `PlayerPrefs` and updates on-screen text.
   - Serving a hero awards gold.
5. **Upgrade System**
   - Simple upgrade to increase gold reward per hero.
   - Stores upgrade level in `PlayerPrefs` with basic UI button to purchase.

These features focus on the core gameplay loop of spawning heroes, serving them and receiving rewards.
