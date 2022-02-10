# azkii
Azkii Adventure: modern text adventure games

AQA Computer Science programming project 2022


NOTES & TODO:

    line 187 of game-data.cs will throw various errors if the direction items are arranged in a different order.

        POSSIBLE FIX: check if the input object is a direction by iterating over items and checking if their name is a direction (north, south, etc.). As for assigning player location, use a switch-case statement to map the indexes of the direction items to the indexes of the location's travel table.

    The player cannot say they want to go to a location by it's name - they can only use directions to navigate.

    Add synnonyms and adjectives for improved parsing.