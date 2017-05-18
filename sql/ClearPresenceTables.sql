DELETE FROM agroPresence


DECLARE @var INT = 51, @culture INT = 1;
WHILE @var < 59
BEGIN
   
   SET @culture = 1;

   WHILE @culture < 4

   BEGIN

	   Insert into agroPresence VALUES (@culture, 1, @var, 0, 0, 0, 0, 0, 0, 0)
	   Insert into agroPresence VALUES (@culture, 2, @var, 0, 0, 0, 0, 0, 0, 0)
	   Insert into agroPresence VALUES (@culture, 3, @var, 0, 0, 0, 0, 0, 0, 0)

	   SET @culture = @culture + 1;

   END;

   SET @var = @var + 1;
END;
