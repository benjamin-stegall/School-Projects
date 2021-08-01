#Python v3.9.6
#Working on: Win10

from abc import ABC, abstractmethod

#Defining a parent
class groceries(ABC):
    def paySlip(self, amount):
        print("Total: ",amount)
    @abstractmethod
    def payment(self, amount):
        pass

#Child
class cardPayment(groceries):
    def payment(self, amount):
        print("Purchase denied, Contact your card holder for more information.")

#Call the functions
obj = cardPayment()
obj.paySlip('$85')
obj.payment('85')
