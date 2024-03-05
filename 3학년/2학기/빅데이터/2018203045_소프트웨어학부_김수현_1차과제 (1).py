# -*- coding: utf-8 -*-
"""KW_MMDS - Colab 1.ipynb

Automatically generated by Colaboratory.

Original file is located at
    https://colab.research.google.com/drive/1I29N2KxSZO0NZX2Tvnvz0zSBAxv_klAr

# KW_MMDS - Colab 1
## Wordcount in Spark

### Setup

Let's setup Spark on your Colab environment.  Run the cell below!
"""

!pip install pyspark
!pip install -U -q PyDrive
!apt install openjdk-8-jdk-headless -qq
import os
os.environ["JAVA_HOME"] = "/usr/lib/jvm/java-8-openjdk-amd64"

"""Now we authenticate a Google Drive client to download the file we will be processing in our Spark job.

**Make sure to follow the interactive instructions.**
"""

from pydrive.auth import GoogleAuth
from pydrive.drive import GoogleDrive
from google.colab import auth
from oauth2client.client import GoogleCredentials

# Authenticate and create the PyDrive client
auth.authenticate_user()
gauth = GoogleAuth()
gauth.credentials = GoogleCredentials.get_application_default()
drive = GoogleDrive(gauth)

id='1SE6k_0YukzGd5wK-E4i6mG83nydlfvSa'
downloaded = drive.CreateFile({'id': id})
downloaded.GetContentFile('pg100.txt')

"""If you executed the cells above, you should be able to see the file *pg100.txt* under the "Files" tab on the left panel.

### Your task

If you run successfully the setup stage, you are ready to work on the *pg100.txt* file which contains a copy of the complete works of Shakespeare.

1. Write a Spark application which outputs the number of words that start with each letter. This means that for every letter we want to count the total number of (non-unique) words that start with a specific letter. In your implementation **ignore the letter case**, i.e., consider all words as lower case. Also, you can ignore all the words **starting** with a non-alphabetic character.

(셰익스피어 전집에서 a부터 z까지 각 알파벳으로 시작하는 단어의 수를 세어보세요. 대문자는 소문자로 해석합니다. 또한 알파벳으로 시작하지 않는 단어는 무시합니다.)
"""

from pyspark.sql import *
from pyspark.sql.functions import *
from pyspark import SparkContext
import pandas as pd

# create the Spark Session
spark = SparkSession.builder.getOrCreate()

# create the Spark Context
sc = spark.sparkContext

RDDs = sc.textFile('pg100.txt')
RDDs = RDDs.map(lambda line: line.lower())
RDDs = RDDs.flatMap(lambda line: line.split(" "))
RDDs = RDDs.filter(lambda word: len(word) > 0)
RDDs = RDDs.filter(lambda word: word[0].isalpha())
RDDs = RDDs.map(lambda word: (word[0], 1))
RDDs = RDDs.reduceByKey(lambda a, b: a+b)
RDDs = RDDs.sortByKey(ascending=True)
RDDs.take(26)

"""2. Now, you have to work on the *2641-0.txt* file which contains 'A Room With A View' by E. M. Forster. Write a Spark application which outputs the 10 most frequently used words that start with **N**.  In your implementation ignore the letter case, i.e., consider all words as **upper** case.

('풍경이 있는 방'에서 N으로 시작하는 가장 많이 사용된 단어 10개를 출력하세요. 소문자는 대문자로 해석합니다.)
"""

# 풍경이 있는 방 다운로드: 2641-0.txt
room_id='1kXS_ZcsEiSdRsEwf_vIdDDJ9-RoFIcBn'
room_downloaded = drive.CreateFile({'id': id})
room_downloaded.GetContentFile('2641-0.txt')

RDDs = sc.textFile('2641-0.txt')
RDDs = RDDs.map(lambda line: line.upper())
RDDs = RDDs.flatMap(lambda line: line.split(" "))
RDDs = RDDs.filter(lambda word: len(word) > 0)
RDDs = RDDs.filter(lambda word: word.isalpha())
RDDs = RDDs.filter(lambda word: word[0] == "N")
RDDs = RDDs.map(lambda word: (word, 1))
RDDs = RDDs.reduceByKey(lambda a, b: a+b)
RDDs = RDDs.map(lambda tuple: (tuple[1], tuple[0]))
RDDs = RDDs.sortByKey(ascending=False)
RDDs = RDDs.map(lambda tuple: (tuple[0], tuple[1]))
RDDs.take(10)