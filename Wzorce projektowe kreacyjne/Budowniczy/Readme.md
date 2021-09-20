#Budowniczy

Wzorzec daje nam możliwość tworzenia złożonych obiektów etapami. Możemy dac klientow możliwość korzystania z etapów oraz wydelegowanie wytworzenia dyrektorowi.


Potrzebne jest nam:
- budowniczy- ```ICarBuilder``` który będzie zawierał definicję budowy samochodu
- konkretny budowniczy- ```SportCarBuilder : ICarBuilder```  
- dyrektor- ```CarDirector``` który będzie przydzielał budowniczego do wykonania


