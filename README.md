⚔️ Superhero Battle Arena
A console-based battle simulation built in C# to practice core OOP concepts.

🦸 Heroes
HeroSpecialtyMageAttacks with magic spellsWarriorAttacks with brute strengthArcherAttacks with precise arrows
Each hero has a Name, Health, and Power set via a parameterised constructor.

⚙️ How It Works

Two heroes are selected for battle
Each hero introduces themselves
Heroes take turns attacking each other
Each attack reduces the target's health based on Power × Kicks
Battle ends when a hero's health reaches 0
The surviving hero is declared the winner


🧱 OOP Concepts Used

Abstract Class — BaseHero defines shared structure and forces Attack() on all subclasses
Inheritance — Mage, Warrior, Archer all inherit from BaseHero
Encapsulation — Health and Power are private, exposed via protected properties
Polymorphism — Each hero overrides Attack() with unique behavior
Method Overloading — Heal() works with no args (heals 20 HP) or a custom amount
Reflection — Used in Introduce() and Attack() to get the actual hero type at runtime
