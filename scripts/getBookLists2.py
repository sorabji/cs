#!/usr/bin/python

import os
import sys
import requests
import time
import random

infile = sys.argv[1]
failfile = 'failfiles'
num = 1
path = os.path.join(os.path.expanduser('~'),'newBookList')
os.chdir(path)
url = 'https://www.googleapis.com/books/v1/volumes'
params = {'q': ''}

def file_len(fname):
    i=0
    with open(fname) as f:
        for i, l in enumerate(f):
            pass
    return i + 1

def getStuff(catFile,failfile):
    with open(catFile) as cats:
        for term in cats:
            # damn new lines
            params['q'] = term[:-1]
            print "getting %s" % term[:-1]
            retOb = requests.get(url,params)
            if retOb.status_code == 403:
                print "failure on %s" % term[:-1]
                with open(failfile,'a') as failure:
                    print >> failure, term[:-1]
                #period = random.random()*100
                period = 1
                print "sleeping for %d seconds" % period
                time.sleep(period)
            else:
                print "got it! writing to file"
                jsons = retOb.content
                with open(term,'w') as out:
                    out.write(jsons)

getStuff(infile,failfile)
infile = failfile

while True:
    if file_len(infile) > 1:
        failfile = failfile[:-1]
        failfile = failfile + num.__str__()
        num+=1
        getStuff(infile,failfile)
    else:
        break

