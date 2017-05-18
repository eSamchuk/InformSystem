--CREATE TABLE VariableDimensions 
--(
--VariableID int NOT NULL,
--Period1 INT NOT NULL,
--Period2 INT NOT NULL, 
--Period3 INT NOT NULL,
--PRIMARY KEY (VariableID),
--FOREIGN KEY (VariableID) REFERENCES Variables(VariableID));

Declare @cnt INT = 1, @period INT = 0;

while @cnt <= 58
Begin

 if (@cnt <> 53) 
 Begin

	Insert INTO VariableDimensions VALUES (@cnt, 1, 0);
	Insert INTO VariableDimensions VALUES (@cnt, 2, 0);
	Insert INTO VariableDimensions VALUES (@cnt, 3, 0);

 END;

Set @cnt = @cnt + 1
End;
