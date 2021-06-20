# TruckManager Project

This is an example project demonstrate how to use oop concept as the real world scenario.

The scenario suppose truck as base object it's can implemented to the "RedTruck" or any name you can use. \
All Thuck will be decline and get dirty over time when driver is driving the truck.
Each truck has 4 wheel they can be decline and get dirty over time same as the truck itself.

Suppose 3 role as "driver", "cleaner", "Maintainer". 
1. The Driver 
 * Can check truck status.
 * When driving, dirty and decline percent are gradually decreased (You can change them to be increase instead). 
 * When cleaning or maintaining, the driver must stop driving.
2. The Cleaner 
 * Can check truck status.
 * If the dirty percent is equal or lower than 10%, the cleaner will clean the truck and dirty percent will gradually increase (You can change them to be decrease instead).
 * Can't not driving or maintaining the truck.
 * Must stop cleaing when driver is driving.

3. The Maintainer 
 * Can check truck status.
 * If the decline percent is equal or lower than 50%, the maintainer will maintain the truck and decline percent will gradually increase (You can change them to be decrease instead).
 * Can't not driving or cleaing the truck.
 * Must stop cleaing when driver is driving.