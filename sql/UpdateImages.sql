--Update Images Set ImageSeason = 4 Where ImageSeason = 2 AND
--(
--ImageVariable = 1 OR
--ImageVariable = 2 OR
--ImageVariable = 3 OR
--ImageVariable = 22 OR
--ImageVariable = 32 OR
--ImageVariable = 34 OR
--ImageVariable = 35 OR
--ImageVariable = 36 OR
--ImageVariable = 39 OR
--ImageVariable = 42 
--)


--Update Images Set ImageSeason = 2 Where ImageSeason = 1 AND
--(
--ImageVariable = 6 OR
--ImageVariable = 11 OR
--ImageVariable = 12 OR
--ImageVariable = 46 OR
--ImageVariable = 47 OR
--ImageVariable = 48 OR
--ImageVariable = 49 OR
--ImageVariable = 50 
--)

--Update Images Set ImageSeason = 3 Where ImageSeason = 1 AND
--(
--ImageVariable = 10 OR
--ImageVariable = 13 OR
--ImageVariable = 14 OR
--ImageVariable = 15 OR
--ImageVariable = 16 OR
--ImageVariable = 17
--)

--Update Images Set ImageSeason = 4 Where ImageSeason = 1 AND
--(
--ImageVariable = 45

--)

--Update Images Set ImageSeason = 8 Where ImageSeason = 1 AND ImageCulture = 2 AND
--(
--ImageVariable = 51 OR
--ImageVariable = 52 OR
--ImageVariable = 53 OR
--ImageVariable = 54 OR
--ImageVariable = 55 OR
--ImageVariable = 56 OR
--ImageVariable = 57 OR
--ImageVariable = 58
--)


--Update Images Set ImageSeason = 13 Where ImageSeason = 1 AND ImageCulture = 1 AND
--(
--ImageVariable = 51 OR
--ImageVariable = 52 OR
--ImageVariable = 53 OR
--ImageVariable = 54 OR
--ImageVariable = 55 OR
--ImageVariable = 56 OR
--ImageVariable = 57 OR
--ImageVariable = 58
--)



--Update Images Set ImageSeason = 20 Where ImageSeason = 1 AND ImageCulture = 3 AND
--(
--ImageVariable = 51 OR
--ImageVariable = 52 OR
--ImageVariable = 53 OR
--ImageVariable = 54 OR
--ImageVariable = 55 OR
--ImageVariable = 56 OR
--ImageVariable = 57 OR
--ImageVariable = 58
--)

Select ImageID, ImageVariable, ImageSeason, ImagePeriod from Images WHERE 

ImageVariable = 34
ORDER BY ImageVariable ASC, ImageSeason ASC, ImagePeriod ASC