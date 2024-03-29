# -*- coding: utf-8 -*-
"""KW_MMDS- Colab 2.ipynb

Automatically generated by Colaboratory.

Original file is located at
    https://colab.research.google.com/drive/1jgVf1cwl5X78nQxVuXEH0FLjyjpdCqwe

# KW_MMDS - Colab 2
## Frequent Pattern Mining in Spark

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

id='1dhi1F78ssqR8gE6U-AgB80ZW7V_9snX4'
downloaded = drive.CreateFile({'id': id})
downloaded.GetContentFile('products.csv')

id='1KZBNEaIyMTcsRV817us6uLZgm-Mii8oU'
downloaded = drive.CreateFile({'id': id})
downloaded.GetContentFile('order_products__train.csv')

"""If you executed the cells above, you should be able to see the dataset we will need for this Colab under the "Files" tab on the left panel."""

# Commented out IPython magic to ensure Python compatibility.
import pandas as pd
import numpy as np
import matplotlib.pyplot as plt
# %matplotlib inline

import pyspark
from pyspark.sql import *
from pyspark.sql.functions import *
from pyspark import SparkContext, SparkConf

"""Let's initialize the Spark context."""

# create the session
conf = SparkConf().set("spark.ui.port", "4050")

# create the context
sc = pyspark.SparkContext(conf=conf)
spark = SparkSession.builder.getOrCreate()

"""### Your task

If you run successfully the setup stage, you are ready to work with the **3 Million Instacart Orders** dataset. In case you want to read more about it, check the [official Instacart blog post](https://tech.instacart.com/3-million-instacart-orders-open-sourced-d40d29ead6f2) about it, a concise [schema description](https://gist.github.com/jeremystan/c3b39d947d9b88b3ccff3147dbcf6c6b) of the dataset, and the [download page](https://www.instacart.com/datasets/grocery-shopping-2017).

In this Colab, we will be working only with a small training dataset (~131K orders) to perform fast Frequent Pattern Mining with the FP-Growth algorithm.
"""

products = spark.read.csv('products.csv', header=True, inferSchema=True)
orders = spark.read.csv('order_products__train.csv', header=True, inferSchema=True)

products.printSchema()

orders.printSchema()

"""Use the Spark Dataframe API to join 'products' and 'orders', so that you will be able to see the product names in each transaction (and not only their ids).  Then, group by the orders by 'order_id' to obtain one row per basket (i.e., set of products purchased together by one customer).

In this Colab we will explore [MLlib](https://spark.apache.org/mllib/), Apache Spark's scalable machine learning library. Specifically, you can use its implementation of the [FP-Growth](https://spark.apache.org/docs/latest/ml-frequent-pattern-mining.html#fp-growth) algorithm to perform efficiently Frequent Pattern Mining in Spark.
Use the Python example in the documentation, and train a model with 

```minSupport=0.01``` and ```minConfidence=0.5```

1. Compute how many frequent itemsets and association rules were generated by running FP-growth.
"""

# YOUR CODE HERE
from pyspark.ml.fpm import FPGrowth

orders_joined = orders.join(products, products.product_id == orders.product_id)
orders_joined = orders_joined.selectExpr(["order_id", "product_name"])

df = orders_joined.groupBy('order_id').agg(collect_set('product_name').alias('items'))

fpGrowth = FPGrowth(itemsCol="items", minSupport=0.01, minConfidence=0.5)
model = fpGrowth.fit(df)

print(model.freqItemsets.count(), model.associationRules.count())

"""2. What is the most frequent item?"""

# YOUR CODE HERE
model.freqItemsets.sort(desc("freq")).show(1)

"""3. Now retrain the FP-growth model changing only 
```minsupport=0.001``` 
and compute how many frequent itemsets and association rules were generated.

"""

# YOUR CODE HERE
fpGrowth = FPGrowth(itemsCol="items", minSupport=0.001, minConfidence=0.5)
model = fpGrowth.fit(df)

print(model.freqItemsets.count(), model.associationRules.count())

"""4. Print all the association rules of the above problem."""

# YOUR CODE HERE
model.associationRules.show(truncate=False)

"""5. What can be inferred from the association rules? Write a comment you can get from the rules."""

# YOUR TEXT HERE
# (IN ENGLISH OR KOREAN)
[Organic Raspberries, Organic Hass Avocado]를 사는 사람들 중에 Bag of Organic Bananas까지 살 경향이 있다.
많은 사람들이 Organic Hass Avocado를 사는 사람이 비율이 많다.