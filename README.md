# SWATCodeGen
SWATCodeGen is a Code Generator for a WC3 map named "SWAT Aftermath". 
It can generate a code with any ranks, any classes, any talents(Anyway,restricted by class) and any medals.

#Known Problems:
An player’s id which contains SPECIAL non-ascii character may cause the generated code unusable. That means most Unicode names such as “phrātēr”, “幽幽sama一生推” and “安らかに眠れ” are ( at least, “should be” ) available. However, in a few status, it will fail. I don’t know why it happen. Maybe it depends on the count of Unicode character, or… just some mum f**kers don’t know how to use a such easy software.

Sometime the auto-copy may fail, but you can manually copy it.

# The Algorithm
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
 (In fact, it's impossible that the Armour Code is greater than 2, since it has been normalized.)
- And than, it will obscure **the Level Code**, the level code equals subtracting one from player's level.
 ( Level Code = Level - 1, i.e. a level 1 player's level code is 0, a level 12 player's level code is 11 )
 
```
if (levelcode > 10)
{
	if ((medal1 + medal2) > 1)
    {
	    levelcode = 14;
    }
    else if (medal1 > 0)
    {
	    levelcode = 13;
    }
    else if (medal2 > 0)
    {
	    levelcode = 12;
    }
}
if (levelcode > 8)
{
	if (diff < 4)
	{
		if (medal3 < 1)
	    {
	        diff = 1;
        }
        else
        {
	        diff = 2;
        }
    }
    else
    {
	    if (medal3 < 1)
        {
	        diff = 3;
        }
    }
}
else if (levelcode > 5 && diff < 2)
{
     diff = 2;
}
else if (levelcode > 2 && diff < 1)
{
	diff = 1;
}
if (levelcode < 9)
{
	if (diff < 3)
	{
		medal4 = 0;
		medal5 = 0;
	}
	else if (diff < 1)
	{
		medal6 = 0;
	}
}
```

The medalX are **The Medal Amount X**, which are the amounts of six kinds of medal that player has got. 

| Medal (X) |  Max amount |
| -----:              | :----: |
|Key to the City (1)|1|
|Medal of Honor (2)|1|
|Police Combat Cross (3)|1|
|Commendation Bar (4)|1|
|Life Saving Award (5)|1|
|Recognition for Exceptional Merit (6)|3|

The diff is **the Difficulty Code**, means the hardest difficulty that the player has  defeated.

Sorry but I forgot to record the meaning of Difficulty Code... Anyway, it's certainly that **4** is the maximum.

```
CodeA = unusedXP / 10 + 50 * levelcode + 50 * 15 * diff + 50 * 15 * 5 * medal4 + 50 * 15 * 5 * 2 * 
        medal5 + 50 * 15 * 5 * 2 * 2 * medal6 + 50 * 15 * 5 * 2 * 2 * 4 * 
        (classcode + 8 * armourcode + 8 * 3 * trait + 8 * 3 * 18 * spec + 8 * 3 * 18 * 9 * talent);
```
For short, it is:

```
CodeA = unusedXP / 10 + 50 * levelcode + 750 * diff + 3750 * medal4 + 7500 * medal5 + 15000 * medal6 + 
        60000 * (classcode + 8 * armourcode + 24 * trait + 432 * spec + 3888 * talent);
```

Remember that all divisions in this algorithm are exact divisions:

```
ED(i,j) -> (i - i % j) / j
//In C-like languages, it simply equals i/j.
```

It's no doubt that the *trait*, *spec*, *talent* are **the Trait Code**, **the Spec Code** and **the Talent Code**.

| Trait (Trait Code)) |
| -----:              |
|Skilled (0)|
|Gifted (1)|
|Survivalist (2)|
|Dragoon (3)|
|Acrobat (4)|
|Swift Learner (5)|
|Healer (6)|
|Flower Child (7)|
|Chem. Reliant (8)|
|Rad. Resistant (9)|
|Gadgeteer (10)|
|Prowler (11)|
|Energizer (12)|
|Pack Rat (13)|
|Engineer (14)|
|Reckless (15)|

| Specialization (Spec Code)) |
| -----:              |
|Weaponry (0)|
|Power Armor (1)|
|Energy Cells (2)|
|Cybernetics (3)|
|Triage (4)|
|Chemistry (5)|
|Leadership (6)|
|Robotics (7)|
|Espionage (8)|

| Talent (Talent Code)) |
| -----:              |
|Courage (0)|
|Wiring (1)|
|Running (2)|
|Spotting (3)|
|Toughness (4)|
|Thinkering (5)|
|Hacking (6)|

- As you see, now we got an integer. However, we have to stringize it.

```
string codeA = seed.ToString() + FixLength(iCodeA.ToString(), 9) + (unusedXP % 10).ToString();
```

FixLength is used to ensure the iCodeA has enough length. It will fill '0' in the head of string if it is too short.

```
string FixLength(string str, int length)
{
	while (str.Length < length)
	{
		str = "0" + str;
    }
	return str;
}
```

- Now, we have **the first Raw code**.
- We are going to talk about **the pass two**. However, I wanna stress again that both passes are parallel. Neither of them requires the other's result. **THAT MEANS THE NORMALIZATIONS AND OBSCURING IN PASS ONE WON'T EFFECT PASS TWO!**
- The pass two has some redundant codes. I skip them since they won't effect the result.
- First, it will hash player's name, generates **the Hashed Name**.

```
int getHashedName(string name)
{
    char[] cs = name.ToCharArray();
    int i = 0;
    int j = 0;
    int loop = 1;
    foreach (char c in cs)
    {
        if (c == 'r' || c == 'R') i = 12;
        else if (c == 'd' || c == 'D') i = 25;
        else if (c == 'y' || c == 'Y') i = 23;
        else if (c == 'n' || c == 'N') i = 22;
        else if (c == 's' || c == 'S') i = 13;
        else if (c == 'z' || c == 'Z') i = 36;
        else if (c == 'q' || c == 'Q') i = 35;
        else if (c == 'c' || c == 'C') i = 24;
        else if (c == 't' || c == 'T') i = 14;
        else if (c == 'g' || c == 'G') i = 30;
        else if (c == 'f' || c == 'F') i = 33;
        else if (c == 'w' || c == 'W') i = 32;
        else if (c == 'x' || c == 'X') i = 31;
        else if (c == 'o' || c == 'O') i = 21;
        else if (c == 'l' || c == 'L') i = 15;
        else if (c == 'i' || c == 'I') i = 19;
        else if (c == 'b' || c == 'B') i = 37;
        else if (c == 'p' || c == 'P') i = 26;
        else if (c == 'a' || c == 'A') i = 18;
        else if (c == 'u' || c == 'U') i = 20;
        else if (c == 'e' || c == 'E') i = 17;
        else if (c == 'k' || c == 'K') i = 28;
        else if (c == 'v' || c == 'V') i = 34;
        else if (c == 'j' || c == 'J') i = 27;
        else if (c == 'm' || c == 'M') i = 16;
        else if (c == 'h' || c == 'H') i = 29;
        else if (c == '1') i = 9;
        else if (c == '0') i = 11;
        else if (c == '6') i = 8;
        else if (c == '5') i = 10;
        else if (c == '7') i = 6;
        else if (c == '9') i = 2;
        else if (c == '4') i = 3;
        else if (c == '2') i = 7;
        else if (c == '3') i = 5;
        else if (c == '8') i = 4;
        else if (c == '_') i = 1;
        else if (c == '(' || c == ')') i = 38;
        else if (c == '-') i = 39;
        else if (c == '[' || c == ']') i = 40;
        else if (c == '.') i = 41;
        else if (c == '!') i = 42;
        else
        {
            int number = Encoding.UTF8.GetByteCount(new char[] { c });
            i = number * 43;
        }
        j += i * ((loop % 3) + 1);
        loop++;
    }
    return j;
}
```

You may noticed that the hashing of Unicode character is very simple. That means hashing "古明地恋" and "芙兰朵露" will get same results, and the players whose hashed names are equal can share codes.

- And then, it will generate code and stringize it.

```
int[] factor1 = {171,142,175,157,167,150,149,151,153,165};
int[] factor2 = {169,170,166,173,158,177,161,180,186,159};
int iCodeB = hashedname * (spec + 1) + (trait + 4) * (trait + 6) + (level + 1) * (unusedXP + 1) + 
      (talent + 1) * 43 * factor1[hashedname % 10] - (type + 1) * (241 + factor2[hashedname % 10]) - 
      (medal6 + 1) * 50;
iCodeB += (medal1 + 1) * 4 + (medal2 + 1) * 9 + (medal3 + 1) * 19 + (medal4 + 1) * 39 + 
          (medal5 + 1) * 79 + (armour + 1) * 159;
iCodeB += 100 * (diff + 1) * (iCodeB % 1000);
while (iCodeB >= 100000)
{
    iCodeB = iCodeB % 100000 + iCodeB / 100000;
}
codeB = FixLength(iCodeB.ToString(), 5);
```

- Now, we got **the second Raw code**!

**Mixing** is the second stage, and it requires the result of stage one. It will mix two raw codes generated by stage one.

```
string mixedCode = codeA.Substring(0, 2) + codeB.Substring(4, 1) + codeA.Substring(2, 4) + 
                  codeB.Substring(3, 1) + codeA.Substring(6, 2) + codeB.Substring(1, 2) + 
                  codeA.Substring(8, 3) + codeB.Substring(0, 1);
```

This is a C# code, if you want to port it to Java or Jass, don't forget the difference of Substring between different languages.

**Disordering** is the last stage, it will disorder the MixedCode. ( However, the mixing is also a disordering, isn't? )

```
int i = Convert.ToInt32(mixedCode.Substring(0, 1));
string finalCode = mixedCode.Substring(0, 1) + mixedCode.Substring(16 - i) + mixedCode.Substring(1, 15 - i);
```

- As you see, first, it will pick the first number of Mixed Code, and use it as factor.
- The first number will keep its position, and the next 15 numbers will be disordered by the factor.
- And now, you get the **Final Code**!
