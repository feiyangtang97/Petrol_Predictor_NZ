import pandas as pd
import numpy as np
import matplotlib.pyplot as plt
from pylab import rcParams
from pandas.tseries.offsets import *
import statsmodels.api as sm
from scipy import stats
from scipy.stats import ttest_ind
from datetime import datetime
import warnings
warnings.filterwarnings('ignore')
df_MSD_Weekly=pd.read_csv('weekly_table-20-May-2016.csv')
ts_data_petrol = pd.TimeSeries(df_MSD_Weekly['Petrol_discounted_retail_price_NZc.p.l'].values, index=pd.to_datetime(df_MSD_Weekly.Week_ending_friday))
ts_data_diesel= pd.TimeSeries(df_MSD_Weekly['Diesel_discounted_retail_price_NZc.p.l'].values, index=pd.to_datetime(df_MSD_Weekly.Week_ending_friday))
ts_log_data_petrol = np.log(ts_data_petrol)
ts_log_data_diesel = np.log(ts_data_diesel)
model_petrol = sm.tsa.ARMA(ts_log_data_petrol, order=(1,1)).fit()
model_diesel= sm.tsa.ARMA(ts_log_data_diesel, order=(1,1)).fit()

y_forecast_petrol = model_petrol.predict(pd.datetime.now().isoformat(),( pd.datetime.now()+Day(32)).isoformat())
y_forecast_diesel = model_diesel.predict(pd.datetime.now().isoformat(),( pd.datetime.now()+Day(32)).isoformat())
import sys
f = open('predictions.txt', 'w')

predic_result=[str(np.exp(y_forecast_petrol)[0]),str(np.exp(y_forecast_petrol)[1]),str(np.exp(y_forecast_diesel)[0]),str(np.exp(y_forecast_diesel)[1])]
#predic_result=np.asanyarray(predic_result)
for each in predic_result:
    f.writelines(each)
    f.write(" ")

f.close()

df_diesel=df_MSD_Weekly[['Week_ending_friday','Diesel_discounted_retail_price_NZc.p.l']]
df_Petrol=df_MSD_Weekly[['Week_ending_friday','Petrol_discounted_retail_price_NZc.p.l']]

df_diesel=df_diesel.set_index(df_diesel.Week_ending_friday)
df_diesel.ix[-52:,:].plot(title="NZ Diesel price trend for current year",colors="blue")
plt.savefig('diesel.png')
df_Petrol=df_Petrol.set_index(df_Petrol.Week_ending_friday)
df_Petrol.ix[-52:,:].plot(title="Petrol_discounted_retail_price_NZc.p.l",colors="red")
plt.savefig('petrol.png')