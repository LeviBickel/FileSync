# FileSync

Simple directory comparison tool with automatic synchronization enabled. Built in C#.

## Installation:

Run the MSI installer package.

## First Setup:

1.) Start the application.
2.) A manual directory synchronization can be run from this panel by selecting your source and destination directories and then pressing the "Execute" button. 
3.) To setup automatic synchronization, select settings and set the source and destination directories here and ensure that the "RealTime" checkbox is selected. The interval can be adjusted in minutes to adjust how frequently the check occurs in the background.
4.)Save the settings and FileSync will keep these directories synchronized.


## Network Drives:

If you are attempting to synchronize a local directory with a network drive, ensure you are using the share folder like the following: \\server1\C$ --or-- \\server-2\E$\some\path\
This is required due to permissions errors while copying to a network location. 


## Logging

FileSync will log errors during the file comparision and transfer process to the Event Viewer. The logs can be found under the Windows Logs -> Application section and has the following attributes:
  Event ID: 101
  Source Name: Application
  
You will see that the event log contains some text about a description not being found. Just parse through the text and you will see the specific error text for FileSync after "The following information was included with the event: "

Everytime the comparision and transfer runs there will be an event log message recorded whether the run was successful or not.

## Notes:

It is common for Windows to recognize the application as not responding for really large directories or during slow connections to a network drive. This is an expected behavior. 

