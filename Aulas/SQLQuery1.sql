RESTORE DATABASE ClovisApplicationTesting
FROM DISK = 'C:\Users\user\Downloads\AdventureWorks2016.bak'

WITH MOVE 'AdventureWorks2016_Data' TO 'C:\Users\user\source\repos\Aulas-de-CSharp\Aulas\MeuDBTeste\NewFolder1\AdventureWorks2016.mdf',
MOVE 'AdventureWorks2016_Log' TO 'C:\Users\user\source\repos\Aulas-de-CSharp\Aulas\MeuDBTeste\NewFolder1\AdventureWorks2016.ldf',
REPLACE