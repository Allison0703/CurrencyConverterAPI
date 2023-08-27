# CurrencyConverterAPI
匯率轉換API

CurrencyConverterAPI使用Asp.Net Core來建立Web API。


[路徑] 

~/api/CurrencyConverter?source={source}&target={target}&amount={amount}

大括號為欲輸入的參數值



[檔案說明]

CurrencyConverterAPI.sln: Visual Studio方案檔

CurrencyConverterAPI: 匯率轉換API程式
	Controllers > CurrencyConverterController.cs > Get方法接收網址上的參數值。
 	Models > ConverterResult.cs 回傳結果用的Class
  		 CurrencyConverter.cs 匯率轉換用的Class
     	Services.cs > CurrencyConvert方法處理參數值是否合法，若合法即進行匯率轉換並回傳結果。
    
CurrencyConverterAPITests: 單元測試程式
	ServicesTests.cs > CurrencyConvertTest用來測試Services.cs中的CurrencyConvert功能
