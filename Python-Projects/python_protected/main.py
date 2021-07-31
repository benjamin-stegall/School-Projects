class Protected:
    def __init__(self):
        #Defining variable
        self._protectedname = "Joe"

#Prints the name
protect = Protected()
print(protect._protectedname)


class Private:
    def __init__(self):
        self.__privatename = "Jim"

    #This function prints the name when called
    def getPname(self):
        print(self.__privatename)

    #This function changes the name
    def setPname(self, private):
        self.__privatename = private

#Prints the 2 names
priv = Private()
priv.getPname()
priv.setPname("Jimmy")
priv.getPname()
