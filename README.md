# does-guns-lift

### Description:  For around a month I collected data from a character within the game ["old school runescape."](https://oldschool.runescape.com/) This character is called 'The Guns' and essentially every time I ran past him in game, I would jot down the number he had above his head \- corresponding to the rep he was on for his set at that current moment. According to the wiki article for this character, [he counts up to 8,200 \- 10,000 before losing track and starting again,](http://oldschoolrunescape.wikia.com/wiki/%27The_Guns%27) and I wanted to see how close my data set was to the theoretical average lift 'The Guns' would be on in a given set.

![guns-lifting-log](https://github.com/EnEmerson/does-guns-lift/blob/master/resources/guns-lifting-log.png)

#### The Maths: The theoretical average number of lifts in a set would be 4,550. 

Maximum average number of reps per set:

* (10,000 + 8,200) / 2 = 9,100

Average of the sets:

* (9,100 + 0) / 2 = 4,550

Therefore, the average rep 'The Guns' should be on when I run past him is aproximately 4,550. If the average of the set is greater than this threshold, the progam will display "'The Guns' lifts," if not, it will display "'The Guns' doesn't lift."

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