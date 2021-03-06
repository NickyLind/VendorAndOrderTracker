# _Vendor and Order Tracker_

#### _This application will allow a user to create order objects inside vendor objects on a webpage_

#### By _**Nick Lindau**_

## Technologies Used

* _.NET5.0_
* _C#_
* _Visual Studio Code_
* _ASP NET Core MVC_
* _Razor_

## Description

_This application will use RESTful routing to layout a website where a user can create a Vendor object and then create Order objects within that Vendor object_

## Setup/Installation Requirements

* _Find the resposiotory at (https://github.com/NickyLind/VendorAndOrderTracker.git)_
* _Select the green 'Code' button above the repository and copy the HHTPS link_
* _In your terminal, find the directory you want to place the Vender and Order Tracker directory in_
* _In your terminal, use the git command `$git clone https://github.com/NickyLind/VendorAndOrderTracker.git`_
* _Open in Visual Studio Code or another editor_
* _You will need to restore the dependencies and project specific tools by running the `$dotnet restore` command in the VenderAndOrderTracker directory as well as build the project using the `$dotnet build` command in the same directory_
* _Navigate to the VenderAndOrderTracker.Tests directory and run the command `$dotnet restore` to install packages for running tests_
* _In the same VenderAndOrderTracker.Tests directory you can run the command `$dotnet test` to run the tests for the program in the terminal_
* _To see results of the tests you will need to scroll up in the terminal to find the relevant testing information_
* _If all tests are passing, the relevant information will be colored green, otherwise failing tests will return in red coloring_
* _To run the program, you will need to navigate to the VenderAndOrderTracker directory and run the command `$dotnet run`_
* _If everything is working correctly a server should open up in localport:5000._
* _You can type Http://localport:5000 into your browser search bar to acess the site_

## Known Bugs

* _There is a bug where the button to clear all orders for a vendor redirects to the delete page but does not actually clear the orders_
* _Feel free to let me know what you find!_

## License

_[MIT](https://choosealicense.com/licenses/mit/)_
 _Copyright (c) Nick Lindau 03/05/2021_

## Contact Information

_Nick Lindau @ <nicholaithegreat@gmail.com>_
