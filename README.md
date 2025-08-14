# .NET Fundamentals

## Context
You have been hired to build a system for a parking lot, which will be used to manage parked vehicles and perform your operations, such as adding a vehicle, removing a vehicle (and displaying the amount charged during the period) and listing vehicles.

## Proposal
The class contains three variables, being:

** Precincial **: decimal type. It is the price charged to make your vehicle parked.

** Precopoporhora **: decimal type. It is the price for the time the vehicle remains parked.

** Vehicles **: It's a string list, representing a parked vehicle collection. Contains only the license plate.

The class contains three methods, being:

** AddSeveiculum **: Method responsible for receiving a plate typed by the user and storing in the variable ** Vehicles **.

** Removerveiculum **: Method responsible for checking if a particular vehicle is parked, and if positive, you will ask for the amount of hours it remained in the parking lot. After that, it performs the following calculation: ** Precincial ***** Precopoporhora **, displaying to the user.

** ListTarVeiculos **: Lists all vehicles currently present in the parking lot. If there is none, display the message "There are no parked vehicles".

Finally, an interactive menu should be done with the following actions implemented:
1. Register vehicle
2. Remove vehicle
3. List vehicles