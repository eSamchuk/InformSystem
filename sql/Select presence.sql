SELECT Periods.PeriodName, Variables.VariableName, Year, Winter, Spring, Summer, Autumn, Cold, Warm FROM Periods, Variables, regularPresence
Where Period = Periods.PeriodID AND Variable = Variables.VariableID
Order BY PeriodID ASC, VariableID ASC



/****** Script for SelectTopNRows command from SSMS  ******/
SELECT AgroCultures.CultureName, Periods.PeriodName, Variables.VariableName, Seasons.SeasonName Phase1, Phase2, Phase3, Phase4, Phase5, Phase6, Phase7 FROM Periods, Variables, agroPresence, Seasons, AgroCultures
Where Period = Periods.PeriodID AND Variable = Variables.VariableID AND Culture = AgroCultures.CultureID AND VariableID >=51 AND SeasonID >= 8
Order BY PeriodID ASC, VariableID ASC 

