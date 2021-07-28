#Parent Class
class User:
    name = "None"
    email = ""
    password = "1234"

    #Checks if entered login info is correct
    def login(self):
        entry_email = input("Enter your email: ")
        entry_password = input("Enter your password: ")
        if (entry_email == self.email and entry_password == self.password):
            print("Welcome back, {}".format(self.name))
        else:
            print("Access Denied")


#Child Class
class Distributor(User):
    can_sell = True
    seller_id = 123

    #Checks if entered login info is correct. This one checks the seller id
    def login(self):
        entry_email = input("Enter your email: ")
        entry_password = input("Enter your password: ")
        seller_id = input("Enter your company ID: ")
        if (seller_id == self.seller_id and entry_password == self.password):
            print("Welcome back, {}".format(self.name))
        else:
            print("Access Denied")
            

#Child Class
class Admin(User):
    is_admin = True
    pin_number = '123'

    #Checks if entered login info is correct. This one checks the address
    def login(self):
        entry_email = input("Enter your email: ")
        entry_password = input("Enter your password: ")
        pin_number = input("Enter your pin: ")
        if (pin_number == self.pin_number and entry_password == self.password):
            print("Welcome back, {}".format(self.name))
        else:
            print("Access Denied")
            

#Calls login methods from all classes
customer = User()
customer.login()

seller = Distributor()
seller.login()

admin = Admin()
admin.login()
