# mass-file-renamer
![mass-file-renamer icon](/assets/fork.png)
###### Mass File Renamer: A program to simplify renaming a lot of files in a simple batch GUI
This app was designed to be a lightweight and more importantly a stand alone application. By being both of these things this app is also portable and can be taken with you on your flash drive.

![Screenshot of the main form](/assets/main.png)
## Features
- Lightweight stand alone binary. Can be used from a USB thumb drive.
- Drag-and-drop functionality means you don't have to browse around for the target directory.
- Enables you to rename all the files in a directory.
- Search and remove lets you drop unwanted text off each file name.
- Drop *x* number of characters off the beginning or end of a file name.
- Can set to only target certain file extensions.
- Can set to ignore/include hidden files.
- Simple search and replace lets you provide a search string then replace it with something else.
- Regex (Regular Expression) Search and Replace lets use regular expressions to search and replace with in case file names have a similar but changing string.
- Has a test mode to let you see what the results of the regex search and replace will do BEFORE actually renaming the files.
- Has a built in regex help to help you with building your expressions.
- Supports using capture () and recalling it with $1, $2 etc in the replace string.
- Proper Case (Capitalize the first letter of each word and make the rest lower-case).
- Automatically number the files in a directory, including leading zeroes.

## Minimum Requirements
- Windows &ge; 7
- [.NET Framework](https://dotnet.microsoft.com/en-us/download/dotnet-framework) &ge; 4.6.2

## Version Numbering
I use a variation of [semantic versioning](https://semver.org/) that follows the scheme `major.minor.patch.revision`.
- A major revision would involve a total refactor, language change, or other significant update to the codebase.
- A minor revision includes new features or significant usability enhancements.
- Patches are updates to existing functionality to improve or streamline their functionality.
- Revisions are small bugfixes or minor code formatting changes that do not affect functionality.
