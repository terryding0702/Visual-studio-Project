CREATE TABLE [dbo].[QuestionLists](
	[Id] int IDENTITY(1,1) NOT NULL,
	[SymptomDescriptions] nvarchar(max) NOT NULL,
	[HappenDate] nvarchar(max) NOT NULL,
	[UserId] nvarchar(max) NOT NULL
	PRIMARY KEY(Id)
);
GO

CREATE TABLE [dbo].[Reservation](
	[Id] int IDENTITY(1,1) NOT NULL,
	[BookingDate] nvarchar(max) NOT NULL,
	[ContactNumber] int NOT NULL,
	[Email] nvarchar(max) NOT NULL,
	[Location] nvarchar(max) NOT NULL
	PRIMARY KEY (Id)
);
GO