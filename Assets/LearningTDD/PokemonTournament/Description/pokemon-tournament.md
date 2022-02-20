---
layout: post
title:  "Pokemon Tournament Kata"
categories: [Unity3D, Outside-In, Software-Design, SOLID Principles, Experienced]
image: banking_kata.jpg
---

{% include credits.md name='Pablo Palma' url='https://github.com/Power-Learning/power-learning/tree/tdd_kata_pokemon_tournament/' %}

## Motivation
The point of this Kata is to learn and improve TDD skills, as well as good practices to when developing the implementation of the code.
This Kata will be guided by iterations, in order to test each one.
Please note Clean Code, DRY, and KISS in each iteration.

## Description
We are in a Pokemon tournament, where our player faces an opponent who will be the first to choose which Pokemon to use, so our player must choose the right Pokemon according to what our opponent chooses.
The combinations you should consider are:
Pokemon Fire wins over Pokemon Steel
Pokemon Steel wins over Pokemon Ice
Ice Pokemon wins over Pokemon Earth
Pokemon Earth wins over Pokemon Steel
Pokemon Water wins over Pokemon Fire

You can add the combinations you want (source link)

By choosing our Pokemon, we can indicate through commands, what type of attack we want it to perform (Physical or magical) 
Eg: "M" = Magical or "F" = Physical
The commands will be sent through an arrangement where they indicate all the attacks we want from our Pokemon. Ex: ['M',' M', 'F']

## Rules
• Work the iterations sequentially, do not see or exceed without having finished the previous one.

• Don't do more than each iteration asks of you

### First iteration:

  Perform a function that returns a type of Pokemon from our rival, and, therefore, our player must invoke the appropriate Pokemon to win the battle as indicated in the table.


## Second iteration:
Once our player's Pokemon has been summoned, we must send the list of commands to the Pokemon to attack.
For each attack carried out, the attack carried out by our Pokemon must be printed on the console.
Our Pokemon has an imaginary MP bar, which has a total of 100 points, so in each attack we make, the MP is consumed as follows:
Magic attack consumes 30 MP
Physical attack consumes 10 MP
If the MP is at zero, and there are still attacks to be executed, our command execution must be cut off and a print must return with the following message: "MP insufficient"
The MP cannot have a negative value (e.g. -1)

## Bonus track:
Our Pokemon has an MP bar (UI), which is consumed according to the attacks we choose, taking into account the values mentioned in the previous point.




{% include starting_points.md %}
