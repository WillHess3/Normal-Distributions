# Normal-Distributions
An easy class to allow you to get random values as they would naturally appear on a normal distribution

When to use:
If there is a situation where some variation can be inserted to make the game (or whatever you are making) seem more natural use this normal distribution technique

How it works:
You pick 2 values. The first one is the mean and it says what the most common / average value will be. The second value is the standard deviation and it says how much variation there will be. With this class, you can get a random value that will be "pulled toward" your average.

How to use:
1) Copy and paste the code into your project
2) Make a new NormalDistribution object with your mean and standard deviation of choice passed in as arguments
3) call the GetRandomValue() function on your normal distribution object to get a random value from the curve

How to pick your mean and standard deviation:
The mean is easy, it is whatever the current value is, or if you don't have a current value yet, it is whatever you want the most common value to be. In normal distributions, 68% of the values you can "randomly get on the curve" will fall between one standard deviation above and below the mean, so pick a range (centered at the mean) you would be comfortable with about 70% of the values to be in and get the standard deviation from the distance the endpoints are to the mean. Also, 95% of the data lies between 2 standard deviations from the mean, and it's 99.7% for 3.

The kicker:
The code is NOT A NORMAL DISTRIBUTION, it is a pretty close approximation. I couldn't figure out a way to implement the actual thing due to non-elementary integrals complicating things, so this code gives a pretty good approximation instead. 

More Context + Examples:
watch this video - https://youtu.be/4_KwhtDGIOY
