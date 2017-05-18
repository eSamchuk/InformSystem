/****** Script for SelectTopNRows command from SSMS  ******/
SELECT Variables.VariableName AS 'Показник'
      ,Periods.PeriodName AS 'Період'
      ,Dimension AS 'Розмірність'
  FROM VariableDimensions, Variables, Periods
  WHERE Variables.VariableID = VariableDimensions.VariableID AND Periods.PeriodID =VariableDimensions.Period 
