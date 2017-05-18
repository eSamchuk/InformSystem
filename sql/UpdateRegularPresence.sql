--DELETE FROM regularPresence;

--DECLARE @cnt INT = 1;
--WHILE @cnt < 51
--BEGIN
   
--   Insert into regularPresence VALUES (1, @cnt, 'Нема', 'Нема', 'Нема', 'Нема', 'Нема', 'Нема', 'Нема')
--   Insert into regularPresence VALUES (2, @cnt, 'Нема', 'Нема', 'Нема', 'Нема', 'Нема', 'Нема', 'Нема')
--   Insert into regularPresence VALUES (3, @cnt, 'Нема', 'Нема', 'Нема', 'Нема', 'Нема', 'Нема', 'Нема')

--   SET @cnt = @cnt + 1;
--END;

----РЗВЛО
--Update regularPresence SET Warm = '-', Cold = '-' where 
--(Variable >= 1 AND Variable <= 3) OR
--Variable = 22 OR
--Variable = 32 OR
--(Variable >= 34 AND Variable <= 36) OR
--Variable = 39 OR
--Variable = 42;

----РІК
--Update regularPresence SET Warm = '-', Cold = '-', Winter = '-', Spring = '-', Summer = '-', Autumn = '-' where 
--Variable = 4 OR
--Variable = 5 OR
--(Variable >= 7 AND Variable <= 9) OR
--(Variable >= 18 AND Variable <= 21) OR
--(Variable >= 23 AND Variable <= 31) OR
--Variable = 33 OR
--(Variable >= 37 AND Variable <= 38) OR
--(Variable >= 40 AND Variable <= 41) OR
--(Variable >= 43 AND Variable <= 44);

----ТП
--Update regularPresence SET Cold = '-', Year = '-', Winter = '-', Spring = '-', Summer = '-', Autumn = '-' where 
--Variable = 6 OR
--(Variable >= 14 AND Variable <= 15) OR
--(Variable >= 46 AND Variable <= 50);

----ХП
--Update regularPresence SET Warm = '-', Year = '-', Winter = '-', Spring = '-', Summer = '-', Autumn = '-' where 
--(Variable >= 10 AND Variable <= 13) OR
--(Variable >= 16 AND Variable <= 17);

----Зима
--Update regularPresence SET Warm = '-', Year = '-', Cold = '-', Spring = '-', Summer = '-', Autumn = '-' where 
--Variable = 45;



DECLARE @period INT = 1, @season INT = 0, @var INT = 0, @type nchar(10) = 'Карта';

DECLARE @MyCursor CURSOR;


WHILE @period < 4
BEGIN

	BEGIN

		SET @MyCursor = CURSOR FOR
		SELECT Images.ImageSeason, Images.ImageVariable from Images WHERE images.ImageVariable < 51  AND Images.ImagePeriod = @period

		OPEN @MyCursor 
		FETCH NEXT FROM @MyCursor 
		INTO @season, @var

		WHILE @@FETCH_STATUS = 0
		BEGIN
   
			if @season = 1 UPDATE regularPresence SET Year = @type WHERE Variable = @var AND Period = @period
			if @season = 2 UPDATE regularPresence SET Warm = @type WHERE Variable = @var AND Period = @period
			if @season = 3 UPDATE regularPresence SET Cold = @type WHERE Variable = @var AND Period = @period
			if @season = 4 UPDATE regularPresence SET Winter = @type WHERE Variable = @var AND Period = @period
			if @season = 5 UPDATE regularPresence SET Spring = @type WHERE Variable = @var AND Period = @period
			if @season = 6 UPDATE regularPresence SET Summer = @type WHERE Variable = @var AND Period = @period
			if @season = 7 UPDATE regularPresence SET Autumn = @type WHERE Variable = @var AND Period = @period

		  FETCH NEXT FROM @MyCursor 
		  INTO @season, @var
		END; 

		CLOSE @MyCursor ;
		DEALLOCATE @MyCursor;

	END;

	set @period = @period + 1;

END;

DECLARE @tableName varchar(60);

SET @type = 'Таблиця'
 
DECLARE @index INT = 0, @index2 INT = 0, @length INT = 0;

DECLARE @tableCursor CURSOR;

SET @var = 0
SET @season = 0

BEGIN

	SET @tableCursor = CURSOR FOR
	SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME Like 'Table_%'

	OPEN @tableCursor 
	FETCH NEXT FROM @tableCursor 
	INTO @tableName

	WHILE @@FETCH_STATUS = 0
	BEGIN
   
		SET @length = LEN(@tableName);

		SET @index = CHARINDEX( '_', @tableName, 1) + 1;
		SET @index2 = CHARINDEX( '_', @tableName, @index);

		SET @period = CAST (SUBSTRING(@tableName, @index, @index2 - @index) AS INT)

		SET @index = CHARINDEX( '_', @tableName, @index2) + 1;
		SET @index2 = CHARINDEX( '_', @tableName, @index);

		SET @season = CAST (SUBSTRING(@tableName, @index, @index2 - @index) AS INT)

		SET @index = CHARINDEX( '_', @tableName, @index2)+ 1;
		SET @var = CAST (SUBSTRING(@tableName, @index, @length - @index + 1) AS INT)

		if @season = 1 UPDATE regularPresence SET Year = @type WHERE Variable = @var AND Period = @period
		if @season = 2 UPDATE regularPresence SET Warm = @type WHERE Variable = @var AND Period = @period
		if @season = 3 UPDATE regularPresence SET Cold = @type WHERE Variable = @var AND Period = @period
		if @season = 4 UPDATE regularPresence SET Winter = @type WHERE Variable = @var AND Period = @period
		if @season = 5 UPDATE regularPresence SET Spring = @type WHERE Variable = @var AND Period = @period
		if @season = 6 UPDATE regularPresence SET Summer = @type WHERE Variable = @var AND Period = @period
		if @season = 7 UPDATE regularPresence SET Autumn = @type WHERE Variable = @var AND Period = @period

		FETCH NEXT FROM @tableCursor 
		INTO @tableName
	END; 

    CLOSE @tableCursor ;
    DEALLOCATE @tableCursor;
END;