#Python v3.9.6


def start(nice=0, mean=0, name=""):
    # Get the user's desired name
    name = describe_game(name)
    nice, mean, name = nice_mean(nice, mean, name)



def describe_game(name):
    """
        This checks to see if the user is returning or not.
        If new player, make them enter a name.
        If returning, reuse given name.
    """   
    if name != "":
        # Greets returning player
        print("\nWelcome back, {}.".format(name))
    else:
        stop = True
        while stop == True:
            if name == "":
                name = input("\nPlease enter a name. \n>>> ").capitalize()
                if name != "":
                    # Brief intro for new players
                    print("\nWelcome, {}.".format(name))
                    print("\nIn this simple game, you can choose between kind or mean interactions with different people.")
                    print("Of course, your choices have consequences...")
                    stop = False
    return name



def nice_mean(nice, mean, name):
    stop = True
    while stop == True:
        # Encounter
        show_score(nice, mean, name)
        pick = input("\nA man approaches you and attempts to engage in conversation. How do you react? (Nice/Mean) \n>>> ").lower()
        if pick == "nice":
            print("You entreat the man and he eventually walks off in a pleasent mood.")
            nice = (nice + 1)
            stop = False
        if pick == "mean":
            print("\nThe man looks at you with a sour face and walks away...")
            mean = (mean + 1)
            stop = False
    score(nice, mean, name) # Passes variables to the score()



def show_score(nice, mean, name):
    print("\nYou have had {} kind interactions and {} mean interactions.".format(nice, mean))



def score(nice, mean, name):
    # Shows user their interaction count
    if nice > 2:
        lose(nice,mean,name)
    if mean > 2:
        win(nice,mean,name)
    else:
        nice_mean(nice,mean,name)



def win(nice, mean, name):
    # Win condition
    print("\nYour attitude caught the eye of your superiors and you quickly rose through the ranks, eventually becoming CEO.\nYou would go on to create the biggest company the world had ever seen, with power and money to rival most governments.\nEven with this power, you still felt a sense of unhappiness and displeasure with yourself.")
    again(nice, mean, name)
    

def lose(nice, mean, name):
    # Lose condition
    print("\nYour friendly attitude and willingness to place others first was praised by many.\nYou would go on to be a beggar in a big city, barely scraping by.\nDespite the hardships, you felt a sense of peace and acceptance about yourself.")
    again(nice, mean, name)



def again(nice, mean, name):
    # Lets user quit or restart
    stop = True
    while stop == True:
        choice = input("\nWould you like to play again? (Yes/No)\n>>> ").lower()
        if choice == "yes":
            stop = False
            reset(nice, mean, name)
        if choice == "no":
            stop = False
            quit()
        else:
            print("\nPlease type Yes or No.\n>>> ")



def reset(nice, mean, name):
    # Resets values
    nice = 0
    mean = 0
    start(nice, mean, name)



if __name__ == "__main__":
    start()
