# SWATCodeGen
SWATCodeGen is a Code Generator for a WC3 map named "SWAT Aftermath". 
It can generate a code with any ranks, any classes, any talents(Anyway,restricted by class) and any medals.

# The algorithm
All right, cracker boy, I'm sure that you don't care about a crude gui program. So let's talk about the damn algorithm of SWAT:AM.

This algorith has **three** stages : Raw codes generating, Internal swap, and Breed.

**Raw code generating** is the first and most important stage, it has two passes, both pass are parallel. Every pass will generate a raw code. So this stage will generate two raw codes.
-  **The pass one** is relative simple. First, it will pick a random even integer from 0, 2, 4, 6, 8, and 10. We name it **the seed**.
- Second, it will generate **the normalized talent** by player's **class code** and **talent code**.

| Class (Class Code))      |    Talent (Talent Code) | Normalized Talent  |
| --------:                | --------:               | :--: |
| Covert Sniper (0)        |Courage (0)              |0|
|                          |Wiring (1)|1|
|                          |Running (2)|2|
|                          |Thinkering (5)|3|
| Field Medic (1)          |Courage (0)|0|
|                          |Wiring (1)|1|
|                          |Toughness (4)|2|
|                          |Hacking (6)|3|
| Tactician (2)            |Courage (0)|0|
|                          |Wiring (1)|1|
|                          |Running (2)|2|
|                          |Hacking (6)|3|
| Psychologist (3)         |Courage (0)|0|
|                          |Wiring (1)|1|
|                          |Spotting (3)|2|
|                          |Hacking (6)|3|
| Heavy Ordnance  (4)      |Courage (0)|0|
|                          |Running (2)|1|
|                          |Toughness (4)|2|
|                          |Thinkering (5)|3|
| Demolitions (5)          |Courage (0)|0|
|                          |Running (2)|1|
|                          |Toughness (4)|2|
|                          |Spotting (3)|3|
| Cyborg (6)               |Courage (0)|0|
|                          |Spotting (3)|1|
|                          |Running (2)|2|
|                          |Hacking (6)|3|
| Pyrotechnician  (7)      |Courage (0)|0|
|                          |Spotting (3)|1|
|                          |Thinkering (5)|2|
|                          |Toughness (4)|3|
| Watchman (8~9)           |Courage (0)|0|
|                          |Toughness (4)|1|
|                          |Thinkering (5)|2|
|                          |Spotting (3)|3|
| Maverick (10~14)         |Courage (0)|0|
|                          |Running (2)|1|
|                          |Hacking (6)|2|
|                          |Thinkering (5)|3|
| Tech Ops  (15)           |Courage (0)|0|
|                          |Wiring (1)|1|
|                          |Thinkering (5)|2|
|                          |Hacking (6)|3|
| Umbrella Lolita (16)     |Courage (0)|0|
|                          |Wiring (1)|1|
|                          |Spotting (3)|2|
|                          |Toughness (4)|3|

Notice that the Watchman and the Maverick have multiple class, because they have multiple weapon. 
And not all normalizations are ordered. Maybe it's designer's mistake, or... a crack counter-measure?

- And then, there are some normalizing.

| Class (Class Code)) |    Normalizing |
| -----:              | :--------:    |
| Cyborg (6)| Armour Code = 2 |
| Watchman (8)| Armour Code = 0; Class Code = 6 |
| Watchman (9)| Armour Code = 1; Class Code = 6 |
| Maverick,TechOps,Lolita(>9)| **Class Code -= 10 ; Seed++** |

Oh, and this is **the Armour Code** table:

| Armour (Armour Code)) |
| -----:              |
|Light (0)|
|Medium (1)|
|Heavy (2)|
|Advanced (3)|

- After normalizing, if Armour Code > 2, clamp it to 2.

# Work in process...
