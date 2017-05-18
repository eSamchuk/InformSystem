--DELETE FROM agroPresence

DECLARE @var INT = 51, @culture INT = 1;

--WHILE @var < 59
--BEGIN
   
--   SET @culture = 1;

--   WHILE @culture < 4

--   BEGIN

--	   Insert into agroPresence VALUES (@culture, 1, @var, 'Нема', 'Нема', 'Нема', 'Нема', 'Нема', 'Нема', 'Нема')
--	   Insert into agroPresence VALUES (@culture, 2, @var, 'Нема', 'Нема', 'Нема', 'Нема', 'Нема', 'Нема', 'Нема')
--	   Insert into agroPresence VALUES (@culture, 3, @var, 'Нема', 'Нема', 'Нема', 'Нема', 'Нема', 'Нема', 'Нема')

--	   SET @culture = @culture + 1;

--   END;

--   SET @var = @var + 1;
--END;

--Delete from agroPresence Where Variable = 53



UPDATE agroPresence SET Phase6 = '-', Phase7 = '-' WHERE Culture <> 1

UPDATE agroPresence SET 
Phase2 = '-',
Phase3 = '-',
Phase4 = '-',
Phase5 = '-',
Phase6 = '-',
Phase7 = '-' 
 WHERE Variable >= 57




DECLARE @tableName varchar(60);

Declare @period INT = 0, @season INT = 0, @index INT = 0, @index2 INT = 0, @length INT = 0, @type nchar(10) = 'Таблиця';

DECLARE @MyCursor CURSOR;

BEGIN

    SET @MyCursor = CURSOR FOR
	SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME Like 'Agro_Table_%'

    OPEN @MyCursor 
    FETCH NEXT FROM @MyCursor 
    INTO @tableName

    WHILE @@FETCH_STATUS = 0
    BEGIN
   
		SET @length = LEN(@tableName);

		SET @var = CAST (SUBSTRING(@tableName, @length - 1, 2) AS INT)

		SET @index = CHARINDEX( '_', @tableName, 1) + 1;
		SET @index = CHARINDEX( '_', @tableName, @index) + 1;
		SET @index2 = CHARINDEX( '_', @tableName, @index);

		SET @period = CAST (SUBSTRING(@tableName, @index, @index2 - @index) AS INT)

		SET @index = CHARINDEX( '_', @tableName, @index2) + 1;
		SET @index2 = CHARINDEX( '_', @tableName, @index);

		SET @season = CAST (SUBSTRING(@tableName, @index, @index2 - @index) AS INT)

		SET @index = CHARINDEX( '_', @tableName, @index2) + 1;
		SET @index2 = CHARINDEX( '_', @tableName, @index);

		
		if (@var < 57)

		SET @culture = CAST (SUBSTRING(@tableName, @index, @index2 - @index) AS INT)
	
		begin
			if @season = 8 UPDATE agroPresence SET Phase1 = @type WHERE Variable = @var AND Period = @period AND Culture = @culture
			if @season = 9 UPDATE agroPresence SET Phase2 = @type WHERE Variable = @var AND Period = @period AND Culture = @culture
			if @season = 10 UPDATE agroPresence SET Phase3 = @type WHERE Variable = @var AND Period = @period AND Culture = @culture
			if @season = 11 UPDATE agroPresence SET Phase4 = @type WHERE Variable = @var AND Period = @period AND Culture = @culture
			if @season = 12 UPDATE agroPresence SET Phase5 = @type WHERE Variable = @var AND Period = @period AND Culture = @culture
			if @season = 13 UPDATE agroPresence SET Phase6 = @type WHERE Variable = @var AND Period = @period AND Culture = @culture
			if @season = 14 UPDATE agroPresence SET Phase7 = @type WHERE Variable = @var AND Period = @period AND Culture = @culture
			if @season = 15 UPDATE agroPresence SET Phase1 = @type WHERE Variable = @var AND Period = @period AND Culture = @culture
			if @season = 16 UPDATE agroPresence SET Phase2 = @type WHERE Variable = @var AND Period = @period AND Culture = @culture
			if @season = 17 UPDATE agroPresence SET Phase3 = @type WHERE Variable = @var AND Period = @period AND Culture = @culture
			if @season = 18 UPDATE agroPresence SET Phase4 = @type WHERE Variable = @var AND Period = @period AND Culture = @culture
			if @season = 19 UPDATE agroPresence SET Phase5 = @type WHERE Variable = @var AND Period = @period AND Culture = @culture
			if @season = 20 UPDATE agroPresence SET Phase1 = @type WHERE Variable = @var AND Period = @period AND Culture = @culture
			if @season = 21 UPDATE agroPresence SET Phase2 = @type WHERE Variable = @var AND Period = @period AND Culture = @culture
			if @season = 22 UPDATE agroPresence SET Phase3 = @type WHERE Variable = @var AND Period = @period AND Culture = @culture
			if @season = 23 UPDATE agroPresence SET Phase4 = @type WHERE Variable = @var AND Period = @period AND Culture = @culture
			if @season = 24 UPDATE agroPresence SET Phase5 = @type WHERE Variable = @var AND Period = @period AND Culture = @culture
		end;

      FETCH NEXT FROM @MyCursor 
      INTO @tableName
    END; 

    CLOSE @MyCursor ;
    DEALLOCATE @MyCursor;
END;


SET @period = 1
SET @type = 'Карта'

WHILE @period < 4
BEGIN

	SET @season = 0
	SET @var = 0
	SET @culture = 0 

	DECLARE @cnt INT = 0;

	DECLARE @imageCursor CURSOR;

	BEGIN

		SET @imageCursor = CURSOR FOR
		SELECT Images.ImageSeason, Images.ImageVariable, Images.ImageCulture from Images WHERE images.ImageVariable >= 51  AND Images.ImagePeriod = @period

		OPEN @imageCursor 
		FETCH NEXT FROM @imageCursor 
		INTO @season, @var, @culture

		WHILE @@FETCH_STATUS = 0
		BEGIN
   
			if @season = 8 UPDATE agroPresence SET Phase1 = @type WHERE Variable = @var AND Period = @period AND Culture = @culture
			if @season = 9 UPDATE agroPresence SET Phase2 = @type WHERE Variable = @var AND Period = @period AND Culture = @culture
			if @season = 10 UPDATE agroPresence SET Phase3 = @type WHERE Variable = @var AND Period = @period AND Culture = @culture
			if @season = 11 UPDATE agroPresence SET Phase4 = @type WHERE Variable = @var AND Period = @period AND Culture = @culture
			if @season = 12 UPDATE agroPresence SET Phase5 = @type WHERE Variable = @var AND Period = @period AND Culture = @culture
			if @season = 13 UPDATE agroPresence SET Phase6 = @type WHERE Variable = @var AND Period = @period AND Culture = @culture
			if @season = 14 UPDATE agroPresence SET Phase7 = @type WHERE Variable = @var AND Period = @period AND Culture = @culture
			if @season = 15 UPDATE agroPresence SET Phase1 = @type WHERE Variable = @var AND Period = @period AND Culture = @culture
			if @season = 16 UPDATE agroPresence SET Phase2 = @type WHERE Variable = @var AND Period = @period AND Culture = @culture
			if @season = 17 UPDATE agroPresence SET Phase3 = @type WHERE Variable = @var AND Period = @period AND Culture = @culture
			if @season = 18 UPDATE agroPresence SET Phase4 = @type WHERE Variable = @var AND Period = @period AND Culture = @culture
			if @season = 19 UPDATE agroPresence SET Phase5 = @type WHERE Variable = @var AND Period = @period AND Culture = @culture
			if @season = 20 UPDATE agroPresence SET Phase1 = @type WHERE Variable = @var AND Period = @period AND Culture = @culture
			if @season = 21 UPDATE agroPresence SET Phase2 = @type WHERE Variable = @var AND Period = @period AND Culture = @culture
			if @season = 22 UPDATE agroPresence SET Phase3 = @type WHERE Variable = @var AND Period = @period AND Culture = @culture
			if @season = 23 UPDATE agroPresence SET Phase4 = @type WHERE Variable = @var AND Period = @period AND Culture = @culture
			if @season = 24 UPDATE agroPresence SET Phase5 = @type WHERE Variable = @var AND Period = @period AND Culture = @culture

			SET @cnt = @cnt + 1;

		  FETCH NEXT FROM @imageCursor 
		INTO @season, @var, @culture
		END; 

		Print @cnt
		CLOSE @imageCursor ;
		DEALLOCATE @imageCursor;

	END;

	Set @period = @period + 1

END;