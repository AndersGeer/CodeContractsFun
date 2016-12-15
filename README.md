# CodeContractsFun

This project is school project based around a private pdf on our fronter.

![alt text](http://i.imgur.com/pypW2sJ.png "Logo Title Text 1")
This project is based around this UML diagram and is created with code contract constraints in the account class.

This project references objects from bank onwards. Since customers and account cannot exist without a bank, the Account and Customer class have protected internal constructors only allowing them to be called from inside the struct and current assembly. 

A bank however can with the given diagram exist without any, and thus can be created without any customers and accounts.

Date in movement is currently not implemented and is using DateTime.Now to have the field instantiated. DateTimes are annoying to work with properly.

Be aware this this diagram is wrong in that it apparently credits the source account and debits the target account. This feels like stealing and has been reversed in my implementation.
