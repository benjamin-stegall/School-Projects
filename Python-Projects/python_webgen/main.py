#
# Tkinter Webpage Generator
#
# Python v3.9.6
#
# For Win10
#
from tkinter import *
import tkinter as tk
import webbrowser

# Base html format
html = """
<html>
    <body>
        <h1>{}</h1>
    </body>
</html>
"""

# This defines the gui
class ParentWindow(Frame):
    def __init__ (self, master):
        Frame.__init__ (self)

        self.master = master
        self.master.resizable(width=False, height=False)
        self.master.geometry('{}x{}'.format(700, 400))
        self.master.title('Webpage Genrator')
        
        self.varEntryField = StringVar()

        self.lblEntryField = Label(self.master, text='Body Content: ', font=('Arial', 14))
        self.lblEntryField.grid(row=0,column=0, padx=(30,0), pady=(30,0))

        self.txtEntryField = Entry(self.master, text=self.varEntryField, font=('Arial', 14))
        self.txtEntryField.grid(row=0, column=1, padx=(30,0), pady=(30,0))

        self.btnSubmit = Button(self.master, text='Create HTML', width=12, height=1, command=self.submit)
        self.btnSubmit.grid(row=2, column=1, padx=(0,0), pady=(30,0), sticky=NE)

        self.btnCancel = Button(self.master, text='Cancel', width=12, height=1, command=self.cancel)
        self.btnCancel.grid(row=2, column=1, padx=(0,100), pady=(30,0), sticky=NE)

    def submit(self):
        # Stores entry as 'ef' for use later
        ef = self.varEntryField.get()

        # Create the doc
        createDoc = open("main.html", "w")
        createDoc
        createDoc.write(html.format(ef))
        createDoc.close()

        # Opens browser when user creates doc
        webbrowser.open("main.html",new=2,autoraise=True)

    def cancel(self):
        # Close if user clicks cancel
        self.master.destroy()

        

if __name__ == "__main__":
    root = tk.Tk()
    App = ParentWindow(root)
    root.mainloop()
