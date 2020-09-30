# File Processor
![FileProcessor Firstlook](/FirstLook.png)

It is a string replacer. It can replace target string with replace string. 

# Key Feature
* Developed with the help of SOLID principles
* It can replace not only company name but any text
* It can replace text from **Word doc**
* It can be upgraded for any type of file, very easily. I.e. Xml, Pdf etc.
* We do not have to touch existing code to add new file type
* It can work on large number of files
* Multithreading
* Supports recurring replacement on the same file. Even Replace string has the Target string. I.e. Target = SoftwarePeople, Replace = SoftwarePeople Bangladesh
* It can process 1500 word files in 56 sec. You can find 1500 word docs in the root of the repo.
![FileProcessor Timing(/Timing.png)

#In short
** Any text, Any file type, Any number of files, Folder with mix type**

# How to run
* Clone or download the repository
* Restore Package
* Run

# Known Issue
* I am using a tool Spire.Net (Free version) which has a following warning on every processed file.
* Evaluation Warning: The document was created with Spire.Doc for .NET.
