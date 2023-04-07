insert into [dbo].[Modules]
(Name, Description)
values('OOP', 'Object oriented programming')

insert into [dbo].[Modules]
(Name, Description)
values('MAD', 'Mobile applications development')

insert into [dbo].[Students]
([FirstName],[LastName],[DoB],[Course],[Age],[StudentModuleId])
values('Lily', 'Smith', '1995-01-01', 'BIS', '21','2')
insert into [dbo].[Students]
([FirstName],[LastName],[DoB],[Course],[Age],[StudentModuleId])
values('Sam', 'Thomas', '1996-01-01', 'BIS', '24','2')

insert into [dbo].[Students]
([FirstName],[LastName],[DoB],[Course],[Age],[StudentModuleId])
values('Rose', 'Black', '1997-01-01', 'BIS', '23','2')
insert into [dbo].[Students]
([FirstName],[LastName],[DoB],[Course],[Age],[StudentModuleId])
values('Mike', 'Smith', '1998-01-01', 'BIS', '22','2')
select * from Students