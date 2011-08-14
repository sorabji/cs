#!/usr/bin/python

"""
isbn: jsonData[u'items'][0][u'volumeInfo'][u'industryIdentifiers'][0][u'identifier']
    items is all items, iterate, industryIdentifiers has both ISBN_10 and ISBN_13, first is what we want
title: jsonData[u'items'][0][u'volumeInfo'][u'title']
author: jsonData[u'items'][0][u'volumeInfo'][u'authors']LIST
    authors is a list...possible multiple authors
listPrice: jsonData[u'items'][0][u'saleInfo'][u'listPrice'][u'amount']
retailPrice: jsonData[u'items'][0][u'saleInfo'][u'retailPrice'][u'amount']
"""
import os
import json
import random
import csv
import math
import sys

#outfile = "books.data"
outfile = sys.argv[1]
#path = os.path.join(os.path.expanduser('~'),'bookLists')
path = os.path.join(os.path.curdir,'bookLists')
#csvWriter = csv.writer(open(outfile,"w"),delimiter="|")
outfile = open(outfile,'w')
files = os.listdir(path)

for infile in files:
    jsonData = json.load(open(os.path.join(path,infile)))
    for item in jsonData[u'items']:
        curData = []
        data = item[u'volumeInfo']
        saleInfo = item[u'saleInfo']

        if (data[u'industryIdentifiers'][0][u'type'] == "OTHER"):
            isbn = (math.floor(random.random()*10000000000)).__str__()
            isbn = isbn[:-2]
            curData.append(isbn)
        else:
            isbn = data[u'industryIdentifiers'][0][u'identifier']
            curData.append(isbn)
        title = data[u'title']
        curData.append(title)
        try:
            authorsList = data[u'authors']
        except KeyError:
            authorsList = ['john smith']
        author = authorsList[0]
        curData.append(author)
        if u'listPrice' in saleInfo:
            if u'amount' in saleInfo[u'listPrice']:
                listPrice = saleInfo[u'listPrice'][u'amount']
                retailPrice = saleInfo[u'retailPrice'][u'amount']
            else:
                listPrice = saleInfo[u'listPrice']
                retailPrice = saleInfo[u'retailPrice']
        else:
            listPrice = round((random.random()*1000),2)
            retailPrice = listPrice*.6
        curData.append(listPrice)
        curData.append(retailPrice)
        #csvWriter.writerow(curData)
        i = 0
        for x in curData:
            if i < 4:
                tmp = "%(var)s|"%{'var':x}
            else:
                tmp = "%(var)s"%{'var':x}
            i += 1
            try:
                outfile.write(tmp)
            except UnicodeEncodeError:
                outfile.write("unicodeErrorHere|")
        outfile.write("\n")

outfile.close()
