--Select Periods.PeriodID, VariableID, SeasonID From Variables, Seasons, Periods
--Where 
--SeasonName <> 'All' AND
--Variables.VariableSeasonID = Seasons.SeasonID And Variables.VariableSeasonID < 5 

--union

--Select Periods.PeriodID, VariableID, SeasonID From Variables, Periods  
--LEFT JOIN Seasons ON SeasonID = 1 OR (SeasonID >= 4 AND  SeasonID <= 7)
--WHERE VariableSeasonID = 0

----ORDER BY PeriodName DESC, VariableName ASC


--Select Periods.PeriodID, CultureID, VariableID, SeasonID From Variables, Seasons, AgroCultures, Periods  
--Where 
--SeasonName <> 'All' AND
--Variables.VariableSeasonID = Seasons.Chapter And Variables.VariableSeasonID >= 5

--ORDER BY PeriodName DESC

 

--DECLARE @cnt INT = 1;
--WHILE @cnt < 51
--BEGIN
   
--   Insert into regularPresence VALUES (1, @cnt, 0, 0, 0, 0, 0, 0, 0)
--   Insert into regularPresence VALUES (2, @cnt, 0, 0, 0, 0, 0, 0, 0)
--   Insert into regularPresence VALUES (3, @cnt, 0, 0, 0, 0, 0, 0, 0)

--   SET @cnt = @cnt + 1;
--END;

--DECLARE @period INT = 3, @season INT = 0, @var INT = 0;

--DECLARE @MyCursor CURSOR;

--BEGIN

--    SET @MyCursor = CURSOR FOR
--    SELECT Images.ImageSeason, Images.ImageVariable from Images WHERE images.ImageVariable < 51  AND Images.ImagePeriod = @period

--    OPEN @MyCursor 
--    FETCH NEXT FROM @MyCursor 
--    INTO @season, @var

--    WHILE @@FETCH_STATUS = 0
--    BEGIN
   
--		if @season = 1 UPDATE regularPresence SET Year = 1 WHERE Variable = @var AND Period = @period
--		if @season = 2 UPDATE regularPresence SET Warm = 1 WHERE Variable = @var AND Period = @period
--		if @season = 3 UPDATE regularPresence SET Cold = 1 WHERE Variable = @var AND Period = @period
--		if @season = 4 UPDATE regularPresence SET Winter = 1 WHERE Variable = @var AND Period = @period
--		if @season = 5 UPDATE regularPresence SET Spring = 1 WHERE Variable = @var AND Period = @period
--		if @season = 6 UPDATE regularPresence SET Summer = 1 WHERE Variable = @var AND Period = @period
--		if @season = 7 UPDATE regularPresence SET Autumn = 1 WHERE Variable = @var AND Period = @period

--      FETCH NEXT FROM @MyCursor 
--      INTO @season, @var
--    END; 

--    CLOSE @MyCursor ;
--    DEALLOCATE @MyCursor;
--END;