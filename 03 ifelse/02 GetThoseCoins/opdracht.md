

## GetThoseCoins

- lees de uitleg hieronder:
```
We hebben nu een game waar de speler valt en waar coins komen
de speler moet de coins kunnen pakken en binnen het scherm blijven
```
> ![](img/getthosecoins.GIF)

- open de solution `GetThoseCoins.sln`

- run de application:
    > ![](img/game.PNG)

- daar loopt al wat maar nog niet 100%


## 1)

- open `Form1.cs`
- zoek:
    - //1) 
        - maak hier een if statement
            - als lDown true is dan voer je de code hieronder uit
            > - player.x -= 112.5f * frametime;
            - zet die in de {} van de if
## 2)

- open `Form1.cs`
- zoek:
    - //2) 
        - maak hier een if statement
            - als rDown true is dan voer je de code hieronder uit
            > - player.x = 112.5f * frametime;
            - zet die in de {} van de if
  
## 3)

- open `Form1.cs`
- zoek:
    - //3)     
        - maak hier een if statement:
            - als de coin dicht bij de speler is dan gebruik je de code hieronder
            > -  coins.Remove(coin);
            - en tel je 1 bij de score op
            - zet dat allemaal in de {} van de if

## 4)

- open `Form1.cs`
- zoek:
    - //4)     
        - de speler kan nog buiten het scherm komen!!! los dat met een if op.
        >  zet bijvoorbeeld de speler x weer:
        >   - terug op size of op het eind van het scherm (size*8)

## testen

- start de applicatie op
- druk op spatie
    - de speler beweegt
    - je kan scoren
    - je blijf binnen het scherm
    > ![](img/beter.PNG)

## Extra skills

- zie je de snelheid van de speler en de coins?
    - dat zijn harde waardes... niet echt mooi
        - verander dat zodat het variabelen worden die bovenaan bij score staan

- probeer de score hoger te laten worden als de afstand tot de speler groter is
## klaar

- commit & push naar je github        