# Python 3.9.6

import sqlite3 # Importing sqlite module...

# Data is pulled from here
file_list = ('information.docx','hello.txt','myimage.png','mymovie.mpg', \
             'world.txt','data.pdf','myphoto.jpg')


conn = sqlite3.connect('test.db')
with conn:
    # Creates a table
    cur = conn.cursor()
    cur.execute("CREATE TABLE IF NOT EXISTS tbl_files( \
        file_id INTEGER PRIMARY KEY AUTOINCREMENT, \
        file_name TEXT \
        )")
    conn.commit()
conn.close()

conn = sqlite3.connect('test.db')
for x in file_list:
    # Looks through the defined list for .txt files
    if x.endswith('.txt'):
        with conn:
            cur = conn.cursor()
            cur.execute("INSERT INTO tbl_files (file_name) VALUES (?)", (x,))
            conn.commit()
            # The matching files are added to the table and displayed to the user
            print(x)
conn.close()            
    

    
    




