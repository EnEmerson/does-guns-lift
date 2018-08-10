# does-guns-lift

## Description: 

For around a month I collected data from a character within the game ["old school runescape"](https://oldschool.runescape.com/). This character is called 'The Guns' and essentially every time I ran past him in game, I would jot down the number he had above his head, which corresponded to the rep he was on for his set at the time. According to his wiki article, [he counts up to 8,200 \- 10,000 before losing track and starting over,](http://oldschoolrunescape.wikia.com/wiki/%27The_Guns%27), and I wanted to see how close my test data set was to the actual mean of the reps 'The Guns' would doing in a set.

![guns-lifting-log](https://github.com/EnEmerson/does-guns-lift/blob/master/resources/guns-lifting-log.png)

### The Maths:

#### Average maximum number of reps per set:

* (10,000 + 8,200) / 2 = 9,100

#### Mean of the average set:

Range is between 0 and 9,100.

* 9,100 / 2 = 4,550

Therefore, the average rep 'The Guns' should be on when I run past him is aproximately **4,550.** If the average of the set is greater than this threshold, the progam will display "'The Guns' lifts," if not, it will display "'The Guns' doesn't lift."

```C#
if (avgLifts < liftThreshold) //result of lift or not to lift
{
	resultBox.Text = "'The Guns' doesn't lift.";
}
else
{
	resultBox.Text = "'The Guns' lifts.";
}
```

## Keep lifting brotha.
![guns-dialog-box](https://github.com/EnEmerson/does-guns-lift/blob/master/resources/guns-dialog-box.png)