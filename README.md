# Music Organizer (C# Web Application)

#### A console-based application to simulate a music library organizer where the user can input Artists and Records hosted on [GitHub](https://github.com/KristaRutz/MusicOrganizer.Solution). _Last Updated 03.12.2020._

#### By _**Krista Rutz, Jack Dunning, Steven Fleming**_

## Description

This application lets the user enter artists and update the discography of said artists to simulate the user's music library. Artists and records can be added, and artists can be searched by name.
It might even be hosted on hosted on [GitHub](https://github.com/KristaRutz/MusicOrganizer.Solution). It does so using an MVC framework, Razor, RESTful routing conventions, objects within objects, static content, layouts, and partials.

## Installation / Set-up

Download or clone the repository to run this program locally! _This program requires .NET Core SDK to run. [Here is a free tutorial](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-c-and-net) for installing .NET on Mac or Windows 10._

- Download or clone this repo.
  - **To Download ZIP:**
    - Select "Download" on the [GitHub Repository](https://github.com/KristaRutz/MusicOrganizer.Solution) site
    - Once downloaded, open the ZIP and extract files. The new folder will be created as 'MusicOrganizer.Solution'.
  - **To Clone:**
    - Clone from command line into your Desktop: `$ git clone https://github.com/KristaRutz/MusicOrganizer.Solution`
    - The new directory will be created as 'Desktop/MusicOrganizer.Solution'.
- Once you have stored the files locally, execute the following commands.
  - Navigate to the application directory: `$ cd MusicOrganizer.Solution/MusicOrganizer`
  - `dotnet build`
  - `dotnet run`
- Upon success, the program will begin running in your console.

## Technologies Used

- C#
- .NET Core 2.2
- HTML
- Custom CSS and Bootstrap

## Specs

<details>
  <summary>Expand specs for this project</summary>

Make a program for users to catalog and organize their music. This could be a CD, vinyl or even a tape collection.

They should be able to create a new record, enter the record title, and list out all of their records.
Add a feature that allows users to add an artist to a record. Keep it simple - assume each is by a single artist.
After that, let users list out all the artists and choose an artist to see which records are by that artist.
Further Exploration
Try creating another link on the home page to take the user to a "/search_by_artist" page. Users should be able to fill out a form with an artist name to search for their collection. After submitting the form they should be taken to a page listing out all the records they own by that artist.

Then try to improve the search functionality. If the user has created a record object by "JS Bach," they should be able to search for it by typing in "bach," "Bach," or "Johann Sebastian Bach." Say the user has a record by "Bachman–Turner Overdrive" as well as one by "JS Bach." If the user searches by the name "bach" or "Bach," both the records by "JS Bach" and "Bachman–Turner Overdrive" should be displayed.

</details>

## Known Bugs

- No known bugs

## Support and contact details

Please contact us if you run into any issues or have questions, ideas or concerns. Krista can be contacted at <krista.rutz@pomona.edu>. Feel free to create a pull request for updates - _contributions to the code are encouraged!_

### License

Copyright (c) 2020 **_Krista Rutz, Jack Dunning, Steven Fleming_**

_This software is licensed under the MIT license._

<details>
  <summary>View license details</summary>

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

</details>
