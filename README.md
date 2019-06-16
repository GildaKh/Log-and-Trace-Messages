
This assignment projects a small part of tracing and logging message generation regarding my final project.
Here, log messages provide information about the process, timing, and exceptions in the system. 
They help to diagnose any error situations from the information they contain. 
For example, passing a null value to a function for a non-optional input parameter leads to an error.
However, tracing messages wrap semantic or in specific cases syntax problems in the message form. 
These messages inform the user of  potential issues in the user input that can lead to misinterpretation and analysis of the system. 
For example, a digit in a value of a field in configuration file must lead to an error with the exact position of the digit 
but any other character is acceptable.

As a demonstration that how tracing messages and logging work, four different types of messages and small instance of logging 
are selected from the main project and implemented for this assignment.


Technologies:
•	Developing language: C#                    Version: 7.3
•	Developing tool: Visual studio             Version: 2017 Community


“LogandTrace” solution consists of three projects as follows:
  •	MessageGenerator: holds the tracing messages and log message interfaces and implementations
  •	MessageAnalyzer: as a sample that parses a text and produces trace and log messages by using “MessageGenerator”
  •	Test: unit tests for testing “MessageAnalyzer”



In  designing “LogandTrace” solution, these principles are considered:
  •	Anticipate for possible futures: By using abstract classes, inheritance, delegate, and interfaces, 
     we assume another type of message, analyzer, or even logger might be added.
  •	Separation of concern (SoC): 
      o	Separating logging from trace messages. 
      o	Separating logging approach (in file, console, or in database) from logging definition and usage
      o	Avoiding duplications.
  •	Project dependencies: 
      o	Avoiding cyclic dependencies
      o	Encapsulating objects properly
      o	Following a layering (hierarchical) architecture in this solution 
  •	Test: Since the input and output types of the methods are different from the main assignment, 
      only part of the test cases are brought here. 
  •	LSP -LiskovSubstitution Principle: Considering ErrorMessageBase and MessageBase as the base classes in "MessageGenerator" project
      and not defining only ErrorMessageBase is based on this principle. 
  •	Dependency Inversion Principle: dependency upon abstraction in “MessageAnalyzer” project

