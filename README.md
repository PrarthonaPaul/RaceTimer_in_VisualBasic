# RaceTimer_in_VisualBasic
This is a GUI stopwatch created in visual basic, but without using the timer object and specifically using loops. 


# Important info: 

A crucial part of the porgram that increments the time in the stopwatch is the sleep timer funtion. 
Line 13 of the code contains the following code: 

    System.Threading.Thread.Sleep(0.501) 
  
as stated in the Pseudocode, the value inside the bracket depends on the speed of the computer that 
runs the program. It should be adjusted to mimic a real stopwatch. Higher values corresponds to a
faster timer and a lower value corresponds to a slower timer. Typically a faster computer will require 
lower number. 
