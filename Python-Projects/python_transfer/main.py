#
# Shutil File Transfer
#
# Python v3.9.6
#
# For Win10
#
import shutil
import os
import datetime
import tkinter
from tkinter import *


# Defining Class
class ParentWindow(Frame):

    #Defines the app window
    def __init__ (self, master):
        Frame.__init__ (self)

        self.master = master
        self.master.resizable(width=False, height=False)
        self.master.geometry('{}x{}'.format(700, 400))
        self.master.title('File Manager')
        
        self.varSource = StringVar()
        self.varDestination = StringVar()

        self.lblSource = Label(self.master, text='Source Folder: ', font=('Arial', 14))
        self.lblSource.grid(row=0,column=0, padx=(30,0), pady=(30,0))

        self.lblDestination = Label(self.master, text='Destination Folder: ', font=('Arial', 14))
        self.lblDestination.grid(row=1,column=0, padx=(30,0), pady=(30,0))

        self.txtSource = Entry(self.master, text=self.varSource, font=('Arial', 14))
        self.txtSource.grid(row=0, column=1, padx=(30,0), pady=(30,0))

        self.txtDestination = Entry(self.master, text=self.varDestination, font=('Arial', 14))
        self.txtDestination.grid(row=1, column=1, padx=(30,0), pady=(30,0))

        self.btnSubmit = Button(self.master, text='Transfer', width=12, height=2, command=lambda:self.last_mod_time(self))
        self.btnSubmit.grid(row=2, column=1, padx=(0,20), pady=(30,0), sticky=NE)

        self.btnCancel = Button(self.master, text='Cancel', width=12, height=2, command=self.cancel)
        self.btnCancel.grid(row=2, column=1, padx=(0,120), pady=(30,0), sticky=NE)

           

    # Checks to make sure files were recently modified   
    def last_mod_time(fname,self):
        # Gets user entered file paths
        src = self.txtSource.get()
        dst = self.txtDestination.get()
        # Gets file timestamps
        for fname in os.listdir(src):
            src_fname = os.path.join(src, fname)
            mtime = os.path.getmtime(src_fname)
            mod_time = datetime.datetime.fromtimestamp(mtime)
            now_time = datetime.datetime.now()
            before = now_time - datetime.timedelta(hours=24)

            if mod_time >= before:
                # If file was modified within 24 hrs, copy to dst folder. Using copy2 to keep timestamps intact
                shutil.copy2(src_fname, dst)
    

    # Closes app
    def cancel(self):
        self.master.destroy()



if __name__ == "__main__":
    root = Tk()
    App = ParentWindow(root)
    root.mainloop()
    
