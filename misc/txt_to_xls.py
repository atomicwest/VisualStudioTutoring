#this parser was written specifically to handle txt files with
#tab and/or new line delimited files such as
#https://onlinecourses.science.psu.edu/stat501/sites/onlinecourses.science.psu.edu.stat501/files/data/skincancer.txt

import os
import sys
import pandas as pd
import numpy as np
import xlwt

from collections import deque

filename = "skincancer.txt"

file = open(filename, 'r')
rows = deque([])
for row in file:
    rows.append(row.split("\t"))
    # rows.append(row.split("\n"))

#assuming the first row contains the names of the columns
headers = [x.strip() for x in rows[0][0].split(" ") if x != ""]

#remove headers if they are the first row
rows.popleft()

#create dictionary for storing data
data = { k:[] for k in headers}

#store info in data  dictionary
for r in rows:
    info = [n for n in r[0].split(" ") if n != ""]
    for i in range(len(headers)):
        # if i==0: continue
        data[headers[i]].append(info[i].strip())

#separate State or other column to use as index
states = data["State"]
data.pop("State")

df = pd.DataFrame(data, index=states)

print(df)

# df.to_csv('skincancer.csv')
df.to_excel('skincancer.xls',filename.strip('.txt'))



