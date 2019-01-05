# The ThreeTeeth Browser

A simple web browser for Windows based on the Microsoft Trident engine. 

ThreeTeeth was originally released on zetacentauri.com as the Zeta MiniBrowser, 
later renamed to The ThreeTeeth Browser and hosted on threeteeth.com. It was 
downloaded more than 15,000 times before being open-sourced.

![ThreeTeeth Screenshot](https://github.com/Xangis/ThreeTeeth/blob/master/Images/ThreeTeeth_1.3_Screenshot1.png)

No effort has been made to make this browser secure.

A prebuilt Windows installer is available in the Installer directory:

https://github.com/Xangis/ThreeTeeth/blob/master/Installer/ThreeTeeth1.31Setup.exe

ThreeTeeth requires the [Microsoft .NET Framework 3.5 or Newer](http://www.microsoft.com/downloads/en/details.aspx?familyid=333325fd-ae52-4e35-b531-508d977d32a6&displaylang=en) and runs on Windows XP or newer.

If you would like a more modern browser, try [WbBrowse](https://github.com/xangis/wbbrowse), also by me.

# Usage

![Main Navigation Toolbar for the ThreeTeeth Browser](https://github.com/Xangis/ThreeTeeth/blob/master/Images/ThreeTeeth_1.3_Screenshot7.png)

Here are what the buttons do: 

![Left Button](https://github.com/Xangis/ThreeTeeth/blob/master/MiniBrowser/Resources/left.bmp) The left arrow lets you navigate to the previous web page in your history, if any.  If there is not a previous web page it will be grayed out.

![Right Button](https://github.com/Xangis/ThreeTeeth/blob/master/MiniBrowser/Resources/right.bmp) The right arrow lets you navigate to the next web page in your history, if any.  If there is not a next web page it will be grayed out.

![Stop Button](https://github.com/Xangis/ThreeTeeth/blob/master/MiniBrowser/Resources/stop.bmp) The stop sign lets you stop the current page load, if any.  If there is nothing loading it will be grayed out.

![Refresh Button](https://github.com/Xangis/ThreeTeeth/blob/master/MiniBrowser/Resources/refresh.bmp) The circular arrows let you refresh the currently loaded web page.

![Home Button](https://github.com/Xangis/ThreeTeeth/blob/master/MiniBrowser/Resources/home.bmp) The home icon lets you return to the ThreeTeeth search page.

![Open Folder Button](https://github.com/Xangis/ThreeTeeth/blob/master/MiniBrowser/Resources/openfolder_orange.bmp) The folder icon lets you open an HTML file stored on your computer.

![Print Button](https://github.com/Xangis/ThreeTeeth/blob/master/MiniBrowser/Resources/icon_print.bmp) The print button lets you send a web page to the printer.

![Code Button](https://github.com/Xangis/ThreeTeeth/blob/master/MiniBrowser/Resources/code.bmp) The angle brackets let you view the source HTML for the current web page.

![Question Button](https://github.com/Xangis/ThreeTeeth/blob/master/MiniBrowser/Resources/question2.bmp) The question mark icon lets you view the about box for the ThreeTeeth web browser.

![Bookmark Button](https://github.com/Xangis/ThreeTeeth/blob/master/MiniBrowser/Resources/bookmark.bmp) The bookmark button lets you add a page to the list of bookmarks stored by ThreeTeeth.

The URL bar shows you the currently loaded web page's URL.  You can type a web address into the URL bar to navigate to a new web page.  After you've entered the URL, press enter or click on the arrow to the right of the URL bar to navigate to the page.

### Bookmarking and Loading Bookmarks

![The Bookmark Add Dialog](https://github.com/Xangis/ThreeTeeth/blob/master/Images/ThreeTeeth_1.3_Screenshot5.png)

When you click the bookmark button, you will be shown the URL and the name of the page.  You can edit the page name and URL if you want to have a more descriptive URL title or want to go to a different part of the website.  Clicking "OK" adds the bookmark to the bookmark list, while clicking "Cancel" aborts the operation.

![Navigate to a Bookmark](https://github.com/Xangis/ThreeTeeth/blob/master/Images/ThreeTeeth_1.3_Screenshot6.png)

To navigate to a bookmark, click the drop down list next to the bookmark button and select an item from the list.  The browser will load the web page for that bookmark.

# Changelog

### Changes in Version 1.31 (2015-09-19):

- Changed start page to reflect ThreeTeeth moving to zetacentauri.com.

*NOTE: It appears that the changes for 1.31 did not make it into this repository. They may be lost, or I may have them somewhere.*

### Changes in Version 1.3 (2013-01-09):

- Added support for adding and navigating to bookmarks.
- Some user interface improvements related to window resizing.

### Changes in Version 1.2 (6/27/2012):

- Added the ability to open an HTML file using the command line.
- Some minor cosmetic improvements.
- More improvements to code formatting in the source view.
- Improved the order in which controls are selected via the tab key.

### Changes in Version 1.1 (6/18/2011):

- Added a button to open a file from disk.
- Improved code formatting in the source view.

### Changes in Version 1.0 (5/17/2011):

*Note: Before version 1.0, ThreeTeeth was known as the Zeta MiniBrowser.*

- The current web page title now shows up in the title bar.
- Script errors no longer show annoying pop-up messages.
- Buttons have been changed from big clunky text to icons.
- The URL bar now updates with navigation.
- The browser now loads a search page to start with.
- There is now a home button that will take you back to the search page.

# Development Status

I stopped developing this software back in 2015. It probably does not behave like
a modern web browser. I may or may not decide to update and/or maintain it, but
for now it should be considered "abandonware". The original domain it was
hosted on has long since expired and is now owned by a squatter, so the
"search" page is worthless.
