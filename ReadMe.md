#Question 1

##RepositoryEmployee
It's not optimized on the get sorted side but it's quite contained
on the solution, so from the collection we can always call an
array, or dictionary, or list, etc... representation from our private
collection. 

##RepositoryOptimizedEmployee
It's optimized on the GetOrderedEmployeeArray side. The question itself doesn't
address the problem of removing or updating an Employee. 'Cause this solution
uses two different data structures it's important to know how syncronization
is provided.

Both solutions, to the extent of the methods provided, are thread safe.

##RepositoryFunctionalEmployee
Similar to the previous but it doesn't use OOP classic exception
but railway functional pattern.

#Question 2

Used instead of Writeln("something else here") a double method Speed(). Also used
an abstract class instead of an interface. It works both ways.

#Question 3
First of all I am missing the context of the domain so I can only point out this:
1) either the tax rate is applied on all products in the same way or it is applied on
every single product, in the first case total += (total * taxRate); doesn't make any sense
tho at the end the result is not wrong, in the second case total += (total * taxRate); could have a meaning
if applied on every single product having the ILocalizationInfo  for each one of it but I didn't provide
any solution for that, and in any case the line of code is wrong.
2) I moved the parameters to the constructor as it seems a better way to encapsulate the logic of the class,
also provided a simple Calculate() method where the result is brought about by the ILocalizationInfo implementation
itself. Added, in order to do so, a property TaxRate to the ILocalizationInfo interface.
3) Calculate() and Calculate(IEnumerable<Product> products, ILocalizationInfo localInfo) are left both in the
code but actually only one approach is needed. I'd suggest using Calculate().
4) It's not clear how far this review should go, aside from clear errors, I have given a more sustainable
way to TDD the class through dependency injection (see contructor).

Enjoy.



