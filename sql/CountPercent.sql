declare @summReg float = 0, @absentReg float = 0;
declare @summAgro float = 0, @absentAgro float = 0;
declare @type char(10) = '-'

Set @summReg = 
(select Count(*) From regularPresence Where Warm <> @type) +
(select Count(*) From regularPresence Where Cold <> @type) +
(select Count(*) From regularPresence Where Year <> @type) +
(select Count(*) From regularPresence Where Winter <> @type) +
(select Count(*) From regularPresence Where Spring <> @type) +
(select Count(*) From regularPresence Where Summer <> @type) +
(select Count(*) From regularPresence Where Autumn <> @type)

Set @type = 'Нема'

Set @absentReg = 
(select Count(*) From regularPresence Where Warm = @type) +
(select Count(*) From regularPresence Where Cold = @type) +
(select Count(*) From regularPresence Where Year = @type) +
(select Count(*) From regularPresence Where Winter = @type) +
(select Count(*) From regularPresence Where Spring = @type) +
(select Count(*) From regularPresence Where Summer = @type) +
(select Count(*) From regularPresence Where Autumn = @type)

print @summReg
print @absentReg

print ((@summReg - @absentReg) / @summReg) * 100;

Set @type = '-'

Set @summAgro = 
(select Count(*) From agroPresence Where Phase1 <> @type) +
(select Count(*) From agroPresence Where Phase2 <> @type) +
(select Count(*) From agroPresence Where Phase3 <> @type) +
(select Count(*) From agroPresence Where Phase4 <> @type) +
(select Count(*) From agroPresence Where Phase5 <> @type) +
(select Count(*) From agroPresence Where Phase6 <> @type) +
(select Count(*) From agroPresence Where Phase7 <> @type)

Set @type = 'Нема'

Set @absentAgro = 
(select Count(*) From agroPresence Where Phase1 = @type) +
(select Count(*) From agroPresence Where Phase2 = @type) +
(select Count(*) From agroPresence Where Phase3 = @type) +
(select Count(*) From agroPresence Where Phase4 = @type) +
(select Count(*) From agroPresence Where Phase5 = @type) +
(select Count(*) From agroPresence Where Phase6 = @type) +
(select Count(*) From agroPresence Where Phase7 = @type)

print @summAgro
print @absentAgro

print ((@summAgro - @absentAgro) / @summAgro) * 100;