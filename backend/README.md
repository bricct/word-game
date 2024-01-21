# Word Game Backend

## Services

### WordGameApi

Responsible for serving traffic to and from the frontend and updating the database accordingly

Endpoints
- /login
- /game gets the game status for the currently logged in user
- /lock_vowels to lock in the two selected values for the user
- /guess to submit a word guess for the user


### WordGameDb

Responsible for persisting the game data for the users and saving game history

Tables
- User table (Id, Email, HashedPw, Token, GameData, CreatedAt, UpdatedAt)
- Games table (Id, UserId, GameData, GameDate, CreatedAt, UpdatedAt)


### WordGameCore

Shared library for models and entities related to the WordGame


### WordGameGen

Console application to run on a daily cron schedule, responsible for the following:
- Create consonants for the day and compute all combos of words with each vowel choice
- Update all users to have empty game states, take the existing game data in user tables
  and submit it to the games table with the previous date
