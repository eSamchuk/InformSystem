--DECLARE @tableName varchar(60);

--Declare @period INT = 0, @var INT = 0, @season INT = 0, @index INT = 0, @index2 INT = 0, @length INT = 0;

--DECLARE @MyCursor CURSOR;

--BEGIN

--    SET @MyCursor = CURSOR FOR
--	SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME Like 'Table_%'

--    OPEN @MyCursor 
--    FETCH NEXT FROM @MyCursor 
--    INTO @tableName

--    WHILE @@FETCH_STATUS = 0
--    BEGIN
   
--		SET @length = LEN(@tableName);

--		SET @index = CHARINDEX( '_', @tableName, 1) + 1;
--		SET @index2 = CHARINDEX( '_', @tableName, @index);

--		SET @period = CAST (SUBSTRING(@tableName, @index, @index2 - @index) AS INT)

--		SET @index = CHARINDEX( '_', @tableName, @index2) + 1;
--		SET @index2 = CHARINDEX( '_', @tableName, @index);

--		SET @season = CAST (SUBSTRING(@tableName, @index, @index2 - @index) AS INT)

--		SET @index = CHARINDEX( '_', @tableName, @index2)+ 1;
--		SET @var = CAST (SUBSTRING(@tableName, @index, @length - @index + 1) AS INT)

--		--Print @tableName 
--		--Print @period 
--		--Print @season 
--		--Print @var 

--		if @season = 1 UPDATE regularPresence SET Year = 1 WHERE Variable = @var AND Period = @period
--		if @season = 2 UPDATE regularPresence SET Warm = 1 WHERE Variable = @var AND Period = @period
--		if @season = 3 UPDATE regularPresence SET Cold = 1 WHERE Variable = @var AND Period = @period
--		if @season = 4 UPDATE regularPresence SET Winter = 1 WHERE Variable = @var AND Period = @period
--		if @season = 5 UPDATE regularPresence SET Spring = 1 WHERE Variable = @var AND Period = @period
--		if @season = 6 UPDATE regularPresence SET Summer = 1 WHERE Variable = @var AND Period = @period
--		if @season = 7 UPDATE regularPresence SET Autumn = 1 WHERE Variable = @var AND Period = @period

--      FETCH NEXT FROM @MyCursor 
--      INTO @tableName
--    END; 

--    CLOSE @MyCursor ;
--    DEALLOCATE @MyCursor;
--END;



--DECLARE @var INT = 51, @culture INT = 1;
--WHILE @var < 59
--BEGIN
   
--   SET @culture = 1;

--   WHILE @culture < 4

--   BEGIN

--	   Insert into agroPresence VALUES (@culture, 1, @var, 0, 0, 0, 0, 0, 0, 0)
--	   Insert into agroPresence VALUES (@culture, 2, @var, 0, 0, 0, 0, 0, 0, 0)
--	   Insert into agroPresence VALUES (@culture, 3, @var, 0, 0, 0, 0, 0, 0, 0)

--	   SET @culture = @culture + 1;

--   END;

--   SET @var = @var + 1;
--END;







