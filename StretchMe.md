# WCCI - Computational Thinking
## Stretch Tasks

> The name of this game is: SCOPE

- We need to add a counter to the Program class to keep track of how many of the system commands are return
- We also need to keep track of the last program that was ran so that we can provide an exit report
- An exit report should inform the user how many total system commands were ran as well as what the last command was

## Tips and Tricks

- Declare a static variable to keep track of the count of system command runs
- Add increment statements at the appropriate locations of the Main method
- Declare a static variable to keep track of the name of the last system command

## Hints

- You have a couple of options, you can create static variables at the Program level or you can create local variables at the Main method level

## Sample Code

```chsarp
int count = 15;
count++; // adds 1
count += 1; // adds 1
count = count + 1; // adds 1
Console.WriteLine(count); // outputs 18
