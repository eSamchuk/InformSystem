/****** Script for SelectTopNRows command from SSMS  ******/
SELECT Variables.VariableID, VariableName, PeriodName,DimensionName

  FROM Variables, Periods, Dimensions,VariableDimensions

  Where Variables.VariableID = VariableDimensions.VariableID
  AND Periods.PeriodID = VariableDimensions.Period
  AND VariableDimensions.Dimension= Dimensions.DimensionID

  

  SELECT  VariableID, Period

  FROM VariableDimensions

  Where  Dimension = 0

