###CA1(WPF)

Create a WPF Application to maintain details of rooms in a hotel. Each Room has a room number. Each Room can accommodate a single guest whose name is recorded. The date and time of the checking in of the guest is also recorded.

Make appropriate classes to record this information. As there is no direct user input, your application (on startup) should:

create 20 Rooms with unique sequential numbers starting from 1 through to 20
randomly assign a guest to some rooms - ensure some rooms are kept vacant
the name of each guest should be drawn randomly from a collection of names
record the check-in time by randomly generating a date and time from the last week (7 days previous to today) - you do not need to validate this as your program is generating the data
Your UI (user interface) should show a list of Rooms. A button at the bottom of the screen will add another Room (and randomly check-in another guest to that room). Each Room should be displayed similar to this:

Room No: 4 Frank on 3/8/2015 @ 15:35
or
Room No: 7 (Vacant)
At the bottom of the screen, provide a % figure for occupancy i.e. the percentage of rooms with a guest.
Provide a figure for the percentage of guests that checked in before noon (i.e. after mid-night but before noon).
Use some styling to decorate your UI.
Employ the most effective, efficient coding approaches you have been taught, for maximum marks.