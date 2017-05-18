
DECLARE @MyCursor CURSOR;
DECLARE @sqlstatement nvarchar(4000)
DECLARE @tableName varchar(60);

Declare @period INT = 0, @season INT = 0, @index INT = 0, @index2 INT = 0, @length INT = 0, @var INT = 0,  @culture INT = 0;

Declare @actual INT = 0, @changeSpeed INT = 0, @pValue INT = 0, @region INT = 0;

BEGIN

SET @MyCursor = CURSOR FOR SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME Like 'Agro_Table_%'

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

		if (@var < 57)
			Begin

				SET @index = CHARINDEX( '_', @tableName, @index2) + 1;
				SET @index2 = CHARINDEX( '_', @tableName, @index);
				SET @season = CAST (SUBSTRING(@tableName, @index, @index2 - @index) AS INT);

			END;
		ELSE SET @season = 0;

		SET @index = CHARINDEX( '_', @tableName, @index2) + 1;
		SET @index2 = CHARINDEX( '_', @tableName, @index);

		SET @culture = CAST (SUBSTRING(@tableName, @index, @index2 - @index) AS INT)


		set @sqlstatement = 'DECLARE extractedFromTable CURSOR FOR SELECT * FROM '  + @tableName;
		Print @sqlstatement;
		EXEC sp_executesql @sqlstatement;
		set @sqlstatement = 'OPEN extractedFromTable';
		EXEC sp_executesql @sqlstatement;

		set @sqlstatement = ' FETCH NEXT FROM extractedFromTable INTO @region, @actual, @changeSpeed, @pValue ';
		EXEC sp_executesql @sqlstatement;


		UPDATE AgroTable SET actualValue = @actual, changeSpeed = @changeSpeed, pValue = @pValue
		WHERE period = @period AND regionID = @region AND season = @season AND culture = @culture

		set @sqlstatement = 'CLOSE extractedFromTable; DEALLOCATE extractedFromTable;'
		EXEC sp_executesql @sqlstatement;

	

		

      FETCH NEXT FROM @MyCursor 
      INTO @tableName
    END; 

    CLOSE @MyCursor ;
    DEALLOCATE @MyCursor;

END;





