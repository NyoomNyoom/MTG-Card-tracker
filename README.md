# MTG Card tracker

## About

This project aims to cover a nieche in Magic the Gathering
that I have mot found a solution for that fits my specific needs.
This project is going consist of a card collection tracker,
a life total tracker and a deck builder and tracker.

### Features I want to add
* A bulk add cards from commander pre cons
* card scanning
* different game modes for life tracker
* collection $$ value
* a tracker initialisation page. (where you can organise how many players are playing, and starting life)

## Progress so far

So far I have 3 screens working a main menu, a tracker page and a barebones collection page where I am testing API calls. I have added a second folder with a C# project inside of it for testing the API calls as I am running into some interesting errors and this will make it easier to test.

### Tracker page
Currently working:
* tracks health and has win/lose conditions built in.
* Getting the MTG api to return a card image (Having a couple of issues with null returns).

Next steps:
* implementing commander damage
* counters for poision, and emblems.
