

## rpgbattle V2

> we gaan nu dubbele code weghalen met functions

- open de solution `RpgBattleV2.sln`

## 1)
- open `Form1.cs` (rechter muis -> view code)
- zoek:
    - // 1)
    - doe het volgende:
    - maak daar een nieuwe function:
        - naam: `UpdateMonsterHealth`
        - gebruik `private` en `void`
        - zet de code die onder `2)` staat tussen de {} (de body)

## 2)

- open `Form1.cs` (rechter muis -> view code)
- zoek:
    - // 2)
    - doe het volgende:
    - vervang de code onder `//2)` met een function call naar de nieuwe function
        - `UpdateMonsterHealth`

## 3)

- open `Form1.cs` (rechter muis -> view code)
- zoek:
    - // 2)
    - lees deze uitleg:
    > de code onder `3)` was ook dubbel, dat willen we niet
    - gebruik nu onder `3)` ook de function:
        - `UpdateMonsterHealth`
    - haal de dubbele code weg
            
## klaar

- commit & push naar je github        