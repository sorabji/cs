#!/usr/bin/python

import os
import subprocess

cats = open('categories.txt')
path = os.path.join(os.path.expanduser('~'),'bookLists')
os.chdir(path)
for term in cats:
    # damn new lines
    term = term[:-1]
    os.system('wget --waitretry=120 -O '+term+'.json https://www.googleapis.com/books/v1/volumes?q='+term+'&printType=paid-ebooks')
    os.system('sleep 30')
