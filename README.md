# Project Title

Gilded Rose Refactoring Project

## Description

The Gilded Rose kata is a famous refactoring challenge that really stretches your ability to understand and
manipulate complicated logic. You can gain access to the Repository of the project [here](https://github.com/emilybache/GildedRose-Refactoring-Kata)
## A Brief Requirement of the project :

* All items have a SellIn value which denotes the number of days we have to sell the item
* All items have a Quality value which denotes how valuable the item is
* At the end of each day our system lowers both values for every item
* Pretty simple, right? Well this is where it gets interesting:

* Once the sell by date has passed, Quality degrades twice as fast
* The Quality of an item is never negative
* “Aged Brie” actually increases in Quality the older it gets
* The Quality of an item is never more than 50
* “Sulfuras”, being a legendary item, never has to be sold or decreases in Quality
* “Backstage passes”, like aged brie, increases in Quality as it’s SellIn value approaches; Quality increases by 2 when there are 10 days or less and by 3 when there are 5 days or less but Quality drops to 0 after the concert
### new Requirement
* We have recently signed a supplier of conjured items. This requires an update to our system:
* "Conjured" items degrade in Quality twice as fast as normal items



## Getting Started

you can clone the project in your application, and then install all dependancies by Nuget Package Manager
![image](https://raw.githubusercontent.com/NuGet/docs.microsoft.com-nuget/main/docs/quickstart/media/QS_Use-02-ManageNuGetPackages.png)

### Dependencies

* [Coverlet](https://www.nuget.org/packages/coverlet.collector/)
* [Verify xUnit](https://www.nuget.org/packages/Verify.Xunit/)
* [xunit](https://xunit.net/)

### Executing program

* Write click on the GildedRose project and Set as Startup project
* Press F5 

Or

* On the menu Go to the Debug -> Start Widthout Debuging
### Run the tests
* Test are run and can be seen by Test Explorer
* Right Click on the test project and select Run Tests or Debug Tests
* You can Run tests by typing Ctrl+R,A
<!--
## Authors

Contributors names and contact info

ex. Dominique Pizzie  
ex. [@DomPizzie](https://twitter.com/dompizzie)


## License

This project is licensed under the [NAME HERE] License - see the LICENSE.md file for details

## Acknowledgments

Inspiration, code snippets, etc.
* [awesome-readme](https://github.com/matiassingers/awesome-readme)
* [PurpleBooth](https://gist.github.com/PurpleBooth/109311bb0361f32d87a2)
* [dbader](https://github.com/dbader/readme-template)
* [zenorocha](https://gist.github.com/zenorocha/4526327)
* [fvcproductions](https://gist.github.com/fvcproductions/1bfc2d4aecb01a834b46)
-->
