DECLARE @tableName varchar(60);

DECLARE @type varchar(10) = 'Таблиця'
 
DECLARE @index INT = 0, @index2 INT = 0, @length INT = 0,  @var INT = 0, @season INT = 0, @period INT = 0;

DECLARE @tableCursor CURSOR;

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

		SELECT @tableName, Images.ImageID  FROM Images WHERE
		Images.ImageVariable = @var AND Images.ImageSeason = @season AND Images.ImagePeriod = @period



		FETCH NEXT FROM @tableCursor 
		INTO @tableName
	END; 

    CLOSE @tableCursor ;
    DEALLOCATE @tableCursor;
END;