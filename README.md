# ProjectEuler.NET

This project hosts my C# solutions to widely solved Project Euler problems.

For more information: <https://projecteuler.net>.

The Medium article that inspired this: <https://blog.usejournal.com/consider-yourself-a-developer-you-should-solve-the-project-euler-problems-ed8d13397c9c>.

## Installation

### Repo Overview
This repository contains a Visual Studio repository and C# code. 
Each problem is solved within a dedicated class with a corresponding name.
Each class is accompanied by a Unit Test class with same name and a tests suffix.

### Git access
In order to clone this project in CLI:
* `cd your-workspace-folder`
* `git clone https://github.com/mattan212/ProjectEuler.NET`
* `open your-workspace-folder`

### Run the project (Test Explorer - Recommended)
In order to get a solution for a problem you can run the tests in VS Test explorer.
* typically I wrote two unit tests to each problem: First one to solve the provided example and the second one to solve the problem itself.
* You can add your own tests, just follow an existing example from a previous test of the same class you wish to run.

### Run the project (Main)
* Open Program.cs
* Delete the call to Greet();
* Call the class that represents the problem you wish to solve with the required input parameters. Set the return value to a variable.
* Print out the output.

For example: 
```
	var result = CountingSundays.Solve(DateTime.Now.Subtract(TimeSpan.FromYears(1)), DateTime.Now);
	Console.Writeline(result);
```


## Disclaimer
As the article notes, it's against the competition to post solutions. However, as the first 50-100 questions have been solved by 100k+ developers, and solutions are widely available online, it is ok and recommended to post those solutions.
I hope you find this useful, feel free to send your comments and feedback.
Please remember, these are my solutions and not anyone's else. There might be a better solution, hell, a quick google search could potentially find you a better solution than mine..)
The code posted here is for reference, education, and assistance to those of you out there that need it.
Feel free to check out my website at <https://mattanm.com>, or follow me on Twitter at <https://twitter.com/MattanGuitar>.
