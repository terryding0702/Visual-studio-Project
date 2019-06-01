CREATE TABLE [dbo].[Reservation] (
    [Id]            INT            IDENTITY (1, 1) NOT NULL,
    [BookingDate]   NVARCHAR (MAX) NOT NULL,
    [ContactNumber] INT            NOT NULL,
    [Email]         NVARCHAR (MAX) NOT NULL,
    [Location]      NVARCHAR (MAX) NOT NULL,
	[UserId] NVARCHAR(MAX) NOT NULL
    PRIMARY KEY CLUSTERED ([Id] ASC)
);