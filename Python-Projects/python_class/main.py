#Defining Class
class User:
    name = "None"
    email = ""
    password = "1234"
    account = 0

    #Checks if entered login info is correct
    def login(self):
        entry_email = input("Enter your email: ")
        entry_password = input("Enter your password: ")
        if (entry_email == self.email and entry_password == self.password):
            print("Welcome back, {}".format(self.name))
        else:
            print("Access Denied")
    #Initilization
    def __init__(self, name, email, password, account):
        self.name = name
        self.email = email
        self.password = password
        self.account = account

#Child Classes
class Customer(User):
    shipping_address = ''
    billing_info = ''

class Distributor(User):
    can_sell = True
    seller_id = 0

#Gets the user info and calls for the login function
new_user = User('John Doe', 'doe@email.com', '1234', 1)

new_user.login()
    
    

    
